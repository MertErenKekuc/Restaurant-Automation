using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class FormOptions : Form
    {
        public FormOptions()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTurnBack_Click(object sender, EventArgs e)
        {
            FormMenu frm = new FormMenu();
            this.Close();
            frm.Show();
        }

        private void FormOptions_Load(object sender, EventArgs e)
        {
            cEmployees employee = new cEmployees();
            cEmployeeMission emis = new cEmployeeMission();
            string mission = emis.EmployeeMission(cGeneral._missionId);

            if (mission == "Manager")
            {
                employee.EmployeeGetbyInformation(cbEmployee);
                emis.getEmployeeMission(cbMission);
                employee.EmployeeGetbyInformationLV(lvInfo);



                tbPassword2.ReadOnly = false;
                tbPasswordAgain2.ReadOnly = false;

                lbInfo.Text = "Mission : Manager / Authority : Unlimited / User :" + employee.OnlyOneEmployeeInfo(cGeneral._employeeId);

            }
            else
            {
                employee.EmployeeGetbyInformation(cbEmployee);

                groupBox1.Visible = false;
                lvInfo.Visible = false;
                lbInfo.Text = "Mission : Employee / Authority : limited / User :" + employee.OnlyOneEmployeeInfo(cGeneral._employeeId);
            }

        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (tbNewPassword1.Text.Trim() != "" || tbNewPasswordAgain.Text.Trim() != "")
            {
                if (tbNewPassword1.Text == tbNewPasswordAgain.Text)
                {
                    if (tbUserID.Text != "")
                    {
                        cEmployees c = new cEmployees();
                        bool result = c.EmployeeChangePassword(Convert.ToInt32(tbUserID.Text), tbNewPassword1.Text);
                        if (result)
                        {
                            MessageBox.Show("Password changed");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Select Employee!!!");
                    }
                }
                else
                {
                    MessageBox.Show("Passwords are not the same!!!");
                }
            }
            else
            {
                MessageBox.Show("Do not leave the password field blank!!!");
            }
        }

        private void cbMission_SelectedIndexChanged(object sender, EventArgs e)
        {
            cEmployeeMission c = (cEmployeeMission)cbMission.SelectedItem;
            tbEmployeeID.Text = Convert.ToString(c.EmployeeMissionID);
        }

        private void cbEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            cEmployees c = (cEmployees)cbEmployee.SelectedItem;
            tbUserID.Text = Convert.ToString(c.ID);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {

            tbPassword2.ReadOnly = true;
            tbPasswordAgain2.ReadOnly = true;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure delete?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (lvInfo.SelectedItems.Count > 0)
                {
                    cEmployees c = new cEmployees();
                    bool result = c.EmployeeDelete(Convert.ToInt32(lvInfo.SelectedItems[0].Text));
                    if (result)
                    {
                        MessageBox.Show("Employee record deleted");
                        c.EmployeeGetbyInformationLV(lvInfo);
                    }
                    else
                    {
                        MessageBox.Show("An error occurred while deleting the record.");
                    }
                }
                else
                {
                    MessageBox.Show("Select record");
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //tbMission.Text = Convert.ToString(cGeneral._missionId);
            if (tbName.Text.Trim() != "" || tbSurname.Text.Trim() != "" || tbPassword2.Text.Trim() != "" || tbPasswordAgain2.Text.Trim() != "" || tbMission.Text.Trim() != "")
            {
                if ((tbPasswordAgain2.Text.Trim() == tbPassword2.Text.Trim()) && (tbPassword2.Text.Length > 5 || tbPasswordAgain2.Text.Length > 5))
                {
                    cEmployees c = new cEmployees();
                    c.EmployeeName = tbName.Text.Trim();
                    c.EmployeeSurname = tbSurname.Text.Trim();
                    c.EmployeePassword = tbNewPasswordAgain.Text;
                    cGeneral._missionId = Convert.ToInt32(tbMission.Text);
                    c.EmployeeMissionID = cGeneral._missionId;

                    bool reuslt = c.EmployeeAdd(c);

                    if (reuslt)
                    {
                        MessageBox.Show("Record successfully added");
                    }
                    else
                    {
                        MessageBox.Show("An error occurred while adding the record.");
                    }
                }
                else
                {
                    MessageBox.Show("Passwords are not the same!!!");
                }
            }
            else
            {
                MessageBox.Show("Do not leave blank space!!!");
            }
        }

        private void btnChange2_Click(object sender, EventArgs e)
        {
            if (lvInfo.SelectedItems.Count > 0)
            {

                if (tbName.Text != "" || tbSurname.Text != "" || tbPassword2.Text != "" || tbPasswordAgain2.Text != "")
                {
                    if ((tbPasswordAgain2.Text.Trim() == tbPassword2.Text.Trim()) && (tbPassword2.Text.Length > 5 || tbPasswordAgain2.Text.Length > 5))
                    {
                        cEmployees c = new cEmployees();
                        c.EmployeeName = tbName.Text.Trim();
                        c.EmployeeSurname = tbSurname.Text.Trim();
                        c.EmployeePassword = tbPassword2.Text;
                        cGeneral._missionId = Convert.ToInt32(tbMission.Text);
                        c.EmployeeMissionID = cGeneral._missionId;
                        //c.EmployeeMissionID= Convert.ToInt32(tbMission.Text);
                        bool result = c.EmployeeUpdate(c, Convert.ToInt32(tbEmployeeID.Text));

                        if (result)
                        {
                            MessageBox.Show("Record successfully updated");
                            c.EmployeeGetbyInformationFromIDLV(lvInfo, Convert.ToInt32(tbEmployeeID.Text));
                        }
                        else
                        {
                            MessageBox.Show("An error occurred while changed the record.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Passwords are not the same!!!");
                    }
                }
                else
                {
                    MessageBox.Show("Do not leave blank space!!!");
                }
            }
            else
            {
                MessageBox.Show("Select record");
            }
        }

        private void lvInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvInfo.SelectedItems.Count > 0)
            {
                tbEmployeeID.Text = lvInfo.SelectedItems[0].SubItems[0].Text;
                cbMission.SelectedIndex = Convert.ToInt32(lvInfo.SelectedItems[0].SubItems[1].Text) -1;
                tbName.Text = lvInfo.SelectedItems[0].SubItems[3].Text;
                tbSurname.Text = lvInfo.SelectedItems[0].SubItems[4].Text;
            }

        }

        private void tbMission_TextChanged(object sender, EventArgs e)
        {
 
        }
    }
}
