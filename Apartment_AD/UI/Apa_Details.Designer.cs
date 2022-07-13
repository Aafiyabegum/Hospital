namespace Apartment_AD
{
    partial class Apa_Details
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Apa_Details));
            this.txtApart = new System.Windows.Forms.TextBox();
            this.lblApSearch = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Apartment_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apartmentUnitsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apartBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.apartmentDataSet1 = new Apartment_AD.ApartmentDataSet1();
            this.apartBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOWN = new System.Windows.Forms.Button();
            this.apartTableAdapter = new Apartment_AD.ApartmentDataSet1TableAdapters.ApartTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtApart
            // 
            this.txtApart.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApart.Location = new System.Drawing.Point(292, 140);
            this.txtApart.Margin = new System.Windows.Forms.Padding(4);
            this.txtApart.Name = "txtApart";
            this.txtApart.Size = new System.Drawing.Size(419, 34);
            this.txtApart.TabIndex = 53;
            this.txtApart.TextChanged += new System.EventHandler(this.txtApart_TextChanged);
            // 
            // lblApSearch
            // 
            this.lblApSearch.AutoSize = true;
            this.lblApSearch.ForeColor = System.Drawing.Color.White;
            this.lblApSearch.Location = new System.Drawing.Point(71, 146);
            this.lblApSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApSearch.Name = "lblApSearch";
            this.lblApSearch.Size = new System.Drawing.Size(213, 23);
            this.lblApSearch.TabIndex = 52;
            this.lblApSearch.Text = "Search by Apartment ID";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Apartment_ID,
            this.apartmentUnitsDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dataGridView2.DataSource = this.apartBindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(67, 184);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(644, 263);
            this.dataGridView2.TabIndex = 51;
            // 
            // Apartment_ID
            // 
            this.Apartment_ID.DataPropertyName = "Apartment_ID";
            this.Apartment_ID.HeaderText = "Apartment_ID";
            this.Apartment_ID.Name = "Apartment_ID";
            this.Apartment_ID.Width = 150;
            // 
            // apartmentUnitsDataGridViewTextBoxColumn
            // 
            this.apartmentUnitsDataGridViewTextBoxColumn.DataPropertyName = "Apartment_Units";
            this.apartmentUnitsDataGridViewTextBoxColumn.HeaderText = "Apartment_Units";
            this.apartmentUnitsDataGridViewTextBoxColumn.Name = "apartmentUnitsDataGridViewTextBoxColumn";
            this.apartmentUnitsDataGridViewTextBoxColumn.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Apartment_Type";
            this.dataGridViewTextBoxColumn2.HeaderText = "Apartment_Type";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Phone_No";
            this.dataGridViewTextBoxColumn3.HeaderText = "Phone_No";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // apartBindingSource1
            // 
            this.apartBindingSource1.DataMember = "Apart";
            this.apartBindingSource1.DataSource = this.apartmentDataSet1;
            // 
            // apartmentDataSet1
            // 
            this.apartmentDataSet1.DataSetName = "ApartmentDataSet1";
            this.apartmentDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // apartBindingSource
            // 
            this.apartBindingSource.DataMember = "Apart";
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(679, 2);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(34, 36);
            this.btnClose.TabIndex = 55;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Broadway", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(90, 39);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(567, 32);
            this.label3.TabIndex = 56;
            this.label3.Text = "DETAILS OF ALL THE APARTMENTS";
            // 
            // btnOWN
            // 
            this.btnOWN.FlatAppearance.BorderSize = 0;
            this.btnOWN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnOWN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOWN.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOWN.ForeColor = System.Drawing.Color.White;
            this.btnOWN.Location = new System.Drawing.Point(548, 453);
            this.btnOWN.Name = "btnOWN";
            this.btnOWN.Size = new System.Drawing.Size(163, 35);
            this.btnOWN.TabIndex = 57;
            this.btnOWN.Text = "Back to OWNER";
            this.btnOWN.UseVisualStyleBackColor = true;
            this.btnOWN.Click += new System.EventHandler(this.btnOWN_Click);
            // 
            // apartTableAdapter
            // 
            this.apartTableAdapter.ClearBeforeFill = true;
            // 
            // Apa_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(180)))));
            this.ClientSize = new System.Drawing.Size(718, 500);
            this.Controls.Add(this.btnOWN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtApart);
            this.Controls.Add(this.lblApSearch);
            this.Controls.Add(this.dataGridView2);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Apa_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Apa_Details";
            this.Load += new System.EventHandler(this.Apa_Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtApart;
        private System.Windows.Forms.Label lblApSearch;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label3;
        //private ApartmentDataSet5 apartmentDataSet5;
        private System.Windows.Forms.BindingSource apartBindingSource;
        //private ApartmentDataSet5TableAdapters.ApartTableAdapter apartTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn apartmentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ownerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noofmembersinfamilyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apartmentNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apartmentTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnOWN;
        private ApartmentDataSet1 apartmentDataSet1;
        private System.Windows.Forms.BindingSource apartBindingSource1;
        private ApartmentDataSet1TableAdapters.ApartTableAdapter apartTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apartment_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn apartmentUnitsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}