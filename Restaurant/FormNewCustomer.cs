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
    public partial class FormNewCustomer : Form
    {
        public FormNewCustomer()
        {
            InitializeComponent();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {

            if (tbTelephone.Text.Length > 6)
            {
                if (tbName.Text == "" || tbSurName.Text == "")
                {
                    MessageBox.Show("Please fill in your name and surname");
                }
                else
                {
                    cCustomers cstmr = new cCustomers();
                    bool result = cstmr.isthereanyCustomer(tbTelephone.Text);

                    if (!result)
                    {
                        cstmr.Name = tbName.Text;
                        cstmr.Surname = tbSurName.Text;
                        cstmr.Telephone = tbTelephone.Text;
                        tbCustomerNo.Text = cstmr.customerSave(cstmr).ToString();

                        if (tbCustomerNo.Text != "")
                        {
                            MessageBox.Show("Customer added");
                        }
                        else
                        {
                            MessageBox.Show("Could not add customer!!!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Customer already exists!!!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter a 7 digit phone number.");
            }
        }

        private void btnTurnBack_Click(object sender, EventArgs e)
        {
            FormCustomers frm = new FormCustomers();
            this.Close();
            frm.Show();
        }

        private void btnChooseCustomer_Click(object sender, EventArgs e)
        {
            if (cGeneral._addCustomer == 0)
            {
                FormReservation ffrm = new FormReservation();
                cGeneral._addCustomer = 1;
                this.Close();
                ffrm.Show();

            }
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            if (tbTelephone.Text.Length > 6)
            {
                if (tbName.Text == "" || tbSurName.Text == "")
                {
                    MessageBox.Show("Please fill in your name and surname");
                }
                else
                {
                    cCustomers cstmr = new cCustomers();

                    cstmr.Name = tbName.Text;
                    cstmr.Surname = tbSurName.Text;
                    cstmr.Telephone = tbTelephone.Text;
                    cstmr.customerUpdate(cstmr);
                    cstmr.ID = Convert.ToInt32(tbCustomerNo.Text);
                    bool result = cstmr.customerUpdate(cstmr);

                    if (result)
                    {
                        if (tbCustomerNo.Text != "")
                        {
                            MessageBox.Show("Customer info updated");
                        }
                        else
                        {
                            MessageBox.Show("Could not update customer!!!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Customer already exists!!!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter a 7 digit phone number.");
            }
        }

        private void FormNewCustomer_Load(object sender, EventArgs e)
        {
            if(cGeneral._customerID>0)
            {
                cCustomers cc=new cCustomers();
                tbCustomerNo.Text = cGeneral._customerID.ToString();
                cc.listCustomerfromID(Convert.ToInt32(tbCustomerNo.Text),tbName,tbSurName,tbTelephone);
            }
        }
    }
}

