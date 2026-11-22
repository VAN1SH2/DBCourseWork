namespace DBCourseWork
{
    partial class AdminForm
    {
        private void InitializeComponent()
        {
            warehouseTitleLabel = new Label();
            managerLabel = new Label();
            signOutButton = new Button();
            adminTabControl = new TabControl();
            ordersTabPage = new TabPage();
            materialsTabPage = new TabPage();
            categoriesTabPage = new TabPage();
            maintenanceTabPage = new TabPage();
            statusLabel = new Label();
            orderStatusComboBox = new ComboBox();
            ordersGrid = new DataGridView();
            orderItemsGroupBox = new GroupBox();
            orderItemsGrid = new DataGridView();
            approveOrderButton = new Button();
            rejectOrderButton = new Button();
            materialsGrid = new DataGridView();
            materialGroupBox = new GroupBox();
            materialNameLabel = new Label();
            materialNameTextBox = new TextBox();
            materialCategoryLabel = new Label();
            materialCategoryComboBox = new ComboBox();
            materialUnitLabel = new Label();
            materialUnitTextBox = new TextBox();
            materialPriceLabel = new Label();
            materialPriceInput = new NumericUpDown();
            materialStockLabel = new Label();
            materialStockInput = new NumericUpDown();
            addMaterialButton = new Button();
            editMaterialButton = new Button();
            deleteMaterialButton = new Button();
            categoriesGrid = new DataGridView();
            categoryGroupBox = new GroupBox();
            categoryNameLabel = new Label();
            categoryNameTextBox = new TextBox();
            addCategoryButton = new Button();
            editCategoryButton = new Button();
            deleteCategoryButton = new Button();
            inventoryTableGroupBox = new GroupBox();
            inventoryTableLinkLabel = new Label();
            createInventoryTableButton = new Button();
            undoInventoryTableButton = new Button();
            orderNumberColumn = new DataGridViewTextBoxColumn();
            orderWorkerColumn = new DataGridViewTextBoxColumn();
            orderDateColumn = new DataGridViewTextBoxColumn();
            orderStatusColumn = new DataGridViewTextBoxColumn();
            orderTotalColumn = new DataGridViewTextBoxColumn();
            itemMaterialColumn = new DataGridViewTextBoxColumn();
            itemUnitColumn = new DataGridViewTextBoxColumn();
            itemQuantityColumn = new DataGridViewTextBoxColumn();
            itemPriceColumn = new DataGridViewTextBoxColumn();
            itemTotalColumn = new DataGridViewTextBoxColumn();
            materialNameColumn = new DataGridViewTextBoxColumn();
            materialCategoryColumn = new DataGridViewTextBoxColumn();
            materialUnitColumn = new DataGridViewTextBoxColumn();
            materialPriceColumn = new DataGridViewTextBoxColumn();
            materialStockColumn = new DataGridViewTextBoxColumn();
            categoryCodeColumn = new DataGridViewTextBoxColumn();
            categoryNameColumn = new DataGridViewTextBoxColumn();

            SuspendLayout();
            adminTabControl.SuspendLayout();
            ordersTabPage.SuspendLayout();
            materialsTabPage.SuspendLayout();
            categoriesTabPage.SuspendLayout();
            maintenanceTabPage.SuspendLayout();
            orderItemsGroupBox.SuspendLayout();
            materialGroupBox.SuspendLayout();
            categoryGroupBox.SuspendLayout();
            inventoryTableGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ordersGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderItemsGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)materialsGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)materialPriceInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)materialStockInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)categoriesGrid).BeginInit();

            warehouseTitleLabel.AutoSize = true;
            warehouseTitleLabel.Location = new Point(20, 15);
            warehouseTitleLabel.TabIndex = 0;
            warehouseTitleLabel.Text = "Склад строительных материалов";
            warehouseTitleLabel.Name = "warehouseTitleLabel";

            managerLabel.AutoSize = true;
            managerLabel.Location = new Point(20, 38);
            managerLabel.TabIndex = 1;
            managerLabel.Text = "Управляющий складом";
            managerLabel.Name = "managerLabel";

            signOutButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            signOutButton.Location = new Point(858, 22);
            signOutButton.Size = new Size(112, 32);
            signOutButton.TabIndex = 0;
            signOutButton.Text = "Выйти";
            signOutButton.UseVisualStyleBackColor = true;
            signOutButton.Name = "signOutButton";

            adminTabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            adminTabControl.Location = new Point(20, 78);
            adminTabControl.Size = new Size(950, 608);
            adminTabControl.SelectedIndex = 0;
            adminTabControl.TabIndex = 1;
            adminTabControl.Controls.Add(ordersTabPage);
            adminTabControl.Controls.Add(materialsTabPage);
            adminTabControl.Controls.Add(categoriesTabPage);
            adminTabControl.Controls.Add(maintenanceTabPage);
            adminTabControl.Name = "adminTabControl";

            ordersTabPage.Location = new Point(4, 24);
            ordersTabPage.Size = new Size(942, 580);
            ordersTabPage.TabIndex = 0;
            ordersTabPage.Text = "Заявки";
            ordersTabPage.UseVisualStyleBackColor = true;
            ordersTabPage.Controls.Add(statusLabel);
            ordersTabPage.Controls.Add(orderStatusComboBox);
            ordersTabPage.Controls.Add(ordersGrid);
            ordersTabPage.Controls.Add(orderItemsGroupBox);
            ordersTabPage.Controls.Add(approveOrderButton);
            ordersTabPage.Controls.Add(rejectOrderButton);
            ordersTabPage.Name = "ordersTabPage";

            materialsTabPage.Location = new Point(4, 24);
            materialsTabPage.Size = new Size(942, 580);
            materialsTabPage.TabIndex = 1;
            materialsTabPage.Text = "Материалы";
            materialsTabPage.UseVisualStyleBackColor = true;
            materialsTabPage.Controls.Add(materialsGrid);
            materialsTabPage.Controls.Add(materialGroupBox);
            materialsTabPage.Name = "materialsTabPage";

            categoriesTabPage.Location = new Point(4, 24);
            categoriesTabPage.Size = new Size(942, 580);
            categoriesTabPage.TabIndex = 2;
            categoriesTabPage.Text = "Категории";
            categoriesTabPage.UseVisualStyleBackColor = true;
            categoriesTabPage.Controls.Add(categoriesGrid);
            categoriesTabPage.Controls.Add(categoryGroupBox);
            categoriesTabPage.Name = "categoriesTabPage";

            maintenanceTabPage.Location = new Point(4, 24);
            maintenanceTabPage.Size = new Size(942, 580);
            maintenanceTabPage.TabIndex = 3;
            maintenanceTabPage.Text = "Обслуживание БД";
            maintenanceTabPage.UseVisualStyleBackColor = true;
            maintenanceTabPage.Controls.Add(inventoryTableGroupBox);
            maintenanceTabPage.Name = "maintenanceTabPage";

            statusLabel.AutoSize = true;
            statusLabel.Location = new Point(16, 21);
            statusLabel.TabIndex = 0;
            statusLabel.Text = "&Статус";
            statusLabel.Name = "statusLabel";

            orderStatusComboBox.AccessibleName = "Статус заявки";
            orderStatusComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            orderStatusComboBox.FormattingEnabled = true;
            orderStatusComboBox.Location = new Point(72, 17);
            orderStatusComboBox.Size = new Size(200, 23);
            orderStatusComboBox.TabIndex = 1;
            orderStatusComboBox.Name = "orderStatusComboBox";

            ordersGrid.AllowUserToAddRows = false;
            ordersGrid.AllowUserToDeleteRows = false;
            ordersGrid.AllowUserToResizeRows = false;
            ordersGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ordersGrid.AccessibleName = "Заявки рабочих";
            ordersGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ordersGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ordersGrid.Columns.AddRange(orderNumberColumn, orderWorkerColumn, orderDateColumn, orderStatusColumn, orderTotalColumn);
            ordersGrid.MultiSelect = false;
            ordersGrid.ReadOnly = true;
            ordersGrid.RowHeadersVisible = false;
            ordersGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ordersGrid.Location = new Point(16, 54);
            ordersGrid.Size = new Size(910, 226);
            ordersGrid.TabIndex = 2;
            ordersGrid.Name = "ordersGrid";

            orderItemsGroupBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            orderItemsGroupBox.Location = new Point(16, 294);
            orderItemsGroupBox.Size = new Size(910, 222);
            orderItemsGroupBox.TabIndex = 3;
            orderItemsGroupBox.TabStop = false;
            orderItemsGroupBox.Text = "Состав выбранной заявки";
            orderItemsGroupBox.Controls.Add(orderItemsGrid);
            orderItemsGroupBox.Name = "orderItemsGroupBox";

            orderItemsGrid.AllowUserToAddRows = false;
            orderItemsGrid.AllowUserToDeleteRows = false;
            orderItemsGrid.AllowUserToResizeRows = false;
            orderItemsGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            orderItemsGrid.AccessibleName = "Состав выбранной заявки";
            orderItemsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            orderItemsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            orderItemsGrid.Columns.AddRange(itemMaterialColumn, itemUnitColumn, itemQuantityColumn, itemPriceColumn, itemTotalColumn);
            orderItemsGrid.MultiSelect = false;
            orderItemsGrid.ReadOnly = true;
            orderItemsGrid.RowHeadersVisible = false;
            orderItemsGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            orderItemsGrid.Location = new Point(12, 25);
            orderItemsGrid.Size = new Size(886, 184);
            orderItemsGrid.TabIndex = 0;
            orderItemsGrid.Name = "orderItemsGrid";

            approveOrderButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            approveOrderButton.Location = new Point(668, 530);
            approveOrderButton.Size = new Size(122, 32);
            approveOrderButton.TabIndex = 4;
            approveOrderButton.Text = "Одобрить";
            approveOrderButton.UseVisualStyleBackColor = true;
            approveOrderButton.Name = "approveOrderButton";

            rejectOrderButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            rejectOrderButton.Location = new Point(804, 530);
            rejectOrderButton.Size = new Size(122, 32);
            rejectOrderButton.TabIndex = 5;
            rejectOrderButton.Text = "Отклонить";
            rejectOrderButton.UseVisualStyleBackColor = true;
            rejectOrderButton.Name = "rejectOrderButton";

            materialsGrid.AllowUserToAddRows = false;
            materialsGrid.AllowUserToDeleteRows = false;
            materialsGrid.AllowUserToResizeRows = false;
            materialsGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            materialsGrid.AccessibleName = "Материалы";
            materialsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            materialsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            materialsGrid.Columns.AddRange(materialNameColumn, materialCategoryColumn, materialUnitColumn, materialPriceColumn, materialStockColumn);
            materialsGrid.MultiSelect = false;
            materialsGrid.ReadOnly = true;
            materialsGrid.RowHeadersVisible = false;
            materialsGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            materialsGrid.Location = new Point(16, 16);
            materialsGrid.Size = new Size(910, 331);
            materialsGrid.TabIndex = 0;
            materialsGrid.Name = "materialsGrid";

            materialGroupBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            materialGroupBox.Location = new Point(16, 361);
            materialGroupBox.Size = new Size(910, 203);
            materialGroupBox.TabIndex = 1;
            materialGroupBox.TabStop = false;
            materialGroupBox.Text = "Данные материала";
            materialGroupBox.Controls.Add(materialNameLabel);
            materialGroupBox.Controls.Add(materialNameTextBox);
            materialGroupBox.Controls.Add(materialCategoryLabel);
            materialGroupBox.Controls.Add(materialCategoryComboBox);
            materialGroupBox.Controls.Add(materialUnitLabel);
            materialGroupBox.Controls.Add(materialUnitTextBox);
            materialGroupBox.Controls.Add(materialPriceLabel);
            materialGroupBox.Controls.Add(materialPriceInput);
            materialGroupBox.Controls.Add(materialStockLabel);
            materialGroupBox.Controls.Add(materialStockInput);
            materialGroupBox.Controls.Add(addMaterialButton);
            materialGroupBox.Controls.Add(editMaterialButton);
            materialGroupBox.Controls.Add(deleteMaterialButton);
            materialGroupBox.Name = "materialGroupBox";

            materialNameLabel.AutoSize = true;
            materialNameLabel.Location = new Point(12, 26);
            materialNameLabel.TabIndex = 0;
            materialNameLabel.Text = "&Название";
            materialNameLabel.Name = "materialNameLabel";

            materialNameTextBox.AccessibleName = "Название материала";
            materialNameTextBox.Location = new Point(12, 47);
            materialNameTextBox.Size = new Size(280, 23);
            materialNameTextBox.TabIndex = 1;
            materialNameTextBox.Name = "materialNameTextBox";

            materialCategoryLabel.AutoSize = true;
            materialCategoryLabel.Location = new Point(308, 26);
            materialCategoryLabel.TabIndex = 2;
            materialCategoryLabel.Text = "&Категория";
            materialCategoryLabel.Name = "materialCategoryLabel";

            materialCategoryComboBox.AccessibleName = "Категория материала";
            materialCategoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            materialCategoryComboBox.FormattingEnabled = true;
            materialCategoryComboBox.Location = new Point(308, 47);
            materialCategoryComboBox.Size = new Size(206, 23);
            materialCategoryComboBox.TabIndex = 3;
            materialCategoryComboBox.Name = "materialCategoryComboBox";

            materialUnitLabel.AutoSize = true;
            materialUnitLabel.Location = new Point(530, 26);
            materialUnitLabel.TabIndex = 4;
            materialUnitLabel.Text = "&Единица измерения";
            materialUnitLabel.Name = "materialUnitLabel";

            materialUnitTextBox.AccessibleName = "Единица измерения";
            materialUnitTextBox.Location = new Point(530, 47);
            materialUnitTextBox.Size = new Size(160, 23);
            materialUnitTextBox.TabIndex = 5;
            materialUnitTextBox.Name = "materialUnitTextBox";

            materialPriceLabel.AutoSize = true;
            materialPriceLabel.Location = new Point(12, 89);
            materialPriceLabel.TabIndex = 6;
            materialPriceLabel.Text = "&Цена за единицу";
            materialPriceLabel.Name = "materialPriceLabel";

            materialPriceInput.AccessibleName = "Цена за единицу";
            materialPriceInput.DecimalPlaces = 2;
            materialPriceInput.Maximum = 1000000000M;
            materialPriceInput.Location = new Point(12, 110);
            materialPriceInput.Size = new Size(132, 23);
            materialPriceInput.TabIndex = 7;
            materialPriceInput.Name = "materialPriceInput";

            materialStockLabel.AutoSize = true;
            materialStockLabel.Location = new Point(160, 89);
            materialStockLabel.TabIndex = 8;
            materialStockLabel.Text = "&Остаток";
            materialStockLabel.Name = "materialStockLabel";

            materialStockInput.AccessibleName = "Остаток";
            materialStockInput.DecimalPlaces = 3;
            materialStockInput.Maximum = 1000000000M;
            materialStockInput.Location = new Point(160, 110);
            materialStockInput.Size = new Size(144, 23);
            materialStockInput.TabIndex = 9;
            materialStockInput.Name = "materialStockInput";

            addMaterialButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            addMaterialButton.Location = new Point(530, 153);
            addMaterialButton.Size = new Size(114, 32);
            addMaterialButton.TabIndex = 10;
            addMaterialButton.Text = "Добавить";
            addMaterialButton.UseVisualStyleBackColor = true;
            addMaterialButton.Name = "addMaterialButton";

            editMaterialButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            editMaterialButton.Location = new Point(657, 153);
            editMaterialButton.Size = new Size(114, 32);
            editMaterialButton.TabIndex = 11;
            editMaterialButton.Text = "Изменить";
            editMaterialButton.UseVisualStyleBackColor = true;
            editMaterialButton.Name = "editMaterialButton";

            deleteMaterialButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            deleteMaterialButton.Location = new Point(784, 153);
            deleteMaterialButton.Size = new Size(114, 32);
            deleteMaterialButton.TabIndex = 12;
            deleteMaterialButton.Text = "Удалить";
            deleteMaterialButton.UseVisualStyleBackColor = true;
            deleteMaterialButton.Name = "deleteMaterialButton";

            categoriesGrid.AllowUserToAddRows = false;
            categoriesGrid.AllowUserToDeleteRows = false;
            categoriesGrid.AllowUserToResizeRows = false;
            categoriesGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            categoriesGrid.AccessibleName = "Категории материалов";
            categoriesGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            categoriesGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            categoriesGrid.Columns.AddRange(categoryCodeColumn, categoryNameColumn);
            categoriesGrid.MultiSelect = false;
            categoriesGrid.ReadOnly = true;
            categoriesGrid.RowHeadersVisible = false;
            categoriesGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            categoriesGrid.Location = new Point(16, 16);
            categoriesGrid.Size = new Size(910, 398);
            categoriesGrid.TabIndex = 0;
            categoriesGrid.Name = "categoriesGrid";

            categoryGroupBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            categoryGroupBox.Location = new Point(16, 428);
            categoryGroupBox.Size = new Size(910, 136);
            categoryGroupBox.TabIndex = 1;
            categoryGroupBox.TabStop = false;
            categoryGroupBox.Text = "Данные категории";
            categoryGroupBox.Controls.Add(categoryNameLabel);
            categoryGroupBox.Controls.Add(categoryNameTextBox);
            categoryGroupBox.Controls.Add(addCategoryButton);
            categoryGroupBox.Controls.Add(editCategoryButton);
            categoryGroupBox.Controls.Add(deleteCategoryButton);
            categoryGroupBox.Name = "categoryGroupBox";

            categoryNameLabel.AutoSize = true;
            categoryNameLabel.Location = new Point(12, 25);
            categoryNameLabel.TabIndex = 0;
            categoryNameLabel.Text = "&Название";
            categoryNameLabel.Name = "categoryNameLabel";

            categoryNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            categoryNameTextBox.AccessibleName = "Название категории";
            categoryNameTextBox.Location = new Point(12, 46);
            categoryNameTextBox.Size = new Size(886, 23);
            categoryNameTextBox.TabIndex = 1;
            categoryNameTextBox.Name = "categoryNameTextBox";

            addCategoryButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            addCategoryButton.Location = new Point(530, 88);
            addCategoryButton.Size = new Size(114, 32);
            addCategoryButton.TabIndex = 2;
            addCategoryButton.Text = "Добавить";
            addCategoryButton.UseVisualStyleBackColor = true;
            addCategoryButton.Name = "addCategoryButton";

            editCategoryButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            editCategoryButton.Location = new Point(657, 88);
            editCategoryButton.Size = new Size(114, 32);
            editCategoryButton.TabIndex = 3;
            editCategoryButton.Text = "Изменить";
            editCategoryButton.UseVisualStyleBackColor = true;
            editCategoryButton.Name = "editCategoryButton";

            deleteCategoryButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            deleteCategoryButton.Location = new Point(784, 88);
            deleteCategoryButton.Size = new Size(114, 32);
            deleteCategoryButton.TabIndex = 4;
            deleteCategoryButton.Text = "Удалить";
            deleteCategoryButton.UseVisualStyleBackColor = true;
            deleteCategoryButton.Name = "deleteCategoryButton";

            inventoryTableGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            inventoryTableGroupBox.Location = new Point(16, 16);
            inventoryTableGroupBox.Size = new Size(910, 132);
            inventoryTableGroupBox.TabIndex = 0;
            inventoryTableGroupBox.TabStop = false;
            inventoryTableGroupBox.Text = "Проверка остатков";
            inventoryTableGroupBox.Controls.Add(inventoryTableLinkLabel);
            inventoryTableGroupBox.Controls.Add(createInventoryTableButton);
            inventoryTableGroupBox.Controls.Add(undoInventoryTableButton);
            inventoryTableGroupBox.Name = "inventoryTableGroupBox";

            inventoryTableLinkLabel.AutoSize = true;
            inventoryTableLinkLabel.Location = new Point(12, 26);
            inventoryTableLinkLabel.TabIndex = 0;
            inventoryTableLinkLabel.Text = "Таблица проверки остатков в рабочей базе";
            inventoryTableLinkLabel.Name = "inventoryTableLinkLabel";

            createInventoryTableButton.Location = new Point(12, 69);
            createInventoryTableButton.Size = new Size(157, 32);
            createInventoryTableButton.TabIndex = 1;
            createInventoryTableButton.Text = "Создать таблицу";
            createInventoryTableButton.UseVisualStyleBackColor = true;
            createInventoryTableButton.Name = "createInventoryTableButton";

            undoInventoryTableButton.Enabled = false;
            undoInventoryTableButton.Location = new Point(183, 69);
            undoInventoryTableButton.Size = new Size(157, 32);
            undoInventoryTableButton.TabIndex = 2;
            undoInventoryTableButton.Text = "Откатить добавление";
            undoInventoryTableButton.UseVisualStyleBackColor = true;
            undoInventoryTableButton.Name = "undoInventoryTableButton";

            orderNumberColumn.FillWeight = 65F;
            orderNumberColumn.HeaderText = "Номер";
            orderNumberColumn.Name = "orderNumberColumn";

            orderWorkerColumn.FillWeight = 155F;
            orderWorkerColumn.HeaderText = "Рабочий";
            orderWorkerColumn.Name = "orderWorkerColumn";

            orderDateColumn.FillWeight = 120F;
            orderDateColumn.HeaderText = "Дата и время";
            orderDateColumn.Name = "orderDateColumn";

            orderStatusColumn.FillWeight = 100F;
            orderStatusColumn.HeaderText = "Статус";
            orderStatusColumn.Name = "orderStatusColumn";

            orderTotalColumn.FillWeight = 90F;
            orderTotalColumn.HeaderText = "Сумма";
            orderTotalColumn.Name = "orderTotalColumn";

            itemMaterialColumn.FillWeight = 170F;
            itemMaterialColumn.HeaderText = "Материал";
            itemMaterialColumn.Name = "itemMaterialColumn";

            itemUnitColumn.FillWeight = 65F;
            itemUnitColumn.HeaderText = "Ед. изм.";
            itemUnitColumn.Name = "itemUnitColumn";

            itemQuantityColumn.FillWeight = 85F;
            itemQuantityColumn.HeaderText = "Количество";
            itemQuantityColumn.Name = "itemQuantityColumn";

            itemPriceColumn.FillWeight = 85F;
            itemPriceColumn.HeaderText = "Цена за ед.";
            itemPriceColumn.Name = "itemPriceColumn";

            itemTotalColumn.FillWeight = 85F;
            itemTotalColumn.HeaderText = "Сумма";
            itemTotalColumn.Name = "itemTotalColumn";

            materialNameColumn.FillWeight = 175F;
            materialNameColumn.HeaderText = "Материал";
            materialNameColumn.Name = "materialNameColumn";

            materialCategoryColumn.FillWeight = 130F;
            materialCategoryColumn.HeaderText = "Категория";
            materialCategoryColumn.Name = "materialCategoryColumn";

            materialUnitColumn.FillWeight = 65F;
            materialUnitColumn.HeaderText = "Ед. изм.";
            materialUnitColumn.Name = "materialUnitColumn";

            materialPriceColumn.FillWeight = 85F;
            materialPriceColumn.HeaderText = "Цена за ед.";
            materialPriceColumn.Name = "materialPriceColumn";

            materialStockColumn.FillWeight = 85F;
            materialStockColumn.HeaderText = "Остаток";
            materialStockColumn.Name = "materialStockColumn";

            categoryCodeColumn.FillWeight = 45F;
            categoryCodeColumn.HeaderText = "Код";
            categoryCodeColumn.Name = "categoryCodeColumn";

            categoryNameColumn.FillWeight = 200F;
            categoryNameColumn.HeaderText = "Название";
            categoryNameColumn.Name = "categoryNameColumn";

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(990, 706);
            Controls.Add(warehouseTitleLabel);
            Controls.Add(managerLabel);
            Controls.Add(signOutButton);
            Controls.Add(adminTabControl);
            MinimumSize = new Size(820, 630);
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Склад — управляющий";

            ((System.ComponentModel.ISupportInitialize)ordersGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderItemsGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)materialsGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)materialPriceInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)materialStockInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)categoriesGrid).EndInit();
            inventoryTableGroupBox.ResumeLayout(false);
            inventoryTableGroupBox.PerformLayout();
            categoryGroupBox.ResumeLayout(false);
            categoryGroupBox.PerformLayout();
            materialGroupBox.ResumeLayout(false);
            materialGroupBox.PerformLayout();
            orderItemsGroupBox.ResumeLayout(false);
            maintenanceTabPage.ResumeLayout(false);
            categoriesTabPage.ResumeLayout(false);
            materialsTabPage.ResumeLayout(false);
            ordersTabPage.ResumeLayout(false);
            ordersTabPage.PerformLayout();
            adminTabControl.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private Label warehouseTitleLabel;
        private Label managerLabel;
        private Button signOutButton;
        private TabControl adminTabControl;
        private TabPage ordersTabPage;
        private TabPage materialsTabPage;
        private TabPage categoriesTabPage;
        private TabPage maintenanceTabPage;
        private Label statusLabel;
        private ComboBox orderStatusComboBox;
        private DataGridView ordersGrid;
        private GroupBox orderItemsGroupBox;
        private DataGridView orderItemsGrid;
        private Button approveOrderButton;
        private Button rejectOrderButton;
        private DataGridView materialsGrid;
        private GroupBox materialGroupBox;
        private Label materialNameLabel;
        private TextBox materialNameTextBox;
        private Label materialCategoryLabel;
        private ComboBox materialCategoryComboBox;
        private Label materialUnitLabel;
        private TextBox materialUnitTextBox;
        private Label materialPriceLabel;
        private NumericUpDown materialPriceInput;
        private Label materialStockLabel;
        private NumericUpDown materialStockInput;
        private Button addMaterialButton;
        private Button editMaterialButton;
        private Button deleteMaterialButton;
        private DataGridView categoriesGrid;
        private GroupBox categoryGroupBox;
        private Label categoryNameLabel;
        private TextBox categoryNameTextBox;
        private Button addCategoryButton;
        private Button editCategoryButton;
        private Button deleteCategoryButton;
        private GroupBox inventoryTableGroupBox;
        private Label inventoryTableLinkLabel;
        private Button createInventoryTableButton;
        private Button undoInventoryTableButton;
        private DataGridViewTextBoxColumn orderNumberColumn;
        private DataGridViewTextBoxColumn orderWorkerColumn;
        private DataGridViewTextBoxColumn orderDateColumn;
        private DataGridViewTextBoxColumn orderStatusColumn;
        private DataGridViewTextBoxColumn orderTotalColumn;
        private DataGridViewTextBoxColumn itemMaterialColumn;
        private DataGridViewTextBoxColumn itemUnitColumn;
        private DataGridViewTextBoxColumn itemQuantityColumn;
        private DataGridViewTextBoxColumn itemPriceColumn;
        private DataGridViewTextBoxColumn itemTotalColumn;
        private DataGridViewTextBoxColumn materialNameColumn;
        private DataGridViewTextBoxColumn materialCategoryColumn;
        private DataGridViewTextBoxColumn materialUnitColumn;
        private DataGridViewTextBoxColumn materialPriceColumn;
        private DataGridViewTextBoxColumn materialStockColumn;
        private DataGridViewTextBoxColumn categoryCodeColumn;
        private DataGridViewTextBoxColumn categoryNameColumn;
    }
}
