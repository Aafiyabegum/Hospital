namespace Apartment_AD
{
    partial class Te_Payment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Te_Payment));
            this.lblSearch = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txttenant = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.invoiceIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenantIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentFeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maintenanceFeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dueAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.apartmentDataSet7 = new Apartment_AD.ApartmentDataSet7();
            this.btnTE = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.invoiceTableAdapter = new Apartment_AD.ApartmentDataSet7TableAdapters.InvoiceTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(-389, 106);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(179, 23);
            this.lblSearch.TabIndex = 48;
            this.lblSearch.Text = "Search by Tenant ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Broadway", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-16, -126);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(442, 32);
            this.label1.TabIndex = 45;
            this.label1.Text = "Payment Details of Tenant";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-188, -174);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // txttenant
            // 
            this.txttenant.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttenant.Location = new System.Drawing.Point(237, 151);
            this.txttenant.Name = "txttenant";
            this.txttenant.Size = new System.Drawing.Size(627, 34);
            this.txttenant.TabIndex = 55;
            this.txttenant.TextChanged += new System.EventHandler(this.txttenant_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(23, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 23);
            this.label2.TabIndex = 54;
            this.label2.Text = "Search by Tenant ID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.invoiceIDDataGridViewTextBoxColumn,
            this.tenantIDDataGridViewTextBoxColumn,
            this.rentFeeDataGridViewTextBoxColumn,
            this.maintenanceFeeDataGridViewTextBoxColumn,
            this.dueAmountDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.invoiceBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(26, 191);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(844, 186);
            this.dataGridView1.TabIndex = 53;
            // 
            // invoiceIDDataGridViewTextBoxColumn
            // 
            this.invoiceIDDataGridViewTextBoxColumn.DataPropertyName = "Invoice_ID";
            this.invoiceIDDataGridViewTextBoxColumn.HeaderText = "Invoice_ID";
            this.invoiceIDDataGridViewTextBoxColumn.Name = "invoiceIDDataGridViewTextBoxColumn";
            this.invoiceIDDataGridViewTextBoxColumn.Width = 150;
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
            // invoiceBindingSource
            // 
            this.invoiceBindingSource.DataMember = "Invoice";
            this.invoiceBindingSource.DataSource = this.apartmentDataSet7;
            // 
            // apartmentDataSet7
            // 
            this.apartmentDataSet7.DataSetName = "ApartmentDataSet7";
            this.apartmentDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnTE
            // 
            this.btnTE.FlatAppearance.BorderSize = 0;
            this.btnTE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnTE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTE.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTE.ForeColor = System.Drawing.Color.White;
            this.btnTE.Location = new System.Drawing.Point(688, 383);
            this.btnTE.Name = "btnTE";
            this.btnTE.Size = new System.Drawing.Size(183, 32);
            this.btnTE.TabIndex = 52;
            this.btnTE.Text = "Back to TENANT";
            this.btnTE.UseVisualStyleBackColor = true;
            this.btnTE.Click += new System.EventHandler(this.btnTE_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Broadway", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(271, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(413, 32);
            this.label3.TabIndex = 51;
            this.label3.Text = "Invoice Details of Tenant";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(146, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 50;
            this.pictureBox2.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(838, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(32, 32);
            this.btnClose.TabIndex = 49;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // invoiceTableAdapter
            // 
            this.invoiceTableAdapter.ClearBeforeFill = true;
            // 
            // Te_Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(180)))));
            this.ClientSize = new System.Drawing.Size(876, 429);
            this.Controls.Add(this.txttenant);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnTE);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Te_Payment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Te_Payment";
            this.Load += new System.EventHandler(this.Te_Payment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txttenant;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnTE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnClose;
        private ApartmentDataSet7 apartmentDataSet7;
        private System.Windows.Forms.BindingSource invoiceBindingSource;
        private ApartmentDataSet7TableAdapters.InvoiceTableAdapter invoiceTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenantIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentFeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maintenanceFeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dueAmountDataGridViewTextBoxColumn;
    }
}