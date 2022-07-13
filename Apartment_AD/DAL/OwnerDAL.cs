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
    //DAL means Data Access Layer, creating class with methods to insert update delete select data
    class OwnerDAL
    {
        //Static method to connect to database
        SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=Apartment;Integrated Security=True");
        //Methods
        #region Select Data from Database
        public DataTable Select()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=Apartment;Integrated Security=True");
            //To hold the data from database
            DataTable dt = new DataTable();
            try 
            {
                //SQL Query to get data from the database
                String sql = "Select *from Owner";
                
                //For executing command
                SqlCommand cmd = new SqlCommand(sql, con);
                
                //Getting data from database 
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                
                //Database connection open
                con.Open();
                
                //Fill data in our dataTable
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                //Throw message if any error occurs
                MessageBox.Show(ex.Message);
            }
            finally 
            {
                //Closing connection
                con.Close();
            }
            //Return the value in DataTable
            return dt;
        }
        #endregion

        #region Insert Data in Database
        public bool Insert(OwnerBLL o)
        {
            bool isSuccess = false;
            
            SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=Apartment;Integrated Security=True"); 
            try 
            {
                string sql = "Insert into Owner(Owner_ID,Owner_Name,No_of_members_in_family,Apartment_Units,Apartment_Type,Phone_No,Mail_ID) values(@Owner_ID,@Owner_Name,@No_of_members_in_family,@Apartment_Units,@Apartment_Type,@Phone_No,@Mail_ID)";
                SqlCommand cmd = new SqlCommand(sql,con);
                cmd.Parameters.AddWithValue("Owner_ID",o.Owner_ID);
                cmd.Parameters.AddWithValue("Owner_Name",o.Owner_Name);
                cmd.Parameters.AddWithValue("No_of_members_in_family",o.No_of_members_in_family);
                cmd.Parameters.AddWithValue("Apartment_Units",o.Apartment_Units);
                cmd.Parameters.AddWithValue("Apartment_Type",o.Apartment_Type);
                cmd.Parameters.AddWithValue("Phone_No",o.Phone_No);
                cmd.Parameters.AddWithValue("Mail_ID",o.Mail_ID);
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
            catch(Exception ex) 
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
        public bool Update(OwnerBLL o)
        {
            bool isSuccess = false;
            SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=Apartment;Integrated Security=True");
            try 
            {
                string sql = "Update Owner SET Owner_Name=@Owner_Name,No_of_members_in_family=@No_of_members_in_family,Apartment_Units=@Apartment_Units,Apartment_Type=@Apartment_Type,Phone_No=@Phone_No,Mail_ID=@Mail_ID WHERE Owner_ID=@Owner_ID";
                SqlCommand cmd = new SqlCommand(sql,con);
                cmd.Parameters.AddWithValue("Owner_ID", o.Owner_ID);
                cmd.Parameters.AddWithValue("Owner_Name", o.Owner_Name);
                cmd.Parameters.AddWithValue("No_of_members_in_family", o.No_of_members_in_family);
                cmd.Parameters.AddWithValue("Apartment_Units", o.Apartment_Units);
                cmd.Parameters.AddWithValue("Apartment_Type", o.Apartment_Type);
                cmd.Parameters.AddWithValue("Phone_No", o.Phone_No);
                cmd.Parameters.AddWithValue("Mail_ID", o.Mail_ID);

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
            catch(Exception ex) 
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
        public bool Delete(OwnerBLL o)
        { 
            bool isSuccess = false;
            SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=Apartment;Integrated Security=True");
            try 
            {
                string sql = "Delete from Owner WHERE Owner_ID=@Owner_ID";
                SqlCommand cmd = new SqlCommand(sql,con);
                cmd.Parameters.AddWithValue("Owner_ID", o.Owner_ID);
              
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
            catch(Exception ex) 
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
                String sql = "Select *from Owner WHERE Owner_ID LIKE '%" + keywords + "%' OR Owner_Name LIKE '%" + keywords + "%'";

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
