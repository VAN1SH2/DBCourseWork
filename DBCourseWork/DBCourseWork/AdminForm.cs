using System.Data;
using System.Data.OleDb;

namespace DBCourseWork
{
    public partial class AdminForm : Form
    {
        private const string InventoryTableName = "inventory_checks";
        private const string InventoryRelationName = "fk_coursework_inventory_material";

        private enum InventoryTableState
        {
            Missing,
            CreatedByApp,
            ExistingTable
        }

        public AdminForm()
        {
            InitializeComponent();
        }

        internal AdminForm(string fullName) : this()
        {
            managerLabel.Text = fullName + " — управляющий складом";
            WarehouseDb.BindColumns(ordersGrid, "id", "full_name", "order_date", "status_text", "total");
            WarehouseDb.BindColumns(orderItemsGrid, "material_name", "unit", "quantity", "price_at_order", "line_total");
            WarehouseDb.BindColumns(materialsGrid, "material_name", "category_name", "unit", "price", "stock_qty");
            WarehouseDb.BindColumns(categoriesGrid, "id", "name");

            orderStatusComboBox.Items.AddRange(["Все заявки", "Создана", "Одобрена", "Отклонена"]);
            orderStatusComboBox.SelectedIndex = 0;
            approveOrderButton.Enabled = false;
            rejectOrderButton.Enabled = false;
            materialNameTextBox.MaxLength = 120;
            materialUnitTextBox.MaxLength = 16;
            materialPriceInput.DecimalPlaces = 4;
            categoryNameTextBox.MaxLength = 100;

            Shown += (_, _) => WarehouseDb.Run(this, ShowOrders);
            adminTabControl.SelectedIndexChanged += adminTabControl_SelectedIndexChanged;
            orderStatusComboBox.SelectionChangeCommitted += (_, _) => WarehouseDb.Run(this, ShowOrders);
            ordersGrid.SelectionChanged += ordersGrid_SelectionChanged;
            approveOrderButton.Click += (_, _) => DecideOrder(true);
            rejectOrderButton.Click += (_, _) => DecideOrder(false);
            materialsGrid.SelectionChanged += materialsGrid_SelectionChanged;
            categoriesGrid.SelectionChanged += categoriesGrid_SelectionChanged;
            addMaterialButton.Click += (_, _) => SaveMaterial(false);
            editMaterialButton.Click += (_, _) => SaveMaterial(true);
            deleteMaterialButton.Click += deleteMaterialButton_Click;
            addCategoryButton.Click += (_, _) => SaveCategory(false);
            editCategoryButton.Click += (_, _) => SaveCategory(true);
            deleteCategoryButton.Click += deleteCategoryButton_Click;
            createInventoryTableButton.Click += (_, _) => ChangeInventoryTable_Click(true);
            undoInventoryTableButton.Click += (_, _) => ChangeInventoryTable_Click(false);
            signOutButton.Click += (_, _) => Close();
        }

        private void adminTabControl_SelectedIndexChanged(object? sender, EventArgs e)
        {
            WarehouseDb.Run(this, () =>
            {
                if (adminTabControl.SelectedTab == ordersTabPage)
                    ShowOrders();
                else if (adminTabControl.SelectedTab == materialsTabPage)
                {
                    ShowMaterialCategories();
                    ShowMaterials();
                }
                else if (adminTabControl.SelectedTab == categoriesTabPage)
                    ShowCategories();
                else if (adminTabControl.SelectedTab == maintenanceTabPage)
                    ShowInventoryTableState();
            });
        }

        private void ShowOrders()
        {
            string? status = orderStatusComboBox.SelectedIndex switch
            {
                1 => "created",
                2 => "approved",
                3 => "rejected",
                _ => null
            };
            ordersGrid.DataSource = OrderQueries.ShowOrders(status: status);
        }

        private void ordersGrid_SelectionChanged(object? sender, EventArgs e)
        {
            WarehouseDb.Run(this, () =>
            {
                DataRow? row = WarehouseDb.SelectedRow(ordersGrid);
                bool pending = row?["status"] as string == "created";
                approveOrderButton.Enabled = pending;
                rejectOrderButton.Enabled = pending;
                orderItemsGrid.DataSource = row == null ? null : OrderQueries.ShowItems((int)row["id"]);
            });
        }

        private void DecideOrder(bool approve)
        {
            WarehouseDb.Run(this, () =>
            {
                DataRow row = WarehouseDb.SelectedRow(ordersGrid)
                    ?? throw new InvalidOperationException("Выбери заявку.");
                string question = approve ? "Одобрить заявку и списать материалы со склада?" : "Отклонить заявку?";
                if (MessageBox.Show(this, question, "Заявка", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    return;

                OrderQueries.DecideOrder((int)row["id"], approve);
                ShowOrders();
            });
        }

        private void ShowMaterials()
        {
            string sQ = "SELECT m.[id], m.[name] AS [material_name], m.[category_id], c.[name] AS [category_name], " +
                "m.[unit], m.[price], m.[stock_qty] FROM [materials] AS m " +
                "INNER JOIN [categories] AS c ON m.[category_id] = c.[id] ORDER BY m.[name]";
            materialsGrid.DataSource = WarehouseDb.ReadTable(sQ);
        }

        private void ShowMaterialCategories()
        {
            string sQ = "SELECT [id], [name] FROM [categories] ORDER BY [name]";
            materialCategoryComboBox.DisplayMember = "name";
            materialCategoryComboBox.ValueMember = "id";
            materialCategoryComboBox.DataSource = WarehouseDb.ReadTable(sQ);
        }

        private void ShowCategories()
        {
            string sQ = "SELECT [id], [name] FROM [categories] ORDER BY [name]";
            categoriesGrid.DataSource = WarehouseDb.ReadTable(sQ);
        }

        private void materialsGrid_SelectionChanged(object? sender, EventArgs e)
        {
            DataRow? row = WarehouseDb.SelectedRow(materialsGrid);
            if (row == null)
                return;

            materialNameTextBox.Text = (string)row["material_name"];
            materialCategoryComboBox.SelectedValue = (int)row["category_id"];
            materialUnitTextBox.Text = (string)row["unit"];
            materialPriceInput.Value = Math.Min(materialPriceInput.Maximum, (decimal)row["price"]);
            materialStockInput.Value = Math.Min(materialStockInput.Maximum, Convert.ToDecimal(row["stock_qty"]));
        }

        private void categoriesGrid_SelectionChanged(object? sender, EventArgs e)
        {
            DataRow? row = WarehouseDb.SelectedRow(categoriesGrid);
            if (row != null)
                categoryNameTextBox.Text = (string)row["name"];
        }

        private void SaveMaterial(bool edit)
        {
            WarehouseDb.Run(this, () =>
            {
                string name = materialNameTextBox.Text.Trim();
                string unit = materialUnitTextBox.Text.Trim();
                if (name.Length == 0 || unit.Length == 0 || materialCategoryComboBox.SelectedValue is not int categoryId)
                    throw new InvalidOperationException("Укажи название, категорию и единицу измерения.");

                DataRow? selected = edit ? WarehouseDb.SelectedRow(materialsGrid) : null;
                if (edit && selected == null)
                    throw new InvalidOperationException("Выбери материал для изменения.");

                WriteMaterial(name, categoryId, unit, materialPriceInput.Value, (double)materialStockInput.Value,
                    selected == null ? null : ((int)selected["id"], (double)selected["stock_qty"]));
                ShowMaterials();
            });
        }

        internal static void WriteMaterial(string name, int categoryId, string unit, decimal price,
            double stock, (int Id, double PreviousStock)? selected = null)
        {
            string sQ = selected.HasValue
                ? "UPDATE [materials] SET [name] = ?, [category_id] = ?, [unit] = ?, [price] = ?, [stock_qty] = ? WHERE [id] = ? AND [stock_qty] = ?"
                : "INSERT INTO [materials] ([name], [category_id], [unit], [price], [stock_qty]) VALUES (?, ?, ?, ?, ?)";
            using OleDbConnection connection = WarehouseDb.Open();
            using OleDbCommand cmd = new OleDbCommand(sQ, connection);
            cmd.Parameters.AddWithValue("?", name);
            cmd.Parameters.AddWithValue("?", categoryId);
            cmd.Parameters.AddWithValue("?", unit);
            cmd.Parameters.Add("?", OleDbType.Currency).Value = price;
            cmd.Parameters.AddWithValue("?", stock);
            if (selected.HasValue)
            {
                cmd.Parameters.AddWithValue("?", selected.Value.Id);
                cmd.Parameters.AddWithValue("?", selected.Value.PreviousStock);
            }
            if (cmd.ExecuteNonQuery() != 1)
                throw new InvalidOperationException("Остаток изменился. Переключись на другую вкладку и вернись к материалам.");
        }

        private void SaveCategory(bool edit)
        {
            WarehouseDb.Run(this, () =>
            {
                string name = categoryNameTextBox.Text.Trim();
                if (name.Length == 0)
                    throw new InvalidOperationException("Укажи название категории.");

                DataRow? selected = edit ? WarehouseDb.SelectedRow(categoriesGrid) : null;
                if (edit && selected == null)
                    throw new InvalidOperationException("Выбери категорию для изменения.");

                WriteCategory(name, selected == null ? null : (int)selected["id"]);
                ShowCategories();
            });
        }

        internal static void WriteCategory(string name, int? selectedId = null)
        {
            string sQ = selectedId.HasValue ? "UPDATE [categories] SET [name] = ? WHERE [id] = ?"
                : "INSERT INTO [categories] ([name]) VALUES (?)";
            using OleDbConnection connection = WarehouseDb.Open();
            using OleDbCommand cmd = new OleDbCommand(sQ, connection);
            cmd.Parameters.AddWithValue("?", name);
            if (selectedId.HasValue)
                cmd.Parameters.AddWithValue("?", selectedId.Value);
            if (cmd.ExecuteNonQuery() != 1)
                throw new InvalidOperationException("Категория уже удалена.");
        }

        private void deleteMaterialButton_Click(object? sender, EventArgs e)
        {
            RemoveRecord(materialsGrid, "DELETE FROM [materials] WHERE [id] = ?", "Удалить выбранный материал?", ShowMaterials);
        }

        private void deleteCategoryButton_Click(object? sender, EventArgs e)
        {
            RemoveRecord(categoriesGrid, "DELETE FROM [categories] WHERE [id] = ?", "Удалить выбранную категорию?", ShowCategories);
        }

        private void RemoveRecord(DataGridView grid, string sQ, string question, Action refresh)
        {
            WarehouseDb.Run(this, () =>
            {
                DataRow selected = WarehouseDb.SelectedRow(grid)
                    ?? throw new InvalidOperationException("Выбери запись для удаления.");
                if (MessageBox.Show(this, question, "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    return;

                DeleteRecord(sQ, (int)selected["id"]);
                refresh();
            });
        }

        internal static void DeleteRecord(string sQ, int id)
        {
            using OleDbConnection connection = WarehouseDb.Open();
            using OleDbCommand cmd = new OleDbCommand(sQ, connection);
            cmd.Parameters.AddWithValue("?", id);
            if (cmd.ExecuteNonQuery() != 1)
                throw new InvalidOperationException("Запись уже удалена.");
        }

        private void ShowInventoryTableState()
        {
            using OleDbConnection connection = WarehouseDb.Open();
            InventoryTableState state = GetInventoryTableState(connection);
            createInventoryTableButton.Enabled = state == InventoryTableState.Missing;
            undoInventoryTableButton.Enabled = state == InventoryTableState.CreatedByApp;
            inventoryTableLinkLabel.Text = state switch
            {
                InventoryTableState.Missing => "Можно добавить таблицу проверки остатков со связью с материалами.",
                InventoryTableState.CreatedByApp => "Таблица проверки остатков добавлена и связана с материалами.",
                _ => "Таблица с таким именем уже существует. Откат недоступен."
            };
        }

        private void ChangeInventoryTable_Click(bool create)
        {
            if (!create && MessageBox.Show(this, "Откатить добавление? Таблица проверки остатков и её записи будут удалены.",
                "Откат добавления", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
                return;

            WarehouseDb.Run(this, () =>
            {
                ChangeInventoryTable(create);
                ShowInventoryTableState();
                MessageBox.Show(this, create ? "Связанная таблица создана в рабочей базе." : "Добавление таблицы отменено.", "Обслуживание БД");
            });
        }

        internal static void ChangeInventoryTable(bool create)
        {
            using OleDbConnection connection = WarehouseDb.Open();
            InventoryTableState state = GetInventoryTableState(connection);
            if (create && state != InventoryTableState.Missing)
                throw new InvalidOperationException("Таблица проверки остатков уже существует.");
            if (!create && state != InventoryTableState.CreatedByApp)
                throw new InvalidOperationException("В рабочей базе нет таблицы, добавленной этой кнопкой.");

            string sQ = create
                ? $"CREATE TABLE [{InventoryTableName}] ([id] COUNTER CONSTRAINT [pk_inventory_checks] PRIMARY KEY, " +
                  "[material_id] LONG NOT NULL, [checked_at] DATETIME NOT NULL, [actual_qty] DOUBLE NOT NULL, " +
                  $"CONSTRAINT [{InventoryRelationName}] FOREIGN KEY ([material_id]) REFERENCES [materials] ([id]))"
                : $"DROP TABLE [{InventoryTableName}]";

            using OleDbCommand cmd = new OleDbCommand(sQ, connection);
            cmd.ExecuteNonQuery();
        }

        private static InventoryTableState GetInventoryTableState(OleDbConnection connection)
        {
            DataTable tables = connection.GetSchema("Tables", [null, null, InventoryTableName]);
            if (tables.Rows.Count == 0)
                return InventoryTableState.Missing;

            using DataTable? relations = connection.GetOleDbSchemaTable(OleDbSchemaGuid.Foreign_Keys,
                [null, null, "materials", null, null, InventoryTableName]);
            bool createdByApp = relations != null && relations.Rows.Cast<DataRow>().Any(row =>
                string.Equals(row["FK_NAME"] as string, InventoryRelationName, StringComparison.OrdinalIgnoreCase)
                && string.Equals(row["FK_COLUMN_NAME"] as string, "material_id", StringComparison.OrdinalIgnoreCase)
                && string.Equals(row["PK_COLUMN_NAME"] as string, "id", StringComparison.OrdinalIgnoreCase));
            return createdByApp ? InventoryTableState.CreatedByApp : InventoryTableState.ExistingTable;
        }
    }
}
