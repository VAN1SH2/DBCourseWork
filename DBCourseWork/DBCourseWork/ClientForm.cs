using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DBCourseWork
{
    public partial class ClientForm : Form
    {
        private readonly int workerId;
        private readonly DataTable draft = new DataTable();

        public ClientForm()
        {
            InitializeComponent();
        }

        internal ClientForm(int workerId, string fullName) : this()
        {
            this.workerId = workerId;
            workerNameLabel.Text = fullName;

            WarehouseDb.BindColumns(materialsGrid, "material_name", "category_name", "unit", "price", "stock_qty");
            WarehouseDb.BindColumns(draftGrid, "material_name", "quantity", "price_at_order", "line_total");
            WarehouseDb.BindColumns(ordersGrid, "id", "order_date", "total", "status_text");
            WarehouseDb.BindColumns(orderDetailsGrid, "material_name", "quantity", "price_at_order", "line_total");

            draft.Columns.Add("material_id", typeof(int));
            draft.Columns.Add("material_name", typeof(string));
            draft.Columns.Add("quantity", typeof(decimal));
            draft.Columns.Add("price_at_order", typeof(decimal));
            draft.Columns.Add("line_total", typeof(decimal));
            draft.PrimaryKey = [draft.Columns["material_id"]!];
            draftGrid.DataSource = draft;
            UpdateDraftTotal();

            Shown += ClientForm_Shown;
            categoryComboBox.SelectionChangeCommitted += FilterChanged;
            inStockCheckBox.CheckedChanged += FilterChanged;
            addItemButton.Click += addItemButton_Click;
            removeItemButton.Click += removeItemButton_Click;
            submitOrderButton.Click += submitOrderButton_Click;
            ordersGrid.SelectionChanged += ordersGrid_SelectionChanged;
            workerTabControl.SelectedIndexChanged += workerTabControl_SelectedIndexChanged;
            signOutButton.Click += (_, _) => Close();
        }

        private void ClientForm_Shown(object? sender, EventArgs e)
        {
            WarehouseDb.Run(this, () =>
            {
                string sQ = "SELECT [id], [name] FROM [categories] ORDER BY [name]";
                DataTable table = WarehouseDb.ReadTable(sQ);
                DataRow allCategories = table.NewRow();
                allCategories["id"] = 0;
                allCategories["name"] = "Все категории";
                table.Rows.InsertAt(allCategories, 0);

                categoryComboBox.DisplayMember = "name";
                categoryComboBox.ValueMember = "id";
                categoryComboBox.DataSource = table;
                ShowMaterials();
            });
        }

        private void FilterChanged(object? sender, EventArgs e)
        {
            WarehouseDb.Run(this, ShowMaterials);
        }

        private void ShowMaterials()
        {
            string sQ = "SELECT m.[id], m.[name] AS [material_name], c.[name] AS [category_name], " +
                "m.[unit], m.[price], m.[stock_qty] FROM [materials] AS m " +
                "INNER JOIN [categories] AS c ON m.[category_id] = c.[id] WHERE 1 = 1";

            using OleDbConnection connection = WarehouseDb.Open();
            using OleDbCommand cmd = new OleDbCommand(sQ, connection);
            if (categoryComboBox.SelectedValue is int categoryId && categoryId > 0)
            {
                cmd.CommandText += " AND m.[category_id] = ?";
                cmd.Parameters.AddWithValue("?", categoryId);
            }
            if (inStockCheckBox.Checked)
                cmd.CommandText += " AND m.[stock_qty] > 0";

            cmd.CommandText += " ORDER BY m.[name]";
            materialsGrid.DataSource = WarehouseDb.ReadTable(cmd);
        }

        private void addItemButton_Click(object? sender, EventArgs e)
        {
            WarehouseDb.Run(this, () =>
            {
                DataRow material = WarehouseDb.SelectedRow(materialsGrid)
                    ?? throw new InvalidOperationException("Выбери материал в каталоге.");

                int materialId = (int)material["id"];
                DataRow? row = draft.Rows.Find(materialId);
                decimal quantity = quantityInput.Value + (row == null ? 0M : (decimal)row["quantity"]);
                if (quantity > Convert.ToDecimal(material["stock_qty"]))
                    throw new InvalidOperationException("Выбранное количество больше остатка.");

                decimal price = (decimal)material["price"];
                decimal lineTotal = decimal.Round(quantity * price, 4);
                if (row == null)
                    draft.Rows.Add(materialId, material["material_name"], quantity, price, lineTotal);
                else
                {
                    row["quantity"] = quantity;
                    row["price_at_order"] = price;
                    row["line_total"] = lineTotal;
                }

                UpdateDraftTotal();
            });
        }

        private void removeItemButton_Click(object? sender, EventArgs e)
        {
            DataRow? row = WarehouseDb.SelectedRow(draftGrid);
            if (row != null)
                draft.Rows.Remove(row);

            UpdateDraftTotal();
        }

        private void submitOrderButton_Click(object? sender, EventArgs e)
        {
            WarehouseDb.Run(this, () =>
            {
                int orderId = OrderQueries.CreateOrder(workerId, draft);
                draft.Clear();
                UpdateDraftTotal();
                MessageBox.Show(this, $"Заявка № {orderId} отправлена.", "Склад");
                workerTabControl.SelectedTab = ordersTabPage;
            });
        }

        private void UpdateDraftTotal()
        {
            decimal total = 0M;
            foreach (DataRow row in draft.Rows)
                total += (decimal)row["line_total"];

            draftTotalLabel.Text = $"Итого   {total:N2} ₽";
            submitOrderButton.Enabled = draft.Rows.Count > 0;
            removeItemButton.Enabled = draft.Rows.Count > 0;
        }

        private void workerTabControl_SelectedIndexChanged(object? sender, EventArgs e)
        {
            WarehouseDb.Run(this, () =>
            {
                if (workerTabControl.SelectedTab == ordersTabPage)
                    ordersGrid.DataSource = OrderQueries.ShowOrders(workerId);
                else
                    ShowMaterials();
            });
        }

        private void ordersGrid_SelectionChanged(object? sender, EventArgs e)
        {
            WarehouseDb.Run(this, () =>
            {
                DataRow? row = WarehouseDb.SelectedRow(ordersGrid);
                orderDetailsGrid.DataSource = row == null ? null : OrderQueries.ShowItems((int)row["id"], workerId);
            });
        }
    }
}
