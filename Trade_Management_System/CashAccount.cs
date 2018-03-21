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
    public partial class CashAccount : Form
    {
        public CashAccount()
        {
            InitializeComponent();
        }

        private void tblCashAccountBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblCashAccountBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.trade_Management_SystemDataSet);

        }

        private void CashAccount_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'trade_Management_SystemDataSet.tblCashAccount' table. You can move, or remove it, as needed.
            this.tblCashAccountTableAdapter.Fill(this.trade_Management_SystemDataSet.tblCashAccount);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.tblCashAccountBindingSource.AddNew();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblCashAccountBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.trade_Management_SystemDataSet);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.tblCashAccountBindingSource.MoveNext();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            this.tblCashAccountBindingSource.MovePrevious();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.tblCashAccountBindingSource.RemoveCurrent();
        }

        private void cash_IDTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dep_IDTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cashDepositsTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cashWithdrawalTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
