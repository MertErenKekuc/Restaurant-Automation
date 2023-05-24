using System;
using System.Collections;
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
    public partial class FormOrders : Form
    {
        public FormOrders()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }


        private void btnFastFoods_Click(object sender, EventArgs e)
        {
            cProductsCategory pc = new cProductsCategory();
            pc.getbyProductType(lvMenu, btnFastFoods2);
        }


        private void btnMainFoods_Click(object sender, EventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnTurnBack_Click(object sender, EventArgs e)
        {
            FormMenu frm = new FormMenu();
            this.Close();
            frm.Show();
        }

        private void btnPayement_Click(object sender, EventArgs e)
        {
            cTables tbl = new cTables();
            int tableID = tbl.TableGetbyNumber(cGeneral._buttonName);
            cBill bll = new cBill();
            int additionID = bll.getbyAddition(tableID);
            cGeneral._billID = additionID.ToString();
            FormBill frm = new FormBill();
            cReservation cr = new cReservation();
            cr.ReservationClose(additionID);
            this.Close();
            frm.Show();
        }

        void Operation(Object Sender, EventArgs e)
        {
            Button btn = Sender as Button;


            switch (btn.Name)
            {
                case "btn1":
                    tbPiece.Text += (1).ToString();
                    break;
                case "btn2":
                    tbPiece.Text += (2).ToString();
                    break;
                case "btn3":
                    tbPiece.Text += (3).ToString();
                    break;
                case "btn4":
                    tbPiece.Text += (4).ToString();
                    break;
                case "btn5":
                    tbPiece.Text += (5).ToString();
                    break;
                case "btn6":
                    tbPiece.Text += (6).ToString();
                    break;
                case "btn7":
                    tbPiece.Text += (7).ToString();
                    break;
                case "btn8":
                    tbPiece.Text += (8).ToString();
                    break;
                case "btn9":
                    tbPiece.Text += (9).ToString();
                    break;
                case "btn0":
                    tbPiece.Text += (0).ToString();
                    break;

                default:
                    MessageBox.Show("Enter number");
                    break;
            }

        }
        private void FormOrders_Load(object sender, EventArgs e)
        {
            cTables tbl = new cTables();

            int tableID = tbl.TableGetbyNumber(cGeneral._buttonName);

            if (tbl.TableGetbyState(tableID, 2) == true || tbl.TableGetbyState(tableID, 3) == true)
            {
                cBill bll = new cBill();
                int additionID = bll.getbyAddition(tableID);
                cSales orders = new cSales();
                orders.getByOrder(lvOrders, additionID);
            }

            btn1.Click += new EventHandler(Operation);
            btn2.Click += new EventHandler(Operation);
            btn3.Click += new EventHandler(Operation);
            btn4.Click += new EventHandler(Operation);
            btn5.Click += new EventHandler(Operation);
            btn6.Click += new EventHandler(Operation);
            btn7.Click += new EventHandler(Operation);
            btn8.Click += new EventHandler(Operation);
            btn9.Click += new EventHandler(Operation);
            btn0.Click += new EventHandler(Operation);
        }

        private void btn8_Click(object sender, EventArgs e)
        {

        }

        private void btnMainFoods1_Click(object sender, EventArgs e)
        {
            cProductsCategory pc = new cProductsCategory();
            pc.getbyProductType(lvMenu, btnMainFoods1);
        }

        private void btnSnack6_Click(object sender, EventArgs e)
        {
            cProductsCategory pc = new cProductsCategory();
            pc.getbyProductType(lvMenu, btnSnack6);
        }

        private void btnDesserts5_Click(object sender, EventArgs e)
        {
            cProductsCategory pc = new cProductsCategory();
            pc.getbyProductType(lvMenu, btnDesserts5);
        }

        private void btnSalads4_Click(object sender, EventArgs e)
        {
            cProductsCategory pc = new cProductsCategory();
            pc.getbyProductType(lvMenu, btnSalads4);
        }

        private void btnDrink3_Click(object sender, EventArgs e)
        {
            cProductsCategory pc = new cProductsCategory();
            pc.getbyProductType(lvMenu, btnDrink3);
        }

        int counter1 = 0;
        int counter2 = 0;

        private void lvMenu_DoubleClick(object sender, EventArgs e)
        {
            cTables tbl = new cTables();
            cBill bll = new cBill();
            int tableID = tbl.TableGetbyNumber(cGeneral._buttonName);
            int additionID = bll.getbyAddition(tableID);


            if (tbPiece.Text == "")
            {
                tbPiece.Text = "1";
            }
            if (lvMenu.Items.Count > 0)
            {
                counter1 = lvOrders.Items.Count;
                lvOrders.Items.Add(lvMenu.SelectedItems[0].Text);
                lvOrders.Items[counter1].SubItems.Add(tbPiece.Text);
                lvOrders.Items[counter1].SubItems.Add(lvMenu.SelectedItems[0].SubItems[2].Text);
                lvOrders.Items[counter1].SubItems.Add((Convert.ToDecimal(lvMenu.SelectedItems[0].SubItems[1].Text) * Convert.ToDecimal(tbPiece.Text)).ToString());
                lvOrders.Items[counter1].SubItems.Add("0");
                counter2 = lvNewAdd.Items.Count;
                lvOrders.Items[counter1].SubItems.Add(counter2.ToString());

                lvNewAdd.Items.Add(additionID.ToString());
                lvNewAdd.Items[counter2].SubItems.Add(lvMenu.SelectedItems[0].SubItems[2].Text);
                lvNewAdd.Items[counter2].SubItems.Add(tbPiece.Text);
                lvNewAdd.Items[counter2].SubItems.Add(tableID.ToString());
                lvNewAdd.Items[counter2].SubItems.Add(counter2.ToString());

                counter2++;
                tbPiece.Text = "";

            }
        }

        ArrayList deleted = new ArrayList();
        private void btnOrder_Click(object sender, EventArgs e)
        {
            //1=Empty
            //2=Full
            //3=Reserved

            cEmployees emp = new cEmployees();
            cTables tbl = new cTables();
            cBill bll = new cBill();
            cSales sl = new cSales();
            FormTables frm = new FormTables();
            bool result = false;
            int tableID = tbl.TableGetbyNumber(cGeneral._buttonName);

            if (tbl.TableGetbyState(tableID, 1) == true)
            {
                bll.EmployeeID = cGeneral._employeeId;
                bll.TableID = tableID;
                bll.Time = DateTime.Now;
                result = bll.setbyAdditionNew(bll);
                tbl.setChangeTableState(cGeneral._buttonName, 2);

                if (lvOrders.Items.Count > 0)
                {
                    for (int i = 0; i < lvOrders.Items.Count; i++)
                    {
                        sl.TableID = tableID;
                        sl.ProductID = Convert.ToInt32(lvOrders.Items[i].SubItems[2].Text);
                        sl.BillD = bll.getbyAddition(tableID);
                        sl.Piece = Convert.ToInt32(lvOrders.Items[i].SubItems[1].Text);
                        sl.setSaveOrder(sl);
                    }
                    this.Close();
                    frm.Show();
                }

            }
            else if (tbl.TableGetbyState(tableID, 2) == true)
            {
                if (lvNewAdd.Items.Count > 0)
                {
                    for (int i = 0; i < lvNewAdd.Items.Count; i++)
                    {
                        sl.TableID = tableID;
                        sl.ProductID = Convert.ToInt32(lvNewAdd.Items[i].SubItems[1].Text);
                        sl.BillD = bll.getbyAddition(tableID);
                        sl.Piece = Convert.ToInt32(lvOrders.Items[i].SubItems[2].Text);
                        sl.setSaveOrder(sl);
                    }
                    cGeneral._billID = Convert.ToString(bll.getbyAddition(tableID));
                }
                if (deleted.Count > 0)
                {
                    foreach (string item in deleted)
                    {
                        sl.setDeleteOrder(Convert.ToInt32(item));
                    }
                }
            }
            else if ((tbl.TableGetbyState(tableID, 3) == true))
            {
                //bll.EmployeeID = 1;
                //bll.TableID = tableID;
                //bll.Time = DateTime.Now;
                //result = bll.setbyAdditionNew(bll);
                tbl.setChangeTableState(cGeneral._buttonName, 2);

                if (lvOrders.Items.Count > 0)
                {
                    for (int i = 0; i < lvOrders.Items.Count; i++)
                    {
                        sl.TableID = tableID;
                        sl.ProductID = Convert.ToInt32(lvOrders.Items[i].SubItems[2].Text);
                        sl.BillD = bll.getbyAddition(tableID);
                        sl.Piece = Convert.ToInt32(lvOrders.Items[i].SubItems[1].Text);
                        sl.setSaveOrder(sl);
                    }
                    this.Close();
                    frm.Show();
                }
            }
        }

        private void lvOrders_Click(object sender, EventArgs e)
        {
            if (lvOrders.SelectedItems[0].SubItems[4].Text != "0")
            {
                cSales sl = new cSales();
                sl.setDeleteOrder(Convert.ToInt32(lvOrders.SelectedItems[0].SubItems[4].Text));

            }
            else
            {
                for (int i = 0; i < lvNewAdd.Items.Count; i++)
                {
                    if (lvNewAdd.Items[i].SubItems[4].Text == lvOrders.SelectedItems[0].SubItems[5].Text)
                    {
                        lvNewAdd.Items.RemoveAt(i);
                    }
                }
            }
            lvOrders.Items.RemoveAt(lvOrders.SelectedItems[0].Index);
        }

        private void lvMenu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lvNewAdd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}
