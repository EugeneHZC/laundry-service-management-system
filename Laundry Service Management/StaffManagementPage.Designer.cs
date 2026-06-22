namespace Laundry_Service_Management
{
    partial class StaffManagementPage
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.titleLbl = new System.Windows.Forms.Label();
            this.searchLbl = new System.Windows.Forms.Label();
            this.searchTxtBx = new System.Windows.Forms.TextBox();
            this.staffDataGridView = new System.Windows.Forms.DataGridView();
            this.formGroupBx = new System.Windows.Forms.GroupBox();
            this.clearBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.joinDatePicker = new System.Windows.Forms.DateTimePicker();
            this.joinDateLbl = new System.Windows.Forms.Label();
            this.passwordTxtBx = new System.Windows.Forms.TextBox();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.phoneTxtBx = new System.Windows.Forms.TextBox();
            this.phoneLbl = new System.Windows.Forms.Label();
            this.genderCmbBx = new System.Windows.Forms.ComboBox();
            this.genderLbl = new System.Windows.Forms.Label();
            this.nameTxtBx = new System.Windows.Forms.TextBox();
            this.nameLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.staffDataGridView)).BeginInit();
            this.formGroupBx.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.Location = new System.Drawing.Point(37, 32);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(188, 25);
            this.titleLbl.TabIndex = 0;
            this.titleLbl.Text = "Staff Management";
            // 
            // searchLbl
            // 
            this.searchLbl.AutoSize = true;
            this.searchLbl.Location = new System.Drawing.Point(39, 79);
            this.searchLbl.Name = "searchLbl";
            this.searchLbl.Size = new System.Drawing.Size(266, 16);
            this.searchLbl.TabIndex = 1;
            this.searchLbl.Text = "Search by ID/name/gender/phone/join date";
            // 
            // searchTxtBx
            // 
            this.searchTxtBx.Location = new System.Drawing.Point(42, 110);
            this.searchTxtBx.Name = "searchTxtBx";
            this.searchTxtBx.Size = new System.Drawing.Size(620, 22);
            this.searchTxtBx.TabIndex = 2;
            this.searchTxtBx.TextChanged += new System.EventHandler(this.searchTxtBx_TextChanged);
            // 
            // staffDataGridView
            // 
            this.staffDataGridView.AllowUserToAddRows = false;
            this.staffDataGridView.AllowUserToDeleteRows = false;
            this.staffDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.staffDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.staffDataGridView.Location = new System.Drawing.Point(42, 157);
            this.staffDataGridView.Name = "staffDataGridView";
            this.staffDataGridView.ReadOnly = true;
            this.staffDataGridView.RowHeadersWidth = 51;
            this.staffDataGridView.RowTemplate.Height = 24;
            this.staffDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.staffDataGridView.Size = new System.Drawing.Size(620, 472);
            this.staffDataGridView.TabIndex = 3;
            this.staffDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.staffDataGridView_CellClick);
            // 
            // formGroupBx
            // 
            this.formGroupBx.Controls.Add(this.clearBtn);
            this.formGroupBx.Controls.Add(this.deleteBtn);
            this.formGroupBx.Controls.Add(this.updateBtn);
            this.formGroupBx.Controls.Add(this.addBtn);
            this.formGroupBx.Controls.Add(this.joinDatePicker);
            this.formGroupBx.Controls.Add(this.joinDateLbl);
            this.formGroupBx.Controls.Add(this.passwordTxtBx);
            this.formGroupBx.Controls.Add(this.passwordLbl);
            this.formGroupBx.Controls.Add(this.phoneTxtBx);
            this.formGroupBx.Controls.Add(this.phoneLbl);
            this.formGroupBx.Controls.Add(this.genderCmbBx);
            this.formGroupBx.Controls.Add(this.genderLbl);
            this.formGroupBx.Controls.Add(this.nameTxtBx);
            this.formGroupBx.Controls.Add(this.nameLbl);
            this.formGroupBx.Location = new System.Drawing.Point(700, 91);
            this.formGroupBx.Name = "formGroupBx";
            this.formGroupBx.Size = new System.Drawing.Size(291, 538);
            this.formGroupBx.TabIndex = 4;
            this.formGroupBx.TabStop = false;
            this.formGroupBx.Text = "Staff Details";
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(161, 433);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(101, 38);
            this.clearBtn.TabIndex = 13;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(30, 433);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(101, 38);
            this.deleteBtn.TabIndex = 12;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(161, 376);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(101, 38);
            this.updateBtn.TabIndex = 11;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(30, 376);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(101, 38);
            this.addBtn.TabIndex = 10;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // joinDatePicker
            // 
            this.joinDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.joinDatePicker.Location = new System.Drawing.Point(30, 309);
            this.joinDatePicker.Name = "joinDatePicker";
            this.joinDatePicker.Size = new System.Drawing.Size(232, 22);
            this.joinDatePicker.TabIndex = 9;
            // 
            // joinDateLbl
            // 
            this.joinDateLbl.AutoSize = true;
            this.joinDateLbl.Location = new System.Drawing.Point(27, 285);
            this.joinDateLbl.Name = "joinDateLbl";
            this.joinDateLbl.Size = new System.Drawing.Size(64, 16);
            this.joinDateLbl.TabIndex = 8;
            this.joinDateLbl.Text = "Join Date";
            // 
            // passwordTxtBx
            // 
            this.passwordTxtBx.Location = new System.Drawing.Point(30, 245);
            this.passwordTxtBx.Name = "passwordTxtBx";
            this.passwordTxtBx.Size = new System.Drawing.Size(232, 22);
            this.passwordTxtBx.TabIndex = 7;
            this.passwordTxtBx.UseSystemPasswordChar = true;
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Location = new System.Drawing.Point(27, 221);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(67, 16);
            this.passwordLbl.TabIndex = 6;
            this.passwordLbl.Text = "Password";
            // 
            // phoneTxtBx
            // 
            this.phoneTxtBx.Location = new System.Drawing.Point(30, 181);
            this.phoneTxtBx.Name = "phoneTxtBx";
            this.phoneTxtBx.Size = new System.Drawing.Size(232, 22);
            this.phoneTxtBx.TabIndex = 5;
            // 
            // phoneLbl
            // 
            this.phoneLbl.AutoSize = true;
            this.phoneLbl.Location = new System.Drawing.Point(27, 157);
            this.phoneLbl.Name = "phoneLbl";
            this.phoneLbl.Size = new System.Drawing.Size(67, 16);
            this.phoneLbl.TabIndex = 4;
            this.phoneLbl.Text = "Phone No";
            // 
            // genderCmbBx
            // 
            this.genderCmbBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderCmbBx.FormattingEnabled = true;
            this.genderCmbBx.Items.AddRange(new object[] {
            "M",
            "F"});
            this.genderCmbBx.Location = new System.Drawing.Point(30, 118);
            this.genderCmbBx.Name = "genderCmbBx";
            this.genderCmbBx.Size = new System.Drawing.Size(232, 24);
            this.genderCmbBx.TabIndex = 3;
            // 
            // genderLbl
            // 
            this.genderLbl.AutoSize = true;
            this.genderLbl.Location = new System.Drawing.Point(27, 94);
            this.genderLbl.Name = "genderLbl";
            this.genderLbl.Size = new System.Drawing.Size(52, 16);
            this.genderLbl.TabIndex = 2;
            this.genderLbl.Text = "Gender";
            // 
            // nameTxtBx
            // 
            this.nameTxtBx.Location = new System.Drawing.Point(30, 55);
            this.nameTxtBx.Name = "nameTxtBx";
            this.nameTxtBx.Size = new System.Drawing.Size(232, 22);
            this.nameTxtBx.TabIndex = 1;
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(27, 31);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(44, 16);
            this.nameLbl.TabIndex = 0;
            this.nameLbl.Text = "Name";
            // 
            // StaffManagementPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.formGroupBx);
            this.Controls.Add(this.staffDataGridView);
            this.Controls.Add(this.searchTxtBx);
            this.Controls.Add(this.searchLbl);
            this.Controls.Add(this.titleLbl);
            this.Name = "StaffManagementPage";
            this.Size = new System.Drawing.Size(1046, 720);
            ((System.ComponentModel.ISupportInitialize)(this.staffDataGridView)).EndInit();
            this.formGroupBx.ResumeLayout(false);
            this.formGroupBx.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Label searchLbl;
        private System.Windows.Forms.TextBox searchTxtBx;
        private System.Windows.Forms.DataGridView staffDataGridView;
        private System.Windows.Forms.GroupBox formGroupBx;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.DateTimePicker joinDatePicker;
        private System.Windows.Forms.Label joinDateLbl;
        private System.Windows.Forms.TextBox passwordTxtBx;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.TextBox phoneTxtBx;
        private System.Windows.Forms.Label phoneLbl;
        private System.Windows.Forms.ComboBox genderCmbBx;
        private System.Windows.Forms.Label genderLbl;
        private System.Windows.Forms.TextBox nameTxtBx;
        private System.Windows.Forms.Label nameLbl;
    }
}
