using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class FormTables : Form
    {
        public FormTables()
        {
            InitializeComponent();
        }

        private void btnTurnBack_Click(object sender, EventArgs e)
        {
            FormMenu frm = new FormMenu();
            this.Close();
            frm.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        cGeneral gnrl = new cGeneral();
        private void FormTables_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(gnrl.connection);
            SqlCommand cmd = new SqlCommand("Select Status,ID from Tables", con);
            SqlDataReader dr = null;

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            dr = cmd.ExecuteReader();


            while (dr.Read())
            {
                foreach (Control item in this.Controls)
                {
                    if (item is Button)
                    {
                        if (item.Name == "btnTable" + dr["ID"].ToString() && dr["Status"].ToString() == "1")
                        {
                            item.BackgroundImage = (System.Drawing.Image)(Properties.Resources.table_green);
                        }
                        else if (item.Name == "btnTable" + dr["ID"].ToString() && dr["Status"].ToString() == "2")
                        {
                            //cTables tbl = new cTables();

                            //DateTime dt1 = DateTime.Parse(tbl.SessionSum(2),dr["ID"].ToString());
                            //DateTime dt2 = DateTime.Now;
                            //string st1 = Convert.ToDateTime(tbl.SessionSum(2),dr["ID"].ToString()).ToShortTimeString();
                            //string st2 = DateTime.Now.ToShortTimeString();

                            //DateTime t1 = dt1.AddMinutes(DateTime.Parse(st1).TimeOfDay.TotalMinutes);
                            //DateTime t2 = dt2.AddMinutes(DateTime.Parse(st2).TimeOfDay.TotalMinutes);

                            //var difference = t2 - t1;

                            //item.Text = String.Format("{0}{1}{2}",
                                //difference.Days > 0 ? string.Format("{0} day", difference.Days) : "",
                                //difference.Hours > 0 ? string.Format("{1} hour", difference.Hours) : "",
                                //difference.Minutes > 0 ? string.Format("{2} minute", difference.Minutes) : "").Trim() + "\n\n\nTable" + dr["ID"].ToString();

                            item.BackgroundImage = (System.Drawing.Image)(Properties.Resources.table_red);
                        }
                        else if (item.Name == "btnTable" + dr["ID"].ToString() && dr["Status"].ToString() == "3")
                        {
                            item.BackgroundImage = (System.Drawing.Image)(Properties.Resources.table_blue);
                        }
                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnTable1_Click(object sender, EventArgs e)
        {
            FormOrders frm = new FormOrders();
            int length = btnTable1.Text.Length;
            cGeneral._buttonValue = btnTable1.Text.Substring(length - 6, 6);
            cGeneral._buttonName = btnTable1.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void btnTable2_Click(object sender, EventArgs e)
        {
            FormOrders frm = new FormOrders();
            int length = btnTable2.Text.Length;
            cGeneral._buttonValue = btnTable2.Text.Substring(length - 6, 6);
            cGeneral._buttonName = btnTable2.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void btnTable3_Click(object sender, EventArgs e)
        {
            FormOrders frm = new FormOrders();
            int length = btnTable3.Text.Length;
            cGeneral._buttonValue = btnTable3.Text.Substring(length - 6, 6);
            cGeneral._buttonName = btnTable3.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void btnTable4_Click(object sender, EventArgs e)
        {
            FormOrders frm = new FormOrders();
            int length = btnTable4.Text.Length;
            cGeneral._buttonValue = btnTable4.Text.Substring(length - 6, 6);
            cGeneral._buttonName = btnTable4.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void btnTable5_Click(object sender, EventArgs e)
        {
            FormOrders frm = new FormOrders();
            int length = btnTable5.Text.Length;
            cGeneral._buttonValue = btnTable5.Text.Substring(length - 6, 6);
            cGeneral._buttonName = btnTable5.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void btnTable6_Click(object sender, EventArgs e)
        {
            FormOrders frm = new FormOrders();
            int length = btnTable6.Text.Length;
            cGeneral._buttonValue = btnTable6.Text.Substring(length - 6, 6);
            cGeneral._buttonName = btnTable6.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void btnTable7_Click(object sender, EventArgs e)
        {
            FormOrders frm = new FormOrders();
            int length = btnTable7.Text.Length;
            cGeneral._buttonValue = btnTable7.Text.Substring(length - 6, 6);
            cGeneral._buttonName = btnTable7.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void btnTable8_Click(object sender, EventArgs e)
        {
            FormOrders frm = new FormOrders();
            int length = btnTable8.Text.Length;
            cGeneral._buttonValue = btnTable8.Text.Substring(length - 6, 6);
            cGeneral._buttonName = btnTable8.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void btnTable9_Click(object sender, EventArgs e)
        {
            FormOrders frm = new FormOrders();
            int length = btnTable9.Text.Length;
            cGeneral._buttonValue = btnTable9.Text.Substring(length - 6, 6);
            cGeneral._buttonName = btnTable9.Name;
            this.Close();
            frm.ShowDialog();
        }
    }
}
