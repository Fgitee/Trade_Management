namespace Trade_Management_System
{
    partial class TreasuryBond
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
            System.Windows.Forms.Label treasuryBond_IDLabel;
            System.Windows.Forms.Label inv_IDLabel;
            System.Windows.Forms.Label treasuryBondNameLabel;
            System.Windows.Forms.Label faceValueLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label tradeValueLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TreasuryBond));
            this.trade_Management_SystemDataSet = new Trade_Management_System.Trade_Management_SystemDataSet();
            this.tblTreasurybondBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblTreasurybondTableAdapter = new Trade_Management_System.Trade_Management_SystemDataSetTableAdapters.tblTreasurybondTableAdapter();
            this.tableAdapterManager = new Trade_Management_System.Trade_Management_SystemDataSetTableAdapters.TableAdapterManager();
            this.tblTreasurybondBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tblTreasurybondBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tslSearch = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.txtSearch = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.treasuryBond_IDTextBox = new System.Windows.Forms.TextBox();
            this.inv_IDTextBox = new System.Windows.Forms.TextBox();
            this.treasuryBondNameTextBox = new System.Windows.Forms.TextBox();
            this.faceValueTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.tradeValueTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tblTreasurybondDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            treasuryBond_IDLabel = new System.Windows.Forms.Label();
            inv_IDLabel = new System.Windows.Forms.Label();
            treasuryBondNameLabel = new System.Windows.Forms.Label();
            faceValueLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            tradeValueLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trade_Management_SystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTreasurybondBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTreasurybondBindingNavigator)).BeginInit();
            this.tblTreasurybondBindingNavigator.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblTreasurybondDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // treasuryBond_IDLabel
            // 
            treasuryBond_IDLabel.AutoSize = true;
            treasuryBond_IDLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treasuryBond_IDLabel.Location = new System.Drawing.Point(66, 84);
            treasuryBond_IDLabel.Name = "treasuryBond_IDLabel";
            treasuryBond_IDLabel.Size = new System.Drawing.Size(173, 28);
            treasuryBond_IDLabel.TabIndex = 1;
            treasuryBond_IDLabel.Text = "Treasury Bond ID:";
            // 
            // inv_IDLabel
            // 
            inv_IDLabel.AutoSize = true;
            inv_IDLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            inv_IDLabel.Location = new System.Drawing.Point(66, 150);
            inv_IDLabel.Name = "inv_IDLabel";
            inv_IDLabel.Size = new System.Drawing.Size(71, 28);
            inv_IDLabel.TabIndex = 3;
            inv_IDLabel.Text = "Inv ID:";
            // 
            // treasuryBondNameLabel
            // 
            treasuryBondNameLabel.AutoSize = true;
            treasuryBondNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treasuryBondNameLabel.Location = new System.Drawing.Point(66, 213);
            treasuryBondNameLabel.Name = "treasuryBondNameLabel";
            treasuryBondNameLabel.Size = new System.Drawing.Size(207, 28);
            treasuryBondNameLabel.TabIndex = 5;
            treasuryBondNameLabel.Text = "Treasury Bond Name:";
            // 
            // faceValueLabel
            // 
            faceValueLabel.AutoSize = true;
            faceValueLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            faceValueLabel.Location = new System.Drawing.Point(695, 81);
            faceValueLabel.Name = "faceValueLabel";
            faceValueLabel.Size = new System.Drawing.Size(112, 28);
            faceValueLabel.TabIndex = 7;
            faceValueLabel.Text = "Face Value:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            priceLabel.Location = new System.Drawing.Point(695, 147);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(61, 28);
            priceLabel.TabIndex = 9;
            priceLabel.Text = "Price:";
            // 
            // tradeValueLabel
            // 
            tradeValueLabel.AutoSize = true;
            tradeValueLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tradeValueLabel.Location = new System.Drawing.Point(695, 210);
            tradeValueLabel.Name = "tradeValueLabel";
            tradeValueLabel.Size = new System.Drawing.Size(122, 28);
            tradeValueLabel.TabIndex = 11;
            tradeValueLabel.Text = "Trade Value:";
            // 
            // trade_Management_SystemDataSet
            // 
            this.trade_Management_SystemDataSet.DataSetName = "Trade_Management_SystemDataSet";
            this.trade_Management_SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblTreasurybondBindingSource
            // 
            this.tblTreasurybondBindingSource.DataMember = "tblTreasurybond";
            this.tblTreasurybondBindingSource.DataSource = this.trade_Management_SystemDataSet;
            // 
            // tblTreasurybondTableAdapter
            // 
            this.tblTreasurybondTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblCashAccountTableAdapter = null;
            this.tableAdapterManager.tblDepositoryAccountTableAdapter = null;
            this.tableAdapterManager.tblInvestorTableAdapter = null;
            this.tableAdapterManager.tblLoginTableAdapter = null;
            this.tableAdapterManager.tblStockTableAdapter = null;
            this.tableAdapterManager.tblTreasurybondTableAdapter = this.tblTreasurybondTableAdapter;
            this.tableAdapterManager.UpdateOrder = Trade_Management_System.Trade_Management_SystemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tblTreasurybondBindingNavigator
            // 
            this.tblTreasurybondBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tblTreasurybondBindingNavigator.BindingSource = this.tblTreasurybondBindingSource;
            this.tblTreasurybondBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tblTreasurybondBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tblTreasurybondBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.tblTreasurybondBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tblTreasurybondBindingNavigatorSaveItem,
            this.tslSearch,
            this.toolStripSeparator1,
            this.toolStripSeparator2,
            this.txtSearch,
            this.toolStripSeparator3,
            this.toolStripButton1});
            this.tblTreasurybondBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tblTreasurybondBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tblTreasurybondBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tblTreasurybondBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tblTreasurybondBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tblTreasurybondBindingNavigator.Name = "tblTreasurybondBindingNavigator";
            this.tblTreasurybondBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tblTreasurybondBindingNavigator.Size = new System.Drawing.Size(1344, 31);
            this.tblTreasurybondBindingNavigator.TabIndex = 0;
            this.tblTreasurybondBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 30);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(28, 30);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(28, 30);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(28, 30);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 33);
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(28, 30);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(28, 30);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // tblTreasurybondBindingNavigatorSaveItem
            // 
            this.tblTreasurybondBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tblTreasurybondBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tblTreasurybondBindingNavigatorSaveItem.Image")));
            this.tblTreasurybondBindingNavigatorSaveItem.Name = "tblTreasurybondBindingNavigatorSaveItem";
            this.tblTreasurybondBindingNavigatorSaveItem.Size = new System.Drawing.Size(28, 30);
            this.tblTreasurybondBindingNavigatorSaveItem.Text = "Save Data";
            this.tblTreasurybondBindingNavigatorSaveItem.Click += new System.EventHandler(this.tblTreasurybondBindingNavigatorSaveItem_Click);
            // 
            // tslSearch
            // 
            this.tslSearch.Name = "tslSearch";
            this.tslSearch.Size = new System.Drawing.Size(64, 30);
            this.tslSearch.Text = "Search";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // txtSearch
            // 
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(300, 33);
            this.txtSearch.Text = "Search";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 33);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(28, 30);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // treasuryBond_IDTextBox
            // 
            this.treasuryBond_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblTreasurybondBindingSource, "TreasuryBond_ID", true));
            this.treasuryBond_IDTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treasuryBond_IDTextBox.Location = new System.Drawing.Point(292, 81);
            this.treasuryBond_IDTextBox.Name = "treasuryBond_IDTextBox";
            this.treasuryBond_IDTextBox.Size = new System.Drawing.Size(371, 34);
            this.treasuryBond_IDTextBox.TabIndex = 2;
            this.treasuryBond_IDTextBox.TextChanged += new System.EventHandler(this.treasuryBond_IDTextBox_TextChanged);
            this.treasuryBond_IDTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.treasuryBond_IDTextBox_KeyPress);
            // 
            // inv_IDTextBox
            // 
            this.inv_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblTreasurybondBindingSource, "Inv_ID", true));
            this.inv_IDTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inv_IDTextBox.Location = new System.Drawing.Point(292, 147);
            this.inv_IDTextBox.Name = "inv_IDTextBox";
            this.inv_IDTextBox.Size = new System.Drawing.Size(371, 34);
            this.inv_IDTextBox.TabIndex = 4;
            this.inv_IDTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inv_IDTextBox_KeyPress);
            // 
            // treasuryBondNameTextBox
            // 
            this.treasuryBondNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblTreasurybondBindingSource, "TreasuryBondName", true));
            this.treasuryBondNameTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treasuryBondNameTextBox.Location = new System.Drawing.Point(292, 210);
            this.treasuryBondNameTextBox.Name = "treasuryBondNameTextBox";
            this.treasuryBondNameTextBox.Size = new System.Drawing.Size(371, 34);
            this.treasuryBondNameTextBox.TabIndex = 6;
            this.treasuryBondNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.treasuryBondNameTextBox_KeyPress);
            // 
            // faceValueTextBox
            // 
            this.faceValueTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblTreasurybondBindingSource, "FaceValue", true));
            this.faceValueTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.faceValueTextBox.Location = new System.Drawing.Point(863, 78);
            this.faceValueTextBox.Name = "faceValueTextBox";
            this.faceValueTextBox.Size = new System.Drawing.Size(371, 34);
            this.faceValueTextBox.TabIndex = 8;
            this.faceValueTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.faceValueTextBox_KeyPress);
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblTreasurybondBindingSource, "Price", true));
            this.priceTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTextBox.Location = new System.Drawing.Point(863, 144);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(371, 34);
            this.priceTextBox.TabIndex = 10;
            this.priceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.priceTextBox_KeyPress);
            // 
            // tradeValueTextBox
            // 
            this.tradeValueTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblTreasurybondBindingSource, "TradeValue", true));
            this.tradeValueTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tradeValueTextBox.Location = new System.Drawing.Point(863, 207);
            this.tradeValueTextBox.Name = "tradeValueTextBox";
            this.tradeValueTextBox.Size = new System.Drawing.Size(371, 34);
            this.tradeValueTextBox.TabIndex = 12;
            this.tradeValueTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tradeValueTextBox_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnPrevious);
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Location = new System.Drawing.Point(269, 271);
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
            // tblTreasurybondDataGridView
            // 
            this.tblTreasurybondDataGridView.AutoGenerateColumns = false;
            this.tblTreasurybondDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblTreasurybondDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.tblTreasurybondDataGridView.DataSource = this.tblTreasurybondBindingSource;
            this.tblTreasurybondDataGridView.Location = new System.Drawing.Point(71, 386);
            this.tblTreasurybondDataGridView.Name = "tblTreasurybondDataGridView";
            this.tblTreasurybondDataGridView.RowTemplate.Height = 28;
            this.tblTreasurybondDataGridView.Size = new System.Drawing.Size(1163, 220);
            this.tblTreasurybondDataGridView.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TreasuryBond_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "TreasuryBond_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 120;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Inv_ID";
            this.dataGridViewTextBoxColumn2.HeaderText = "Inv_ID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TreasuryBondName";
            this.dataGridViewTextBoxColumn3.HeaderText = "TreasuryBondName";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 180;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "FaceValue";
            this.dataGridViewTextBoxColumn4.HeaderText = "FaceValue";
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
            this.dataGridViewTextBoxColumn6.DataPropertyName = "TradeValue";
            this.dataGridViewTextBoxColumn6.HeaderText = "TradeValue";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 120;
            // 
            // TreasuryBond
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 732);
            this.Controls.Add(this.tblTreasurybondDataGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(treasuryBond_IDLabel);
            this.Controls.Add(this.treasuryBond_IDTextBox);
            this.Controls.Add(inv_IDLabel);
            this.Controls.Add(this.inv_IDTextBox);
            this.Controls.Add(treasuryBondNameLabel);
            this.Controls.Add(this.treasuryBondNameTextBox);
            this.Controls.Add(faceValueLabel);
            this.Controls.Add(this.faceValueTextBox);
            this.Controls.Add(priceLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(tradeValueLabel);
            this.Controls.Add(this.tradeValueTextBox);
            this.Controls.Add(this.tblTreasurybondBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "TreasuryBond";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TreasuryBond";
            this.Load += new System.EventHandler(this.TreasuryBond_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trade_Management_SystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTreasurybondBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTreasurybondBindingNavigator)).EndInit();
            this.tblTreasurybondBindingNavigator.ResumeLayout(false);
            this.tblTreasurybondBindingNavigator.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblTreasurybondDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Trade_Management_SystemDataSet trade_Management_SystemDataSet;
        private System.Windows.Forms.BindingSource tblTreasurybondBindingSource;
        private Trade_Management_SystemDataSetTableAdapters.tblTreasurybondTableAdapter tblTreasurybondTableAdapter;
        private Trade_Management_SystemDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tblTreasurybondBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tblTreasurybondBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox treasuryBond_IDTextBox;
        private System.Windows.Forms.TextBox inv_IDTextBox;
        private System.Windows.Forms.TextBox treasuryBondNameTextBox;
        private System.Windows.Forms.TextBox faceValueTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox tradeValueTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView tblTreasurybondDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.ToolStripLabel tslSearch;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripTextBox txtSearch;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}