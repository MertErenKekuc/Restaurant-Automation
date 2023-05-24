using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Restaurant
{
    class cEmployeesMovement
    {
        cGeneral gnrl = new cGeneral();

        private int _ID;
        private int _EmployeeID;
        private string _Operation;
        private DateTime _Time;

        public int ID { get => _ID; set => _ID = value; }
        public int EmployeeID { get => _EmployeeID; set => _EmployeeID = value; }

        public string Operation { get => _Operation; set => _Operation = value; }
        public DateTime Time { get => _Time; set => _Time = value; }


        public bool EmployeesMovementSave(cEmployeesMovement em)
        {
            bool result = false;

            SqlConnection con = new SqlConnection(gnrl.connection);
            SqlCommand cmd = new SqlCommand("Insert Into EmployeesMovement(EmployeeID,Operation,Time)Values(@employeeID,@operation,@time)", con);

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@employeeID", SqlDbType.Int).Value = em._EmployeeID;
                cmd.Parameters.Add("@operation", SqlDbType.VarChar).Value = em._Operation;
                cmd.Parameters.Add("@time", SqlDbType.DateTime).Value = em._Time;

                result = Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string fault = ex.Message;
                throw;
            }

            return result;
        }
    }
}
