namespace Apartment_AD
{
    partial class Apart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Apart));
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.txtPhoe = new System.Windows.Forms.TextBox();
            this.txtApa = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbApunits = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDEl = new System.Windows.Forms.Button();
            this.btnAd = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.apartmentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apartmentUnitsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apartmentTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apartBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.apartmentDataSet10 = new Apartment_AD.ApartmentDataSet10();
            this.apartTableAdapter = new Apartment_AD.ApartmentDataSet10TableAdapters.ApartTableAdapter();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentDataSet10)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(527, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(32, 34);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Broadway", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(178, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Create Apartment";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(72, 41);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(101, 107);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Apartment_AD.Properties.Resources.Ower2;
            this.pictureBox1.Image = global::Apartment_AD.Properties.Resources.Ower;
            this.pictureBox1.Location = new System.Drawing.Point(-106, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // cmbType
            // 
            this.cmbType.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Residential",
            "Commercial"});
            this.cmbType.Location = new System.Drawing.Point(277, 263);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(270, 29);
            this.cmbType.TabIndex = 33;
            // 
            // txtPhoe
            // 
            this.txtPhoe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhoe.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoe.ForeColor = System.Drawing.Color.Black;
            this.txtPhoe.Location = new System.Drawing.Point(277, 306);
            this.txtPhoe.Multiline = true;
            this.txtPhoe.Name = "txtPhoe";
            this.txtPhoe.Size = new System.Drawing.Size(270, 24);
            this.txtPhoe.TabIndex = 30;
            // 
            // txtApa
            // 
            this.txtApa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApa.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApa.ForeColor = System.Drawing.Color.Black;
            this.txtApa.Location = new System.Drawing.Point(277, 179);
            this.txtApa.Multiline = true;
            this.txtApa.Name = "txtApa";
            this.txtApa.Size = new System.Drawing.Size(270, 24);
            this.txtApa.TabIndex = 26;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Location = new System.Drawing.Point(277, 335);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(270, 1);
            this.panel6.TabIndex = 25;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(277, 295);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(270, 1);
            this.panel5.TabIndex = 22;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(277, 253);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(270, 1);
            this.panel4.TabIndex = 21;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(277, 209);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 1);
            this.panel1.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(35, 306);
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
            this.label6.Location = new System.Drawing.Point(35, 264);
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
            this.label5.Location = new System.Drawing.Point(35, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "Apartment Units";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(35, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Apartment ID";
            // 
            // cmbApunits
            // 
            this.cmbApunits.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbApunits.FormattingEnabled = true;
            this.cmbApunits.Items.AddRange(new object[] {
            "Unit 01",
            "Unit 02",
            "Unit 03"});
            this.cmbApunits.Location = new System.Drawing.Point(277, 215);
            this.cmbApunits.Name = "cmbApunits";
            this.cmbApunits.Size = new System.Drawing.Size(270, 29);
            this.cmbApunits.TabIndex = 36;
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(277, 357);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(104, 34);
            this.btnUpdate.TabIndex = 41;
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
            this.btnDEl.Location = new System.Drawing.Point(144, 357);
            this.btnDEl.Name = "btnDEl";
            this.btnDEl.Size = new System.Drawing.Size(104, 31);
            this.btnDEl.TabIndex = 39;
            this.btnDEl.Text = "DELETE";
            this.btnDEl.UseVisualStyleBackColor = true;
            this.btnDEl.Click += new System.EventHandler(this.btnDEl_Click);
            // 
            // btnAd
            // 
            this.btnAd.FlatAppearance.BorderSize = 0;
            this.btnAd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnAd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAd.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAd.ForeColor = System.Drawing.Color.White;
            this.btnAd.Location = new System.Drawing.Point(385, 405);
            this.btnAd.Name = "btnAd";
            this.btnAd.Size = new System.Drawing.Size(160, 35);
            this.btnAd.TabIndex = 38;
            this.btnAd.Text = "Back to ADMIN";
            this.btnAd.UseVisualStyleBackColor = true;
            this.btnAd.Click += new System.EventHandler(this.btnAd_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.Location = new System.Drawing.Point(12, 357);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(104, 31);
            this.btnCreate.TabIndex = 37;
            this.btnCreate.Text = "CREATE";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.apartmentIDDataGridViewTextBoxColumn,
            this.apartmentUnitsDataGridViewTextBoxColumn,
            this.apartmentTypeDataGridViewTextBoxColumn,
            this.phoneNoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.apartBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 449);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(534, 231);
            this.dataGridView1.TabIndex = 42;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // apartmentIDDataGridViewTextBoxColumn
            // 
            this.apartmentIDDataGridViewTextBoxColumn.DataPropertyName = "Apartment_ID";
            this.apartmentIDDataGridViewTextBoxColumn.HeaderText = "Apartment_ID";
            this.apartmentIDDataGridViewTextBoxColumn.Name = "apartmentIDDataGridViewTextBoxColumn";
            // 
            // apartmentUnitsDataGridViewTextBoxColumn
            // 
            this.apartmentUnitsDataGridViewTextBoxColumn.DataPropertyName = "Apartment_Units";
            this.apartmentUnitsDataGridViewTextBoxColumn.HeaderText = "Apartment_Units";
            this.apartmentUnitsDataGridViewTextBoxColumn.Name = "apartmentUnitsDataGridViewTextBoxColumn";
            this.apartmentUnitsDataGridViewTextBoxColumn.Width = 135;
            // 
            // apartmentTypeDataGridViewTextBoxColumn
            // 
            this.apartmentTypeDataGridViewTextBoxColumn.DataPropertyName = "Apartment_Type";
            this.apartmentTypeDataGridViewTextBoxColumn.HeaderText = "Apartment_Type";
            this.apartmentTypeDataGridViewTextBoxColumn.Name = "apartmentTypeDataGridViewTextBoxColumn";
            this.apartmentTypeDataGridViewTextBoxColumn.Width = 135;
            // 
            // phoneNoDataGridViewTextBoxColumn
            // 
            this.phoneNoDataGridViewTextBoxColumn.DataPropertyName = "Phone_No";
            this.phoneNoDataGridViewTextBoxColumn.HeaderText = "Phone_No";
            this.phoneNoDataGridViewTextBoxColumn.Name = "phoneNoDataGridViewTextBoxColumn";
            this.phoneNoDataGridViewTextBoxColumn.Width = 110;
            // 
            // apartBindingSource
            // 
            this.apartBindingSource.DataMember = "Apart";
            this.apartBindingSource.DataSource = this.apartmentDataSet10;
            // 
            // apartmentDataSet10
            // 
            this.apartmentDataSet10.DataSetName = "ApartmentDataSet10";
            this.apartmentDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // apartTableAdapter
            // 
            this.apartTableAdapter.ClearBeforeFill = true;
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.Location = new System.Drawing.Point(95, 417);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(284, 24);
            this.txtSearch.TabIndex = 48;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(11, 417);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 23);
            this.label9.TabIndex = 47;
            this.label9.Text = "SEARCH";
            // 
            // Apart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(180)))));
            this.ClientSize = new System.Drawing.Size(557, 692);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDEl);
            this.Controls.Add(this.btnAd);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.cmbApunits);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.txtPhoe);
            this.Controls.Add(this.txtApa);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Apart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Apart";
            this.Load += new System.EventHandler(this.Apart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentDataSet10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.TextBox txtPhoe;
        private System.Windows.Forms.TextBox txtApa;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbApunits;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDEl;
        private System.Windows.Forms.Button btnAd;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ApartmentDataSet10 apartmentDataSet10;
        private System.Windows.Forms.BindingSource apartBindingSource;
        private ApartmentDataSet10TableAdapters.ApartTableAdapter apartTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn apartmentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apartmentUnitsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apartmentTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label9;
    }
}