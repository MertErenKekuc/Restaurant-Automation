using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Restaurant
{
    class cEmployeeMission
    {
        cGeneral gnrl = new cGeneral();

        private int _employeeMissionID;
        private string _mission;

        public int EmployeeMissionID { get => _employeeMissionID; set => _employeeMissionID = value; }
        public string Mission { get => _mission; set => _mission = value; }

        public void getEmployeeMission(ComboBox cb)
        {
            cb.Items.Clear();

            SqlConnection con = new SqlConnection(gnrl.connection);
            SqlCommand cmd = new SqlCommand("Select * from Missions", con);
            SqlDataReader dr = null;


            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    cEmployeeMission cm = new cEmployeeMission();
                    cm._employeeMissionID = Convert.ToInt32(dr["ID"].ToString());
                    cm._mission = dr["Mission"].ToString();
                    cb.Items.Add(cm);
                }
            }
            catch (SqlException ex)
            {
                string fault = ex.Message;
                throw;
            }
            finally
            {
                dr.Close();
                con.Close();
            }
        }

        public string EmployeeMission(int emp)
        {
            string result = "";
            SqlConnection con = new SqlConnection(gnrl.connection);
            SqlCommand cmd = new SqlCommand("Select Mission from Missions where ID=@empID", con);
            cmd.Parameters.Add("empID", SqlDbType.Int).Value = emp;

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                result = cmd.ExecuteScalar().ToString();
            }
            catch (SqlException ex)
            {
                string fault = ex.Message;
                throw;
            }
            finally
            {
                con.Close();
            }
            return result;
        }
        public override string ToString()
        {
            return _mission;
        }
    }
}
