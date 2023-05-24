using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace Restaurant
{
    class cSales
    {
        private int _ID;
        private int _BillD;
        private int _TableID;
        private int _ProductID;
        private int _Piece;
        private bool _Status;

        public int ID { get => _ID; set => _ID = value; }
        public int BillD { get => _BillD; set => _BillD = value; }
        public int TableID { get => _TableID; set => _TableID = value; }
        public int ProductID { get => _ProductID; set => _ProductID = value; }
        public int Piece { get => _Piece; set => _Piece = value; }
        public bool Status { get => _Status; set => _Status = value; }

        public void getByOrder(ListView lv, int billID)
        {
            cGeneral gnrl = new cGeneral();

            SqlConnection con = new SqlConnection(gnrl.connection);
            SqlCommand cmd = new SqlCommand("select ProductName,Price,Sales.ID,ProductID,Sales.Piece from Sales INNER JOIN Products on Sales.ProductID=Products.ID Where BillID=@billID", con);
            SqlDataReader dr = null;
            cmd.Parameters.Add("@billID", SqlDbType.Int).Value = billID;

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                dr = cmd.ExecuteReader();
                int counter = 0;

                while (dr.Read())
                {
                    lv.Items.Add(dr["ProductName"].ToString());
                    lv.Items[counter].SubItems.Add(dr["Piece"].ToString());
                    lv.Items[counter].SubItems.Add(dr["ProductID"].ToString());
                    lv.Items[counter].SubItems.Add(Convert.ToString(Convert.ToDecimal(dr["Price"]) * Convert.ToDecimal(dr["Piece"])));
                    lv.Items[counter].SubItems.Add(dr["ID"].ToString());

                    counter++;
                }
            }
            catch (SqlException ex)
            {
                string fault = ex.Message;

            }
            finally
            {
                dr.Close();
                con.Dispose();
                con.Close();
            }
        }
        public bool setSaveOrder(cSales info)
        {
            cGeneral gnrl = new cGeneral();

            bool result = false;
            SqlConnection con = new SqlConnection(gnrl.connection);
            SqlCommand cmd = new SqlCommand("Insert Into Sales(BillID,TableID,Piece,ProductID) values(@billID,@tableID,@piece,@productID)", con);

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@billID", SqlDbType.Int).Value = info.BillD;
                cmd.Parameters.Add("@tableID", SqlDbType.Int).Value = info.TableID;
                cmd.Parameters.Add("@piece", SqlDbType.Int).Value = info.Piece;
                cmd.Parameters.Add("@productID", SqlDbType.Int).Value = info.ProductID;

                result = Convert.ToBoolean(cmd.ExecuteNonQuery());
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
        public void setDeleteOrder(int salesID)
        {
            cGeneral gnrl = new cGeneral();
            SqlConnection con = new SqlConnection(gnrl.connection);
            SqlCommand cmd = new SqlCommand("Delete from Sales where ID=@saleID", con);

            cmd.Parameters.Add("@saleID", SqlDbType.Int).Value = salesID;

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.ExecuteNonQuery();
            con.Dispose();
            con.Close();

        }
        public int PayementTypeID(int BillID)
        {
            int payementTypeID = 0;
            cGeneral gnrl = new cGeneral();
            SqlConnection con = new SqlConnection(gnrl.connection);
            SqlCommand cmd = new SqlCommand("Select ID From PayementType", con);

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                payementTypeID = Convert.ToInt32(cmd.ExecuteScalar());
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
            return payementTypeID;
        }
    }
}
