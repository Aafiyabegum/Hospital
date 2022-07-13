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
    public partial class Tenant : Form
    {
        public Tenant()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        TenantBLL t = new TenantBLL();
        TenantDAL dal = new TenantDAL();

        private void btnCreat_Click(object sender, EventArgs e)
        {
            if (txtTID.Text != "" && txtTName.Text != "" && cmbApunits.Text != "" && cmbApatype.Text != "" && txtPhone.Text != "" && txtmail.Text != "")
            {
                t.Tenant_ID = txtTID.Text;
                t.Tenant_Name = txtTName.Text;
                t.Apartment_Units = cmbApunits.Text;
                t.Apartment_Type = cmbApatype.Text;
                t.Phone_No = int.Parse(txtPhone.Text);
                t.Mail_ID = txtmail.Text;

                //Inserting data into database
                bool success = dal.Insert(t);
                if (success == true)
                {
                    //Tenant successfuly created
                    MessageBox.Show("Tenant Successfully Created", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                }
                else
                {
                    //Failed to create Tenant
                    MessageBox.Show("Failed to create");
                }

                //Refreshing data gridview
                DataTable dt = dal.Select();
                dataGridView1.DataSource = dt;
            }
            else if (txtTID.Text != "" && txtTName.Text != "" && cmbApunits.Text != "" && cmbApatype.Text != "")
            {
                MessageBox.Show("Fail to create Tenant, Check the fields...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clear();
            }
            else
            {
                MessageBox.Show("Fail to create Tenant, All the fields are Empty...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Question);
                clear();
            }

        }

        //Clear method to clear the field
        private void clear()
        {
            txtTID.Text = "";
            txtTName.Text = "";
            cmbApunits.Text = "";
            cmbApatype.Text = "";
            txtPhone.Text = "";
            txtmail.Text = "";
            txtTID.Focus();
        }

        private void Tenant_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'apartmentDataSet12.Tenant' table. You can move, or remove it, as needed.
            this.tenantTableAdapter1.Fill(this.apartmentDataSet12.Tenant);
            // TODO: This line of code loads data into the 'apartmentDataSet11.Tenant' table. You can move, or remove it, as needed.
            //this.tenantTableAdapter.Fill(this.apartmentDataSet11.Tenant);
            DataTable dt = dal.Select();
            dataGridView1.DataSource = dt;
        }

        private void btnAdm_Click_1(object sender, EventArgs e)
        {
            Dashboard frm = new Dashboard();
            frm.Show();
            this.Hide();
        }

        private void btnDEl_Click(object sender, EventArgs e)
        {
            //Get the Tenant Id from Form
            t.Tenant_ID = txtTID.Text;
            bool success = dal.Delete(t);

            //if data is deleted then the value of success will be true, else it will be false
            if (success == true)
            {
                //Tenant successfuly deleted
                MessageBox.Show("Tenant Successfully Deleted", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();
            }
            else
            {
                //Failed to delete
                MessageBox.Show("Failed to delete");
            }

            //Refreshing data gridview
            DataTable dt = dal.Select();
            dataGridView1.DataSource = dt;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtTID.Text != "" && txtTName.Text != "" && cmbApunits.Text != "" && cmbApatype.Text != "" && txtPhone.Text != "" && txtmail.Text != "")
            {
                //Get the values from User UI
                t.Tenant_ID = txtTID.Text;
                t.Tenant_Name = txtTName.Text;
                t.Apartment_Units = cmbApunits.Text;
                t.Apartment_Type = cmbApatype.Text;
                t.Phone_No = int.Parse(txtPhone.Text);
                t.Mail_ID = txtmail.Text;

                //Updating data into database
                bool success = dal.Update(t);
                // if data is updated successfully then the vale of success will be true, else it will be false
                if (success == true)
                {
                    //Tenant successfuly Updated
                    MessageBox.Show("Tenant Successfully Updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                }
                else
                {
                    //Failed to update Tenant
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

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Get the details of particular row
            int rowIndex = e.RowIndex;
            txtTID.Text = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
            txtTName.Text = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
            cmbApunits.Text = dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
            cmbApatype.Text = dataGridView1.Rows[rowIndex].Cells[3].Value.ToString();
            txtPhone.Text = dataGridView1.Rows[rowIndex].Cells[4].Value.ToString();
            txtmail.Text = dataGridView1.Rows[rowIndex].Cells[5].Value.ToString();
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
