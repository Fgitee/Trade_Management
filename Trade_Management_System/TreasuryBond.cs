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
    public partial class TreasuryBond : Form
    {
        public TreasuryBond()
        {
            InitializeComponent();
        }

        private void tblTreasurybondBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblTreasurybondBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.trade_Management_SystemDataSet);

        }

        private void TreasuryBond_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'trade_Management_SystemDataSet.tblTreasurybond' table. You can move, or remove it, as needed.
            this.tblTreasurybondTableAdapter.Fill(this.trade_Management_SystemDataSet.tblTreasurybond);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.tblTreasurybondBindingSource.AddNew();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            this.Validate();
            this.tblTreasurybondBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.trade_Management_SystemDataSet);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.tblTreasurybondBindingSource.MoveNext();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            this.tblTreasurybondBindingSource.MovePrevious();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.tblTreasurybondBindingSource.RemoveCurrent();
        }

        private void treasuryBond_IDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void treasuryBond_IDTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void inv_IDTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void treasuryBondNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void faceValueTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void priceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tradeValueTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
