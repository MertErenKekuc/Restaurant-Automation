using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class FormBill : Form
    {
        public FormBill()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnTurnBack_Click(object sender, EventArgs e)
        {
            FormMenu frm = new FormMenu();
            this.Close();
            frm.Show();
        }
        cSales sl = new cSales();
        private void FormBill_Load(object sender, EventArgs e)
        {
            int PayementTypeID;
            lbBillID.Text = cGeneral._billID;
            cSales sl = new cSales();
            sl.getByOrder(lvProducts, Convert.ToInt32(lbBillID.Text));
            if (lvProducts.Items.Count > 0)
            {
                decimal total = 0;
                for (int i = 0; i < lvProducts.Items.Count; i++)
                {
                    total += Convert.ToDecimal(lvProducts.Items[i].SubItems[3].Text);
                }
                lbPay.Text = Convert.ToString(total);
                PayementTypeID = sl.PayementTypeID(Convert.ToInt32(lbBillID.Text));

                if (PayementTypeID == 1)
                {
                    rbCash.Checked = true;
                }
                else if (PayementTypeID == 2)
                {
                    rbCreditCard.Checked = true;
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cTables tbl = new cTables();
            cReservation rsr = new cReservation();
            cBill bll = new cBill();

            int tableID = tbl.TableGetbyNumber(cGeneral._buttonName);
            int customerID = 0;

            if (tbl.TableGetbyState(tableID,3)==true)
            {
                customerID= rsr.getbyClientFormReservation(tableID);
            }

            customerID = 1;
            int payementTypeID = 0;

            if (rbCreditCard.Checked == true)
            {
                payementTypeID = 2;
            }
            if (rbCash.Checked == true)
            {
                payementTypeID = 1;
            }

            cPayement pymnt = new cPayement();
            pymnt.BillID = Convert.ToInt32(lbBillID.Text);
            pymnt.PayementTypeID = payementTypeID;
            pymnt.CustomerID = customerID;
            pymnt.Total = Convert.ToDecimal(lbPay.Text);

            bool result = pymnt.billClosed(pymnt);

            if (result == true)
            {
                MessageBox.Show("Account closed.");
                tbl.setChangeTableState(Convert.ToString(tableID), 1);
                rsr.ReservationClose(Convert.ToInt32(lbBillID.Text));
                bll.BillClose(Convert.ToInt32(lbBillID.Text),0);

                this.Close();
                FormTables frm = new FormTables();
                frm.Show();
            }
            else
            {
                MessageBox.Show("An error occurred while closing the account!!!");
            }

        }
    }
}
