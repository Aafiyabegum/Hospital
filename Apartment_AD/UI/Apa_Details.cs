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
    public partial class Apa_Details : Form
    {
        public Apa_Details()
        {
            InitializeComponent();
        }

        Apa_DetailsDAL dal = new Apa_DetailsDAL();

        private void Apa_Details_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'apartmentDataSet1.Apart' table. You can move, or remove it, as needed.
            this.apartTableAdapter.Fill(this.apartmentDataSet1.Apart);
           
            DataTable dt = dal.Select();
            dataGridView2.DataSource = dt;

        }

        private void btnOWN_Click(object sender, EventArgs e)
        {
            DashboardOwner frm = new DashboardOwner();
            frm.Show();
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtApart_TextChanged(object sender, EventArgs e)
        {
            //Get Keyword from of text
            string keywords = txtApart.Text;

            //Check if the keywords has value or not & filter the apartment based on keywords
            if (keywords != null)
            {
                //Use search method to display apartment
                DataTable dt = dal.Search(keywords);
                dataGridView2.DataSource = dt;
            }
            else
            {
                //Show all Apart from the database
                DataTable dt = dal.Select();
                dataGridView2.DataSource = dt;
            }
        }
    }
}
