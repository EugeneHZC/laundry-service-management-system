namespace Laundry_Service_Management
{
    partial class ProfilePage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.nameTxtBx = new System.Windows.Forms.TextBox();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.laundryServiceManagementDbDataSet = new Laundry_Service_Management.LaundryServiceManagementDbDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.phoneTxtBx = new System.Windows.Forms.Label();
            this.roleTxtBx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.maleRb = new System.Windows.Forms.RadioButton();
            this.femaleRb = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.usersTableAdapter = new Laundry_Service_Management.LaundryServiceManagementDbDataSetTableAdapters.UsersTableAdapter();
            this.joinDateTxtBx = new System.Windows.Forms.TextBox();
            this.joinDateLbl = new System.Windows.Forms.Label();
            this.changePasswordBtn = new System.Windows.Forms.Button();
            this.changePasswordgGrpBx = new System.Windows.Forms.GroupBox();
            this.newPasswordTxtBx = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.confirmPasswordTxtBx = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.changeBtn = new System.Windows.Forms.Button();
            this.cancelChangeBtn = new System.Windows.Forms.Button();
            this.oldPasswordTxtBx = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laundryServiceManagementDbDataSet)).BeginInit();
            this.changePasswordgGrpBx.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // nameTxtBx
            // 
            this.nameTxtBx.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "name", true));
            this.nameTxtBx.Location = new System.Drawing.Point(184, 103);
            this.nameTxtBx.Name = "nameTxtBx";
            this.nameTxtBx.Size = new System.Drawing.Size(228, 22);
            this.nameTxtBx.TabIndex = 1;
            this.nameTxtBx.TextChanged += new System.EventHandler(this.TxtBx_TextChanged);
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.laundryServiceManagementDbDataSet;
            // 
            // laundryServiceManagementDbDataSet
            // 
            this.laundryServiceManagementDbDataSet.DataSetName = "LaundryServiceManagementDbDataSet";
            this.laundryServiceManagementDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Gender:";
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "phone_no", true));
            this.textBox2.Location = new System.Drawing.Point(184, 187);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(228, 22);
            this.textBox2.TabIndex = 5;
            this.textBox2.TextChanged += new System.EventHandler(this.TxtBx_TextChanged);
            // 
            // phoneTxtBx
            // 
            this.phoneTxtBx.AutoSize = true;
            this.phoneTxtBx.Location = new System.Drawing.Point(81, 190);
            this.phoneTxtBx.Name = "phoneTxtBx";
            this.phoneTxtBx.Size = new System.Drawing.Size(49, 16);
            this.phoneTxtBx.TabIndex = 4;
            this.phoneTxtBx.Text = "Phone:";
            // 
            // roleTxtBx
            // 
            this.roleTxtBx.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "role", true));
            this.roleTxtBx.Enabled = false;
            this.roleTxtBx.Location = new System.Drawing.Point(184, 235);
            this.roleTxtBx.Name = "roleTxtBx";
            this.roleTxtBx.Size = new System.Drawing.Size(228, 22);
            this.roleTxtBx.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Role:";
            // 
            // maleRb
            // 
            this.maleRb.AutoSize = true;
            this.maleRb.Location = new System.Drawing.Point(184, 147);
            this.maleRb.Name = "maleRb";
            this.maleRb.Size = new System.Drawing.Size(58, 20);
            this.maleRb.TabIndex = 8;
            this.maleRb.TabStop = true;
            this.maleRb.Text = "Male";
            this.maleRb.UseVisualStyleBackColor = true;
            this.maleRb.CheckedChanged += new System.EventHandler(this.Rb_CheckedChanged);
            // 
            // femaleRb
            // 
            this.femaleRb.AutoSize = true;
            this.femaleRb.Location = new System.Drawing.Point(263, 147);
            this.femaleRb.Name = "femaleRb";
            this.femaleRb.Size = new System.Drawing.Size(74, 20);
            this.femaleRb.TabIndex = 9;
            this.femaleRb.TabStop = true;
            this.femaleRb.Text = "Female";
            this.femaleRb.UseVisualStyleBackColor = true;
            this.femaleRb.CheckedChanged += new System.EventHandler(this.Rb_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Profile";
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.cancelBtn.Enabled = false;
            this.cancelBtn.ForeColor = System.Drawing.Color.White;
            this.cancelBtn.Location = new System.Drawing.Point(120, 342);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(100, 37);
            this.cancelBtn.TabIndex = 11;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.saveBtn.Enabled = false;
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(237, 342);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(100, 37);
            this.saveBtn.TabIndex = 12;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // joinDateTxtBx
            // 
            this.joinDateTxtBx.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "join_date", true));
            this.joinDateTxtBx.Enabled = false;
            this.joinDateTxtBx.Location = new System.Drawing.Point(184, 281);
            this.joinDateTxtBx.Name = "joinDateTxtBx";
            this.joinDateTxtBx.Size = new System.Drawing.Size(228, 22);
            this.joinDateTxtBx.TabIndex = 14;
            // 
            // joinDateLbl
            // 
            this.joinDateLbl.AutoSize = true;
            this.joinDateLbl.Location = new System.Drawing.Point(81, 284);
            this.joinDateLbl.Name = "joinDateLbl";
            this.joinDateLbl.Size = new System.Drawing.Size(67, 16);
            this.joinDateLbl.TabIndex = 13;
            this.joinDateLbl.Text = "Join Date:";
            // 
            // changePasswordBtn
            // 
            this.changePasswordBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.changePasswordBtn.ForeColor = System.Drawing.Color.White;
            this.changePasswordBtn.Location = new System.Drawing.Point(120, 397);
            this.changePasswordBtn.Name = "changePasswordBtn";
            this.changePasswordBtn.Size = new System.Drawing.Size(217, 37);
            this.changePasswordBtn.TabIndex = 15;
            this.changePasswordBtn.Text = "Change Password";
            this.changePasswordBtn.UseVisualStyleBackColor = false;
            this.changePasswordBtn.Click += new System.EventHandler(this.changePasswordBtn_Click);
            // 
            // changePasswordgGrpBx
            // 
            this.changePasswordgGrpBx.Controls.Add(this.oldPasswordTxtBx);
            this.changePasswordgGrpBx.Controls.Add(this.label6);
            this.changePasswordgGrpBx.Controls.Add(this.changeBtn);
            this.changePasswordgGrpBx.Controls.Add(this.cancelChangeBtn);
            this.changePasswordgGrpBx.Controls.Add(this.confirmPasswordTxtBx);
            this.changePasswordgGrpBx.Controls.Add(this.label5);
            this.changePasswordgGrpBx.Controls.Add(this.newPasswordTxtBx);
            this.changePasswordgGrpBx.Controls.Add(this.label7);
            this.changePasswordgGrpBx.Location = new System.Drawing.Point(487, 103);
            this.changePasswordgGrpBx.Name = "changePasswordgGrpBx";
            this.changePasswordgGrpBx.Size = new System.Drawing.Size(386, 276);
            this.changePasswordgGrpBx.TabIndex = 16;
            this.changePasswordgGrpBx.TabStop = false;
            this.changePasswordgGrpBx.Text = "Change Password";
            this.changePasswordgGrpBx.Visible = false;
            // 
            // newPasswordTxtBx
            // 
            this.newPasswordTxtBx.Location = new System.Drawing.Point(162, 85);
            this.newPasswordTxtBx.Name = "newPasswordTxtBx";
            this.newPasswordTxtBx.Size = new System.Drawing.Size(195, 22);
            this.newPasswordTxtBx.TabIndex = 18;
            this.newPasswordTxtBx.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "New Password:";
            // 
            // confirmPasswordTxtBx
            // 
            this.confirmPasswordTxtBx.Location = new System.Drawing.Point(162, 132);
            this.confirmPasswordTxtBx.Name = "confirmPasswordTxtBx";
            this.confirmPasswordTxtBx.Size = new System.Drawing.Size(195, 22);
            this.confirmPasswordTxtBx.TabIndex = 20;
            this.confirmPasswordTxtBx.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Confirm Password:";
            // 
            // changeBtn
            // 
            this.changeBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.changeBtn.ForeColor = System.Drawing.Color.White;
            this.changeBtn.Location = new System.Drawing.Point(202, 189);
            this.changeBtn.Name = "changeBtn";
            this.changeBtn.Size = new System.Drawing.Size(100, 37);
            this.changeBtn.TabIndex = 18;
            this.changeBtn.Text = "Change";
            this.changeBtn.UseVisualStyleBackColor = false;
            this.changeBtn.Click += new System.EventHandler(this.changeBtn_Click);
            // 
            // cancelChangeBtn
            // 
            this.cancelChangeBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.cancelChangeBtn.ForeColor = System.Drawing.Color.White;
            this.cancelChangeBtn.Location = new System.Drawing.Point(85, 189);
            this.cancelChangeBtn.Name = "cancelChangeBtn";
            this.cancelChangeBtn.Size = new System.Drawing.Size(100, 37);
            this.cancelChangeBtn.TabIndex = 17;
            this.cancelChangeBtn.Text = "Cancel";
            this.cancelChangeBtn.UseVisualStyleBackColor = false;
            this.cancelChangeBtn.Click += new System.EventHandler(this.cancelChangeBtn_Click);
            // 
            // oldPasswordTxtBx
            // 
            this.oldPasswordTxtBx.Location = new System.Drawing.Point(162, 40);
            this.oldPasswordTxtBx.Name = "oldPasswordTxtBx";
            this.oldPasswordTxtBx.Size = new System.Drawing.Size(195, 22);
            this.oldPasswordTxtBx.TabIndex = 22;
            this.oldPasswordTxtBx.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "Old Password:";
            // 
            // ProfilePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.changePasswordgGrpBx);
            this.Controls.Add(this.changePasswordBtn);
            this.Controls.Add(this.joinDateTxtBx);
            this.Controls.Add(this.joinDateLbl);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.femaleRb);
            this.Controls.Add(this.maleRb);
            this.Controls.Add(this.roleTxtBx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.phoneTxtBx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameTxtBx);
            this.Controls.Add(this.label1);
            this.Name = "ProfilePage";
            this.Size = new System.Drawing.Size(1109, 723);
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laundryServiceManagementDbDataSet)).EndInit();
            this.changePasswordgGrpBx.ResumeLayout(false);
            this.changePasswordgGrpBx.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTxtBx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label phoneTxtBx;
        private System.Windows.Forms.TextBox roleTxtBx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton maleRb;
        private System.Windows.Forms.RadioButton femaleRb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private LaundryServiceManagementDbDataSet laundryServiceManagementDbDataSet;
        private LaundryServiceManagementDbDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.TextBox joinDateTxtBx;
        private System.Windows.Forms.Label joinDateLbl;
        private System.Windows.Forms.Button changePasswordBtn;
        private System.Windows.Forms.GroupBox changePasswordgGrpBx;
        private System.Windows.Forms.TextBox oldPasswordTxtBx;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button changeBtn;
        private System.Windows.Forms.Button cancelChangeBtn;
        private System.Windows.Forms.TextBox confirmPasswordTxtBx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox newPasswordTxtBx;
        private System.Windows.Forms.Label label7;
    }
}
