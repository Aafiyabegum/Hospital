namespace Apartment_AD
{
    partial class Paid_Details
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Paid_Details));
            this.btnClose = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.paymentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenantIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentFeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maintenanceFeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dueAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.apartmentDataSet8 = new Apartment_AD.ApartmentDataSet8();
            this.btnPayme = new System.Windows.Forms.Button();
            this.paymentTableAdapter = new Apartment_AD.ApartmentDataSet8TableAdapters.PaymentTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentDataSet8)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(858, 1);
            this.btnClose.Margin = new System.Windows.Forms.Padding(5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(44, 46);
            this.btnClose.TabIndex = 50;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Broadway", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(370, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(371, 32);
            this.label3.TabIndex = 53;
            this.label3.Text = "Paid Details of Tenant";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(222, 25);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(138, 144);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 52;
            this.pictureBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.paymentIDDataGridViewTextBoxColumn,
            this.tenantIDDataGridViewTextBoxColumn,
            this.rentFeeDataGridViewTextBoxColumn,
            this.maintenanceFeeDataGridViewTextBoxColumn,
            this.dueAmountDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.paymentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(49, 195);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(844, 186);
            this.dataGridView1.TabIndex = 55;
            // 
            // paymentIDDataGridViewTextBoxColumn
            // 
            this.paymentIDDataGridViewTextBoxColumn.DataPropertyName = "Payment_ID";
            this.paymentIDDataGridViewTextBoxColumn.HeaderText = "Payment_ID";
            this.paymentIDDataGridViewTextBoxColumn.Name = "paymentIDDataGridViewTextBoxColumn";
            this.paymentIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // tenantIDDataGridViewTextBoxColumn
            // 
            this.tenantIDDataGridViewTextBoxColumn.DataPropertyName = "Tenant_ID";
            this.tenantIDDataGridViewTextBoxColumn.HeaderText = "Tenant_ID";
            this.tenantIDDataGridViewTextBoxColumn.Name = "tenantIDDataGridViewTextBoxColumn";
            this.tenantIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // rentFeeDataGridViewTextBoxColumn
            // 
            this.rentFeeDataGridViewTextBoxColumn.DataPropertyName = "Rent_Fee";
            this.rentFeeDataGridViewTextBoxColumn.HeaderText = "Rent_Fee";
            this.rentFeeDataGridViewTextBoxColumn.Name = "rentFeeDataGridViewTextBoxColumn";
            this.rentFeeDataGridViewTextBoxColumn.Width = 150;
            // 
            // maintenanceFeeDataGridViewTextBoxColumn
            // 
            this.maintenanceFeeDataGridViewTextBoxColumn.DataPropertyName = "Maintenance_Fee";
            this.maintenanceFeeDataGridViewTextBoxColumn.HeaderText = "Maintenance_Fee";
            this.maintenanceFeeDataGridViewTextBoxColumn.Name = "maintenanceFeeDataGridViewTextBoxColumn";
            this.maintenanceFeeDataGridViewTextBoxColumn.Width = 200;
            // 
            // dueAmountDataGridViewTextBoxColumn
            // 
            this.dueAmountDataGridViewTextBoxColumn.DataPropertyName = "Due_Amount";
            this.dueAmountDataGridViewTextBoxColumn.HeaderText = "Due_Amount";
            this.dueAmountDataGridViewTextBoxColumn.Name = "dueAmountDataGridViewTextBoxColumn";
            this.dueAmountDataGridViewTextBoxColumn.Width = 150;
            // 
            // paymentBindingSource
            // 
            this.paymentBindingSource.DataMember = "Payment";
            this.paymentBindingSource.DataSource = this.apartmentDataSet8;
            // 
            // apartmentDataSet8
            // 
            this.apartmentDataSet8.DataSetName = "ApartmentDataSet8";
            this.apartmentDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnPayme
            // 
            this.btnPayme.FlatAppearance.BorderSize = 0;
            this.btnPayme.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnPayme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayme.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayme.ForeColor = System.Drawing.Color.White;
            this.btnPayme.Location = new System.Drawing.Point(695, 391);
            this.btnPayme.Margin = new System.Windows.Forms.Padding(5);
            this.btnPayme.Name = "btnPayme";
            this.btnPayme.Size = new System.Drawing.Size(197, 34);
            this.btnPayme.TabIndex = 54;
            this.btnPayme.Text = "Back to PAYMENT";
            this.btnPayme.UseVisualStyleBackColor = true;
            this.btnPayme.Click += new System.EventHandler(this.btnPayme_Click);
            // 
            // paymentTableAdapter
            // 
            this.paymentTableAdapter.ClearBeforeFill = true;
            // 
            // Paid_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(180)))));
            this.ClientSize = new System.Drawing.Size(906, 438);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnPayme);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnClose);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Paid_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paid_Details";
            this.Load += new System.EventHandler(this.Paid_Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentDataSet8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnPayme;
        private ApartmentDataSet8 apartmentDataSet8;
        private System.Windows.Forms.BindingSource paymentBindingSource;
        private ApartmentDataSet8TableAdapters.PaymentTableAdapter paymentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenantIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentFeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maintenanceFeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dueAmountDataGridViewTextBoxColumn;
    }
}