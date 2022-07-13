namespace Apartment_AD
{
    partial class Profit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profit));
            this.lbltotal = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Tenant_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentFeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maintenanceFeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.apartmentDataSet5 = new Apartment_AD.ApartmentDataSet5();
            this.paymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.apartmentDataSet4 = new Apartment_AD.ApartmentDataSet4();
            this.paymentTableAdapter = new Apartment_AD.ApartmentDataSet4TableAdapters.PaymentTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.paymentTableAdapter1 = new Apartment_AD.ApartmentDataSet5TableAdapters.PaymentTableAdapter();
            this.txtSumProfit = new System.Windows.Forms.TextBox();
            this.lblRe = new System.Windows.Forms.Label();
            this.lblMai = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnADM = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.ForeColor = System.Drawing.Color.White;
            this.lbltotal.Location = new System.Drawing.Point(281, 487);
            this.lbltotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(145, 28);
            this.lbltotal.TabIndex = 4;
            this.lbltotal.Text = "Total Profit:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tenant_ID,
            this.rentFeeDataGridViewTextBoxColumn,
            this.maintenanceFeeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.paymentBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(93, 155);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(420, 216);
            this.dataGridView1.TabIndex = 3;
            // 
            // Tenant_ID
            // 
            this.Tenant_ID.DataPropertyName = "Tenant_ID";
            this.Tenant_ID.HeaderText = "Tenant_ID";
            this.Tenant_ID.Name = "Tenant_ID";
            // 
            // rentFeeDataGridViewTextBoxColumn
            // 
            this.rentFeeDataGridViewTextBoxColumn.DataPropertyName = "Rent_Fee";
            this.rentFeeDataGridViewTextBoxColumn.HeaderText = "Rent_Fee";
            this.rentFeeDataGridViewTextBoxColumn.Name = "rentFeeDataGridViewTextBoxColumn";
            // 
            // maintenanceFeeDataGridViewTextBoxColumn
            // 
            this.maintenanceFeeDataGridViewTextBoxColumn.DataPropertyName = "Maintenance_Fee";
            this.maintenanceFeeDataGridViewTextBoxColumn.HeaderText = "Maintenance_Fee";
            this.maintenanceFeeDataGridViewTextBoxColumn.Name = "maintenanceFeeDataGridViewTextBoxColumn";
            this.maintenanceFeeDataGridViewTextBoxColumn.Width = 200;
            // 
            // paymentBindingSource1
            // 
            this.paymentBindingSource1.DataMember = "Payment";
            this.paymentBindingSource1.DataSource = this.apartmentDataSet5;
            // 
            // apartmentDataSet5
            // 
            this.apartmentDataSet5.DataSetName = "ApartmentDataSet5";
            this.apartmentDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // paymentBindingSource
            // 
            this.paymentBindingSource.DataMember = "Payment";
            this.paymentBindingSource.DataSource = this.apartmentDataSet4;
            // 
            // apartmentDataSet4
            // 
            this.apartmentDataSet4.DataSetName = "ApartmentDataSet4";
            this.apartmentDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // paymentTableAdapter
            // 
            this.paymentTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(180)))));
            this.label1.Font = new System.Drawing.Font("Broadway", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(173, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Total Profit Details";
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(569, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(28, 30);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // paymentTableAdapter1
            // 
            this.paymentTableAdapter1.ClearBeforeFill = true;
            // 
            // txtSumProfit
            // 
            this.txtSumProfit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(180)))));
            this.txtSumProfit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSumProfit.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSumProfit.ForeColor = System.Drawing.Color.White;
            this.txtSumProfit.Location = new System.Drawing.Point(433, 484);
            this.txtSumProfit.Name = "txtSumProfit";
            this.txtSumProfit.Size = new System.Drawing.Size(152, 27);
            this.txtSumProfit.TabIndex = 8;
            // 
            // lblRe
            // 
            this.lblRe.AutoSize = true;
            this.lblRe.ForeColor = System.Drawing.Color.White;
            this.lblRe.Location = new System.Drawing.Point(215, 430);
            this.lblRe.Name = "lblRe";
            this.lblRe.Size = new System.Drawing.Size(21, 23);
            this.lblRe.TabIndex = 9;
            this.lblRe.Text = "0";
            // 
            // lblMai
            // 
            this.lblMai.AutoSize = true;
            this.lblMai.ForeColor = System.Drawing.Color.White;
            this.lblMai.Location = new System.Drawing.Point(364, 430);
            this.lblMai.Name = "lblMai";
            this.lblMai.Size = new System.Drawing.Size(21, 23);
            this.lblMai.TabIndex = 10;
            this.lblMai.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(180)))));
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(201, 388);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "Rent Total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(334, 388);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "Maintenance Total";
            // 
            // btnADM
            // 
            this.btnADM.FlatAppearance.BorderSize = 0;
            this.btnADM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnADM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnADM.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnADM.ForeColor = System.Drawing.Color.White;
            this.btnADM.Location = new System.Drawing.Point(12, 478);
            this.btnADM.Name = "btnADM";
            this.btnADM.Size = new System.Drawing.Size(167, 33);
            this.btnADM.TabIndex = 13;
            this.btnADM.Text = "Back to ADMIN";
            this.btnADM.UseVisualStyleBackColor = true;
            this.btnADM.Click += new System.EventHandler(this.btnADM_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(78, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // Profit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(180)))));
            this.ClientSize = new System.Drawing.Size(597, 524);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnADM);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblMai);
            this.Controls.Add(this.lblRe);
            this.Controls.Add(this.txtSumProfit);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Profit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profit";
            this.Load += new System.EventHandler(this.ProfitSum_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ApartmentDataSet4 apartmentDataSet4;
        private System.Windows.Forms.BindingSource paymentBindingSource;
        private ApartmentDataSet4TableAdapters.PaymentTableAdapter paymentTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private ApartmentDataSet5 apartmentDataSet5;
        private System.Windows.Forms.BindingSource paymentBindingSource1;
        private ApartmentDataSet5TableAdapters.PaymentTableAdapter paymentTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tenant_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentFeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maintenanceFeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtSumProfit;
        private System.Windows.Forms.Label lblRe;
        private System.Windows.Forms.Label lblMai;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnADM;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}