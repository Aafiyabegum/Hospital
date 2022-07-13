using Apartment_AD.BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apartment_AD.DAL
{
    class TenantDAL
    {
        SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=Apartment;Integrated Security=True");
        //Methods

        #region Select Data from Database
        public DataTable Select()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=Apartment;Integrated Security=True");
            DataTable dt = new DataTable();
            try
            {
                String sql = "Select *from Tenant";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                con.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return dt;
        }
        #endregion

        #region Insert Data in Database
        public bool Insert(TenantBLL t)
        {
            //Creating a boolean variable and set its default value to false
            bool isSuccess = false;

            SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=Apartment;Integrated Security=True");
            try
            {
                //Writing query to create new Tenant
                string sql = "Insert into Tenant(Tenant_ID,Tenant_Name,Apartment_Units,Apartment_Type,Phone_No,Mail_ID) values(@Tenant_ID,@Tenant_Name,@Apartment_Units,@Apartment_Type,@Phone_No,@Mail_ID)";
                //Creating SQL command to pass values in our query
                SqlCommand cmd = new SqlCommand(sql, con);

                //Passing values through parameter
                cmd.Parameters.AddWithValue("Tenant_ID", t.Tenant_ID);
                cmd.Parameters.AddWithValue("Tenant_Name", t.Tenant_Name);
                cmd.Parameters.AddWithValue("Apartment_Units", t.Apartment_Units);
                cmd.Parameters.AddWithValue("Apartment_Type", t.Apartment_Type);
                cmd.Parameters.AddWithValue("Phone_No", t.Phone_No);
                cmd.Parameters.AddWithValue("Mail_ID", t.Mail_ID);

                //Open database connection
                con.Open();

                //Creating the int variable to execute query
                int rows = cmd.ExecuteNonQuery();

                //If the query is executed succesfully then its value will be greater than 0, else it will be less than 0
                if (rows > 0)
                {
                    //Query executed succesfully
                    isSuccess = true;
                }
                else
                {
                    //Failed to execute query
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return isSuccess;
        }
        #endregion

        #region Update data in Database
        public bool Update(TenantBLL t)
        {
            bool isSuccess = false;
            SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=Apartment;Integrated Security=True");
            try
            {
                string sql = "Update Tenant SET Tenant_Name=@Tenant_Name,Apartment_Units=@Apartment_Units,Apartment_Type=@Apartment_Type,Phone_No=@Phone_No,Mail_ID=@Mail_ID WHERE Tenant_ID=@Tenant_ID";
                SqlCommand cmd = new SqlCommand(sql, con);

                cmd.Parameters.AddWithValue("Tenant_ID", t.Tenant_ID);
                cmd.Parameters.AddWithValue("Tenant_Name", t.Tenant_Name);
                cmd.Parameters.AddWithValue("Apartment_Units", t.Apartment_Units);
                cmd.Parameters.AddWithValue("Apartment_Type", t.Apartment_Type);
                cmd.Parameters.AddWithValue("Phone_No", t.Phone_No);
                cmd.Parameters.AddWithValue("Mail_ID", t.Mail_ID);


                con.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return isSuccess;
        }
        #endregion

        #region Delete data from Database
        public bool Delete(TenantBLL t)
        {
            bool isSuccess = false;
            SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=Apartment;Integrated Security=True");
            try
            {
                string sql = "Delete from Tenant WHERE Tenant_ID=@Tenant_ID";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("Tenant_ID", t.Tenant_ID);

                con.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return isSuccess;
        }
        #endregion

        #region Search Data from Database
        public DataTable Search(string keywords)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=Apartment;Integrated Security=True");
            DataTable dt = new DataTable();
            try
            {
                String sql = "Select *from Tenant WHERE Tenant_ID LIKE '%" + keywords + "%' OR Tenant_Name LIKE '%" + keywords + "%'";

                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                con.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return dt;
        }
        #endregion


    }
}
