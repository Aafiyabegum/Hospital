using Apartment_AD.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace Apartment_AD.DLL
{
    class loginDAL
    {
        public bool loginCheck(loginBLL l)
        {
            bool isSuccess = false;

            SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=Apartment;Integrated Security=True");

            try
            {
                string sql = "Select * from Login where username=@username AND password=@password AND usertype=@usertype";
                SqlCommand cmd = new SqlCommand(sql,con);

                cmd.Parameters.AddWithValue("@username",l.username);
                cmd.Parameters.AddWithValue("@password", l.password);
                cmd.Parameters.AddWithValue("@usertype", l.usertype);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
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
    }
}
