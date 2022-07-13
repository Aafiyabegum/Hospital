using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Apartment_AD.DAL;

namespace Apartment_AD
{
    public partial class Te_Payment : Form
    {
        public Te_Payment()
        {
            InitializeComponent();
        }

        Te_PaymentDAL dal = new Te_PaymentDAL();

        private void Te_Payment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'apartmentDataSet7.Invoice' table. You can move, or remove it, as needed.
            this.invoiceTableAdapter.Fill(this.apartmentDataSet7.Invoice);
            
            DataTable dt = dal.Select();
            dataGridView1.DataSource = dt;
        }

        private void btnTE_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashboardTenant Te = new DashboardTenant();
            Te.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txttenant_TextChanged(object sender, EventArgs e)
        {
            //Get Keyword from of text
            string keywords = txttenant.Text;

            //Check if the keywords has value or not & filter the apartment based on keywords
            if (keywords != null)
            {
                //Use search method to display apartment
                DataTable dt = dal.Search(keywords);
                dataGridView1.DataSource = dt;
            }
            else
            {
                //Show all Apart from the database
                DataTable dt = dal.Select();
                dataGridView1.DataSource = dt;
            }
        }
    }
}
