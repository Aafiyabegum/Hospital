using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using Apartment_AD.BLL;
using Apartment_AD.DAL;

namespace Apartment_AD
{
    public partial class Apart : Form
    {
        public Apart()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        ApartmentBLL a = new ApartmentBLL();
        ApartmentDAL dal = new ApartmentDAL();


        private void btnAd_Click(object sender, EventArgs e)
        {
            Dashboard frm = new Dashboard();
            frm.Show();
            this.Hide();
        }

        private void Apart_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'apartmentDataSet10.Apart' table. You can move, or remove it, as needed.
            this.apartTableAdapter.Fill(this.apartmentDataSet10.Apart);

            //Display all the apartmentndetails in datagridview
            DataTable dt = dal.Select();
            dataGridView1.DataSource = dt;

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtApa.Text != "" && cmbApunits.Text != "" && cmbType.Text != "" && txtPhoe.Text != "")
            {  //Get the value from Apartment form
                a.Apartment_ID = txtApa.Text;
                a.Apartment_Units = cmbApunits.Text;
                a.Apartment_Type = cmbType.Text;
                a.Phone_No = int.Parse(txtPhoe.Text);


                //Create boolean method to create data into database
                bool success = dal.Insert(a);

                //If the Apart is created successfully then the value of the success will be true, else it will be false
                if (success == true)
                {
                    //Apartment successfuly created
                    MessageBox.Show("Apartment Successfully Created", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                }
                else
                {
                    //Failed to create Apartment
                    MessageBox.Show("Failed to Create", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //Refreshing data gridview
                DataTable dt = dal.Select();
                dataGridView1.DataSource = dt;
            }
            else if (txtApa.Text != "" && cmbApunits.Text != "" && cmbType.Text != "")
            {
                MessageBox.Show("Fail to create Apartment, Check the fields...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clear();
            }
            else
            {
                MessageBox.Show("Fail to create, All the fields are Missing...", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Question);
                clear();
            }
        }

        //Clear method to clear the field
        private void clear()
        {
            txtApa.Text = "";
            cmbApunits.Text = "";
            cmbType.Text = "";
            txtPhoe.Text = "";
            txtApa.Focus();
        }

        private void btnDEl_Click(object sender, EventArgs e)
        {
            //Get the Apart Id from Form which we want to delete
            a.Apartment_ID = txtApa.Text;
            
            //Creating boolean varialble to delete the apartment
            bool success = dal.Delete(a);

            //If data is deleted then the value of success will be true, else it will be false
            if (success == true)
            {
                //Apart successfuly deleted
                MessageBox.Show("Apart Successfully Deleted", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();
            }
            else
            {
                //Failed to delete
                MessageBox.Show("Failed to Delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Refreshing data gridview
            DataTable dt = dal.Select();
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Finding the Row Index of the Row Clicked on datagridview
            int RowIndex = e.RowIndex;
            txtApa.Text = dataGridView1.Rows[RowIndex].Cells[0].Value.ToString();
            cmbApunits.Text = dataGridView1.Rows[RowIndex].Cells[1].Value.ToString();
            cmbType.Text = dataGridView1.Rows[RowIndex].Cells[2].Value.ToString();
            txtPhoe.Text = dataGridView1.Rows[RowIndex].Cells[3].Value.ToString();
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtApa.Text != "" && cmbApunits.Text != "" && cmbType.Text != "" && txtPhoe.Text != "")
            {   //Get the values from the apartment form
                a.Apartment_ID = txtApa.Text;
                a.Apartment_Units = cmbApunits.Text;
                a.Apartment_Type = cmbType.Text;
                a.Phone_No = int.Parse(txtPhoe.Text);

                //Updating data into database
                bool success = dal.Update(a);
                // if data is updated successfully then the vale of success will be true, else it will be false
                if (success == true)
                {
                    //Apart successfuly Updated
                    MessageBox.Show("Apart Successfully Updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                }
                else
                {
                    //Failed to update Apart
                    MessageBox.Show("Failed to Update");
                }

                //Refreshing data gridview
                DataTable dt = dal.Select();
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Fail to update, Fields are Missing...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clear();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //Get Keyword from of text
            string keywords = txtSearch.Text;

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
