using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace Restaurant
{
    class cTables
    {
        private int _ID;
        private int _Capacity;
        private int _Status;
        private bool _Case;
        private string _Tableinfo;

        public int ID { get => _ID; set => _ID = value; }
        public int Capacity { get => _Capacity; set => _Capacity = value; }
        public int Status { get => _Status; set => _Status = value; }
        public bool Case { get => _Case; set => _Case = value; }
        public string Tableinfo { get => _Tableinfo; set => _Tableinfo = value; }

        cGeneral gnrl = new cGeneral();

        public string SessionSum(int state, string tableID)
        {
            string dt = "";
            SqlConnection con = new SqlConnection(gnrl.connection);
            SqlCommand cmd = new SqlCommand("Select TableID,Time from Bills Right Join Tables on Bills.TableID=Tables.ID Where Tables.Status=@status and Bills.Status=0 and Tables.ID=@tableID", con);
            SqlDataReader dr = null;
            cmd.Parameters.Add("@status", SqlDbType.Int).Value = state;
            cmd.Parameters.Add("@tableID", SqlDbType.Int).Value = Convert.ToInt32(tableID);

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    dt = Convert.ToDateTime(dr["Time"]).ToString();
                }
            }
            catch (SqlException ex)
            {
                string Fault = ex.Message;
                throw;
            }
            finally
            {
                dr.Close();
                con.Dispose();
                con.Close();
            }
            return dt;
        }
        public int TableGetbyNumber(string TableValue)
        {
            string aa = TableValue;
            int length = aa.Length;

            return Convert.ToInt32(aa.Substring(length - 1, 1));
        }

        public bool TableGetbyState(int ButtonName, int State)
        {
            bool result = false;
            SqlConnection con = new SqlConnection(gnrl.connection);
            SqlCommand cmd = new SqlCommand("Select Status From Tables Where ID=@TableID and Status=@state", con);

            cmd.Parameters.Add("@TableID", SqlDbType.Int).Value = ButtonName;
            cmd.Parameters.Add("@state", SqlDbType.Int).Value = State;

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
            }
            finally
            {
                con.Dispose();
                con.Close();
            }
            return result;
        }

        public void setChangeTableState(string ButtonName, int state)
        {
            SqlConnection con = new SqlConnection(gnrl.connection);
            SqlCommand cmd = new SqlCommand("Update Tables Set Status=@state where ID=@tableID", con);

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string aa = ButtonName;
            int length = aa.Length;
            cmd.Parameters.Add("@state", SqlDbType.Int).Value = state;
            cmd.Parameters.Add("@tableID", SqlDbType.Int).Value = aa.Substring(length - 1, 1);
            cmd.ExecuteNonQuery();
            con.Dispose();
            con.Close();
        }
        public void TableCapacityandStatus(ComboBox cb)
        {
            string status = "";
            SqlConnection con = new SqlConnection(gnrl.connection);
            SqlCommand cmd = new SqlCommand("Select * from Tables", con);

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cTables ct = new cTables();
                if (ct.Status == 2)
                {
                    status = "Full";
                }
                else if (ct.Status != 3)
                {
                    ct.Capacity = Convert.ToInt32(dr["Capacity"]);
                    ct.Tableinfo = "Table No: " + dr["ID"].ToString() + "Capacity:" + dr["Capacity"].ToString();
                    ct.ID = Convert.ToInt32(dr["ID"]);
                    cb.Items.Add(ct);
                }
            }
            dr.Close();
            con.Dispose();
            con.Close();
        }
        public override string ToString()
        {
            return Tableinfo;
        }
    }
}
