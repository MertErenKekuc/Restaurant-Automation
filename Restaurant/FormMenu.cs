using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void btnTableOrder_Click(object sender, EventArgs e)
        {
            FormTables frm = new FormTables();
            this.Close();
            frm.Show();
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            FormReservation frm = new FormReservation();
            this.Close();
            frm.Show();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            FormCustomers frm = new FormCustomers();
            this.Close();
            frm.Show();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            FormCheckout frm = new FormCheckout();
            this.Close();
            frm.Show();
        }

        private void btnKitchen_Click(object sender, EventArgs e)
        {
            FormKitchen frm = new FormKitchen();
            this.Close();
            frm.Show();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Warning!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            FormOptions frm = new FormOptions();
            this.Close();
            frm.Show();
        }
    }
}
