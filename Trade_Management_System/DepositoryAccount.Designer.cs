namespace Trade_Management_System
{
    partial class DepositoryAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepositoryAccount));
            System.Windows.Forms.Label dep_IDLabel;
            System.Windows.Forms.Label tBond_IDLabel;
            System.Windows.Forms.Label purchasesLabel;
            System.Windows.Forms.Label withdrawalLabel;
            System.Windows.Forms.Label holdingLabel;
            System.Windows.Forms.Label transactionDateLabel;
            System.Windows.Forms.Label settlementDateLabel;
            System.Windows.Forms.Label stock_IDLabel;
            this.trade_Management_SystemDataSet = new Trade_Management_System.Trade_Management_SystemDataSet();
            this.tblDepositoryAccountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblDepositoryAccountTableAdapter = new Trade_Management_System.Trade_Management_SystemDataSetTableAdapters.tblDepositoryAccountTableAdapter();
            this.tableAdapterManager = new Trade_Management_System.Trade_Management_SystemDataSetTableAdapters.TableAdapterManager();
            this.tblDepositoryAccountBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tblDepositoryAccountBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dep_IDTextBox = new System.Windows.Forms.TextBox();
            this.tBond_IDTextBox = new System.Windows.Forms.TextBox();
            this.purchasesTextBox = new System.Windows.Forms.TextBox();
            this.withdrawalTextBox = new System.Windows.Forms.TextBox();
            this.holdingTextBox = new System.Windows.Forms.TextBox();
            this.transactionDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.settlementDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.stock_IDTextBox = new System.Windows.Forms.TextBox();
            this.tblDepositoryAccountDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            dep_IDLabel = new System.Windows.Forms.Label();
            tBond_IDLabel = new System.Windows.Forms.Label();
            purchasesLabel = new System.Windows.Forms.Label();
            withdrawalLabel = new System.Windows.Forms.Label();
            holdingLabel = new System.Windows.Forms.Label();
            transactionDateLabel = new System.Windows.Forms.Label();
            settlementDateLabel = new System.Windows.Forms.Label();
            stock_IDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trade_Management_SystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDepositoryAccountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDepositoryAccountBindingNavigator)).BeginInit();
            this.tblDepositoryAccountBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblDepositoryAccountDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // trade_Management_SystemDataSet
            // 
            this.trade_Management_SystemDataSet.DataSetName = "Trade_Management_SystemDataSet";
            this.trade_Management_SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblDepositoryAccountBindingSource
            // 
            this.tblDepositoryAccountBindingSource.DataMember = "tblDepositoryAccount";
            this.tblDepositoryAccountBindingSource.DataSource = this.trade_Management_SystemDataSet;
            // 
            // tblDepositoryAccountTableAdapter
            // 
            this.tblDepositoryAccountTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblCashAccountTableAdapter = null;
            this.tableAdapterManager.tblDepositoryAccountTableAdapter = this.tblDepositoryAccountTableAdapter;
            this.tableAdapterManager.tblInvestorTableAdapter = null;
            this.tableAdapterManager.tblLoginTableAdapter = null;
            this.tableAdapterManager.tblStockTableAdapter = null;
            this.tableAdapterManager.tblTreasurybondTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Trade_Management_System.Trade_Management_SystemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tblDepositoryAccountBindingNavigator
            // 
            this.tblDepositoryAccountBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tblDepositoryAccountBindingNavigator.BindingSource = this.tblDepositoryAccountBindingSource;
            this.tblDepositoryAccountBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tblDepositoryAccountBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tblDepositoryAccountBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.tblDepositoryAccountBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tblDepositoryAccountBindingNavigatorSaveItem});
            this.tblDepositoryAccountBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tblDepositoryAccountBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tblDepositoryAccountBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tblDepositoryAccountBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tblDepositoryAccountBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tblDepositoryAccountBindingNavigator.Name = "tblDepositoryAccountBindingNavigator";
            this.tblDepositoryAccountBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tblDepositoryAccountBindingNavigator.Size = new System.Drawing.Size(1346, 31);
            this.tblDepositoryAccountBindingNavigator.TabIndex = 0;
            this.tblDepositoryAccountBindingNavigator.Text = "bindingNavigator1";
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
            // tblDepositoryAccountBindingNavigatorSaveItem
            // 
            this.tblDepositoryAccountBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tblDepositoryAccountBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tblDepositoryAccountBindingNavigatorSaveItem.Image")));
            this.tblDepositoryAccountBindingNavigatorSaveItem.Name = "tblDepositoryAccountBindingNavigatorSaveItem";
            this.tblDepositoryAccountBindingNavigatorSaveItem.Size = new System.Drawing.Size(28, 28);
            this.tblDepositoryAccountBindingNavigatorSaveItem.Text = "Save Data";
            this.tblDepositoryAccountBindingNavigatorSaveItem.Click += new System.EventHandler(this.tblDepositoryAccountBindingNavigatorSaveItem_Click);
            // 
            // dep_IDLabel
            // 
            dep_IDLabel.AutoSize = true;
            dep_IDLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dep_IDLabel.Location = new System.Drawing.Point(46, 73);
            dep_IDLabel.Name = "dep_IDLabel";
            dep_IDLabel.Size = new System.Drawing.Size(80, 28);
            dep_IDLabel.TabIndex = 1;
            dep_IDLabel.Text = "Dep ID:";
            // 
            // dep_IDTextBox
            // 
            this.dep_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblDepositoryAccountBindingSource, "Dep_ID", true));
            this.dep_IDTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dep_IDTextBox.Location = new System.Drawing.Point(187, 70);
            this.dep_IDTextBox.Name = "dep_IDTextBox";
            this.dep_IDTextBox.Size = new System.Drawing.Size(421, 34);
            this.dep_IDTextBox.TabIndex = 2;
            this.dep_IDTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dep_IDTextBox_KeyPress);
            // 
            // tBond_IDLabel
            // 
            tBond_IDLabel.AutoSize = true;
            tBond_IDLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tBond_IDLabel.Location = new System.Drawing.Point(46, 121);
            tBond_IDLabel.Name = "tBond_IDLabel";
            tBond_IDLabel.Size = new System.Drawing.Size(102, 28);
            tBond_IDLabel.TabIndex = 3;
            tBond_IDLabel.Text = "TBond ID:";
            // 
            // tBond_IDTextBox
            // 
            this.tBond_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblDepositoryAccountBindingSource, "TBond_ID", true));
            this.tBond_IDTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBond_IDTextBox.Location = new System.Drawing.Point(187, 118);
            this.tBond_IDTextBox.Name = "tBond_IDTextBox";
            this.tBond_IDTextBox.Size = new System.Drawing.Size(421, 34);
            this.tBond_IDTextBox.TabIndex = 4;
            this.tBond_IDTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBond_IDTextBox_KeyPress);
            // 
            // purchasesLabel
            // 
            purchasesLabel.AutoSize = true;
            purchasesLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            purchasesLabel.Location = new System.Drawing.Point(46, 167);
            purchasesLabel.Name = "purchasesLabel";
            purchasesLabel.Size = new System.Drawing.Size(108, 28);
            purchasesLabel.TabIndex = 5;
            purchasesLabel.Text = "Purchases:";
            // 
            // purchasesTextBox
            // 
            this.purchasesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblDepositoryAccountBindingSource, "Purchases", true));
            this.purchasesTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchasesTextBox.Location = new System.Drawing.Point(187, 164);
            this.purchasesTextBox.Name = "purchasesTextBox";
            this.purchasesTextBox.Size = new System.Drawing.Size(421, 34);
            this.purchasesTextBox.TabIndex = 6;
            this.purchasesTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.purchasesTextBox_KeyPress);
            // 
            // withdrawalLabel
            // 
            withdrawalLabel.AutoSize = true;
            withdrawalLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            withdrawalLabel.Location = new System.Drawing.Point(46, 215);
            withdrawalLabel.Name = "withdrawalLabel";
            withdrawalLabel.Size = new System.Drawing.Size(119, 28);
            withdrawalLabel.TabIndex = 7;
            withdrawalLabel.Text = "Withdrawal:";
            // 
            // withdrawalTextBox
            // 
            this.withdrawalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblDepositoryAccountBindingSource, "Withdrawal", true));
            this.withdrawalTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withdrawalTextBox.Location = new System.Drawing.Point(187, 212);
            this.withdrawalTextBox.Name = "withdrawalTextBox";
            this.withdrawalTextBox.Size = new System.Drawing.Size(421, 34);
            this.withdrawalTextBox.TabIndex = 8;
            this.withdrawalTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.withdrawalTextBox_KeyPress);
            // 
            // holdingLabel
            // 
            holdingLabel.AutoSize = true;
            holdingLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            holdingLabel.Location = new System.Drawing.Point(649, 73);
            holdingLabel.Name = "holdingLabel";
            holdingLabel.Size = new System.Drawing.Size(90, 28);
            holdingLabel.TabIndex = 9;
            holdingLabel.Text = "Holding:";
            // 
            // holdingTextBox
            // 
            this.holdingTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblDepositoryAccountBindingSource, "Holding", true));
            this.holdingTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.holdingTextBox.Location = new System.Drawing.Point(823, 70);
            this.holdingTextBox.Name = "holdingTextBox";
            this.holdingTextBox.Size = new System.Drawing.Size(421, 34);
            this.holdingTextBox.TabIndex = 10;
            this.holdingTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.holdingTextBox_KeyPress);
            // 
            // transactionDateLabel
            // 
            transactionDateLabel.AutoSize = true;
            transactionDateLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            transactionDateLabel.Location = new System.Drawing.Point(649, 122);
            transactionDateLabel.Name = "transactionDateLabel";
            transactionDateLabel.Size = new System.Drawing.Size(167, 28);
            transactionDateLabel.TabIndex = 11;
            transactionDateLabel.Text = "Transaction Date:";
            // 
            // transactionDateDateTimePicker
            // 
            this.transactionDateDateTimePicker.CustomFormat = "dd-MM-yyyy";
            this.transactionDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tblDepositoryAccountBindingSource, "TransactionDate", true));
            this.transactionDateDateTimePicker.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.transactionDateDateTimePicker.Location = new System.Drawing.Point(823, 118);
            this.transactionDateDateTimePicker.Name = "transactionDateDateTimePicker";
            this.transactionDateDateTimePicker.Size = new System.Drawing.Size(421, 34);
            this.transactionDateDateTimePicker.TabIndex = 12;
            // 
            // settlementDateLabel
            // 
            settlementDateLabel.AutoSize = true;
            settlementDateLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            settlementDateLabel.Location = new System.Drawing.Point(649, 168);
            settlementDateLabel.Name = "settlementDateLabel";
            settlementDateLabel.Size = new System.Drawing.Size(165, 28);
            settlementDateLabel.TabIndex = 13;
            settlementDateLabel.Text = "Settlement Date:";
            // 
            // settlementDateDateTimePicker
            // 
            this.settlementDateDateTimePicker.CustomFormat = "dd-MM-yyyy";
            this.settlementDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tblDepositoryAccountBindingSource, "SettlementDate", true));
            this.settlementDateDateTimePicker.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settlementDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.settlementDateDateTimePicker.Location = new System.Drawing.Point(823, 164);
            this.settlementDateDateTimePicker.Name = "settlementDateDateTimePicker";
            this.settlementDateDateTimePicker.Size = new System.Drawing.Size(421, 34);
            this.settlementDateDateTimePicker.TabIndex = 14;
            // 
            // stock_IDLabel
            // 
            stock_IDLabel.AutoSize = true;
            stock_IDLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            stock_IDLabel.Location = new System.Drawing.Point(649, 215);
            stock_IDLabel.Name = "stock_IDLabel";
            stock_IDLabel.Size = new System.Drawing.Size(92, 28);
            stock_IDLabel.TabIndex = 15;
            stock_IDLabel.Text = "Stock ID:";
            // 
            // stock_IDTextBox
            // 
            this.stock_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblDepositoryAccountBindingSource, "Stock_ID", true));
            this.stock_IDTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stock_IDTextBox.Location = new System.Drawing.Point(823, 212);
            this.stock_IDTextBox.Name = "stock_IDTextBox";
            this.stock_IDTextBox.Size = new System.Drawing.Size(421, 34);
            this.stock_IDTextBox.TabIndex = 16;
            this.stock_IDTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.stock_IDTextBox_KeyPress);
            // 
            // tblDepositoryAccountDataGridView
            // 
            this.tblDepositoryAccountDataGridView.AutoGenerateColumns = false;
            this.tblDepositoryAccountDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblDepositoryAccountDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.tblDepositoryAccountDataGridView.DataSource = this.tblDepositoryAccountBindingSource;
            this.tblDepositoryAccountDataGridView.Location = new System.Drawing.Point(51, 359);
            this.tblDepositoryAccountDataGridView.Name = "tblDepositoryAccountDataGridView";
            this.tblDepositoryAccountDataGridView.RowTemplate.Height = 28;
            this.tblDepositoryAccountDataGridView.Size = new System.Drawing.Size(1193, 234);
            this.tblDepositoryAccountDataGridView.TabIndex = 17;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Dep_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Dep_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TBond_ID";
            this.dataGridViewTextBoxColumn2.HeaderText = "TBond_ID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Purchases";
            this.dataGridViewTextBoxColumn3.HeaderText = "Purchases";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Withdrawal";
            this.dataGridViewTextBoxColumn4.HeaderText = "Withdrawal";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Holding";
            this.dataGridViewTextBoxColumn5.HeaderText = "Holding";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "TransactionDate";
            this.dataGridViewTextBoxColumn6.HeaderText = "TransactionDate";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "SettlementDate";
            this.dataGridViewTextBoxColumn7.HeaderText = "SettlementDate";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Stock_ID";
            this.dataGridViewTextBoxColumn8.HeaderText = "Stock_ID";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnPrevious);
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Location = new System.Drawing.Point(278, 252);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(806, 100);
            this.panel1.TabIndex = 18;
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
            // DepositoryAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1346, 732);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tblDepositoryAccountDataGridView);
            this.Controls.Add(dep_IDLabel);
            this.Controls.Add(this.dep_IDTextBox);
            this.Controls.Add(tBond_IDLabel);
            this.Controls.Add(this.tBond_IDTextBox);
            this.Controls.Add(purchasesLabel);
            this.Controls.Add(this.purchasesTextBox);
            this.Controls.Add(withdrawalLabel);
            this.Controls.Add(this.withdrawalTextBox);
            this.Controls.Add(holdingLabel);
            this.Controls.Add(this.holdingTextBox);
            this.Controls.Add(transactionDateLabel);
            this.Controls.Add(this.transactionDateDateTimePicker);
            this.Controls.Add(settlementDateLabel);
            this.Controls.Add(this.settlementDateDateTimePicker);
            this.Controls.Add(stock_IDLabel);
            this.Controls.Add(this.stock_IDTextBox);
            this.Controls.Add(this.tblDepositoryAccountBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "DepositoryAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DepositoryAccount";
            this.Load += new System.EventHandler(this.DepositoryAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trade_Management_SystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDepositoryAccountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDepositoryAccountBindingNavigator)).EndInit();
            this.tblDepositoryAccountBindingNavigator.ResumeLayout(false);
            this.tblDepositoryAccountBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblDepositoryAccountDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Trade_Management_SystemDataSet trade_Management_SystemDataSet;
        private System.Windows.Forms.BindingSource tblDepositoryAccountBindingSource;
        private Trade_Management_SystemDataSetTableAdapters.tblDepositoryAccountTableAdapter tblDepositoryAccountTableAdapter;
        private Trade_Management_SystemDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tblDepositoryAccountBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tblDepositoryAccountBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox dep_IDTextBox;
        private System.Windows.Forms.TextBox tBond_IDTextBox;
        private System.Windows.Forms.TextBox purchasesTextBox;
        private System.Windows.Forms.TextBox withdrawalTextBox;
        private System.Windows.Forms.TextBox holdingTextBox;
        private System.Windows.Forms.DateTimePicker transactionDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker settlementDateDateTimePicker;
        private System.Windows.Forms.TextBox stock_IDTextBox;
        private System.Windows.Forms.DataGridView tblDepositoryAccountDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnSave;
    }
}