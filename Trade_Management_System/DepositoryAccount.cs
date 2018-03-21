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
    public partial class DepositoryAccount : Form
    {
        public DepositoryAccount()
        {
            InitializeComponent();
        }

        private void tblDepositoryAccountBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblDepositoryAccountBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.trade_Management_SystemDataSet);

        }

        private void DepositoryAccount_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'trade_Management_SystemDataSet.tblDepositoryAccount' table. You can move, or remove it, as needed.
            this.tblDepositoryAccountTableAdapter.Fill(this.trade_Management_SystemDataSet.tblDepositoryAccount);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.tblDepositoryAccountBindingSource.AddNew();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblDepositoryAccountBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.trade_Management_SystemDataSet);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.tblDepositoryAccountBindingSource.MoveNext();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            this.tblDepositoryAccountBindingSource.MovePrevious();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.tblDepositoryAccountBindingSource.RemoveCurrent();
        }

        private void dep_IDTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tBond_IDTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void purchasesTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void withdrawalTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void holdingTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void stock_IDTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
