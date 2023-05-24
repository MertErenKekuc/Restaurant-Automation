using Microsoft.Reporting.WinForms;
using Microsoft.ReportingServices.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class FormCheckout : Form
    {
        public FormCheckout()
        {
            InitializeComponent();
        }

        private void FormCheckout_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.DataTable3' table. You can move, or remove it, as needed.
            this.dataTable3TableAdapter.Fill(this.dataSet1.DataTable3);
            // TODO: This line of code loads data into the 'dataSet21.DataTable1' table. You can move, or remove it, as needed.
            this.dataTable1TableAdapter1.Fill(this.dataSet21.DataTable1);
            // TODO: This line of code loads data into the 'dataSet1.DataTable1' table. You can move, or remove it, as needed.
            this.dataTable1TableAdapter.Fill(this.dataSet1.DataTable1);
            // TODO: This line of code loads data into the 'dataSet1.DataTable2' table. You can move, or remove it, as needed.
            this.dataTable2TableAdapter.Fill(this.dataSet1.DataTable2);
            this.rpvMounth.RefreshReport();
            this.rpvDay.RefreshReport();
            rpvDay.Visible = false;
            rpvMounth.Visible = false;
        }

        private void btnMonthlyReport_Click(object sender, EventArgs e)
        {
            rpvMounth.Visible = true;
            rpvDay.Visible = false;
        }

        private void btnDailyReport_Click(object sender, EventArgs e)
        {
            rpvMounth.Visible = false;
            rpvDay.Visible = true;
        }

        private void btnTurnBack_Click(object sender, EventArgs e)
        {
            FormMenu frm = new FormMenu();
            this.Close();
            frm.Show();
        }

        private void rpvMounth_Load(object sender, EventArgs e)
        {
        }

        private void DataTable1BindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void rpvDay_Load(object sender, EventArgs e)
        {

        }
    }
}
