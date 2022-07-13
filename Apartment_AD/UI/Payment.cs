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
using Apartment_AD.BLL;
using Apartment_AD.DAL;

namespace Apartment_AD
{
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        InvoiceBLL i = new InvoiceBLL();
        //PaymentBLL p = new PaymentBLL();
        InvoiceDAL dal = new InvoiceDAL();

        
        private void btnADM_Click(object sender, EventArgs e)
        {
            Dashboard frm = new Dashboard();
            frm.Show();
            this.Hide();
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'apartmentDataSet.Invoice' table. You can move, or remove it, as needed.
            this.invoiceTableAdapter.Fill(this.apartmentDataSet.Invoice);
            // TODO: This line of code loads data into the 'apartmentDataSet6.Invoice' table. You can move, or remove it, as needed.
            //this.invoiceTableAdapter.Fill(this.apartmentDataSet6.Invoice);
            DataTable dt = dal.Select();
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttnInCreate_Click(object sender, EventArgs e)
        {
            if (txtPay.Text != "" && txtTeId.Text != "" && txtReFee.Text != "" && txtMaFee.Text != "" && txtDuAm.Text != "")
            {
                i.Invoice_ID = txtPay.Text;
                i.Tenant_ID = txtTeId.Text;
                i.Rent_Fee = txtReFee.Text;
                i.Maintenance_Fee = txtMaFee.Text;
                i.Due_Amount = txtDuAm.Text;

                //Inserting data into database
                bool success = dal.Insert(i);
                if (success == true)
                {
                    //Invoice successfuly created
                    MessageBox.Show("Invoice Successfully Created", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                }
                else
                {
                    //Failed to create Invoice
                    MessageBox.Show("Failed to create");
                }

                //Refreshing data gridview
                DataTable dt = dal.Select();
                dataGridView1.DataSource = dt;
            }
            else if (txtPay.Text != "" && txtTeId.Text != "" && txtReFee.Text != "")
            {
                MessageBox.Show("Fail to create Invoice, Check the fields...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clear();
            }
            else
            {
                MessageBox.Show("Fail to create Invoice, All the fields are Empty...", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Question);
                clear();
            }
        }

        private void clear()
        {
            txtPay.Text = "";
            txtTeId.Text = "";
            txtReFee.Text = "";
            txtMaFee.Text = "";
            txtDuAm.Text = "";
            txtPay.Focus();
        }

        private void btnInUpd_Click(object sender, EventArgs e)
        {
            if (txtPay.Text != "" && txtTeId.Text != "" && txtReFee.Text != "" && txtMaFee.Text != "" && txtDuAm.Text != "")
            {   
                //Get the values from User UI
                i.Invoice_ID = txtPay.Text;
                i.Tenant_ID = txtTeId.Text;
                i.Rent_Fee = txtReFee.Text;
                i.Maintenance_Fee = txtMaFee.Text;
                i.Due_Amount = txtDuAm.Text;

                //Updating data into database
                bool success = dal.Update(i);
                // if data is updated successfully then the vale of success will be true, else it will be false
                if (success == true)
                {
                    //Invoice successfuly Updated
                    MessageBox.Show("Invoice Successfully Updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                }
                else
                {
                    //Failed to update Invoice
                    MessageBox.Show("Failed to update");
                    clear();
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

        private void btnViewpaid_Click(object sender, EventArgs e)
        {
            Paid_Details frm = new Paid_Details();
            frm.Show();
            this.Hide();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Get the details of particular row
            int rowIndex = e.RowIndex;
            txtPay.Text = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
            txtTeId.Text = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
            txtReFee.Text = dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
            txtMaFee.Text = dataGridView1.Rows[rowIndex].Cells[3].Value.ToString();
            txtDuAm.Text = dataGridView1.Rows[rowIndex].Cells[4].Value.ToString();
        }

        private void bttnInDele_Click(object sender, EventArgs e)
        {
            //Get the Owner Id from Form
            i.Invoice_ID = txtPay.Text;
            bool success = dal.Delete(i);

            //if data is deleted then the value of success will be true, else it will be false
            if (success == true)
            {
                //Invoice successfuly deleted
                MessageBox.Show("Invoice Successfully Deleted", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();
            }
            else
            {
                //Failed to delete
                MessageBox.Show("Fail to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Refreshing data gridview
            DataTable dt = dal.Select();
            dataGridView1.DataSource = dt;
        }

        private void btnPAY_Click(object sender, EventArgs e)
        {
            if (txtPay.Text != "" && txtTeId.Text != "" && txtReFee.Text != "" && txtMaFee.Text != "" && txtDuAm.Text != "")
            {
                i.Payment_ID = txtPay.Text;
                i.Tenant_ID = txtTeId.Text;
                i.Rent_Fee = txtReFee.Text;
                i.Maintenance_Fee = txtMaFee.Text;
                i.Due_Amount = txtDuAm.Text;

                //Inserting data into database
                bool success = dal.Pay(i);
                if (success == true)
                {
                    //Invoice successfuly created
                    MessageBox.Show("Successfully Paid", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                }
                else
                {
                    //Failed to create Invoice
                    MessageBox.Show("Failed to pay");
                    clear();
                }

                //Refreshing data gridview
                DataTable dt = dal.Select();
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Fail to Pay Invoice, Fields are Missing...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clear();
            }

        }

        private void txttenant_TextChanged(object sender, EventArgs e)
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
