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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cEmployees emp = new cEmployees();
            emp.EmployeeGetbyInformation(CbUser);
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            cGeneral gnrl = new cGeneral();
            cEmployees emp = new cEmployees();
            bool result = emp.EmployeeEntryControl(TxtPassword.Text, cGeneral._employeeId);
            if (result)
            {
                cEmployeesMovement em = new cEmployeesMovement();
                em.EmployeeID = cGeneral._employeeId;
                em.Operation = "Entered";
                em.Time = DateTime.Now;
                em.EmployeesMovementSave(em);

                this.Hide();
                FormMenu menu = new FormMenu();
                menu.Show();
            }
            else
            {
                MessageBox.Show("İncorrect password","warning!!!",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
        }

        private void CbUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            cEmployees emp = (cEmployees)CbUser.SelectedItem;
            cGeneral._employeeId = emp.ID;
            cGeneral._missionId = emp.EmployeeMissionID;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Warning!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
