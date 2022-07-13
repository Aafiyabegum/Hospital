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
    public partial class Owner : Form
    {
        public Owner()
        {
            InitializeComponent();
        }
     
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Creating objects for our class like for BLL and DAL
        OwnerBLL o = new OwnerBLL();
        OwnerDAL dal = new OwnerDAL();

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "" && txtName.Text != "" && txtFamily.Text != "" && txtmail.Text != "" && txtphone.Text != "" && cmbApunits.Text != "" && cmbApart.Text != "")
            {
                //Getting data from UI, UI means user interface
                o.Owner_ID = txtID.Text;
                o.Owner_Name = txtName.Text;
                o.No_of_members_in_family = txtFamily.Text;
                o.Apartment_Units = cmbApunits.Text;
                o.Apartment_Type = cmbApart.Text;
                o.Phone_No = int.Parse(txtphone.Text);
                o.Mail_ID = txtmail.Text;

                //Inserting data into database
                bool success = dal.Insert(o);
                //If the data is successfully created then the value of success will be true else, it will be false
                if (success == true)
                {
                    //Owner successfuly created
                    MessageBox.Show("Owner Successfully Created", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                }
                else
                {
                    //Failed to create Owner
                    MessageBox.Show("Failed to create");
                }

                //Refreshing data gridview
                DataTable dt = dal.Select();
                dataGridView1.DataSource = dt;
            }
            else if (txtID.Text != "" && txtName.Text != "" && txtFamily.Text != "" && txtmail.Text != "")
            {
                MessageBox.Show("Fail to create Owner, Check the fields...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clear();
            }
            else
            {
                MessageBox.Show("Fail to create Owner, All the fields are Missing...", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Question);
                clear();
            }
        }

        private void btnDEl_Click(object sender, EventArgs e)
        {
            //Get the Owner Id from Form
            o.Owner_ID = txtID.Text;
            bool success = dal.Delete(o);

            //if data is deleted then the value of success will be true, else it will be false
            if (success == true)
            {
                //Owner successfuly deleted
                MessageBox.Show("Owner Successfully Deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();
            }
            else
            {
                //Failed to delete
                MessageBox.Show("Failed to delete, fields are empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Refreshing data gridview
            DataTable dt = dal.Select();
            dataGridView1.DataSource = dt;
        }

        private void Owner_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'apartmentDataSet9.Owner' table. You can move, or remove it, as needed.
            //this.ownerTableAdapter.Fill(this.apartmentDataSet9.Owner);
            
            DataTable dt = dal.Select();
            dataGridView1.DataSource = dt;
        }

        //Clear method to clear the field
        private void clear()
        {
            txtID.Text = "";
            txtName.Text = "";
            txtFamily.Text = "";
            cmbApunits.Text = "";
            txtphone.Text = "";
            txtmail.Text = "";
            cmbApart.Text = "";
            txtID.Focus();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "" && txtName.Text != "" && txtFamily.Text != "" && txtmail.Text != "" && txtphone.Text != "" && cmbApunits.Text != "" && cmbApart.Text != "")
            {
                //Get the values from User UI
                o.Owner_ID = txtID.Text;
                o.Owner_Name = txtName.Text;
                o.No_of_members_in_family = txtFamily.Text;
                o.Apartment_Units = cmbApunits.Text;
                o.Apartment_Type = cmbApart.Text;
                o.Phone_No = int.Parse(txtphone.Text);
                o.Mail_ID = txtmail.Text;

                //Updating data into database
                bool success = dal.Update(o);
                // if data is updated successfully then the vale of success will be true, else it will be false
                if (success == true)
                {
                    //Owner successfuly Updated
                    MessageBox.Show("Owner Successfully Updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                }
                else
                {
                    //Failed to update Owner
                    MessageBox.Show("Failed to update");
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

        private void btnADM_Click_1(object sender, EventArgs e)
        {
            Dashboard frm = new Dashboard();
            frm.Show();
            this.Hide();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Get the details of particular row
            int rowIndex = e.RowIndex;
            txtID.Text = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
            txtName.Text = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
            cmbApunits.Text = dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
            txtFamily.Text = dataGridView1.Rows[rowIndex].Cells[3].Value.ToString();
            cmbApart.Text = dataGridView1.Rows[rowIndex].Cells[4].Value.ToString();
            txtphone.Text = dataGridView1.Rows[rowIndex].Cells[5].Value.ToString();
            txtmail.Text = dataGridView1.Rows[rowIndex].Cells[6].Value.ToString();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //Get Keyword from of text
            string keywords = txtSearch.Text;

            //Check if the keywords has value or not
            if (keywords != null)
            {
                //Show owner based on keywords
                DataTable dt = dal.Search(keywords);
                dataGridView1.DataSource = dt;
            }
            else
            {
                //Show all owner from the database
                DataTable dt = dal.Select();
                dataGridView1.DataSource = dt;
            }
        }
    }
}
