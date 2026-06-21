namespace Laundry_Service_Management
{
    partial class login
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLblRegister = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtBxPassword = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.txtBxName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rdBtnAdmin = new System.Windows.Forms.RadioButton();
            this.rdBtnStaff = new System.Windows.Forms.RadioButton();
            this.rdBtnCustomer = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(107, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "WELCOME BACK !";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.linkLblRegister);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.txtBxPassword);
            this.panel1.Controls.Add(this.Password);
            this.panel1.Controls.Add(this.txtBxName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.rdBtnAdmin);
            this.panel1.Controls.Add(this.rdBtnStaff);
            this.panel1.Controls.Add(this.rdBtnCustomer);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(496, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 534);
            this.panel1.TabIndex = 2;
            // 
            // linkLblRegister
            // 
            this.linkLblRegister.AutoSize = true;
            this.linkLblRegister.Location = new System.Drawing.Point(268, 479);
            this.linkLblRegister.Name = "linkLblRegister";
            this.linkLblRegister.Size = new System.Drawing.Size(95, 16);
            this.linkLblRegister.TabIndex = 12;
            this.linkLblRegister.TabStop = true;
            this.linkLblRegister.Text = "Regsister here";
            this.linkLblRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblRegister_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(120, 479);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Don\'t have an account ? ";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnLogin.ForeColor = System.Drawing.SystemColors.Window;
            this.btnLogin.Location = new System.Drawing.Point(48, 405);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(396, 39);
            this.btnLogin.TabIndex = 11;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtBxPassword
            // 
            this.txtBxPassword.Location = new System.Drawing.Point(48, 339);
            this.txtBxPassword.Name = "txtBxPassword";
            this.txtBxPassword.Size = new System.Drawing.Size(396, 22);
            this.txtBxPassword.TabIndex = 10;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(44, 299);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(83, 20);
            this.Password.TabIndex = 9;
            this.Password.Text = "Password";
            // 
            // txtBxName
            // 
            this.txtBxName.Location = new System.Drawing.Point(48, 252);
            this.txtBxName.Name = "txtBxName";
            this.txtBxName.Size = new System.Drawing.Size(396, 22);
            this.txtBxName.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Login As ";
            // 
            // rdBtnAdmin
            // 
            this.rdBtnAdmin.AutoSize = true;
            this.rdBtnAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtnAdmin.Location = new System.Drawing.Point(318, 170);
            this.rdBtnAdmin.Name = "rdBtnAdmin";
            this.rdBtnAdmin.Size = new System.Drawing.Size(70, 22);
            this.rdBtnAdmin.TabIndex = 5;
            this.rdBtnAdmin.TabStop = true;
            this.rdBtnAdmin.Text = "Admin";
            this.rdBtnAdmin.UseVisualStyleBackColor = true;
            // 
            // rdBtnStaff
            // 
            this.rdBtnStaff.AutoSize = true;
            this.rdBtnStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtnStaff.Location = new System.Drawing.Point(222, 170);
            this.rdBtnStaff.Name = "rdBtnStaff";
            this.rdBtnStaff.Size = new System.Drawing.Size(59, 22);
            this.rdBtnStaff.TabIndex = 4;
            this.rdBtnStaff.TabStop = true;
            this.rdBtnStaff.Text = "Staff";
            this.rdBtnStaff.UseVisualStyleBackColor = true;
            // 
            // rdBtnCustomer
            // 
            this.rdBtnCustomer.AutoSize = true;
            this.rdBtnCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtnCustomer.Location = new System.Drawing.Point(90, 170);
            this.rdBtnCustomer.Name = "rdBtnCustomer";
            this.rdBtnCustomer.Size = new System.Drawing.Size(95, 22);
            this.rdBtnCustomer.TabIndex = 3;
            this.rdBtnCustomer.TabStop = true;
            this.rdBtnCustomer.Text = "Customer";
            this.rdBtnCustomer.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(131, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Please login to your account";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Laundry_Service_Management.Properties.Resources.laundrypic;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(455, 717);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1028, 713);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "login";
            this.Text = "login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdBtnAdmin;
        private System.Windows.Forms.RadioButton rdBtnStaff;
        private System.Windows.Forms.RadioButton rdBtnCustomer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox txtBxName;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtBxPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel linkLblRegister;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}