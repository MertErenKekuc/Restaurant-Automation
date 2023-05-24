using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Security.Principal;

namespace Restaurant
{
    public class cProductsCategory
    {
        private int _ID;
        private string _CategoryName;
        private bool _Status;

        public int ID { get => _ID; set => _ID = value; }
        public string CategoryName { get => _CategoryName; set => _CategoryName = value; }
        public bool Status { get => _Status; set => _Status = value; }

        cGeneral gnrl = new cGeneral();
        public void getbyProductType(ListView kinds, Button btn)
        {
            

            kinds.Items.Clear();
            SqlConnection con = new SqlConnection(gnrl.connection);
            SqlCommand cmd = new SqlCommand("Select ProductName,Price,Products.ID From Categories Inner Join Products on Categories.ID=Products.CategoryID where Products.CategoryID=@categoryId and Products.Status=0", con);

            string aa = btn.Name;
            int length = aa.Length;

            cmd.Parameters.Add("@categoryId", SqlDbType.Int).Value = aa.Substring(length - 1, 1);

            if(con.State==ConnectionState.Closed)
            {
                con.Open();
            }
            SqlDataReader dr = cmd.ExecuteReader();
            int i = 0;

            while(dr.Read())
            {
                kinds.Items.Add(dr["ProductName"].ToString());
                kinds.Items[i].SubItems.Add(dr["Price"].ToString());
                kinds.Items[i].SubItems.Add(dr["ID"].ToString());
                i++;
            }
            dr.Close();
            con.Dispose();
            con.Close();
        }

        public void getProductsCategorycb(ComboBox cb)
        {
            cb.Items.Clear();
            SqlConnection con = new SqlConnection(gnrl.connection);
            SqlCommand cmd = new SqlCommand("select * from Categories where Status=0", con);
            SqlDataReader dr = null;

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        cProductsCategory pc = new cProductsCategory();
                        pc.ID =Convert.ToInt32( dr["ID"]);
                        pc.CategoryName = dr["CategoryName"].ToString();

                        cb.Items.Add(pc);
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

        public void getProductsCategorylv(ListView lv)
        {
            SqlConnection con = new SqlConnection(gnrl.connection);
            SqlCommand cmd = new SqlCommand("select * from Categories where Status=0", con);
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
                        lv.Items[counter].SubItems.Add(dr["CategoryName"].ToString());

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
        public int ProductCategoryAdd(cProductsCategory pc)
        {
            int result = 0;

            SqlConnection con = new SqlConnection(gnrl.connection);
            SqlCommand cmd = new SqlCommand("Insert Into Categories(CategoryName) values(@categoryName) ", con);

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@categoryName", SqlDbType.VarChar).Value = pc.CategoryName;

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

        public int ProductCategoryUpdate(cProductsCategory pc)
        {
            int result = 0;

            cGeneral gnrl = new cGeneral();

            SqlConnection con = new SqlConnection(gnrl.connection);
            SqlCommand cmd = new SqlCommand("Update Categories set CategoryName=@categoryName where ID=@categoryID", con);

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@categoryName", SqlDbType.VarChar).Value = pc.CategoryName;
                cmd.Parameters.Add("@categoryID", SqlDbType.Int).Value =pc._ID;

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

        public int ProductCategoryDelete(int ID)
        {
            int result = 0;

            cGeneral gnrl = new cGeneral();

            SqlConnection con = new SqlConnection(gnrl.connection);
            SqlCommand cmd = new SqlCommand("Update Categories set Status=1 where ID=@categoryID", con);

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@categoryID", SqlDbType.Int).Value = ID;
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
        public override string ToString()
        {
            return CategoryName;
        }
    }
}
