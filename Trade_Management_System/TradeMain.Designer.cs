namespace Trade_Management_System
{
    partial class TradeMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TradeMain));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.investorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tradeTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treasuryBondToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depositoryAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cashAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.investorToolStripMenuItem,
            this.tradeTypeToolStripMenuItem,
            this.depositoryAccountToolStripMenuItem,
            this.cashAccountToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip.Size = new System.Drawing.Size(948, 42);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // investorToolStripMenuItem
            // 
            this.investorToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.investorToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("investorToolStripMenuItem.Image")));
            this.investorToolStripMenuItem.Name = "investorToolStripMenuItem";
            this.investorToolStripMenuItem.Size = new System.Drawing.Size(136, 36);
            this.investorToolStripMenuItem.Text = "Investor";
            this.investorToolStripMenuItem.Click += new System.EventHandler(this.investorToolStripMenuItem_Click);
            // 
            // tradeTypeToolStripMenuItem
            // 
            this.tradeTypeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.treasuryBondToolStripMenuItem,
            this.stockToolStripMenuItem});
            this.tradeTypeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tradeTypeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("tradeTypeToolStripMenuItem.Image")));
            this.tradeTypeToolStripMenuItem.Name = "tradeTypeToolStripMenuItem";
            this.tradeTypeToolStripMenuItem.Size = new System.Drawing.Size(170, 36);
            this.tradeTypeToolStripMenuItem.Text = "Trade Type";
            // 
            // treasuryBondToolStripMenuItem
            // 
            this.treasuryBondToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("treasuryBondToolStripMenuItem.Image")));
            this.treasuryBondToolStripMenuItem.Name = "treasuryBondToolStripMenuItem";
            this.treasuryBondToolStripMenuItem.Size = new System.Drawing.Size(255, 36);
            this.treasuryBondToolStripMenuItem.Text = "Treasury Bond";
            this.treasuryBondToolStripMenuItem.Click += new System.EventHandler(this.treasuryBondToolStripMenuItem_Click);
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("stockToolStripMenuItem.Image")));
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(255, 36);
            this.stockToolStripMenuItem.Text = "Stock";
            this.stockToolStripMenuItem.Click += new System.EventHandler(this.stockToolStripMenuItem_Click);
            // 
            // depositoryAccountToolStripMenuItem
            // 
            this.depositoryAccountToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositoryAccountToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("depositoryAccountToolStripMenuItem.Image")));
            this.depositoryAccountToolStripMenuItem.Name = "depositoryAccountToolStripMenuItem";
            this.depositoryAccountToolStripMenuItem.Size = new System.Drawing.Size(261, 36);
            this.depositoryAccountToolStripMenuItem.Text = "Depository Account";
            this.depositoryAccountToolStripMenuItem.Click += new System.EventHandler(this.depositoryAccountToolStripMenuItem_Click);
            // 
            // cashAccountToolStripMenuItem
            // 
            this.cashAccountToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashAccountToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cashAccountToolStripMenuItem.Image")));
            this.cashAccountToolStripMenuItem.Name = "cashAccountToolStripMenuItem";
            this.cashAccountToolStripMenuItem.Size = new System.Drawing.Size(196, 36);
            this.cashAccountToolStripMenuItem.Text = "Cash Account";
            this.cashAccountToolStripMenuItem.Click += new System.EventHandler(this.cashAccountToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 667);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip.Size = new System.Drawing.Size(948, 30);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(60, 25);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // TradeMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 697);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TradeMain";
            this.Text = "TradeMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TradeMain_FormClosing);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem investorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tradeTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem treasuryBondToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem depositoryAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cashAccountToolStripMenuItem;
    }
}



