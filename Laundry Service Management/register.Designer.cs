namespace Laundry_Service_Management
{
    partial class register
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdBtnFemale = new System.Windows.Forms.RadioButton();
            this.rdBtnMale = new System.Windows.Forms.RadioButton();
            this.linkLblLogin = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.btnregister = new System.Windows.Forms.Button();
            this.txtBxPassword = new System.Windows.Forms.TextBox();
            this.txtBxPhoneNum = new System.Windows.Forms.TextBox();
            this.txtBxName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Laundry_Service_Management.Properties.Resources.laundrypic;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(455, 714);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel1.Controls.Add(this.rdBtnFemale);
            this.panel1.Controls.Add(this.rdBtnMale);
            this.panel1.Controls.Add(this.linkLblLogin);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnregister);
            this.panel1.Controls.Add(this.txtBxPassword);
            this.panel1.Controls.Add(this.txtBxPhoneNum);
            this.panel1.Controls.Add(this.txtBxName);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(496, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 600);
            this.panel1.TabIndex = 1;
            // 
            // rdBtnFemale
            // 
            this.rdBtnFemale.AutoSize = true;
            this.rdBtnFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtnFemale.Location = new System.Drawing.Point(269, 240);
            this.rdBtnFemale.Name = "rdBtnFemale";
            this.rdBtnFemale.Size = new System.Drawing.Size(78, 22);
            this.rdBtnFemale.TabIndex = 17;
            this.rdBtnFemale.TabStop = true;
            this.rdBtnFemale.Text = "Female";
            this.rdBtnFemale.UseVisualStyleBackColor = true;
            // 
            // rdBtnMale
            // 
            this.rdBtnMale.AutoSize = true;
            this.rdBtnMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtnMale.Location = new System.Drawing.Point(145, 240);
            this.rdBtnMale.Name = "rdBtnMale";
            this.rdBtnMale.Size = new System.Drawing.Size(61, 22);
            this.rdBtnMale.TabIndex = 16;
            this.rdBtnMale.TabStop = true;
            this.rdBtnMale.Text = "Male";
            this.rdBtnMale.UseVisualStyleBackColor = true;
            // 
            // linkLblLogin
            // 
            this.linkLblLogin.AutoSize = true;
            this.linkLblLogin.Location = new System.Drawing.Point(277, 553);
            this.linkLblLogin.Name = "linkLblLogin";
            this.linkLblLogin.Size = new System.Drawing.Size(70, 16);
            this.linkLblLogin.TabIndex = 15;
            this.linkLblLogin.TabStop = true;
            this.linkLblLogin.Text = "Login here";
            this.linkLblLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblLogin_LinkClicked);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(111, 553);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Already have an account ? ";
            // 
            // btnregister
            // 
            this.btnregister.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnregister.ForeColor = System.Drawing.SystemColors.Window;
            this.btnregister.Location = new System.Drawing.Point(48, 491);
            this.btnregister.Name = "btnregister";
            this.btnregister.Size = new System.Drawing.Size(396, 39);
            this.btnregister.TabIndex = 13;
            this.btnregister.Text = "Register ";
            this.btnregister.UseVisualStyleBackColor = false;
            this.btnregister.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBxPassword
            // 
            this.txtBxPassword.Location = new System.Drawing.Point(48, 428);
            this.txtBxPassword.Name = "txtBxPassword";
            this.txtBxPassword.Size = new System.Drawing.Size(396, 22);
            this.txtBxPassword.TabIndex = 12;
            this.txtBxPassword.UseSystemPasswordChar = true;
            // 
            // txtBxPhoneNum
            // 
            this.txtBxPhoneNum.Location = new System.Drawing.Point(48, 339);
            this.txtBxPhoneNum.Name = "txtBxPhoneNum";
            this.txtBxPhoneNum.Size = new System.Drawing.Size(396, 22);
            this.txtBxPhoneNum.TabIndex = 11;
            // 
            // txtBxName
            // 
            this.txtBxName.Location = new System.Drawing.Point(48, 148);
            this.txtBxName.Name = "txtBxName";
            this.txtBxName.Size = new System.Drawing.Size(396, 22);
            this.txtBxName.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(44, 384);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Phone Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Gender";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(92, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(307, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Join Smart Watch and enjoy our service";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(107, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "CREATE ACCOUNT";
            // 
            // register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1028, 713);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "register";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.register_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBxName;
        private System.Windows.Forms.TextBox txtBxPassword;
        private System.Windows.Forms.TextBox txtBxPhoneNum;
        private System.Windows.Forms.Button btnregister;
        private System.Windows.Forms.LinkLabel linkLblLogin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rdBtnFemale;
        private System.Windows.Forms.RadioButton rdBtnMale;
    }
}