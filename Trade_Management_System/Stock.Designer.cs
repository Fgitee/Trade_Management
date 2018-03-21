namespace Trade_Management_System
{
    partial class Stock
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stock));
            System.Windows.Forms.Label stock_IDLabel;
            System.Windows.Forms.Label inv_IDLabel;
            System.Windows.Forms.Label stockNameLabel;
            System.Windows.Forms.Label quantityLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label tradeAmountLabel;
            this.trade_Management_SystemDataSet = new Trade_Management_System.Trade_Management_SystemDataSet();
            this.tblStockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblStockTableAdapter = new Trade_Management_System.Trade_Management_SystemDataSetTableAdapters.tblStockTableAdapter();
            this.tableAdapterManager = new Trade_Management_System.Trade_Management_SystemDataSetTableAdapters.TableAdapterManager();
            this.tblStockBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.tblStockBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.stock_IDTextBox = new System.Windows.Forms.TextBox();
            this.inv_IDTextBox = new System.Windows.Forms.TextBox();
            this.stockNameTextBox = new System.Windows.Forms.TextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.tradeAmountTextBox = new System.Windows.Forms.TextBox();
            this.tblStockDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            stock_IDLabel = new System.Windows.Forms.Label();
            inv_IDLabel = new System.Windows.Forms.Label();
            stockNameLabel = new System.Windows.Forms.Label();
            quantityLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            tradeAmountLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trade_Management_SystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStockBindingNavigator)).BeginInit();
            this.tblStockBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblStockDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // trade_Management_SystemDataSet
            // 
            this.trade_Management_SystemDataSet.DataSetName = "Trade_Management_SystemDataSet";
            this.trade_Management_SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblStockBindingSource
            // 
            this.tblStockBindingSource.DataMember = "tblStock";
            this.tblStockBindingSource.DataSource = this.trade_Management_SystemDataSet;
            // 
            // tblStockTableAdapter
            // 
            this.tblStockTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblCashAccountTableAdapter = null;
            this.tableAdapterManager.tblDepositoryAccountTableAdapter = null;
            this.tableAdapterManager.tblInvestorTableAdapter = null;
            this.tableAdapterManager.tblLoginTableAdapter = null;
            this.tableAdapterManager.tblStockTableAdapter = this.tblStockTableAdapter;
            this.tableAdapterManager.tblTreasurybondTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Trade_Management_System.Trade_Management_SystemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tblStockBindingNavigator
            // 
            this.tblStockBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tblStockBindingNavigator.BindingSource = this.tblStockBindingSource;
            this.tblStockBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tblStockBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tblStockBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.tblStockBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tblStockBindingNavigatorSaveItem});
            this.tblStockBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tblStockBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tblStockBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tblStockBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tblStockBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tblStockBindingNavigator.Name = "tblStockBindingNavigator";
            this.tblStockBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tblStockBindingNavigator.Size = new System.Drawing.Size(1346, 31);
            this.tblStockBindingNavigator.TabIndex = 0;
            this.tblStockBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // tblStockBindingNavigatorSaveItem
            // 
            this.tblStockBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tblStockBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tblStockBindingNavigatorSaveItem.Image")));
            this.tblStockBindingNavigatorSaveItem.Name = "tblStockBindingNavigatorSaveItem";
            this.tblStockBindingNavigatorSaveItem.Size = new System.Drawing.Size(28, 28);
            this.tblStockBindingNavigatorSaveItem.Text = "Save Data";
            this.tblStockBindingNavigatorSaveItem.Click += new System.EventHandler(this.tblStockBindingNavigatorSaveItem_Click);
            // 
            // stock_IDLabel
            // 
            stock_IDLabel.AutoSize = true;
            stock_IDLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            stock_IDLabel.Location = new System.Drawing.Point(52, 72);
            stock_IDLabel.Name = "stock_IDLabel";
            stock_IDLabel.Size = new System.Drawing.Size(92, 28);
            stock_IDLabel.TabIndex = 1;
            stock_IDLabel.Text = "Stock ID:";
            // 
            // stock_IDTextBox
            // 
            this.stock_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblStockBindingSource, "Stock_ID", true));
            this.stock_IDTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stock_IDTextBox.Location = new System.Drawing.Point(231, 66);
            this.stock_IDTextBox.Name = "stock_IDTextBox";
            this.stock_IDTextBox.Size = new System.Drawing.Size(352, 34);
            this.stock_IDTextBox.TabIndex = 2;
            this.stock_IDTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.stock_IDTextBox_KeyPress);
            // 
            // inv_IDLabel
            // 
            inv_IDLabel.AutoSize = true;
            inv_IDLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            inv_IDLabel.Location = new System.Drawing.Point(52, 126);
            inv_IDLabel.Name = "inv_IDLabel";
            inv_IDLabel.Size = new System.Drawing.Size(71, 28);
            inv_IDLabel.TabIndex = 3;
            inv_IDLabel.Text = "Inv ID:";
            // 
            // inv_IDTextBox
            // 
            this.inv_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblStockBindingSource, "Inv_ID", true));
            this.inv_IDTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inv_IDTextBox.Location = new System.Drawing.Point(231, 120);
            this.inv_IDTextBox.Name = "inv_IDTextBox";
            this.inv_IDTextBox.Size = new System.Drawing.Size(352, 34);
            this.inv_IDTextBox.TabIndex = 4;
            this.inv_IDTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inv_IDTextBox_KeyPress);
            // 
            // stockNameLabel
            // 
            stockNameLabel.AutoSize = true;
            stockNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            stockNameLabel.Location = new System.Drawing.Point(52, 180);
            stockNameLabel.Name = "stockNameLabel";
            stockNameLabel.Size = new System.Drawing.Size(126, 28);
            stockNameLabel.TabIndex = 5;
            stockNameLabel.Text = "Stock Name:";
            // 
            // stockNameTextBox
            // 
            this.stockNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblStockBindingSource, "StockName", true));
            this.stockNameTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockNameTextBox.Location = new System.Drawing.Point(231, 174);
            this.stockNameTextBox.Name = "stockNameTextBox";
            this.stockNameTextBox.Size = new System.Drawing.Size(352, 34);
            this.stockNameTextBox.TabIndex = 6;
            this.stockNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.stockNameTextBox_KeyPress);
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            quantityLabel.Location = new System.Drawing.Point(756, 72);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new System.Drawing.Size(95, 28);
            quantityLabel.TabIndex = 7;
            quantityLabel.Text = "Quantity:";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblStockBindingSource, "Quantity", true));
            this.quantityTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityTextBox.Location = new System.Drawing.Point(935, 66);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(352, 34);
            this.quantityTextBox.TabIndex = 8;
            this.quantityTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.quantityTextBox_KeyPress);
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            priceLabel.Location = new System.Drawing.Point(756, 126);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(61, 28);
            priceLabel.TabIndex = 9;
            priceLabel.Text = "Price:";
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblStockBindingSource, "Price", true));
            this.priceTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTextBox.Location = new System.Drawing.Point(935, 120);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(352, 34);
            this.priceTextBox.TabIndex = 10;
            this.priceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.priceTextBox_KeyPress);
            // 
            // tradeAmountLabel
            // 
            tradeAmountLabel.AutoSize = true;
            tradeAmountLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tradeAmountLabel.Location = new System.Drawing.Point(756, 180);
            tradeAmountLabel.Name = "tradeAmountLabel";
            tradeAmountLabel.Size = new System.Drawing.Size(146, 28);
            tradeAmountLabel.TabIndex = 11;
            tradeAmountLabel.Text = "Trade Amount:";
            // 
            // tradeAmountTextBox
            // 
            this.tradeAmountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblStockBindingSource, "TradeAmount", true));
            this.tradeAmountTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tradeAmountTextBox.Location = new System.Drawing.Point(935, 174);
            this.tradeAmountTextBox.Name = "tradeAmountTextBox";
            this.tradeAmountTextBox.Size = new System.Drawing.Size(352, 34);
            this.tradeAmountTextBox.TabIndex = 12;
            this.tradeAmountTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tradeAmountTextBox_KeyPress);
            // 
            // tblStockDataGridView
            // 
            this.tblStockDataGridView.AutoGenerateColumns = false;
            this.tblStockDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblStockDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.tblStockDataGridView.DataSource = this.tblStockBindingSource;
            this.tblStockDataGridView.Location = new System.Drawing.Point(57, 357);
            this.tblStockDataGridView.Name = "tblStockDataGridView";
            this.tblStockDataGridView.RowTemplate.Height = 28;
            this.tblStockDataGridView.Size = new System.Drawing.Size(1230, 220);
            this.tblStockDataGridView.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Stock_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Stock_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 120;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Inv_ID";
            this.dataGridViewTextBoxColumn2.HeaderText = "Inv_ID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 120;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "StockName";
            this.dataGridViewTextBoxColumn3.HeaderText = "StockName";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Quantity";
            this.dataGridViewTextBoxColumn4.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn5.HeaderText = "Price";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "TradeAmount";
            this.dataGridViewTextBoxColumn6.HeaderText = "TradeAmount";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 120;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnPrevious);
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Location = new System.Drawing.Point(262, 236);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(806, 100);
            this.panel1.TabIndex = 15;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(36, 21);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(121, 60);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(648, 21);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(121, 60);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.Location = new System.Drawing.Point(493, 21);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(121, 60);
            this.btnPrevious.TabIndex = 2;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(340, 21);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(121, 60);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(191, 21);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(121, 60);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1346, 732);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tblStockDataGridView);
            this.Controls.Add(stock_IDLabel);
            this.Controls.Add(this.stock_IDTextBox);
            this.Controls.Add(inv_IDLabel);
            this.Controls.Add(this.inv_IDTextBox);
            this.Controls.Add(stockNameLabel);
            this.Controls.Add(this.stockNameTextBox);
            this.Controls.Add(quantityLabel);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(priceLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(tradeAmountLabel);
            this.Controls.Add(this.tradeAmountTextBox);
            this.Controls.Add(this.tblStockBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Stock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Stock";
            this.Load += new System.EventHandler(this.Stock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trade_Management_SystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStockBindingNavigator)).EndInit();
            this.tblStockBindingNavigator.ResumeLayout(false);
            this.tblStockBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblStockDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Trade_Management_SystemDataSet trade_Management_SystemDataSet;
        private System.Windows.Forms.BindingSource tblStockBindingSource;
        private Trade_Management_SystemDataSetTableAdapters.tblStockTableAdapter tblStockTableAdapter;
        private Trade_Management_SystemDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tblStockBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tblStockBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox stock_IDTextBox;
        private System.Windows.Forms.TextBox inv_IDTextBox;
        private System.Windows.Forms.TextBox stockNameTextBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox tradeAmountTextBox;
        private System.Windows.Forms.DataGridView tblStockDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnSave;
    }
}