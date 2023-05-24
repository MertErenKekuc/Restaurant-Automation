using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Restaurant
{
    class cProducts
    {
        cGeneral gnrl = new cGeneral();

        private int _ID;
        private int _CategoryID;
        private string _ProductName;
        private decimal _Price;

        public int ID { get => _ID; set => _ID = value; }
        public int CategoryID { get => _CategoryID; set => _CategoryID = value; }
        public string ProductName { get => _ProductName; set => _ProductName = value; }
        public decimal Price { get => _Price; set => _Price = value; }

        public void ListProductsbyProductName(ListView lv, string productName)
        {
            SqlConnection con = new SqlConnection(gnrl.connection);
            SqlCommand cmd = new SqlCommand("select Products.*, from Products Inner Join Categories on Categories.ID=Products.CategoryID where Products.Status=0 and Products.CategoryID=@productID", con);
            SqlDataReader dr = null;

            cmd.Parameters.Add("@productID", SqlDbType.VarChar).Value = ID;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();

                    dr = cmd.ExecuteReader();

                    int counter = 0;

                    while (dr.Read())
                    {
                        lv.Items.Add(dr["ID"].ToString());
                        lv.Items[counter].SubItems.Add(dr["CategoryID"].ToString());
                        lv.Items[counter].SubItems.Add(dr["ProductName"].ToString());
                        lv.Items[counter].SubItems.Add(dr["Price"].ToString());

                        counter++;
                    }
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
                con.Dispose();
                con.Close();
            }
        }
        public int ProductAdd(cProducts cp)
        {
            int result = 0;

            SqlConnection con = new SqlConnection(gnrl.connection);
            SqlCommand cmd = new SqlCommand("Insert Into Products(ProductName,CategoryID,Price) values(@productName,@categoryID,@price) ", con);

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@productName", SqlDbType.VarChar).Value = cp.ProductName;
                cmd.Parameters.Add("@categoryID", SqlDbType.Int).Value = cp.CategoryID;
                cmd.Parameters.Add("@price", SqlDbType.Money).Value = cp.Price;

                result = Convert.ToInt32(cmd.ExecuteNonQuery());
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

        public void ListProducts(ListView lv)
        {
            lv.Items.Clear();
            SqlConnection con = new SqlConnection(gnrl.connection);
            SqlCommand cmd = new SqlCommand("select Products.*,CategoryName from Products Inner Join Categories on Categories.ID=Products.CategoryID where Products.Status=0 ", con);
            SqlDataReader dr = null;

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();

                    dr = cmd.ExecuteReader();

                    int counter = 0;

                    while (dr.Read())
                    {
                        lv.Items.Add(dr["ID"].ToString());
                        lv.Items[counter].SubItems.Add(dr["CategoryID"].ToString());
                        lv.Items[counter].SubItems.Add(dr["ProductName"].ToString());
                        lv.Items[counter].SubItems.Add(dr["Price"].ToString());

                        counter++;
                    }
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
                con.Dispose();
                con.Close();
            }
        }
        public int ProductUpdate(cProducts cp)
        {
            int result = 0;

            cGeneral gnrl = new cGeneral();

            SqlConnection con = new SqlConnection(gnrl.connection);
            SqlCommand cmd = new SqlCommand("Update Products set ProductName=@productName,CategoryID=@categoryID,Price=@price where ID=@productID", con);

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@productName", SqlDbType.VarChar).Value = cp.ProductName;
                cmd.Parameters.Add("@categoryID", SqlDbType.Int).Value = cp.CategoryID;
                cmd.Parameters.Add("@price", SqlDbType.Money).Value = cp.Price;
                cmd.Parameters.Add("@productID", SqlDbType.Int).Value = cp.ID;

                result = Convert.ToInt32(cmd.ExecuteNonQuery());
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
        public int ProductDelete(cProducts cp, int cat)
        {
            int result = 0;

            cGeneral gnrl = new cGeneral();

            SqlConnection con = new SqlConnection(gnrl.connection);
            string sql = "Update Products set Status=1 where";
            if (cat == 0)
            {
                sql += "CategoryID=@productID";
            }
            else
            {
                sql += "ID=@productID";
            }
            SqlCommand cmd = new SqlCommand("Update Products set Status=1 where ID=@productID", con);

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@productID", SqlDbType.Int).Value = cp.ID;

                result = Convert.ToInt32(cmd.ExecuteNonQuery());
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

        public void ListProductsbyProductID(ListView lv, int productID)
        {
            SqlConnection con = new SqlConnection(gnrl.connection);
            SqlCommand cmd = new SqlCommand("select * from Products where Status=0 and ID=@productID", con);
            SqlDataReader dr = null;

            cmd.Parameters.Add("@productID", SqlDbType.Int).Value = productID;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();

                    dr = cmd.ExecuteReader();

                    int counter = 0;

                    while (dr.Read())
                    {
                        lv.Items.Add(dr["ID"].ToString());
                        lv.Items[counter].SubItems.Add(dr["ProductName"].ToString());
                        lv.Items[counter].SubItems.Add(dr["Price"].ToString());

                        counter++;
                    }
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
                con.Dispose();
                con.Close();
            }
        }
    }
}
