namespace Trade_Management_System
{
    partial class CashAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashAccount));
            System.Windows.Forms.Label cash_IDLabel;
            System.Windows.Forms.Label dep_IDLabel;
            System.Windows.Forms.Label cashDepositsLabel;
            System.Windows.Forms.Label cashWithdrawalLabel;
            System.Windows.Forms.Label depositDateLabel;
            System.Windows.Forms.Label withdrawalDateLabel;
            this.trade_Management_SystemDataSet = new Trade_Management_System.Trade_Management_SystemDataSet();
            this.tblCashAccountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblCashAccountTableAdapter = new Trade_Management_System.Trade_Management_SystemDataSetTableAdapters.tblCashAccountTableAdapter();
            this.tableAdapterManager = new Trade_Management_System.Trade_Management_SystemDataSetTableAdapters.TableAdapterManager();
            this.tblCashAccountBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tblCashAccountBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cash_IDTextBox = new System.Windows.Forms.TextBox();
            this.dep_IDTextBox = new System.Windows.Forms.TextBox();
            this.cashDepositsTextBox = new System.Windows.Forms.TextBox();
            this.cashWithdrawalTextBox = new System.Windows.Forms.TextBox();
            this.depositDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.withdrawalDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tblCashAccountDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cash_IDLabel = new System.Windows.Forms.Label();
            dep_IDLabel = new System.Windows.Forms.Label();
            cashDepositsLabel = new System.Windows.Forms.Label();
            cashWithdrawalLabel = new System.Windows.Forms.Label();
            depositDateLabel = new System.Windows.Forms.Label();
            withdrawalDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trade_Management_SystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCashAccountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCashAccountBindingNavigator)).BeginInit();
            this.tblCashAccountBindingNavigator.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblCashAccountDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // trade_Management_SystemDataSet
            // 
            this.trade_Management_SystemDataSet.DataSetName = "Trade_Management_SystemDataSet";
            this.trade_Management_SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblCashAccountBindingSource
            // 
            this.tblCashAccountBindingSource.DataMember = "tblCashAccount";
            this.tblCashAccountBindingSource.DataSource = this.trade_Management_SystemDataSet;
            // 
            // tblCashAccountTableAdapter
            // 
            this.tblCashAccountTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblCashAccountTableAdapter = this.tblCashAccountTableAdapter;
            this.tableAdapterManager.tblDepositoryAccountTableAdapter = null;
            this.tableAdapterManager.tblInvestorTableAdapter = null;
            this.tableAdapterManager.tblLoginTableAdapter = null;
            this.tableAdapterManager.tblStockTableAdapter = null;
            this.tableAdapterManager.tblTreasurybondTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Trade_Management_System.Trade_Management_SystemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tblCashAccountBindingNavigator
            // 
            this.tblCashAccountBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tblCashAccountBindingNavigator.BindingSource = this.tblCashAccountBindingSource;
            this.tblCashAccountBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tblCashAccountBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tblCashAccountBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.tblCashAccountBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tblCashAccountBindingNavigatorSaveItem});
            this.tblCashAccountBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tblCashAccountBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tblCashAccountBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tblCashAccountBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tblCashAccountBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tblCashAccountBindingNavigator.Name = "tblCashAccountBindingNavigator";
            this.tblCashAccountBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tblCashAccountBindingNavigator.Size = new System.Drawing.Size(1346, 31);
            this.tblCashAccountBindingNavigator.TabIndex = 0;
            this.tblCashAccountBindingNavigator.Text = "bindingNavigator1";
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
            // tblCashAccountBindingNavigatorSaveItem
            // 
            this.tblCashAccountBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tblCashAccountBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tblCashAccountBindingNavigatorSaveItem.Image")));
            this.tblCashAccountBindingNavigatorSaveItem.Name = "tblCashAccountBindingNavigatorSaveItem";
            this.tblCashAccountBindingNavigatorSaveItem.Size = new System.Drawing.Size(28, 28);
            this.tblCashAccountBindingNavigatorSaveItem.Text = "Save Data";
            this.tblCashAccountBindingNavigatorSaveItem.Click += new System.EventHandler(this.tblCashAccountBindingNavigatorSaveItem_Click);
            // 
            // cash_IDLabel
            // 
            cash_IDLabel.AutoSize = true;
            cash_IDLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cash_IDLabel.Location = new System.Drawing.Point(34, 72);
            cash_IDLabel.Name = "cash_IDLabel";
            cash_IDLabel.Size = new System.Drawing.Size(86, 28);
            cash_IDLabel.TabIndex = 1;
            cash_IDLabel.Text = "Cash ID:";
            // 
            // cash_IDTextBox
            // 
            this.cash_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblCashAccountBindingSource, "Cash_ID", true));
            this.cash_IDTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cash_IDTextBox.Location = new System.Drawing.Point(189, 66);
            this.cash_IDTextBox.Name = "cash_IDTextBox";
            this.cash_IDTextBox.Size = new System.Drawing.Size(405, 34);
            this.cash_IDTextBox.TabIndex = 2;
            this.cash_IDTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cash_IDTextBox_KeyPress);
            // 
            // dep_IDLabel
            // 
            dep_IDLabel.AutoSize = true;
            dep_IDLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dep_IDLabel.Location = new System.Drawing.Point(34, 126);
            dep_IDLabel.Name = "dep_IDLabel";
            dep_IDLabel.Size = new System.Drawing.Size(80, 28);
            dep_IDLabel.TabIndex = 3;
            dep_IDLabel.Text = "Dep ID:";
            // 
            // dep_IDTextBox
            // 
            this.dep_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblCashAccountBindingSource, "Dep_ID", true));
            this.dep_IDTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dep_IDTextBox.Location = new System.Drawing.Point(189, 120);
            this.dep_IDTextBox.Name = "dep_IDTextBox";
            this.dep_IDTextBox.Size = new System.Drawing.Size(405, 34);
            this.dep_IDTextBox.TabIndex = 4;
            this.dep_IDTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dep_IDTextBox_KeyPress);
            // 
            // cashDepositsLabel
            // 
            cashDepositsLabel.AutoSize = true;
            cashDepositsLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cashDepositsLabel.Location = new System.Drawing.Point(34, 180);
            cashDepositsLabel.Name = "cashDepositsLabel";
            cashDepositsLabel.Size = new System.Drawing.Size(145, 28);
            cashDepositsLabel.TabIndex = 5;
            cashDepositsLabel.Text = "Cash Deposits:";
            // 
            // cashDepositsTextBox
            // 
            this.cashDepositsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblCashAccountBindingSource, "CashDeposits", true));
            this.cashDepositsTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashDepositsTextBox.Location = new System.Drawing.Point(189, 174);
            this.cashDepositsTextBox.Name = "cashDepositsTextBox";
            this.cashDepositsTextBox.Size = new System.Drawing.Size(405, 34);
            this.cashDepositsTextBox.TabIndex = 6;
            this.cashDepositsTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cashDepositsTextBox_KeyPress);
            // 
            // cashWithdrawalLabel
            // 
            cashWithdrawalLabel.AutoSize = true;
            cashWithdrawalLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cashWithdrawalLabel.Location = new System.Drawing.Point(637, 72);
            cashWithdrawalLabel.Name = "cashWithdrawalLabel";
            cashWithdrawalLabel.Size = new System.Drawing.Size(168, 28);
            cashWithdrawalLabel.TabIndex = 7;
            cashWithdrawalLabel.Text = "Cash Withdrawal:";
            // 
            // cashWithdrawalTextBox
            // 
            this.cashWithdrawalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblCashAccountBindingSource, "CashWithdrawal", true));
            this.cashWithdrawalTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashWithdrawalTextBox.Location = new System.Drawing.Point(848, 66);
            this.cashWithdrawalTextBox.Name = "cashWithdrawalTextBox";
            this.cashWithdrawalTextBox.Size = new System.Drawing.Size(405, 34);
            this.cashWithdrawalTextBox.TabIndex = 8;
            this.cashWithdrawalTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cashWithdrawalTextBox_KeyPress);
            // 
            // depositDateLabel
            // 
            depositDateLabel.AutoSize = true;
            depositDateLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            depositDateLabel.Location = new System.Drawing.Point(637, 127);
            depositDateLabel.Name = "depositDateLabel";
            depositDateLabel.Size = new System.Drawing.Size(135, 28);
            depositDateLabel.TabIndex = 9;
            depositDateLabel.Text = "Deposit Date:";
            // 
            // depositDateDateTimePicker
            // 
            this.depositDateDateTimePicker.CustomFormat = "dd-MM-yyyy";
            this.depositDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tblCashAccountBindingSource, "DepositDate", true));
            this.depositDateDateTimePicker.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.depositDateDateTimePicker.Location = new System.Drawing.Point(848, 120);
            this.depositDateDateTimePicker.Name = "depositDateDateTimePicker";
            this.depositDateDateTimePicker.Size = new System.Drawing.Size(405, 34);
            this.depositDateDateTimePicker.TabIndex = 10;
            // 
            // withdrawalDateLabel
            // 
            withdrawalDateLabel.AutoSize = true;
            withdrawalDateLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            withdrawalDateLabel.Location = new System.Drawing.Point(637, 181);
            withdrawalDateLabel.Name = "withdrawalDateLabel";
            withdrawalDateLabel.Size = new System.Drawing.Size(167, 28);
            withdrawalDateLabel.TabIndex = 11;
            withdrawalDateLabel.Text = "Withdrawal Date:";
            // 
            // withdrawalDateDateTimePicker
            // 
            this.withdrawalDateDateTimePicker.CustomFormat = "dd-MM-yyyy";
            this.withdrawalDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tblCashAccountBindingSource, "WithdrawalDate", true));
            this.withdrawalDateDateTimePicker.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withdrawalDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.withdrawalDateDateTimePicker.Location = new System.Drawing.Point(848, 174);
            this.withdrawalDateDateTimePicker.Name = "withdrawalDateDateTimePicker";
            this.withdrawalDateDateTimePicker.Size = new System.Drawing.Size(405, 34);
            this.withdrawalDateDateTimePicker.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnPrevious);
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Location = new System.Drawing.Point(254, 223);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(806, 100);
            this.panel1.TabIndex = 19;
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
            // tblCashAccountDataGridView
            // 
            this.tblCashAccountDataGridView.AutoGenerateColumns = false;
            this.tblCashAccountDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblCashAccountDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.tblCashAccountDataGridView.DataSource = this.tblCashAccountBindingSource;
            this.tblCashAccountDataGridView.Location = new System.Drawing.Point(39, 342);
            this.tblCashAccountDataGridView.Name = "tblCashAccountDataGridView";
            this.tblCashAccountDataGridView.RowTemplate.Height = 28;
            this.tblCashAccountDataGridView.Size = new System.Drawing.Size(1214, 220);
            this.tblCashAccountDataGridView.TabIndex = 19;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Cash_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Cash_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 120;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Dep_ID";
            this.dataGridViewTextBoxColumn2.HeaderText = "Dep_ID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 120;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CashDeposits";
            this.dataGridViewTextBoxColumn3.HeaderText = "CashDeposits";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CashWithdrawal";
            this.dataGridViewTextBoxColumn4.HeaderText = "CashWithdrawal";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DepositDate";
            this.dataGridViewTextBoxColumn5.HeaderText = "DepositDate";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 110;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "WithdrawalDate";
            this.dataGridViewTextBoxColumn6.HeaderText = "WithdrawalDate";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 110;
            // 
            // CashAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1346, 732);
            this.Controls.Add(this.tblCashAccountDataGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(cash_IDLabel);
            this.Controls.Add(this.cash_IDTextBox);
            this.Controls.Add(dep_IDLabel);
            this.Controls.Add(this.dep_IDTextBox);
            this.Controls.Add(cashDepositsLabel);
            this.Controls.Add(this.cashDepositsTextBox);
            this.Controls.Add(cashWithdrawalLabel);
            this.Controls.Add(this.cashWithdrawalTextBox);
            this.Controls.Add(depositDateLabel);
            this.Controls.Add(this.depositDateDateTimePicker);
            this.Controls.Add(withdrawalDateLabel);
            this.Controls.Add(this.withdrawalDateDateTimePicker);
            this.Controls.Add(this.tblCashAccountBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "CashAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CashAccount";
            this.Load += new System.EventHandler(this.CashAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trade_Management_SystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCashAccountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCashAccountBindingNavigator)).EndInit();
            this.tblCashAccountBindingNavigator.ResumeLayout(false);
            this.tblCashAccountBindingNavigator.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblCashAccountDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Trade_Management_SystemDataSet trade_Management_SystemDataSet;
        private System.Windows.Forms.BindingSource tblCashAccountBindingSource;
        private Trade_Management_SystemDataSetTableAdapters.tblCashAccountTableAdapter tblCashAccountTableAdapter;
        private Trade_Management_SystemDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tblCashAccountBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tblCashAccountBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox cash_IDTextBox;
        private System.Windows.Forms.TextBox dep_IDTextBox;
        private System.Windows.Forms.TextBox cashDepositsTextBox;
        private System.Windows.Forms.TextBox cashWithdrawalTextBox;
        private System.Windows.Forms.DateTimePicker depositDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker withdrawalDateDateTimePicker;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView tblCashAccountDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}
