namespace Apartment_AD
{
    partial class Owner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Owner));
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtFamily = new System.Windows.Forms.TextBox();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.txtmail = new System.Windows.Forms.TextBox();
            this.cmbApart = new System.Windows.Forms.ComboBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnADM = new System.Windows.Forms.Button();
            this.btnDEl = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ownerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ownerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apartment_Units = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noofmembersinfamilyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apartmentTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ownerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.apartmentDataSet9 = new Apartment_AD.ApartmentDataSet9();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ownerTableAdapter = new Apartment_AD.ApartmentDataSet9TableAdapters.OwnerTableAdapter();
            this.cmbApunits = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Broadway", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(191, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create Owner";
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(525, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(28, 30);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(47, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Owner ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(47, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Owner Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(47, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "No of members in family";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(47, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Apartment Units";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(47, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Apartment Type";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(47, 328);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 23);
            this.label7.TabIndex = 5;
            this.label7.Text = "Phone No";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(47, 366);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 23);
            this.label8.TabIndex = 5;
            this.label8.Text = "Mail ID";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(288, 170);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 1);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(288, 205);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(236, 1);
            this.panel2.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(288, 243);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(236, 1);
            this.panel3.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(288, 281);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(236, 1);
            this.panel4.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(288, 318);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(236, 1);
            this.panel5.TabIndex = 6;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Location = new System.Drawing.Point(288, 354);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(236, 1);
            this.panel6.TabIndex = 6;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Location = new System.Drawing.Point(288, 392);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(236, 1);
            this.panel7.TabIndex = 6;
            // 
            // txtID
            // 
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtID.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ForeColor = System.Drawing.Color.Black;
            this.txtID.Location = new System.Drawing.Point(288, 143);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(236, 24);
            this.txtID.TabIndex = 7;
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.Location = new System.Drawing.Point(288, 179);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(236, 24);
            this.txtName.TabIndex = 7;
            // 
            // txtFamily
            // 
            this.txtFamily.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFamily.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFamily.ForeColor = System.Drawing.Color.Black;
            this.txtFamily.Location = new System.Drawing.Point(288, 217);
            this.txtFamily.Name = "txtFamily";
            this.txtFamily.Size = new System.Drawing.Size(236, 24);
            this.txtFamily.TabIndex = 7;
            // 
            // txtphone
            // 
            this.txtphone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtphone.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtphone.ForeColor = System.Drawing.Color.Black;
            this.txtphone.Location = new System.Drawing.Point(288, 328);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(236, 24);
            this.txtphone.TabIndex = 7;
            // 
            // txtmail
            // 
            this.txtmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtmail.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmail.ForeColor = System.Drawing.Color.Black;
            this.txtmail.Location = new System.Drawing.Point(288, 366);
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(236, 24);
            this.txtmail.TabIndex = 7;
            // 
            // cmbApart
            // 
            this.cmbApart.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbApart.FormattingEnabled = true;
            this.cmbApart.Items.AddRange(new object[] {
            "Residential",
            "Commercial"});
            this.cmbApart.Location = new System.Drawing.Point(288, 287);
            this.cmbApart.Name = "cmbApart";
            this.cmbApart.Size = new System.Drawing.Size(237, 31);
            this.cmbApart.TabIndex = 8;
            // 
            // btnCreate
            // 
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.Location = new System.Drawing.Point(0, 409);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(104, 29);
            this.btnCreate.TabIndex = 10;
            this.btnCreate.Text = "CREATE";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnADM
            // 
            this.btnADM.FlatAppearance.BorderSize = 0;
            this.btnADM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnADM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnADM.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnADM.ForeColor = System.Drawing.Color.White;
            this.btnADM.Location = new System.Drawing.Point(374, 442);
            this.btnADM.Name = "btnADM";
            this.btnADM.Size = new System.Drawing.Size(167, 33);
            this.btnADM.TabIndex = 11;
            this.btnADM.Text = "Back to ADMIN";
            this.btnADM.UseVisualStyleBackColor = true;
            this.btnADM.Click += new System.EventHandler(this.btnADM_Click_1);
            // 
            // btnDEl
            // 
            this.btnDEl.FlatAppearance.BorderSize = 0;
            this.btnDEl.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnDEl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDEl.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDEl.ForeColor = System.Drawing.Color.White;
            this.btnDEl.Location = new System.Drawing.Point(114, 409);
            this.btnDEl.Name = "btnDEl";
            this.btnDEl.Size = new System.Drawing.Size(104, 29);
            this.btnDEl.TabIndex = 12;
            this.btnDEl.Text = "DELETE";
            this.btnDEl.UseVisualStyleBackColor = true;
            this.btnDEl.Click += new System.EventHandler(this.btnDEl_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ownerIDDataGridViewTextBoxColumn,
            this.ownerNameDataGridViewTextBoxColumn,
            this.Apartment_Units,
            this.noofmembersinfamilyDataGridViewTextBoxColumn,
            this.apartmentTypeDataGridViewTextBoxColumn,
            this.phoneNoDataGridViewTextBoxColumn,
            this.mailIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ownerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 481);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(529, 226);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // ownerIDDataGridViewTextBoxColumn
            // 
            this.ownerIDDataGridViewTextBoxColumn.DataPropertyName = "Owner_ID";
            this.ownerIDDataGridViewTextBoxColumn.HeaderText = "Owner_ID";
            this.ownerIDDataGridViewTextBoxColumn.Name = "ownerIDDataGridViewTextBoxColumn";
            this.ownerIDDataGridViewTextBoxColumn.Width = 80;
            // 
            // ownerNameDataGridViewTextBoxColumn
            // 
            this.ownerNameDataGridViewTextBoxColumn.DataPropertyName = "Owner_Name";
            this.ownerNameDataGridViewTextBoxColumn.HeaderText = "Owner_Name";
            this.ownerNameDataGridViewTextBoxColumn.Name = "ownerNameDataGridViewTextBoxColumn";
            this.ownerNameDataGridViewTextBoxColumn.Width = 80;
            // 
            // Apartment_Units
            // 
            this.Apartment_Units.DataPropertyName = "Apartment_Units";
            this.Apartment_Units.HeaderText = "Apartment_Units";
            this.Apartment_Units.Name = "Apartment_Units";
            // 
            // noofmembersinfamilyDataGridViewTextBoxColumn
            // 
            this.noofmembersinfamilyDataGridViewTextBoxColumn.DataPropertyName = "No_of_members_in_family";
            this.noofmembersinfamilyDataGridViewTextBoxColumn.HeaderText = "Family_Members";
            this.noofmembersinfamilyDataGridViewTextBoxColumn.Name = "noofmembersinfamilyDataGridViewTextBoxColumn";
            this.noofmembersinfamilyDataGridViewTextBoxColumn.Width = 120;
            // 
            // apartmentTypeDataGridViewTextBoxColumn
            // 
            this.apartmentTypeDataGridViewTextBoxColumn.DataPropertyName = "Apartment_Type";
            this.apartmentTypeDataGridViewTextBoxColumn.HeaderText = "Apartment_Type";
            this.apartmentTypeDataGridViewTextBoxColumn.Name = "apartmentTypeDataGridViewTextBoxColumn";
            // 
            // phoneNoDataGridViewTextBoxColumn
            // 
            this.phoneNoDataGridViewTextBoxColumn.DataPropertyName = "Phone_No";
            this.phoneNoDataGridViewTextBoxColumn.HeaderText = "Phone_No";
            this.phoneNoDataGridViewTextBoxColumn.Name = "phoneNoDataGridViewTextBoxColumn";
            this.phoneNoDataGridViewTextBoxColumn.Width = 80;
            // 
            // mailIDDataGridViewTextBoxColumn
            // 
            this.mailIDDataGridViewTextBoxColumn.DataPropertyName = "Mail_ID";
            this.mailIDDataGridViewTextBoxColumn.HeaderText = "Mail_ID";
            this.mailIDDataGridViewTextBoxColumn.Name = "mailIDDataGridViewTextBoxColumn";
            // 
            // ownerBindingSource
            // 
            this.ownerBindingSource.DataMember = "Owner";
            this.ownerBindingSource.DataSource = this.apartmentDataSet9;
            // 
            // apartmentDataSet9
            // 
            this.apartmentDataSet9.DataSetName = "ApartmentDataSet9";
            this.apartmentDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(237, 407);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(104, 32);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(83, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // ownerTableAdapter
            // 
            this.ownerTableAdapter.ClearBeforeFill = true;
            // 
            // cmbApunits
            // 
            this.cmbApunits.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbApunits.FormattingEnabled = true;
            this.cmbApunits.Items.AddRange(new object[] {
            "Unit 01",
            "Unit 02",
            "Unit 03"});
            this.cmbApunits.Location = new System.Drawing.Point(287, 249);
            this.cmbApunits.Name = "cmbApunits";
            this.cmbApunits.Size = new System.Drawing.Size(237, 29);
            this.cmbApunits.TabIndex = 44;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(21, 452);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 23);
            this.label9.TabIndex = 45;
            this.label9.Text = "SEARCH";
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.Location = new System.Drawing.Point(105, 452);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(263, 24);
            this.txtSearch.TabIndex = 46;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // Owner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(180)))));
            this.ClientSize = new System.Drawing.Size(553, 719);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbApunits);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDEl);
            this.Controls.Add(this.btnADM);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.cmbApart);
            this.Controls.Add(this.txtmail);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.txtFamily);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Owner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Owener";
            this.Load += new System.EventHandler(this.Owner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtFamily;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.TextBox txtmail;
        private System.Windows.Forms.ComboBox cmbApart;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnADM;
        private System.Windows.Forms.Button btnDEl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnUpdate;
        private ApartmentDataSet9 apartmentDataSet9;
        private System.Windows.Forms.BindingSource ownerBindingSource;
        private ApartmentDataSet9TableAdapters.OwnerTableAdapter ownerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn apartmentNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cmbApunits;
        private System.Windows.Forms.DataGridViewTextBoxColumn ownerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ownerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apartment_Units;
        private System.Windows.Forms.DataGridViewTextBoxColumn noofmembersinfamilyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apartmentTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSearch;
    }
}