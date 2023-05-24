using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;


namespace Restaurant
{
    class cEmployees
    {
        cGeneral gnrl = new cGeneral();

        private int _ID;
        private int _EmployeeMissionID;
        private string _EmployeeName;
        private string _EmployeeSurname;
        private string _EmployeelUsername;
        private string _EmployeePassword;
        private bool _EmployeeStatus;

        public int ID { get => _ID; set => _ID = value; }
        public string EmployeeName { get => _EmployeeName; set => _EmployeeName = value; }
        public string EmployeeSurname { get => _EmployeeSurname; set => _EmployeeSurname = value; }
        public string EmployeelUsername { get => _EmployeelUsername; set => _EmployeelUsername = value; }
        public string EmployeePassword { get => _EmployeePassword; set => _EmployeePassword = value; }
        public bool EmployeeStatus { get => _EmployeeStatus; set => _EmployeeStatus = value; }
        public int EmployeeMissionID { get => _EmployeeMissionID; set => _EmployeeMissionID = value; }

        public bool EmployeeEntryControl(string password, int Id)
        {
            bool result = false;

            SqlConnection con = new SqlConnection(gnrl.connection);
            SqlCommand cmd = new SqlCommand("Select * from Employees where ID=@Id and Password=@Passwd", con);
            cmd.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
            cmd.Parameters.Add("@Passwd", SqlDbType.VarChar).Value = password;

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                result = Convert.ToBoolean(cmd.ExecuteScalar());
            }
            catch (SqlException ex)
            {

                string fault = ex.Message;
                throw;
            }

            return result;
        }

        public void EmployeeGetbyInformation(ComboBox cb)
        {
            cb.Items.Clear();
            SqlConnection con = new SqlConnection(gnrl.connection);
            SqlCommand cmd = new SqlCommand("Select * from Employees where Status=0", con);

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                cEmployees emp = new cEmployees();
                emp.ID = Convert.ToInt32(dr["ID"]);
                emp.EmployeeMissionID = Convert.ToInt32(dr["MissionID"]);
                emp.EmployeelUsername = Convert.ToString(dr["UserName"]);
                emp.EmployeePassword = Convert.ToString(dr["Password"]);
                emp.EmployeeName = Convert.ToString(dr["Name"]);
                emp.EmployeeSurname = Convert.ToString(dr["Surname"]);
                emp.EmployeeStatus = Convert.ToBoolean(dr["Status"]);

                cb.Items.Add(emp);
            }
            dr.Close();
            con.Close();

        }
        public override string ToString()
        {
            return EmployeeName + " " + EmployeeSurname;
        }

        public void EmployeeGetbyInformationLV(ListView lv)
        {
            lv.Items.Clear();
            SqlConnection con = new SqlConnection(gnrl.connection);
            SqlCommand cmd = new SqlCommand("Select Employees.*,Missions.Mission from Employees Inner Join Missions on Missions.ID=Employees.MissionID where Employees.Status=0", con);

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlDataReader dr = cmd.ExecuteReader();

            int i = 0;
            while (dr.Read())
            {
                lv.Items.Add(dr["ID"].ToString());
                lv.Items[i].SubItems.Add(dr["MissionID"].ToString());
                lv.Items[i].SubItems.Add(dr["Mission"].ToString());
                lv.Items[i].SubItems.Add(dr["Name"].ToString());
                lv.Items[i].SubItems.Add(dr["Surname"].ToString());

                i++;
            }
            dr.Close();
            con.Close();

        }

        public void EmployeeGetbyInformationFromIDLV(ListView lv, int empID)
        {
            lv.Items.Clear();
            SqlConnection con = new SqlConnection(gnrl.connection);
            SqlCommand cmd = new SqlCommand("Select Employees.*,Missions.Mission from Employees Inner Join Missions on Missions.ID=Employees.MissionID where Employees.Status=0 and Employees.ID=@empID", con);
            cmd.Parameters.Add("empID", SqlDbType.Int).Value = empID;

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlDataReader dr = cmd.ExecuteReader();

            int i = 0;
            while (dr.Read())
            {
                lv.Items.Add(dr["ID"].ToString());
                lv.Items[i].SubItems.Add(dr["MissionID"].ToString());
                lv.Items[i].SubItems.Add(dr["Mission"].ToString());
                lv.Items[i].SubItems.Add(dr["Name"].ToString());
                lv.Items[i].SubItems.Add(dr["Surname"].ToString());
                lv.Items[i].SubItems.Add(dr["UserName"].ToString());

                i++;
            }
            dr.Close();
            con.Close();

        }

        public string OnlyOneEmployeeInfo(int empID)
        {
            string result = "";
            SqlConnection con = new SqlConnection(gnrl.connection);
            SqlCommand cmd = new SqlCommand("Select * from Employees where Employees.Status=0 and Employees.ID=@empID", con);
            cmd.Parameters.Add("empID", SqlDbType.Int).Value = empID;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                result = Convert.ToString(cmd.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                string fault = ex.Message;
                throw;
            }

            con.Close();
            return result;
        }

        public bool EmployeeChangePassword(int employeeID, string password)
        {
            bool result = false;

            SqlConnection con = new SqlConnection(gnrl.connection);
            SqlCommand cmd = new SqlCommand("Update Employees set Password=@password where ID=@employeeID", con);
            cmd.Parameters.Add("employeeID", SqlDbType.Int).Value = employeeID;
            cmd.Parameters.Add("password", SqlDbType.VarChar).Value = password;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                result = Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string fault = ex.Message;
                throw;
            }

            con.Close();
            return result;
        }

        public bool EmployeeAdd(cEmployees ce)
        {
            bool result = false;

            SqlConnection con = new SqlConnection(gnrl.connection);
            SqlCommand cmd = new SqlCommand("Insert Into Employees (Name,Surname,Password,MissionID) values(@name,@surname,@password,@missionID)", con);

            cmd.Parameters.Add("missionID", SqlDbType.Int).Value = EmployeeMissionID;
            cmd.Parameters.Add("name", SqlDbType.VarChar).Value = EmployeeName;
            cmd.Parameters.Add("surname", SqlDbType.VarChar).Value = EmployeeSurname;
            cmd.Parameters.Add("password", SqlDbType.VarChar).Value = EmployeePassword;

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                result = Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string fault = ex.Message;
                throw;
            }

            con.Close();
            return result;
        }

        public bool EmployeeUpdate(cEmployees ce, int empID)
        {
            bool result = false;

            SqlConnection con = new SqlConnection(gnrl.connection);
            SqlCommand cmd = new SqlCommand("Update Employees set MissionID=@missionID,Name=@name,Surname=@surname,Password=@password where ID=@empID", con);
            cmd.Parameters.Add("empID", SqlDbType.Int).Value = empID;
            cmd.Parameters.Add("missionID", SqlDbType.Int).Value = _EmployeeMissionID;
            cmd.Parameters.Add("name", SqlDbType.VarChar).Value = _EmployeeName;
            cmd.Parameters.Add("surname", SqlDbType.VarChar).Value = _EmployeeSurname;
            cmd.Parameters.Add("password", SqlDbType.VarChar).Value = _EmployeePassword;

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                result = Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string fault = ex.Message;
                throw;
            }

            con.Close();
            return result;
        }

        public bool EmployeeDelete(int empID)
        {
            bool result = false;

            SqlConnection con = new SqlConnection(gnrl.connection);
            SqlCommand cmd = new SqlCommand("Update Employees set Status=1 where ID=@empID", con);
            cmd.Parameters.Add("empID", SqlDbType.Int).Value = empID;


            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                result = Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string fault = ex.Message;
                throw;
            }

            con.Close();
            return result;
        }
    }
}
