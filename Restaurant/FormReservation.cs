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
    public partial class FormReservation : Form
    {
        public FormReservation()
        {
            InitializeComponent();
        }

        private void lvCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnTurnBack_Click(object sender, EventArgs e)
        {
            FormMenu frm = new FormMenu();
            this.Close();
            frm.Show();
        }

        private void FormReservation_Load(object sender, EventArgs e)
        {
            cCustomers cm = new cCustomers();
            cm.listCustomer(lvCustomer);

            cTables tbl = new cTables();
            tbl.TableCapacityandStatus(cbTable);

            dtTime.MinDate=DateTime.Today;
            dtTime.Format = DateTimePickerFormat.Time;
        }

        private void tbCustomer_TextChanged(object sender, EventArgs e)
        {
            cCustomers cc = new cCustomers();
        }

        private void btnOpenReservation_Click(object sender, EventArgs e)
        {
            cReservation cr = new cReservation();

            if(lvCustomer.SelectedItems.Count > 0) 
            {
                bool result = cr.ReservationControl(Convert.ToInt32(lvCustomer.SelectedItems[0].SubItems[0].Text));
                if(result)
                {
                    if(tbDate.Text!="")
                    {
                        if(tbNomberPerson.Text!="")
                        {
                            cTables tbl = new cTables();
                            if(tbl.TableGetbyState(Convert.ToInt32(tbTableNo.Text), 1))
                            {
                                cBill bll = new cBill();
                                bll.Time=Convert.ToDateTime(tbDate.Text);
                                bll.ID=Convert.ToInt32(tbTableNo.Text);
                                bll.EmployeeID = cGeneral._employeeId;

                                cr.ClientID=Convert.ToInt32(Convert.ToInt32(lvCustomer.SelectedItems[0].SubItems[0].Text));
                                cr.TableID= Convert.ToInt32(tbTableNo.Text);
                                cr.Time= bll.Time = Convert.ToDateTime(tbDate.Text);
                                cr.ClientCount=Convert.ToInt32(tbNomberPerson.Text);

                                cGeneral._tableID = Convert.ToInt32(tbTableNo.Text);

                                cr.BillID = bll.ReservationBillOpen(bll);
                                result = cr.ReservationOpen(cr);

                                tbl.setChangeTableState(tbTableNo.Text, 3);

                                if(result)
                                {
                                    MessageBox.Show("Reservation is open");
                                }
                                else
                                {
                                    MessageBox.Show("Reservation could not be opened");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Reserved table full");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Select number of people!!!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Select date !!!");
                    }
                }
                else
                {
                    MessageBox.Show("The customer already has a reservation");
                }
            }
        }

        private void cbTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbNumberPerson.Enabled = true;
            tbtable.Text=cbTable.SelectedItem.ToString();

            cTables capac = (cTables)cbTable.SelectedItem;
            int capacity = capac.Capacity;
            tbTableNo.Text=Convert.ToString(capac.ID);

            cbNumberPerson.Items.Clear();
            for (int i = 0; i < capacity; i++)
            {
                cbNumberPerson.Items.Add(i + 1);
            }
        }

        private void dtTime_MouseEnter(object sender, EventArgs e)
        {
            dtTime.Width = 140;
        }

        private void dtTime_Enter(object sender, EventArgs e)
        {
            dtTime.Width = 140;
        }

        private void dtTime_MouseLeave(object sender, EventArgs e)
        {
            dtTime.Width = 23;
        }

        private void dtTime_ValueChanged(object sender, EventArgs e)
        {
            tbDate.Text = dtTime.Value.ToString();
        }

        private void cbNumberPerson_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbNomberPerson.Text=cbNumberPerson.SelectedItem.ToString();
        }

        private void cbTable_MouseEnter(object sender, EventArgs e)
        {
            cbTable.Width= 140;
        }

        private void cbTable_MouseLeave(object sender, EventArgs e)
        {
            cbTable.Width= 23;
        }

        private void cbNumberPerson_MouseLeave(object sender, EventArgs e)
        {
            cbNumberPerson.Width= 23;
        }

        private void cbNumberPerson_MouseEnter(object sender, EventArgs e)
        {
            cbNumberPerson.Width= 80;
        }

        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            FormNewCustomer frm = new FormNewCustomer();
            cGeneral._addCustomer = 0;
            this.Close();
            frm.Show();
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            if(lvCustomer.SelectedItems.Count > 0)
            {
                FormNewCustomer frm = new FormNewCustomer();
                cGeneral._addCustomer = 0;
                cGeneral._customerID = Convert.ToInt32(lvCustomer.SelectedItems[0].SubItems[0].Text);
                this.Close();
                frm.Show();
            }
        }

        private void btnReservations_Click(object sender, EventArgs e)
        {

        }
    }
}
