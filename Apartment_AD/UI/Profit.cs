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
    public partial class Profit : Form
    {
        public Profit()
        {
            InitializeComponent();
        }

        private void ProfitSum_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'apartmentDataSet5.Payment' table. You can move, or remove it, as needed.
            this.paymentTableAdapter1.Fill(this.apartmentDataSet5.Payment);
            // TODO: This line of code loads data into the 'apartmentDataSet4.Payment' table. You can move, or remove it, as needed.
            this.paymentTableAdapter.Fill(this.apartmentDataSet4.Payment);
            
            int sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
            }

            lblRe.Text = sum.ToString();

            int sum1 = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                sum1 += Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value);
            }

            lblMai.Text = sum1.ToString();

            txtSumProfit.Text = (sum + sum1).ToString();  
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnADM_Click(object sender, EventArgs e)
        {
            Dashboard frm = new Dashboard();
            frm.Show();
            this.Hide();
        }
    }
}