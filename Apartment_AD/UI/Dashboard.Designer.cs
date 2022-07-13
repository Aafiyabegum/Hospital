namespace Apartment_AD
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.label3 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPa = new System.Windows.Forms.Button();
            this.btnTe = new System.Windows.Forms.Button();
            this.btnAp = new System.Windows.Forms.Button();
            this.btnOw = new System.Windows.Forms.Button();
            this.lbluser = new System.Windows.Forms.Label();
            this.lbllogged = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnREPORT = new System.Windows.Forms.Button();
            this.lbltime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbldate = new System.Windows.Forms.Label();
            this.btnhelp = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Broadway", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(98, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(585, 32);
            this.label3.TabIndex = 16;
            this.label3.Text = "APARTMENT MANAGEMENT SYSTEM";
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Magenta;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(293, 403);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(179, 242);
            this.button4.TabIndex = 14;
            this.button4.Text = "PROFIT";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(777, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(32, 32);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPa
            // 
            this.btnPa.FlatAppearance.BorderSize = 0;
            this.btnPa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Magenta;
            this.btnPa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPa.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPa.ForeColor = System.Drawing.Color.Black;
            this.btnPa.Image = global::Apartment_AD.Properties.Resources.PAY;
            this.btnPa.Location = new System.Drawing.Point(94, 403);
            this.btnPa.Name = "btnPa";
            this.btnPa.Size = new System.Drawing.Size(179, 242);
            this.btnPa.TabIndex = 11;
            this.btnPa.Text = "PAYMENT";
            this.btnPa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPa.UseVisualStyleBackColor = true;
            this.btnPa.Click += new System.EventHandler(this.btnPa_Click);
            // 
            // btnTe
            // 
            this.btnTe.FlatAppearance.BorderSize = 0;
            this.btnTe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Magenta;
            this.btnTe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTe.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTe.ForeColor = System.Drawing.Color.Black;
            this.btnTe.Image = global::Apartment_AD.Properties.Resources.Ten;
            this.btnTe.Location = new System.Drawing.Point(491, 143);
            this.btnTe.Name = "btnTe";
            this.btnTe.Size = new System.Drawing.Size(179, 242);
            this.btnTe.TabIndex = 7;
            this.btnTe.Text = "TENANT";
            this.btnTe.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTe.UseVisualStyleBackColor = true;
            this.btnTe.Click += new System.EventHandler(this.btnTe_Click);
            // 
            // btnAp
            // 
            this.btnAp.FlatAppearance.BorderSize = 0;
            this.btnAp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Magenta;
            this.btnAp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAp.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAp.ForeColor = System.Drawing.Color.Black;
            this.btnAp.Image = global::Apartment_AD.Properties.Resources.aPA;
            this.btnAp.Location = new System.Drawing.Point(286, 143);
            this.btnAp.Name = "btnAp";
            this.btnAp.Size = new System.Drawing.Size(179, 242);
            this.btnAp.TabIndex = 15;
            this.btnAp.Text = "APARTMENT";
            this.btnAp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAp.UseVisualStyleBackColor = true;
            this.btnAp.Click += new System.EventHandler(this.btnAp_Click);
            // 
            // btnOw
            // 
            this.btnOw.FlatAppearance.BorderSize = 0;
            this.btnOw.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Magenta;
            this.btnOw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOw.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOw.ForeColor = System.Drawing.Color.Black;
            this.btnOw.Image = global::Apartment_AD.Properties.Resources.Ower1;
            this.btnOw.Location = new System.Drawing.Point(87, 143);
            this.btnOw.Name = "btnOw";
            this.btnOw.Size = new System.Drawing.Size(179, 242);
            this.btnOw.TabIndex = 12;
            this.btnOw.Text = "OWNER";
            this.btnOw.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOw.UseVisualStyleBackColor = true;
            this.btnOw.Click += new System.EventHandler(this.btnOw_Click);
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluser.Location = new System.Drawing.Point(100, 96);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(148, 23);
            this.lbluser.TabIndex = 17;
            this.lbluser.Text = "You are login as:";
            // 
            // lbllogged
            // 
            this.lbllogged.AutoSize = true;
            this.lbllogged.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllogged.ForeColor = System.Drawing.Color.Red;
            this.lbllogged.Location = new System.Drawing.Point(288, 89);
            this.lbllogged.Name = "lbllogged";
            this.lbllogged.Size = new System.Drawing.Size(0, 33);
            this.lbllogged.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Broadway", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(280, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 32);
            this.label1.TabIndex = 19;
            this.label1.Text = "ABC Company";
            // 
            // btnREPORT
            // 
            this.btnREPORT.FlatAppearance.BorderSize = 0;
            this.btnREPORT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Magenta;
            this.btnREPORT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnREPORT.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnREPORT.ForeColor = System.Drawing.Color.Black;
            this.btnREPORT.Image = ((System.Drawing.Image)(resources.GetObject("btnREPORT.Image")));
            this.btnREPORT.Location = new System.Drawing.Point(491, 403);
            this.btnREPORT.Name = "btnREPORT";
            this.btnREPORT.Size = new System.Drawing.Size(179, 242);
            this.btnREPORT.TabIndex = 20;
            this.btnREPORT.Text = "REPORT";
            this.btnREPORT.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnREPORT.UseVisualStyleBackColor = true;
            this.btnREPORT.Click += new System.EventHandler(this.btnREPORT_Click);
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltime.ForeColor = System.Drawing.Color.White;
            this.lbltime.Location = new System.Drawing.Point(527, 90);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(50, 23);
            this.lbltime.TabIndex = 21;
            this.lbltime.Text = "time";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.ForeColor = System.Drawing.Color.White;
            this.lbldate.Location = new System.Drawing.Point(527, 117);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(48, 23);
            this.lbldate.TabIndex = 22;
            this.lbldate.Text = "date";
            // 
            // btnhelp
            // 
            this.btnhelp.FlatAppearance.BorderSize = 0;
            this.btnhelp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnhelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhelp.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhelp.Location = new System.Drawing.Point(676, 644);
            this.btnhelp.Name = "btnhelp";
            this.btnhelp.Size = new System.Drawing.Size(93, 31);
            this.btnhelp.TabIndex = 23;
            this.btnhelp.Text = "Help";
            this.btnhelp.UseVisualStyleBackColor = true;
            this.btnhelp.Click += new System.EventHandler(this.btnhelp_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.Location = new System.Drawing.Point(676, 681);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(93, 31);
            this.btnAbout.TabIndex = 24;
            this.btnAbout.Text = "About Us";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(180)))));
            this.ClientSize = new System.Drawing.Size(811, 725);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnhelp);
            this.Controls.Add(this.lbldate);
            this.Controls.Add(this.lbltime);
            this.Controls.Add(this.btnREPORT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbllogged);
            this.Controls.Add(this.lbluser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnPa);
            this.Controls.Add(this.btnTe);
            this.Controls.Add(this.btnAp);
            this.Controls.Add(this.btnOw);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dash";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Dashboard_FormClosed);
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnPa;
        private System.Windows.Forms.Button btnTe;
        private System.Windows.Forms.Button btnAp;
        private System.Windows.Forms.Button btnOw;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.Label lbllogged;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnREPORT;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Button btnhelp;
        private System.Windows.Forms.Button btnAbout;

    }
}