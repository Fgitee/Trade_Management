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
    public partial class Investor : Form
    {
        public Investor()
        {
            InitializeComponent();
        }

        private void tblInvestorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblInvestorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.trade_Management_SystemDataSet);

        }

        private void Investor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'trade_Management_SystemDataSet.tblInvestor' table. You can move, or remove it, as needed.
            this.tblInvestorTableAdapter.Fill(this.trade_Management_SystemDataSet.tblInvestor);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.tblInvestorBindingSource.RemoveCurrent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblInvestorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.trade_Management_SystemDataSet);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.tblInvestorBindingSource.MoveNext();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            this.tblInvestorBindingSource.MovePrevious();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.tblInvestorBindingSource.AddNew();
        }

        private void investor_IDTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void accountNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void firstnameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void surnameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tradeTypeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void statusTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
