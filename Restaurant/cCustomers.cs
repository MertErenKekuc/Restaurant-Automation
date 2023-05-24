using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    class cCustomers
    {
        private int _ID;
        private string _Name;
        private string _Surname;
        private string _Telephone;

        public int ID { get => _ID; set => _ID = value; }
        public string Name { get => _Name; set => _Name = value; }
        public string Surname { get => _Surname; set => _Surname = value; }
        public string Telephone { get => _Telephone; set => _Telephone = value; }

        public bool isthereanyCustomer(string tlphone)
        {
            cGeneral gnrl = new cGeneral();
            bool result = false;

            SqlConnection con = new SqlConnection(gnrl.connection);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "isthereanyCustomer";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Telephone", SqlDbType.VarChar).Value = tlphone;
            cmd.Parameters.Add("@result", SqlDbType.Int);
            cmd.Parameters["@result"].Direction = ParameterDirection.Output;

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            try
            {
                cmd.ExecuteNonQuery();
                result = Convert.ToBoolean(cmd.Parameters["@result"].Value);
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
        public int customerSave(cCustomers cc)
        {
            int result = 0;

            cGeneral gnrl = new cGeneral();

            SqlConnection con = new SqlConnection(gnrl.connection);
            SqlCommand cmd = new SqlCommand("Insert Into Customers(Name,Surname,TelephoneNumber) values(@name,@surname,@telephoneNumber); select SCOPE_IDENTITY() ", con);

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = cc.Name;
                cmd.Parameters.Add("@surname", SqlDbType.VarChar).Value = cc.Surname;
                cmd.Parameters.Add("@telephoneNumber", SqlDbType.VarChar).Value = cc.Telephone;

                result = Convert.ToInt32(cmd.ExecuteScalar());
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

        public bool customerUpdate(cCustomers cc)
        {
            bool result = false;

            cGeneral gnrl = new cGeneral();

            SqlConnection con = new SqlConnection(gnrl.connection);
            SqlCommand cmd = new SqlCommand("Update Customers set Name=@name,Surname=@surname,TelephoneNumber=@telephoneNumber where ID=@customerID", con);

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = cc.Name;
                cmd.Parameters.Add("@surname", SqlDbType.VarChar).Value = cc.Surname;
                cmd.Parameters.Add("@telephoneNumber", SqlDbType.VarChar).Value = cc.Telephone;
                cmd.Parameters.Add("@customerID", SqlDbType.Int).Value = cc.ID;

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

        public void listCustomer(ListView lv)
        {
            cGeneral gnrl = new cGeneral();

            SqlConnection con = new SqlConnection(gnrl.connection);
            SqlCommand cmd = new SqlCommand("select * from Customers", con);

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
                        lv.Items[counter].SubItems.Add(dr["Name"].ToString());
                        lv.Items[counter].SubItems.Add(dr["Surname"].ToString());
                        lv.Items[counter].SubItems.Add(dr["TelephoneNumber"].ToString());

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
        public void listCustomerfromID(int customerID, TextBox name, TextBox surname, TextBox telephone)
        {
            cGeneral gnrl = new cGeneral();

            SqlConnection con = new SqlConnection(gnrl.connection);
            SqlCommand cmd = new SqlCommand("select * from Customers where ID=@customerID", con);

            SqlDataReader dr = null;
            cmd.Parameters.Add("@customerID", SqlDbType.Int).Value = customerID;

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();

                    dr = cmd.ExecuteReader();

                    int counter = 0;

                    while (dr.Read())
                    {
                        name.Text = dr["Name"].ToString();
                        surname.Text = dr["Surname"].ToString();
                        telephone.Text = dr["TelephoneNumber"].ToString();

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
        public void listCustomerfromName(ListView lv, string customerName)
        {
            cGeneral gnrl = new cGeneral();

            SqlConnection con = new SqlConnection(gnrl.connection);
            SqlCommand cmd = new SqlCommand("select * from Customers where Name like @CustomerName + '%' ", con);
            SqlDataReader dr = null;
            cmd.Parameters.Add("customerName", SqlDbType.VarChar).Value = customerName;

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();

                    dr = cmd.ExecuteReader();

                    int counter = 0;

                    while (dr.Read())
                    {
                        lv.Items.Add(Convert.ToInt32(dr["ID"]).ToString());
                        lv.Items[counter].SubItems.Add(dr["Name"].ToString());
                        lv.Items[counter].SubItems.Add(dr["Surname"].ToString());
                        lv.Items[counter].SubItems.Add(dr["TelephoneNumber"].ToString());

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
