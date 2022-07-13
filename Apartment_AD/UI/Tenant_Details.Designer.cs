namespace Apartment_AD
{
    partial class Tenant_Details
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tenant_Details));
            this.label3 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apartmentUnitsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenantBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.apartmentDataSet2 = new Apartment_AD.ApartmentDataSet2();
            this.tenantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.apartBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txttenant = new System.Windows.Forms.TextBox();
            this.lblTeSearch = new System.Windows.Forms.Label();
            this.apartBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnOWN = new System.Windows.Forms.Button();
            this.tenantTableAdapter = new Apartment_AD.ApartmentDataSet2TableAdapters.TenantTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenantBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenantBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Broadway", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(173, 46);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(494, 32);
            this.label3.TabIndex = 25;
            this.label3.Text = "DETAILS OF ALL THE TENANTS";
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(825, 4);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(29, 33);
            this.btnClose.TabIndex = 26;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.apartmentUnitsDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dataGridView1.DataSource = this.tenantBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(72, 167);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(769, 263);
            this.dataGridView1.TabIndex = 27;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Tenant_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Tenant_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Tenant_Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tenant_Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 140;
            // 
            // apartmentUnitsDataGridViewTextBoxColumn
            // 
            this.apartmentUnitsDataGridViewTextBoxColumn.DataPropertyName = "Apartment_Units";
            this.apartmentUnitsDataGridViewTextBoxColumn.HeaderText = "Apartment_Units";
            this.apartmentUnitsDataGridViewTextBoxColumn.Name = "apartmentUnitsDataGridViewTextBoxColumn";
            this.apartmentUnitsDataGridViewTextBoxColumn.Width = 140;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Apartment_Type";
            this.dataGridViewTextBoxColumn3.HeaderText = "Apartment_Type";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 140;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Phone_No";
            this.dataGridViewTextBoxColumn4.HeaderText = "Phone_No";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 110;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Mail_ID";
            this.dataGridViewTextBoxColumn5.HeaderText = "Mail_ID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 110;
            // 
            // tenantBindingSource1
            // 
            this.tenantBindingSource1.DataMember = "Tenant";
            this.tenantBindingSource1.DataSource = this.apartmentDataSet2;
            // 
            // apartmentDataSet2
            // 
            this.apartmentDataSet2.DataSetName = "ApartmentDataSet2";
            this.apartmentDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tenantBindingSource
            // 
            this.tenantBindingSource.DataMember = "Tenant";
            // 
            // apartBindingSource
            // 
            this.apartBindingSource.DataMember = "Apart";
            // 
            // txttenant
            // 
            this.txttenant.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttenant.Location = new System.Drawing.Point(345, 121);
            this.txttenant.Name = "txttenant";
            this.txttenant.Size = new System.Drawing.Size(496, 34);
            this.txttenant.TabIndex = 45;
            this.txttenant.TextChanged += new System.EventHandler(this.txttenant_TextChanged);
            // 
            // lblTeSearch
            // 
            this.lblTeSearch.AutoSize = true;
            this.lblTeSearch.ForeColor = System.Drawing.Color.White;
            this.lblTeSearch.Location = new System.Drawing.Point(68, 127);
            this.lblTeSearch.Name = "lblTeSearch";
            this.lblTeSearch.Size = new System.Drawing.Size(309, 23);
            this.lblTeSearch.TabIndex = 44;
            this.lblTeSearch.Text = "Search by Tenant_ID/Tenant_Name";
            // 
            // apartBindingSource1
            // 
            this.apartBindingSource1.DataMember = "Apart";
            // 
            // btnOWN
            // 
            this.btnOWN.FlatAppearance.BorderSize = 0;
            this.btnOWN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnOWN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOWN.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOWN.ForeColor = System.Drawing.Color.White;
            this.btnOWN.Location = new System.Drawing.Point(668, 437);
            this.btnOWN.Name = "btnOWN";
            this.btnOWN.Size = new System.Drawing.Size(173, 32);
            this.btnOWN.TabIndex = 47;
            this.btnOWN.Text = "Back to OWNER";
            this.btnOWN.UseVisualStyleBackColor = true;
            this.btnOWN.Click += new System.EventHandler(this.btnOWN_Click);
            // 
            // tenantTableAdapter
            // 
            this.tenantTableAdapter.ClearBeforeFill = true;
            // 
            // Tenant_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(180)))));
            this.ClientSize = new System.Drawing.Size(857, 493);
            this.Controls.Add(this.btnOWN);
            this.Controls.Add(this.txttenant);
            this.Controls.Add(this.lblTeSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Tenant_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ALL_DATA";
            this.Load += new System.EventHandler(this.ALL_DATA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenantBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenantBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dataGridView1;
        //private ApartmentDataSet1 apartmentDataSet1;
        private System.Windows.Forms.BindingSource tenantBindingSource;
        //private ApartmentDataSet1TableAdapters.TenantTableAdapter tenantTableAdapter;
        //private ApartmentDataSet2 apartmentDataSet2;
        private System.Windows.Forms.BindingSource apartBindingSource;
        //private ApartmentDataSet2TableAdapters.ApartTableAdapter apartTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenantIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenantNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apartmentNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apartmentTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txttenant;
        private System.Windows.Forms.Label lblTeSearch;
        //private ApartmentDataSet4 apartmentDataSet4;
        private System.Windows.Forms.BindingSource apartBindingSource1;
        //private ApartmentDataSet4TableAdapters.ApartTableAdapter apartTableAdapter1;
        private System.Windows.Forms.Button btnOWN;
        private ApartmentDataSet2 apartmentDataSet2;
        private System.Windows.Forms.BindingSource tenantBindingSource1;
        private ApartmentDataSet2TableAdapters.TenantTableAdapter tenantTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn apartmentUnitsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}