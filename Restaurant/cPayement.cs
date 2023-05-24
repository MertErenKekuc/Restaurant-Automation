using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Restaurant
{
    class cPayement
    {
        private int _ID;
        private int _BillID;
        private int _CustomerID;
        private int _PayementTypeID;
        private decimal _Total;
        private DateTime _Time;

        public int ID { get => _ID; set => _ID = value; }
        public int BillID { get => _BillID; set => _BillID = value; }
        public int CustomerID { get => _CustomerID; set => _CustomerID = value; }
        public int PayementTypeID { get => _PayementTypeID; set => _PayementTypeID = value; }
        public decimal Total { get => _Total; set => _Total = value; }
        public DateTime Time { get => _Time; set => _Time = value; }

        public bool billClosed(cPayement pymnt)
        {
            bool result = false;
            cGeneral gnrl = new cGeneral();

            SqlConnection con = new SqlConnection(gnrl.connection);
            SqlCommand cmd = new SqlCommand("Insert Into BillPayement(BillID,CustomerID,PayementTypeID,Total) values(@billID,@customerID,@payementTypeID,@total)", con);

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("BillID", SqlDbType.Int).Value = pymnt.BillID;
                cmd.Parameters.Add("CustomerID", SqlDbType.Int).Value = pymnt.CustomerID;
                cmd.Parameters.Add("PayementTypeID", SqlDbType.Int).Value = pymnt.PayementTypeID;
                cmd.Parameters.Add("Total", SqlDbType.Money).Value = pymnt.Total;

                result = Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string fault = ex.Message;
                throw;
            }
            finally
            {
                con.Dispose();
                con.Close();
            }
            return result;
        }
    }
}
