using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;

namespace Restaurant
{
    class cReservation
    {
        private int _ID;
        private int _TableID;
        private int _BillID;
        private DateTime _Time;
        private int _ClientID;
        private int _ClientCount;

        public int ID { get => _ID; set => _ID = value; }
        public int TableID { get => _TableID; set => _TableID = value; }
        public int BillID { get => _BillID; set => _BillID = value; }
        public DateTime Time { get => _Time; set => _Time = value; }
        public int ClientID { get => _ClientID; set => _ClientID = value; }
        public int ClientCount { get => _ClientCount; set => _ClientCount = value; }

        public int getbyClientFormReservation(int tableID)
        {
            int clientID =0;

            cGeneral gnrl = new cGeneral();
            SqlConnection con = new SqlConnection(gnrl.connection);
            SqlCommand cmd = new SqlCommand("Select top 1 CustomerID from Reservations where TableID=@tableID order by CustomerID Desc",con);


            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("tableID", SqlDbType.Int).Value = tableID;

               clientID = Convert.ToInt32(cmd.ExecuteScalar());
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
            return clientID;

        }

        public void CustomergetbyReservation(ListView lv)
        {
            cGeneral gnrl = new cGeneral();

            lv.Items.Clear();
            SqlConnection con = new SqlConnection(gnrl.connection);
            SqlCommand cmd = new SqlCommand("Select Reservations.CustomerID,(Name+Surname) as Customers from Reservations Inner Join Customers on Reservations.CustomerID=Customers.ID where Reservations.Status=0 ", con);


            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlDataReader dr = cmd.ExecuteReader();
            int i = 0;

            while (dr.Read())
            {
                lv.Items.Add(dr["CustomerID"].ToString());
                lv.Items[i].SubItems.Add(dr["Customers"].ToString());
                i++;
            }
            dr.Close();
            con.Dispose();
            con.Close();
        }
        public void OldReservations(ListView lv, int customerID)
        {
            cGeneral gnrl = new cGeneral();

            lv.Items.Clear();
            SqlConnection con = new SqlConnection(gnrl.connection);
            SqlCommand cmd = new SqlCommand("Select Reservations.CustomerID,Name,Surname,BillID,Time as Customers from Reservations Inner Join Customers on Reservations.CustomerID=Customers.ID  where Reservations.ID=@customerID and Reservations.Status=0 order by Reservations.ID Desc ", con);
            cmd.Parameters.Add("customerID", SqlDbType.Int).Value = customerID;

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlDataReader dr = cmd.ExecuteReader();
            int i = 0;

            while (dr.Read())
            {
                lv.Items.Add(dr["CustomerID"].ToString());
                lv.Items[i].SubItems.Add(dr["Name"].ToString());
                lv.Items[i].SubItems.Add(dr["Surname"].ToString());
                lv.Items[i].SubItems.Add(dr["Time"].ToString());
                lv.Items[i].SubItems.Add(dr["BillID"].ToString());
                i++;
            }
            dr.Close();
            con.Dispose();
            con.Close();
        }
        public DateTime LastTime(int customerID)
        {
            cGeneral gnrl = new cGeneral();

            DateTime dt = new DateTime();
            dt = DateTime.Now;
            SqlConnection con = new SqlConnection(gnrl.connection);
            SqlCommand cmd = new SqlCommand("Select Timefrom Reservations where Reservations.CustomerID=Customers.ID where Reservations.ID=@customerID and Reservations.Status=1 order by Reservations.ID Desc ", con);
            cmd.Parameters.Add("customerID", SqlDbType.Int).Value = customerID;

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            dt = Convert.ToDateTime(cmd.ExecuteScalar());
            con.Dispose();
            con.Close();

            return dt;
        }

        public bool ReservationControl(int customerID)
        {
            cGeneral gnrl = new cGeneral();

            bool result = false;
            SqlConnection con = new SqlConnection(gnrl.connection);
            SqlCommand cmd = new SqlCommand("Select top 1 Reservations.ID from Reservations where CustomerID=@customerID order by ID desc", con);

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("customerID", SqlDbType.Int).Value = customerID;
                result = Convert.ToBoolean(cmd.ExecuteNonQuery());

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

        public bool ReservationOpen(cReservation r)
        {
            cGeneral gnrl = new cGeneral();

            bool result = false;
            SqlConnection con = new SqlConnection(gnrl.connection);
            SqlCommand cmd = new SqlCommand("Insert Into Reservations (CustomerID,TableID,Time,NumberOfPerson,BillID,Status) values (@customerID,@tableID,@time,@numberOfPerson,@billID,1)", con);

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("customerID", SqlDbType.Int).Value = r._ClientID;
                cmd.Parameters.Add("numberOfPerson", SqlDbType.Int).Value = r.ClientCount;
                cmd.Parameters.Add("billID", SqlDbType.Int).Value = r.BillID;
                cmd.Parameters.Add("time", SqlDbType.DateTime).Value = r.Time;
                cmd.Parameters.Add("tableID", SqlDbType.Int).Value = r.TableID;
                result = Convert.ToBoolean(cmd.ExecuteNonQuery());
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
        public int ReservationTableID(int customerID)
        {
            cGeneral gnrl = new cGeneral();

            int result = 0;
            SqlConnection con = new SqlConnection(gnrl.connection);
            SqlCommand cmd = new SqlCommand("Select Reservations.TableID from Inner Join Bills on Reservations.BillID=Bills.ID where Reservations.State=1 and Bills.State=0 and Reservations.CustomerID=customerID", con);

            if(con.State == ConnectionState.Closed) 
            {
                con.Open();
            }
            try
            {
                cmd.Parameters.Add("customerID", SqlDbType.Int).Value = customerID;
                result = Convert.ToInt32(cmd.ExecuteScalar());

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
            return result;
        }
        public bool ReservationClose(int billID)
        {
            bool result = false;
            cGeneral gnrl = new cGeneral();
            SqlConnection con = new SqlConnection(gnrl.connection);
            SqlCommand cmd = new SqlCommand("Update Reservations set Status=1 where BillID=@billID ", con);

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            try
            {
                cmd.Parameters.Add("billID", SqlDbType.Int).Value = billID;
                result = Convert.ToBoolean(cmd.ExecuteScalar());

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
            return result;
        }
    }
}
