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
using Apartment_AD.DLL;

namespace Apartment_AD
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        loginBLL l = new loginBLL();
        loginDAL dal = new loginDAL();
        public static string loggedIn;

        private void btnLogin_Click(object sender, EventArgs e)
        {    
            string username = txtUsername.Text;
            string password = txtpassword.Text;

            l.username = txtUsername.Text.Trim();
            l.password = txtpassword.Text.Trim();
            l.usertype = cmbBxUser.Text.Trim();

            bool success = dal.loginCheck(l);
            if (success == true)
            {
                MessageBox.Show("Login Successfull...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loggedIn = l.usertype;
                switch(l.usertype)
                {
                    case "Admin":
                        {
                            Dashboard admin = new Dashboard();
                            admin.Show();
                            this.Hide();
                        }
                        break;
                    case "Tenant_Manager":
                        {
                            DashboardTenant tenant = new DashboardTenant();
                            tenant.Show();
                            this.Hide();
                        }
                        break;
                    case "Owner_Manager":
                        {
                            DashboardOwner owner = new DashboardOwner();
                            owner.Show();
                            this.Hide();
                        }
                        break;
                    default:
                        {
                            MessageBox.Show("Invalid usertype");
                        }
                        break;
                }
            }
            else if (username == ""&& password == "")
            {
                lbl_error1.Text = "Please Enter User name";
                lbl_error2.Text = "Please Enter Password";
                lblerror3.Text = "Please Select Usertype";
                MessageBox.Show("Fields are empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                lbl_error1.Text = "";
                lbl_error2.Text = "";
                lblerror3.Text = "";
            }
            else
            {
                MessageBox.Show("Login Failed...", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Clear();
                txtpassword.Clear();
                cmbBxUser.Text = "";
                txtUsername.Focus();
            }
        }

        private void lbl_Clear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtpassword.Clear();
            cmbBxUser.Text = "";
            txtUsername.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            //Tooltip comment to make easy
            toolTip1.SetToolTip(txtUsername,"Enter the Username");
            toolTip1.SetToolTip(txtpassword, "Enter the Password");
            toolTip1.SetToolTip(cmbBxUser,"Select the Usertype");
        }
    }
}
