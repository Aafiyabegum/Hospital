using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apartment_AD
{
    public partial class DashboardTenant : Form
    {
        public DashboardTenant()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPa_Click(object sender, EventArgs e)
        {
            this.Hide();
            Te_Payment Te = new Te_Payment();
            Te.Show();
        }

        private void DashboardTenant_Load_1(object sender, EventArgs e)
        {
            btnOw.Enabled = false;
            btnAp.Enabled = false;
            btnTe.Enabled = false;
            btnPro.Enabled = false;

            lbllogged.Text = LogIn.loggedIn;

            lbltime.Text = DateTime.Now.ToLongTimeString();
            lbldate.Text = DateTime.Now.ToLongDateString();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltime.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void DashboardTenant_FormClosed(object sender, FormClosedEventArgs e)
        {
            LogIn log = new LogIn();
            log.Show();
            this.Hide();
        }
    }
}
