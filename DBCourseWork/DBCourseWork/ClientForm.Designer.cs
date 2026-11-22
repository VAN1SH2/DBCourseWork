namespace DBCourseWork
{
    partial class ClientForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            warehouseTitleLabel = new Label();
            workerNameLabel = new Label();
            signOutButton = new Button();
            workerTabControl = new TabControl();
            catalogTabPage = new TabPage();
            categoryLabel = new Label();
            categoryComboBox = new ComboBox();
            inStockCheckBox = new CheckBox();
            materialsGrid = new DataGridView();
            catalogMaterialColumn = new DataGridViewTextBoxColumn();
            catalogCategoryColumn = new DataGridViewTextBoxColumn();
            catalogUnitColumn = new DataGridViewTextBoxColumn();
            catalogPriceColumn = new DataGridViewTextBoxColumn();
            catalogStockColumn = new DataGridViewTextBoxColumn();
            quantityLabel = new Label();
            quantityInput = new NumericUpDown();
            addItemButton = new Button();
            draftGroupBox = new GroupBox();
            draftGrid = new DataGridView();
            draftMaterialColumn = new DataGridViewTextBoxColumn();
            draftQuantityColumn = new DataGridViewTextBoxColumn();
            draftPriceColumn = new DataGridViewTextBoxColumn();
            draftTotalColumn = new DataGridViewTextBoxColumn();
            removeItemButton = new Button();
            draftTotalLabel = new Label();
            submitOrderButton = new Button();
            ordersTabPage = new TabPage();
            ordersGrid = new DataGridView();
            orderNumberColumn = new DataGridViewTextBoxColumn();
            orderDateColumn = new DataGridViewTextBoxColumn();
            orderTotalColumn = new DataGridViewTextBoxColumn();
            orderStatusColumn = new DataGridViewTextBoxColumn();
            detailsGroupBox = new GroupBox();
            orderDetailsGrid = new DataGridView();
            detailMaterialColumn = new DataGridViewTextBoxColumn();
            detailQuantityColumn = new DataGridViewTextBoxColumn();
            detailPriceColumn = new DataGridViewTextBoxColumn();
            detailTotalColumn = new DataGridViewTextBoxColumn();
            workerTabControl.SuspendLayout();
            catalogTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)materialsGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)quantityInput).BeginInit();
            draftGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)draftGrid).BeginInit();
            ordersTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ordersGrid).BeginInit();
            detailsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)orderDetailsGrid).BeginInit();
            SuspendLayout();
            // 
            // warehouseTitleLabel
            // 
            warehouseTitleLabel.AutoSize = true;
            warehouseTitleLabel.Location = new Point(29, 25);
            warehouseTitleLabel.Margin = new Padding(4, 0, 4, 0);
            warehouseTitleLabel.Name = "warehouseTitleLabel";
            warehouseTitleLabel.Size = new Size(280, 25);
            warehouseTitleLabel.TabIndex = 0;
            warehouseTitleLabel.Text = "Склад строительных материалов";
            // 
            // workerNameLabel
            // 
            workerNameLabel.AutoSize = true;
            workerNameLabel.Location = new Point(31, 85);
            workerNameLabel.Margin = new Padding(4, 0, 4, 0);
            workerNameLabel.Name = "workerNameLabel";
            workerNameLabel.Size = new Size(82, 25);
            workerNameLabel.TabIndex = 1;
            workerNameLabel.Text = "Рабочий";
            // 
            // signOutButton
            // 
            signOutButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            signOutButton.Location = new Point(952, 37);
            signOutButton.Margin = new Padding(4, 5, 4, 5);
            signOutButton.Name = "signOutButton";
            signOutButton.Size = new Size(160, 53);
            signOutButton.TabIndex = 0;
            signOutButton.Text = "Выйти";
            signOutButton.UseVisualStyleBackColor = true;
            // 
            // workerTabControl
            // 
            workerTabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            workerTabControl.Controls.Add(catalogTabPage);
            workerTabControl.Controls.Add(ordersTabPage);
            workerTabControl.Location = new Point(29, 130);
            workerTabControl.Margin = new Padding(4, 5, 4, 5);
            workerTabControl.Name = "workerTabControl";
            workerTabControl.SelectedIndex = 0;
            workerTabControl.Size = new Size(1083, 793);
            workerTabControl.TabIndex = 1;
            // 
            // catalogTabPage
            // 
            catalogTabPage.Controls.Add(categoryLabel);
            catalogTabPage.Controls.Add(categoryComboBox);
            catalogTabPage.Controls.Add(inStockCheckBox);
            catalogTabPage.Controls.Add(materialsGrid);
            catalogTabPage.Controls.Add(quantityLabel);
            catalogTabPage.Controls.Add(quantityInput);
            catalogTabPage.Controls.Add(addItemButton);
            catalogTabPage.Controls.Add(draftGroupBox);
            catalogTabPage.Location = new Point(4, 34);
            catalogTabPage.Margin = new Padding(4, 5, 4, 5);
            catalogTabPage.Name = "catalogTabPage";
            catalogTabPage.Size = new Size(1075, 755);
            catalogTabPage.TabIndex = 0;
            catalogTabPage.Text = "Каталог";
            catalogTabPage.UseVisualStyleBackColor = true;
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Location = new Point(23, 35);
            categoryLabel.Margin = new Padding(4, 0, 4, 0);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new Size(95, 25);
            categoryLabel.TabIndex = 0;
            categoryLabel.Text = "&Категория";
            // 
            // categoryComboBox
            // 
            categoryComboBox.AccessibleName = "Категория";
            categoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            categoryComboBox.FormattingEnabled = true;
            categoryComboBox.Location = new Point(129, 28);
            categoryComboBox.Margin = new Padding(4, 5, 4, 5);
            categoryComboBox.Name = "categoryComboBox";
            categoryComboBox.Size = new Size(348, 33);
            categoryComboBox.TabIndex = 1;
            // 
            // inStockCheckBox
            // 
            inStockCheckBox.AutoSize = true;
            inStockCheckBox.Location = new Point(504, 32);
            inStockCheckBox.Margin = new Padding(4, 5, 4, 5);
            inStockCheckBox.Name = "inStockCheckBox";
            inStockCheckBox.Size = new Size(184, 29);
            inStockCheckBox.TabIndex = 2;
            inStockCheckBox.Text = "Только в наличии";
            inStockCheckBox.UseVisualStyleBackColor = true;
            // 
            // materialsGrid
            // 
            materialsGrid.AccessibleName = "Каталог материалов";
            materialsGrid.AllowUserToAddRows = false;
            materialsGrid.AllowUserToDeleteRows = false;
            materialsGrid.AllowUserToResizeRows = false;
            materialsGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            materialsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            materialsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            materialsGrid.Columns.AddRange(new DataGridViewColumn[] { catalogMaterialColumn, catalogCategoryColumn, catalogUnitColumn, catalogPriceColumn, catalogStockColumn });
            materialsGrid.Location = new Point(23, 90);
            materialsGrid.Margin = new Padding(4, 5, 4, 5);
            materialsGrid.MultiSelect = false;
            materialsGrid.Name = "materialsGrid";
            materialsGrid.ReadOnly = true;
            materialsGrid.RowHeadersVisible = false;
            materialsGrid.RowHeadersWidth = 62;
            materialsGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            materialsGrid.Size = new Size(1026, 172);
            materialsGrid.TabIndex = 3;
            // 
            // catalogMaterialColumn
            // 
            catalogMaterialColumn.FillWeight = 175F;
            catalogMaterialColumn.HeaderText = "Материал";
            catalogMaterialColumn.MinimumWidth = 8;
            catalogMaterialColumn.Name = "catalogMaterialColumn";
            catalogMaterialColumn.ReadOnly = true;
            // 
            // catalogCategoryColumn
            // 
            catalogCategoryColumn.FillWeight = 130F;
            catalogCategoryColumn.HeaderText = "Категория";
            catalogCategoryColumn.MinimumWidth = 8;
            catalogCategoryColumn.Name = "catalogCategoryColumn";
            catalogCategoryColumn.ReadOnly = true;
            // 
            // catalogUnitColumn
            // 
            catalogUnitColumn.FillWeight = 60F;
            catalogUnitColumn.HeaderText = "Ед. изм.";
            catalogUnitColumn.MinimumWidth = 8;
            catalogUnitColumn.Name = "catalogUnitColumn";
            catalogUnitColumn.ReadOnly = true;
            // 
            // catalogPriceColumn
            // 
            catalogPriceColumn.FillWeight = 85F;
            catalogPriceColumn.HeaderText = "Цена";
            catalogPriceColumn.MinimumWidth = 8;
            catalogPriceColumn.Name = "catalogPriceColumn";
            catalogPriceColumn.ReadOnly = true;
            // 
            // catalogStockColumn
            // 
            catalogStockColumn.FillWeight = 75F;
            catalogStockColumn.HeaderText = "Остаток";
            catalogStockColumn.MinimumWidth = 8;
            catalogStockColumn.Name = "catalogStockColumn";
            catalogStockColumn.ReadOnly = true;
            // 
            // quantityLabel
            // 
            quantityLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            quantityLabel.AutoSize = true;
            quantityLabel.Location = new Point(23, 292);
            quantityLabel.Margin = new Padding(4, 0, 4, 0);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new Size(107, 25);
            quantityLabel.TabIndex = 4;
            quantityLabel.Text = "Количество";
            // 
            // quantityInput
            // 
            quantityInput.AccessibleName = "Количество";
            quantityInput.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            quantityInput.DecimalPlaces = 3;
            quantityInput.Increment = new decimal(new int[] { 1, 0, 0, 196608 });
            quantityInput.Location = new Point(144, 285);
            quantityInput.Margin = new Padding(4, 5, 4, 5);
            quantityInput.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            quantityInput.Minimum = new decimal(new int[] { 1, 0, 0, 196608 });
            quantityInput.Name = "quantityInput";
            quantityInput.Size = new Size(166, 31);
            quantityInput.TabIndex = 5;
            quantityInput.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // addItemButton
            // 
            addItemButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            addItemButton.Location = new Point(329, 278);
            addItemButton.Margin = new Padding(4, 5, 4, 5);
            addItemButton.Name = "addItemButton";
            addItemButton.Size = new Size(240, 52);
            addItemButton.TabIndex = 6;
            addItemButton.Text = "Добавить в заявку";
            addItemButton.UseVisualStyleBackColor = true;
            // 
            // draftGroupBox
            // 
            draftGroupBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            draftGroupBox.Controls.Add(draftGrid);
            draftGroupBox.Controls.Add(removeItemButton);
            draftGroupBox.Controls.Add(draftTotalLabel);
            draftGroupBox.Controls.Add(submitOrderButton);
            draftGroupBox.Location = new Point(23, 352);
            draftGroupBox.Margin = new Padding(4, 5, 4, 5);
            draftGroupBox.Name = "draftGroupBox";
            draftGroupBox.Padding = new Padding(4, 5, 4, 5);
            draftGroupBox.Size = new Size(1026, 368);
            draftGroupBox.TabIndex = 7;
            draftGroupBox.TabStop = false;
            draftGroupBox.Text = "Новая заявка";
            // 
            // draftGrid
            // 
            draftGrid.AccessibleName = "Позиции новой заявки";
            draftGrid.AllowUserToAddRows = false;
            draftGrid.AllowUserToDeleteRows = false;
            draftGrid.AllowUserToResizeRows = false;
            draftGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            draftGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            draftGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            draftGrid.Columns.AddRange(new DataGridViewColumn[] { draftMaterialColumn, draftQuantityColumn, draftPriceColumn, draftTotalColumn });
            draftGrid.Location = new Point(17, 42);
            draftGrid.Margin = new Padding(4, 5, 4, 5);
            draftGrid.MultiSelect = false;
            draftGrid.Name = "draftGrid";
            draftGrid.ReadOnly = true;
            draftGrid.RowHeadersVisible = false;
            draftGrid.RowHeadersWidth = 62;
            draftGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            draftGrid.Size = new Size(992, 242);
            draftGrid.TabIndex = 0;
            // 
            // draftMaterialColumn
            // 
            draftMaterialColumn.FillWeight = 180F;
            draftMaterialColumn.HeaderText = "Материал";
            draftMaterialColumn.MinimumWidth = 8;
            draftMaterialColumn.Name = "draftMaterialColumn";
            draftMaterialColumn.ReadOnly = true;
            // 
            // draftQuantityColumn
            // 
            draftQuantityColumn.FillWeight = 75F;
            draftQuantityColumn.HeaderText = "Количество";
            draftQuantityColumn.MinimumWidth = 8;
            draftQuantityColumn.Name = "draftQuantityColumn";
            draftQuantityColumn.ReadOnly = true;
            // 
            // draftPriceColumn
            // 
            draftPriceColumn.FillWeight = 85F;
            draftPriceColumn.HeaderText = "Цена за ед.";
            draftPriceColumn.MinimumWidth = 8;
            draftPriceColumn.Name = "draftPriceColumn";
            draftPriceColumn.ReadOnly = true;
            // 
            // draftTotalColumn
            // 
            draftTotalColumn.FillWeight = 85F;
            draftTotalColumn.HeaderText = "Сумма";
            draftTotalColumn.MinimumWidth = 8;
            draftTotalColumn.Name = "draftTotalColumn";
            draftTotalColumn.ReadOnly = true;
            // 
            // removeItemButton
            // 
            removeItemButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            removeItemButton.Location = new Point(17, 302);
            removeItemButton.Margin = new Padding(4, 5, 4, 5);
            removeItemButton.Name = "removeItemButton";
            removeItemButton.Size = new Size(209, 48);
            removeItemButton.TabIndex = 1;
            removeItemButton.Text = "Убрать позицию";
            removeItemButton.UseVisualStyleBackColor = true;
            // 
            // draftTotalLabel
            // 
            draftTotalLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            draftTotalLabel.Location = new Point(459, 305);
            draftTotalLabel.Margin = new Padding(4, 0, 4, 0);
            draftTotalLabel.Name = "draftTotalLabel";
            draftTotalLabel.Size = new Size(280, 43);
            draftTotalLabel.TabIndex = 2;
            draftTotalLabel.Text = "Итого   0,00 ₽";
            draftTotalLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // submitOrderButton
            // 
            submitOrderButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            submitOrderButton.Location = new Point(760, 300);
            submitOrderButton.Margin = new Padding(4, 5, 4, 5);
            submitOrderButton.Name = "submitOrderButton";
            submitOrderButton.Size = new Size(249, 53);
            submitOrderButton.TabIndex = 3;
            submitOrderButton.Text = "Отправить заявку";
            submitOrderButton.UseVisualStyleBackColor = true;
            // 
            // ordersTabPage
            // 
            ordersTabPage.Controls.Add(ordersGrid);
            ordersTabPage.Controls.Add(detailsGroupBox);
            ordersTabPage.Location = new Point(4, 34);
            ordersTabPage.Margin = new Padding(4, 5, 4, 5);
            ordersTabPage.Name = "ordersTabPage";
            ordersTabPage.Size = new Size(1075, 755);
            ordersTabPage.TabIndex = 1;
            ordersTabPage.Text = "Мои заявки";
            ordersTabPage.UseVisualStyleBackColor = true;
            // 
            // ordersGrid
            // 
            ordersGrid.AccessibleName = "Мои заявки";
            ordersGrid.AllowUserToAddRows = false;
            ordersGrid.AllowUserToDeleteRows = false;
            ordersGrid.AllowUserToResizeRows = false;
            ordersGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ordersGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ordersGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ordersGrid.Columns.AddRange(new DataGridViewColumn[] { orderNumberColumn, orderDateColumn, orderTotalColumn, orderStatusColumn });
            ordersGrid.Location = new Point(23, 27);
            ordersGrid.Margin = new Padding(4, 5, 4, 5);
            ordersGrid.MultiSelect = false;
            ordersGrid.Name = "ordersGrid";
            ordersGrid.ReadOnly = true;
            ordersGrid.RowHeadersVisible = false;
            ordersGrid.RowHeadersWidth = 62;
            ordersGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ordersGrid.Size = new Size(1026, 262);
            ordersGrid.TabIndex = 0;
            // 
            // orderNumberColumn
            // 
            orderNumberColumn.FillWeight = 65F;
            orderNumberColumn.HeaderText = "Номер";
            orderNumberColumn.MinimumWidth = 8;
            orderNumberColumn.Name = "orderNumberColumn";
            orderNumberColumn.ReadOnly = true;
            // 
            // orderDateColumn
            // 
            orderDateColumn.FillWeight = 110F;
            orderDateColumn.HeaderText = "Дата";
            orderDateColumn.MinimumWidth = 8;
            orderDateColumn.Name = "orderDateColumn";
            orderDateColumn.ReadOnly = true;
            // 
            // orderTotalColumn
            // 
            orderTotalColumn.FillWeight = 90F;
            orderTotalColumn.HeaderText = "Сумма";
            orderTotalColumn.MinimumWidth = 8;
            orderTotalColumn.Name = "orderTotalColumn";
            orderTotalColumn.ReadOnly = true;
            // 
            // orderStatusColumn
            // 
            orderStatusColumn.FillWeight = 110F;
            orderStatusColumn.HeaderText = "Статус";
            orderStatusColumn.MinimumWidth = 8;
            orderStatusColumn.Name = "orderStatusColumn";
            orderStatusColumn.ReadOnly = true;
            // 
            // detailsGroupBox
            // 
            detailsGroupBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            detailsGroupBox.Controls.Add(orderDetailsGrid);
            detailsGroupBox.Location = new Point(23, 312);
            detailsGroupBox.Margin = new Padding(4, 5, 4, 5);
            detailsGroupBox.Name = "detailsGroupBox";
            detailsGroupBox.Padding = new Padding(4, 5, 4, 5);
            detailsGroupBox.Size = new Size(1026, 408);
            detailsGroupBox.TabIndex = 1;
            detailsGroupBox.TabStop = false;
            detailsGroupBox.Text = "Состав выбранной заявки";
            // 
            // orderDetailsGrid
            // 
            orderDetailsGrid.AccessibleName = "Состав выбранной заявки";
            orderDetailsGrid.AllowUserToAddRows = false;
            orderDetailsGrid.AllowUserToDeleteRows = false;
            orderDetailsGrid.AllowUserToResizeRows = false;
            orderDetailsGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            orderDetailsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            orderDetailsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            orderDetailsGrid.Columns.AddRange(new DataGridViewColumn[] { detailMaterialColumn, detailQuantityColumn, detailPriceColumn, detailTotalColumn });
            orderDetailsGrid.Location = new Point(17, 42);
            orderDetailsGrid.Margin = new Padding(4, 5, 4, 5);
            orderDetailsGrid.MultiSelect = false;
            orderDetailsGrid.Name = "orderDetailsGrid";
            orderDetailsGrid.ReadOnly = true;
            orderDetailsGrid.RowHeadersVisible = false;
            orderDetailsGrid.RowHeadersWidth = 62;
            orderDetailsGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            orderDetailsGrid.Size = new Size(992, 345);
            orderDetailsGrid.TabIndex = 0;
            // 
            // detailMaterialColumn
            // 
            detailMaterialColumn.FillWeight = 180F;
            detailMaterialColumn.HeaderText = "Материал";
            detailMaterialColumn.MinimumWidth = 8;
            detailMaterialColumn.Name = "detailMaterialColumn";
            detailMaterialColumn.ReadOnly = true;
            // 
            // detailQuantityColumn
            // 
            detailQuantityColumn.FillWeight = 75F;
            detailQuantityColumn.HeaderText = "Количество";
            detailQuantityColumn.MinimumWidth = 8;
            detailQuantityColumn.Name = "detailQuantityColumn";
            detailQuantityColumn.ReadOnly = true;
            // 
            // detailPriceColumn
            // 
            detailPriceColumn.FillWeight = 85F;
            detailPriceColumn.HeaderText = "Цена за ед.";
            detailPriceColumn.MinimumWidth = 8;
            detailPriceColumn.Name = "detailPriceColumn";
            detailPriceColumn.ReadOnly = true;
            // 
            // detailTotalColumn
            // 
            detailTotalColumn.FillWeight = 85F;
            detailTotalColumn.HeaderText = "Сумма";
            detailTotalColumn.MinimumWidth = 8;
            detailTotalColumn.Name = "detailTotalColumn";
            detailTotalColumn.ReadOnly = true;
            // 
            // ClientForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1140, 957);
            Controls.Add(warehouseTitleLabel);
            Controls.Add(workerNameLabel);
            Controls.Add(signOutButton);
            Controls.Add(workerTabControl);
            Margin = new Padding(4, 5, 4, 5);
            MinimumSize = new Size(1162, 1013);
            Name = "ClientForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Склад — рабочий";
            workerTabControl.ResumeLayout(false);
            catalogTabPage.ResumeLayout(false);
            catalogTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)materialsGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)quantityInput).EndInit();
            draftGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)draftGrid).EndInit();
            ordersTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ordersGrid).EndInit();
            detailsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)orderDetailsGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label warehouseTitleLabel;
        private Label workerNameLabel;
        private Button signOutButton;
        private TabControl workerTabControl;
        private TabPage catalogTabPage;
        private TabPage ordersTabPage;
        private Label categoryLabel;
        private ComboBox categoryComboBox;
        private CheckBox inStockCheckBox;
        private DataGridView materialsGrid;
        private Label quantityLabel;
        private NumericUpDown quantityInput;
        private Button addItemButton;
        private GroupBox draftGroupBox;
        private DataGridView draftGrid;
        private Button removeItemButton;
        private Label draftTotalLabel;
        private Button submitOrderButton;
        private DataGridView ordersGrid;
        private GroupBox detailsGroupBox;
        private DataGridView orderDetailsGrid;
        private DataGridViewTextBoxColumn catalogMaterialColumn;
        private DataGridViewTextBoxColumn catalogCategoryColumn;
        private DataGridViewTextBoxColumn catalogUnitColumn;
        private DataGridViewTextBoxColumn catalogPriceColumn;
        private DataGridViewTextBoxColumn catalogStockColumn;
        private DataGridViewTextBoxColumn draftMaterialColumn;
        private DataGridViewTextBoxColumn draftQuantityColumn;
        private DataGridViewTextBoxColumn draftPriceColumn;
        private DataGridViewTextBoxColumn draftTotalColumn;
        private DataGridViewTextBoxColumn orderNumberColumn;
        private DataGridViewTextBoxColumn orderDateColumn;
        private DataGridViewTextBoxColumn orderTotalColumn;
        private DataGridViewTextBoxColumn orderStatusColumn;
        private DataGridViewTextBoxColumn detailMaterialColumn;
        private DataGridViewTextBoxColumn detailQuantityColumn;
        private DataGridViewTextBoxColumn detailPriceColumn;
        private DataGridViewTextBoxColumn detailTotalColumn;
    }
}
