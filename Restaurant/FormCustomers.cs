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
    public partial class FormCustomers : Form
    {
        public FormCustomers()
        {
            InitializeComponent();
        }

        private void btnTurnBack_Click(object sender, EventArgs e)
        {
            FormMenu frm = new FormMenu();
            this.Close();
            frm.Show();
        }

        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            FormNewCustomer frm = new FormNewCustomer();
            cGeneral._addCustomer = 1;
            frm.Show();
        }

        private void FormCustomers_Load(object sender, EventArgs e)
        {
            cCustomers cc = new cCustomers();
            cc.listCustomer(lvCustomers);
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            if(lvCustomers.SelectedItems.Count > 0) 
            {
                cGeneral._addCustomer = 1;
                cGeneral._customerID =Convert.ToInt32( lvCustomers.SelectedItems[0].SubItems[0].Text);

                FormNewCustomer frm = new FormNewCustomer();
                this.Close();
                frm.Show();
            }
        }
    }
}
