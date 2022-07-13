namespace Apartment_AD
{
    partial class Payment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment));
            this.label1 = new System.Windows.Forms.Label();
            this.btnADM = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.invoiceBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.apartmentDataSet = new Apartment_AD.ApartmentDataSet();
            this.invoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtReFee = new System.Windows.Forms.TextBox();
            this.txtTeId = new System.Windows.Forms.TextBox();
            this.txtPay = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtMaFee = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtDuAm = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPAY = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bttnInCreate = new System.Windows.Forms.Button();
            this.bttnInDele = new System.Windows.Forms.Button();
            this.btnInUpd = new System.Windows.Forms.Button();
            this.btnViewpaid = new System.Windows.Forms.Button();
            this.invoiceTableAdapter = new Apartment_AD.ApartmentDataSetTableAdapters.InvoiceTableAdapter();
            this.invoiceIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Broadway", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(325, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(427, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "Invoice Details of Tenants";
            // 
            // btnADM
            // 
            this.btnADM.FlatAppearance.BorderSize = 0;
            this.btnADM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnADM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnADM.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnADM.ForeColor = System.Drawing.Color.White;
            this.btnADM.Location = new System.Drawing.Point(705, 643);
            this.btnADM.Name = "btnADM";
            this.btnADM.Size = new System.Drawing.Size(161, 30);
            this.btnADM.TabIndex = 36;
            this.btnADM.Text = "Back to ADMIN";
            this.btnADM.UseVisualStyleBackColor = true;
            this.btnADM.Click += new System.EventHandler(this.btnADM_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.invoiceIDDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridView1.DataSource = this.invoiceBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(22, 439);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(844, 186);
            this.dataGridView1.TabIndex = 40;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // invoiceBindingSource1
            // 
            this.invoiceBindingSource1.DataMember = "Invoice";
            this.invoiceBindingSource1.DataSource = this.apartmentDataSet;
            // 
            // apartmentDataSet
            // 
            this.apartmentDataSet.DataSetName = "ApartmentDataSet";
            this.apartmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // invoiceBindingSource
            // 
            this.invoiceBindingSource.DataMember = "Invoice";
            // 
            // paymentBindingSource
            // 
            this.paymentBindingSource.DataMember = "Payment";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.ForeColor = System.Drawing.Color.White;
            this.lblSearch.Location = new System.Drawing.Point(33, 395);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(281, 23);
            this.lblSearch.TabIndex = 41;
            this.lblSearch.Text = "Search by Tenant_ID/Invoice_ID";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(317, 389);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(549, 34);
            this.txtSearch.TabIndex = 42;
            this.txtSearch.TextChanged += new System.EventHandler(this.txttenant_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(200, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // txtReFee
            // 
            this.txtReFee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtReFee.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReFee.ForeColor = System.Drawing.Color.Black;
            this.txtReFee.Location = new System.Drawing.Point(458, 263);
            this.txtReFee.Name = "txtReFee";
            this.txtReFee.Size = new System.Drawing.Size(270, 24);
            this.txtReFee.TabIndex = 52;
            // 
            // txtTeId
            // 
            this.txtTeId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTeId.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTeId.ForeColor = System.Drawing.Color.Black;
            this.txtTeId.Location = new System.Drawing.Point(458, 223);
            this.txtTeId.Name = "txtTeId";
            this.txtTeId.Size = new System.Drawing.Size(270, 24);
            this.txtTeId.TabIndex = 53;
            // 
            // txtPay
            // 
            this.txtPay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPay.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPay.ForeColor = System.Drawing.Color.Black;
            this.txtPay.Location = new System.Drawing.Point(458, 185);
            this.txtPay.Name = "txtPay";
            this.txtPay.Size = new System.Drawing.Size(270, 24);
            this.txtPay.TabIndex = 54;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(458, 291);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(270, 1);
            this.panel3.TabIndex = 48;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(458, 251);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(270, 1);
            this.panel2.TabIndex = 49;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(458, 213);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 1);
            this.panel1.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(251, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 23);
            this.label5.TabIndex = 44;
            this.label5.Text = "Maintenance Fee";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(251, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 23);
            this.label4.TabIndex = 45;
            this.label4.Text = "Rent Fee";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(251, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 23);
            this.label3.TabIndex = 46;
            this.label3.Text = "Tenant ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(251, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 23);
            this.label2.TabIndex = 47;
            this.label2.Text = "Invoice ID";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(458, 326);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(270, 1);
            this.panel4.TabIndex = 48;
            // 
            // txtMaFee
            // 
            this.txtMaFee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaFee.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaFee.ForeColor = System.Drawing.Color.Black;
            this.txtMaFee.Location = new System.Drawing.Point(458, 298);
            this.txtMaFee.Name = "txtMaFee";
            this.txtMaFee.Size = new System.Drawing.Size(270, 24);
            this.txtMaFee.TabIndex = 52;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(458, 361);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(270, 1);
            this.panel5.TabIndex = 48;
            // 
            // txtDuAm
            // 
            this.txtDuAm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDuAm.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDuAm.ForeColor = System.Drawing.Color.Black;
            this.txtDuAm.Location = new System.Drawing.Point(458, 333);
            this.txtDuAm.Name = "txtDuAm";
            this.txtDuAm.Size = new System.Drawing.Size(270, 24);
            this.txtDuAm.TabIndex = 52;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(251, 339);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 23);
            this.label6.TabIndex = 44;
            this.label6.Text = "Due Amount";
            // 
            // btnPAY
            // 
            this.btnPAY.FlatAppearance.BorderSize = 0;
            this.btnPAY.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnPAY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPAY.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPAY.ForeColor = System.Drawing.Color.White;
            this.btnPAY.Location = new System.Drawing.Point(771, 252);
            this.btnPAY.Name = "btnPAY";
            this.btnPAY.Size = new System.Drawing.Size(83, 35);
            this.btnPAY.TabIndex = 55;
            this.btnPAY.Text = "PAY";
            this.btnPAY.UseVisualStyleBackColor = true;
            this.btnPAY.Click += new System.EventHandler(this.btnPAY_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(843, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 32);
            this.button1.TabIndex = 59;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bttnInCreate
            // 
            this.bttnInCreate.FlatAppearance.BorderSize = 0;
            this.bttnInCreate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.bttnInCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnInCreate.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnInCreate.ForeColor = System.Drawing.Color.Black;
            this.bttnInCreate.Location = new System.Drawing.Point(12, 205);
            this.bttnInCreate.Name = "bttnInCreate";
            this.bttnInCreate.Size = new System.Drawing.Size(151, 31);
            this.bttnInCreate.TabIndex = 60;
            this.bttnInCreate.Text = "Create Invoice";
            this.bttnInCreate.UseVisualStyleBackColor = true;
            this.bttnInCreate.Click += new System.EventHandler(this.bttnInCreate_Click);
            // 
            // bttnInDele
            // 
            this.bttnInDele.FlatAppearance.BorderSize = 0;
            this.bttnInDele.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.bttnInDele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnInDele.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnInDele.ForeColor = System.Drawing.Color.Black;
            this.bttnInDele.Location = new System.Drawing.Point(12, 242);
            this.bttnInDele.Name = "bttnInDele";
            this.bttnInDele.Size = new System.Drawing.Size(151, 35);
            this.bttnInDele.TabIndex = 60;
            this.bttnInDele.Text = "Delete Invoice";
            this.bttnInDele.UseVisualStyleBackColor = true;
            this.bttnInDele.Click += new System.EventHandler(this.bttnInDele_Click);
            // 
            // btnInUpd
            // 
            this.btnInUpd.FlatAppearance.BorderSize = 0;
            this.btnInUpd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnInUpd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInUpd.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInUpd.ForeColor = System.Drawing.Color.Black;
            this.btnInUpd.Location = new System.Drawing.Point(8, 287);
            this.btnInUpd.Name = "btnInUpd";
            this.btnInUpd.Size = new System.Drawing.Size(166, 31);
            this.btnInUpd.TabIndex = 60;
            this.btnInUpd.Text = "Update Invoice";
            this.btnInUpd.UseVisualStyleBackColor = true;
            this.btnInUpd.Click += new System.EventHandler(this.btnInUpd_Click);
            // 
            // btnViewpaid
            // 
            this.btnViewpaid.FlatAppearance.BorderSize = 0;
            this.btnViewpaid.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnViewpaid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewpaid.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewpaid.ForeColor = System.Drawing.Color.Black;
            this.btnViewpaid.Location = new System.Drawing.Point(12, 332);
            this.btnViewpaid.Name = "btnViewpaid";
            this.btnViewpaid.Size = new System.Drawing.Size(186, 34);
            this.btnViewpaid.TabIndex = 61;
            this.btnViewpaid.Text = "View Paid Tenants";
            this.btnViewpaid.UseVisualStyleBackColor = true;
            this.btnViewpaid.Click += new System.EventHandler(this.btnViewpaid_Click);
            // 
            // invoiceTableAdapter
            // 
            this.invoiceTableAdapter.ClearBeforeFill = true;
            // 
            // invoiceIDDataGridViewTextBoxColumn
            // 
            this.invoiceIDDataGridViewTextBoxColumn.DataPropertyName = "Invoice_ID";
            this.invoiceIDDataGridViewTextBoxColumn.HeaderText = "Invoice_ID";
            this.invoiceIDDataGridViewTextBoxColumn.Name = "invoiceIDDataGridViewTextBoxColumn";
            this.invoiceIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Tenant_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Tenant_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Rent_Fee";
            this.dataGridViewTextBoxColumn2.HeaderText = "Rent_Fee";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Maintenance_Fee";
            this.dataGridViewTextBoxColumn3.HeaderText = "Maintenance_Fee";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 250;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Due_Amount";
            this.dataGridViewTextBoxColumn4.HeaderText = "Due_Amount";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(180)))));
            this.ClientSize = new System.Drawing.Size(875, 685);
            this.Controls.Add(this.btnViewpaid);
            this.Controls.Add(this.btnInUpd);
            this.Controls.Add(this.bttnInDele);
            this.Controls.Add(this.bttnInCreate);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPAY);
            this.Controls.Add(this.txtDuAm);
            this.Controls.Add(this.txtMaFee);
            this.Controls.Add(this.txtReFee);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.txtTeId);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.txtPay);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnADM);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Payment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.Payment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnADM;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        //private ApartmentDataSet apartmentDataSet;
        private System.Windows.Forms.BindingSource paymentBindingSource;
        //private ApartmentDataSetTableAdapters.PaymentTableAdapter paymentTableAdapter;
        private System.Windows.Forms.TextBox txtReFee;
        private System.Windows.Forms.TextBox txtTeId;
        private System.Windows.Forms.TextBox txtPay;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtMaFee;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtDuAm;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnPAY;
        private System.Windows.Forms.Button button1;
        //private ApartmentDataSet6 apartmentDataSet6;
        private System.Windows.Forms.BindingSource invoiceBindingSource;
        //private ApartmentDataSet6TableAdapters.InvoiceTableAdapter invoiceTableAdapter;
        //private System.Windows.Forms.DataGridViewTextBoxColumn tenantIDDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn rentFeeDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn maintenanceFeeDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dueAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button bttnInCreate;
        private System.Windows.Forms.Button bttnInDele;
        private System.Windows.Forms.Button btnInUpd;
        private System.Windows.Forms.Button btnViewpaid;
        private ApartmentDataSet apartmentDataSet;
        private System.Windows.Forms.BindingSource invoiceBindingSource1;
        private ApartmentDataSetTableAdapters.InvoiceTableAdapter invoiceTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}