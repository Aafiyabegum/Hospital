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
    class ProfitDAL
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
                String sql = "Select *from Payment";
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
