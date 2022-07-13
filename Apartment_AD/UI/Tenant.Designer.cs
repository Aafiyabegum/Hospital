namespace Apartment_AD
{
    partial class Tenant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tenant));
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbApatype = new System.Windows.Forms.ComboBox();
            this.txtmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtTName = new System.Windows.Forms.TextBox();
            this.txtTID = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCreat = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tenantIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenantNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apartmentUnitsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apartmentTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenantBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.apartmentDataSet12 = new Apartment_AD.ApartmentDataSet12();
            this.tenantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDEl = new System.Windows.Forms.Button();
            this.btnAdm = new System.Windows.Forms.Button();
            this.cmbApunits = new System.Windows.Forms.ComboBox();
            this.tenantTableAdapter1 = new Apartment_AD.ApartmentDataSet12TableAdapters.TenantTableAdapter();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenantBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenantBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(513, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(28, 30);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Broadway", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(178, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Create Tenant";
            // 
            // cmbApatype
            // 
            this.cmbApatype.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbApatype.FormattingEnabled = true;
            this.cmbApatype.Items.AddRange(new object[] {
            "Residential",
            "Commercial"});
            this.cmbApatype.Location = new System.Drawing.Point(240, 253);
            this.cmbApatype.Name = "cmbApatype";
            this.cmbApatype.Size = new System.Drawing.Size(237, 31);
            this.cmbApatype.TabIndex = 33;
            // 
            // txtmail
            // 
            this.txtmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtmail.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmail.ForeColor = System.Drawing.Color.Black;
            this.txtmail.Location = new System.Drawing.Point(241, 328);
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(236, 24);
            this.txtmail.TabIndex = 31;
            // 
            // txtPhone
            // 
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhone.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.ForeColor = System.Drawing.Color.Black;
            this.txtPhone.Location = new System.Drawing.Point(240, 294);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(236, 24);
            this.txtPhone.TabIndex = 30;
            // 
            // txtTName
            // 
            this.txtTName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTName.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTName.ForeColor = System.Drawing.Color.Black;
            this.txtTName.Location = new System.Drawing.Point(241, 183);
            this.txtTName.Name = "txtTName";
            this.txtTName.Size = new System.Drawing.Size(236, 24);
            this.txtTName.TabIndex = 27;
            // 
            // txtTID
            // 
            this.txtTID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTID.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTID.ForeColor = System.Drawing.Color.Black;
            this.txtTID.Location = new System.Drawing.Point(240, 151);
            this.txtTID.Name = "txtTID";
            this.txtTID.Size = new System.Drawing.Size(236, 24);
            this.txtTID.TabIndex = 26;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Location = new System.Drawing.Point(240, 358);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(236, 1);
            this.panel7.TabIndex = 23;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Location = new System.Drawing.Point(240, 321);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(236, 1);
            this.panel6.TabIndex = 25;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(240, 284);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(236, 1);
            this.panel5.TabIndex = 22;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(240, 248);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(236, 1);
            this.panel4.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(240, 213);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(236, 1);
            this.panel2.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(240, 177);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 1);
            this.panel1.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(38, 338);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 23);
            this.label8.TabIndex = 15;
            this.label8.Text = "Mail ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(38, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 23);
            this.label7.TabIndex = 14;
            this.label7.Text = "Phone No";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(38, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 23);
            this.label6.TabIndex = 13;
            this.label6.Text = "Apartment Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(38, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "Apartment Units";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(38, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 23);
            this.label3.TabIndex = 17;
            this.label3.Text = "Tenant Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(38, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tenant ID";
            // 
            // btnCreat
            // 
            this.btnCreat.FlatAppearance.BorderSize = 0;
            this.btnCreat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCreat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreat.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreat.ForeColor = System.Drawing.Color.White;
            this.btnCreat.Location = new System.Drawing.Point(24, 377);
            this.btnCreat.Name = "btnCreat";
            this.btnCreat.Size = new System.Drawing.Size(98, 30);
            this.btnCreat.TabIndex = 35;
            this.btnCreat.Text = "CREATE";
            this.btnCreat.UseVisualStyleBackColor = true;
            this.btnCreat.Click += new System.EventHandler(this.btnCreat_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(70, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenantIDDataGridViewTextBoxColumn,
            this.tenantNameDataGridViewTextBoxColumn,
            this.apartmentUnitsDataGridViewTextBoxColumn,
            this.apartmentTypeDataGridViewTextBoxColumn,
            this.phoneNoDataGridViewTextBoxColumn,
            this.mailIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tenantBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(10, 447);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(522, 212);
            this.dataGridView1.TabIndex = 37;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // tenantIDDataGridViewTextBoxColumn
            // 
            this.tenantIDDataGridViewTextBoxColumn.DataPropertyName = "Tenant_ID";
            this.tenantIDDataGridViewTextBoxColumn.HeaderText = "Tenant_ID";
            this.tenantIDDataGridViewTextBoxColumn.Name = "tenantIDDataGridViewTextBoxColumn";
            this.tenantIDDataGridViewTextBoxColumn.Width = 80;
            // 
            // tenantNameDataGridViewTextBoxColumn
            // 
            this.tenantNameDataGridViewTextBoxColumn.DataPropertyName = "Tenant_Name";
            this.tenantNameDataGridViewTextBoxColumn.HeaderText = "Tenant_Name";
            this.tenantNameDataGridViewTextBoxColumn.Name = "tenantNameDataGridViewTextBoxColumn";
            // 
            // apartmentUnitsDataGridViewTextBoxColumn
            // 
            this.apartmentUnitsDataGridViewTextBoxColumn.DataPropertyName = "Apartment_Units";
            this.apartmentUnitsDataGridViewTextBoxColumn.HeaderText = "Apartment_Units";
            this.apartmentUnitsDataGridViewTextBoxColumn.Name = "apartmentUnitsDataGridViewTextBoxColumn";
            this.apartmentUnitsDataGridViewTextBoxColumn.Width = 120;
            // 
            // apartmentTypeDataGridViewTextBoxColumn
            // 
            this.apartmentTypeDataGridViewTextBoxColumn.DataPropertyName = "Apartment_Type";
            this.apartmentTypeDataGridViewTextBoxColumn.HeaderText = "Apartment_Type";
            this.apartmentTypeDataGridViewTextBoxColumn.Name = "apartmentTypeDataGridViewTextBoxColumn";
            this.apartmentTypeDataGridViewTextBoxColumn.Width = 120;
            // 
            // phoneNoDataGridViewTextBoxColumn
            // 
            this.phoneNoDataGridViewTextBoxColumn.DataPropertyName = "Phone_No";
            this.phoneNoDataGridViewTextBoxColumn.HeaderText = "Phone_No";
            this.phoneNoDataGridViewTextBoxColumn.Name = "phoneNoDataGridViewTextBoxColumn";
            // 
            // mailIDDataGridViewTextBoxColumn
            // 
            this.mailIDDataGridViewTextBoxColumn.DataPropertyName = "Mail_ID";
            this.mailIDDataGridViewTextBoxColumn.HeaderText = "Mail_ID";
            this.mailIDDataGridViewTextBoxColumn.Name = "mailIDDataGridViewTextBoxColumn";
            // 
            // tenantBindingSource1
            // 
            this.tenantBindingSource1.DataMember = "Tenant";
            this.tenantBindingSource1.DataSource = this.apartmentDataSet12;
            // 
            // apartmentDataSet12
            // 
            this.apartmentDataSet12.DataSetName = "ApartmentDataSet12";
            this.apartmentDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tenantBindingSource
            // 
            this.tenantBindingSource.DataMember = "Tenant";
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(222, 377);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(97, 30);
            this.btnUpdate.TabIndex = 42;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDEl
            // 
            this.btnDEl.FlatAppearance.BorderSize = 0;
            this.btnDEl.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnDEl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDEl.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDEl.ForeColor = System.Drawing.Color.White;
            this.btnDEl.Location = new System.Drawing.Point(118, 380);
            this.btnDEl.Name = "btnDEl";
            this.btnDEl.Size = new System.Drawing.Size(98, 27);
            this.btnDEl.TabIndex = 40;
            this.btnDEl.Text = "DELETE";
            this.btnDEl.UseVisualStyleBackColor = true;
            this.btnDEl.Click += new System.EventHandler(this.btnDEl_Click);
            // 
            // btnAdm
            // 
            this.btnAdm.FlatAppearance.BorderSize = 0;
            this.btnAdm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnAdm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdm.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdm.ForeColor = System.Drawing.Color.White;
            this.btnAdm.Location = new System.Drawing.Point(375, 413);
            this.btnAdm.Name = "btnAdm";
            this.btnAdm.Size = new System.Drawing.Size(155, 28);
            this.btnAdm.TabIndex = 39;
            this.btnAdm.Text = "Back to ADMIN";
            this.btnAdm.UseVisualStyleBackColor = true;
            this.btnAdm.Click += new System.EventHandler(this.btnAdm_Click_1);
            // 
            // cmbApunits
            // 
            this.cmbApunits.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbApunits.FormattingEnabled = true;
            this.cmbApunits.Items.AddRange(new object[] {
            "Unit 01",
            "Unit 02",
            "Unit 03"});
            this.cmbApunits.Location = new System.Drawing.Point(240, 216);
            this.cmbApunits.Name = "cmbApunits";
            this.cmbApunits.Size = new System.Drawing.Size(237, 29);
            this.cmbApunits.TabIndex = 43;
            // 
            // tenantTableAdapter1
            // 
            this.tenantTableAdapter1.ClearBeforeFill = true;
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.Location = new System.Drawing.Point(91, 413);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(278, 24);
            this.txtSearch.TabIndex = 48;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(6, 414);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 23);
            this.label9.TabIndex = 47;
            this.label9.Text = "SEARCH";
            // 
            // Tenant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(180)))));
            this.ClientSize = new System.Drawing.Size(542, 685);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbApunits);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDEl);
            this.Controls.Add(this.btnAdm);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCreat);
            this.Controls.Add(this.cmbApatype);
            this.Controls.Add(this.txtmail);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtTName);
            this.Controls.Add(this.txtTID);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Tenant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tenant";
            this.Load += new System.EventHandler(this.Tenant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenantBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenantBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbApatype;
        private System.Windows.Forms.TextBox txtmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtTName;
        private System.Windows.Forms.TextBox txtTID;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCreat;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDEl;
        private System.Windows.Forms.Button btnAdm;
        //private ApartmentDataSet11 apartmentDataSet11;
        private System.Windows.Forms.BindingSource tenantBindingSource;
        //private ApartmentDataSet11TableAdapters.TenantTableAdapter tenantTableAdapter;
        private System.Windows.Forms.ComboBox cmbApunits;
        private ApartmentDataSet12 apartmentDataSet12;
        private System.Windows.Forms.BindingSource tenantBindingSource1;
        private ApartmentDataSet12TableAdapters.TenantTableAdapter tenantTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenantIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenantNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apartmentUnitsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apartmentTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label9;
    }
}