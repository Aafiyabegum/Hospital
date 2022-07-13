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
    public partial class Paid_Details : Form
    {
        public Paid_Details()
        {
            InitializeComponent();
        }

        private void btnPayme_Click(object sender, EventArgs e)
        {
            Payment frm = new Payment();
            frm.Show();
            this.Hide();
        }

        private void Paid_Details_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'apartmentDataSet8.Payment' table. You can move, or remove it, as needed.
            this.paymentTableAdapter.Fill(this.apartmentDataSet8.Payment);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
