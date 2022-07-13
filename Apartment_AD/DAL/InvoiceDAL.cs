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
    class InvoiceDAL
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
                String sql = "Select *from Invoice";
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
        public bool Insert(InvoiceBLL i)
        {
            //Creating a boolean variable and set its default value to false
            bool isSuccess = false;

            SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=Apartment;Integrated Security=True");
            try
            {
                //Writing query to create new Tenant
                string sql = "Insert into Invoice(Invoice_ID,Tenant_ID,Rent_Fee,Maintenance_Fee,Due_Amount) values(@Invoice_ID,@Tenant_ID,@Rent_Fee,@Maintenance_Fee,@Due_Amount)";
                //Creating SQL command to pass values in our query
                SqlCommand cmd = new SqlCommand(sql, con);

                //Passing values through parameter
                cmd.Parameters.AddWithValue("Invoice_ID", i.Invoice_ID);
                cmd.Parameters.AddWithValue("Tenant_ID", i.Tenant_ID);
                cmd.Parameters.AddWithValue("Rent_Fee", i.Rent_Fee);
                cmd.Parameters.AddWithValue("Maintenance_Fee", i.Maintenance_Fee);
                cmd.Parameters.AddWithValue("Due_Amount", i.Due_Amount);

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
        public bool Update(InvoiceBLL i)
        {
            bool isSuccess = false;
            SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=Apartment;Integrated Security=True");
            try
            {
                string sql = "Update Invoice SET Invoice_ID=@Invoice_ID,Rent_Fee=@Rent_Fee,Maintenance_Fee=@Maintenance_Fee,Due_Amount=@Due_Amount WHERE Tenant_ID=@Tenant_ID";
                SqlCommand cmd = new SqlCommand(sql, con);

                cmd.Parameters.AddWithValue("Tenant_ID", i.Tenant_ID);
                cmd.Parameters.AddWithValue("Rent_Fee", i.Rent_Fee);
                cmd.Parameters.AddWithValue("Maintenance_Fee", i.Maintenance_Fee);
                cmd.Parameters.AddWithValue("Due_Amount", i.Due_Amount);
                cmd.Parameters.AddWithValue("Invoice_ID", i.Invoice_ID);

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
        public bool Delete(InvoiceBLL i)
        {
            bool isSuccess = false;
            SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=Apartment;Integrated Security=True");
            try
            {
                string sql = "Delete from Invoice WHERE Invoice_ID=@Invoice_ID";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("Invoice_ID", i.Invoice_ID);

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
                String sql = "Select *from Invoice WHERE Tenant_ID LIKE '%" + keywords + "%' OR Invoice_ID LIKE '%" + keywords + "%'";

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

        #region Pay Data into Database
        public bool Pay(InvoiceBLL i)
        {
            //Creating a boolean variable and set its default value to false
            bool isSuccess = false;

            SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=Apartment;Integrated Security=True");
            try
            {
                //Writing query to create new Tenant
                string sql = "Insert into Payment(Payment_ID,Tenant_ID,Rent_Fee,Maintenance_Fee,Due_Amount) values(@Payment_ID,@Tenant_ID,@Rent_Fee,@Maintenance_Fee,@Due_Amount)";
                //Creating SQL command to pass values in our query
                SqlCommand cmd = new SqlCommand(sql, con);

                //Passing values through parameter
                cmd.Parameters.AddWithValue("Payment_ID", i.Invoice_ID);
                cmd.Parameters.AddWithValue("Tenant_ID", i.Tenant_ID);
                cmd.Parameters.AddWithValue("Rent_Fee", i.Rent_Fee);
                cmd.Parameters.AddWithValue("Maintenance_Fee", i.Maintenance_Fee);
                cmd.Parameters.AddWithValue("Due_Amount", i.Due_Amount);

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
    }
}
