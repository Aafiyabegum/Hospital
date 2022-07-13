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
    public partial class Tenant_Details : Form
    {
        public Tenant_Details()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Tenant_DetailsDAL dal = new Tenant_DetailsDAL();

        private void ALL_DATA_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'apartmentDataSet2.Tenant' table. You can move, or remove it, as needed.
            this.tenantTableAdapter.Fill(this.apartmentDataSet2.Tenant);
            
            DataTable dt = dal.Select();
            dataGridView1.DataSource = dt;

        }

        private void btnOWN_Click(object sender, EventArgs e)
        {
            DashboardOwner frm = new DashboardOwner();
            frm.Show();
            this.Hide();
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
