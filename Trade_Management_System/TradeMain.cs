using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trade_Management_System
{
    public partial class TradeMain : Form
    {
        
        public TradeMain()
        {
            InitializeComponent();
        }

        private void TradeMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void investorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Investor inv = new Investor();
            inv.MdiParent = this;
            inv.Show();
        }

        private void treasuryBondToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreasuryBond treasury = new TreasuryBond();
            treasury.MdiParent = this;
            treasury.Show();
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stock stock = new Stock();
            stock.MdiParent = this;
            stock.Show();
        }

        private void depositoryAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DepositoryAccount depository = new DepositoryAccount();
            depository.MdiParent = this;
            depository.Show();
        }

        private void cashAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CashAccount cash = new CashAccount();
            cash.MdiParent = this;
            cash.Show();
        }
    }
}
