using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Restaurant
{
    public class cBill
    {
        private int _ID;
        private int _EmployeeID;
        private int _TableID;
        private DateTime _Time;
        private bool _Status;
        private decimal _Amount;

        public int ID { get => _ID; set => _ID = value; }
        public int EmployeeID { get => _EmployeeID; set => _EmployeeID = value; }
        public int TableID { get => _TableID; set => _TableID = value; }
        public DateTime Time { get => _Time; set => _Time = value; }
        public bool Status { get => _Status; set => _Status = value; }
        public decimal Amount { get => _Amount; set => _Amount = value; }

        cGeneral gnrl = new cGeneral();
        public int getbyAddition(int TableID)
        {
            SqlConnection con = new SqlConnection(gnrl.connection);
            SqlCommand cmd = new SqlCommand("Select top 1 ID From Bills Where TableID=@tableId Order by ID desc", con);

            cmd.Parameters.Add("@tableId", SqlDbType.Int).Value = TableID;

            try
            {
                if ((con.State == ConnectionState.Closed))
                {
                    con.Open();
                }
                TableID = Convert.ToInt32(cmd.ExecuteScalar());
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
            return TableID;
        }
        public bool setbyAdditionNew(cBill info)
        {
            bool result = false;
            SqlConnection con = new SqlConnection(gnrl.connection);
            SqlCommand cmd = new SqlCommand("Insert Into Bills(EmployeeID,TableID,Time,Status) values(@employeeID,@tableID,@time,@status)", con);

            cmd.Parameters.Add("@employeeID", SqlDbType.Int).Value = info.EmployeeID;
            cmd.Parameters.Add("@tableID", SqlDbType.Int).Value = info.TableID;
            cmd.Parameters.Add("@time", SqlDbType.DateTime).Value = info.Time;
            cmd.Parameters.Add("@status", SqlDbType.Bit).Value = info.Status;

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
            finally
            {
                con.Dispose();
                con.Close();
            }
            return result;
        }
        public void BillClose(int billID, int status)
        {
            bool result = false;
            cGeneral gnrl = new cGeneral();
            SqlConnection con = new SqlConnection(gnrl.connection);
            SqlCommand cmd = new SqlCommand("Update Bills set Status=@status where ID=@billID ", con);

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            try
            {
                cmd.Parameters.Add("billID", SqlDbType.Int).Value = billID;
                cmd.Parameters.Add("status", SqlDbType.Int).Value = status;
                cmd.ExecuteNonQuery();


            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                con.Dispose();
                con.Close();
            }
        }
        public int ReservationBillOpen(cBill info)
        {
            int result = 0;
            SqlConnection con = new SqlConnection(gnrl.connection);
            SqlCommand cmd = new SqlCommand("Insert Into Bills(EmployeeID,TableID,Time) values(@employeeID,@tableID,@time);select scope_IDENTITY()", con);

            info.TableID = cGeneral._tableID;
            cmd.Parameters.Add("@employeeID", SqlDbType.Int).Value = info.EmployeeID;
            cmd.Parameters.Add("@tableID", SqlDbType.Int).Value = info.TableID;
            cmd.Parameters.Add("@time", SqlDbType.DateTime).Value = info.Time;

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                result = Convert.ToInt32(cmd.ExecuteScalar());
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
