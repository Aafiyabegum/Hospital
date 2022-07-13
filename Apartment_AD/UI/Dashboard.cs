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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAp_Click(object sender, EventArgs e)
        {
            this.Hide();
            Apart ap = new Apart();
            ap.Show();
        }

        private void btnOw_Click(object sender, EventArgs e)
        {
            this.Hide();
            Owner ow = new Owner();
            ow.Show();
        }

        private void btnTe_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tenant Te = new Tenant();
            Te.Show();
        }

        private void btnPa_Click(object sender, EventArgs e)
        {
            this.Hide();
            Payment Te = new Payment();
            Te.Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            lbllogged.Text = LogIn.loggedIn;

            lbltime.Text = DateTime.Now.ToLongTimeString();
            lbldate.Text = DateTime.Now.ToLongDateString();
            timer1.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Profit Te = new Profit();
            Te.Show();
        }

        private void btnREPORT_Click(object sender, EventArgs e)
        {
            this.Hide();
            Report Re = new Report();
            Re.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltime.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
            
        }

        private void btnhelp_Click(object sender, EventArgs e)
        {
            this.Hide();
            HelpDe hel = new HelpDe();
            hel.Show();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            this.Hide();
            AboutUs abou = new AboutUs();
            abou.Show();
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            LogIn log = new LogIn();
            log.Show();
            this.Hide();
        }
    }
}
