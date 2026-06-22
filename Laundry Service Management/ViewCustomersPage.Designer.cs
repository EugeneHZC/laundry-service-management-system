namespace Laundry_Service_Management
{
    partial class ViewCustomersPage
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
            this.refreshBtn = new System.Windows.Forms.Button();
            this.customersDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.Location = new System.Drawing.Point(37, 32);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(166, 25);
            this.titleLbl.TabIndex = 0;
            this.titleLbl.Text = "View Customers";
            // 
            // searchLbl
            // 
            this.searchLbl.AutoSize = true;
            this.searchLbl.Location = new System.Drawing.Point(39, 79);
            this.searchLbl.Name = "searchLbl";
            this.searchLbl.Size = new System.Drawing.Size(275, 16);
            this.searchLbl.TabIndex = 1;
            this.searchLbl.Text = "Search by ID/name/gender/phone/join date";
            // 
            // searchTxtBx
            // 
            this.searchTxtBx.Location = new System.Drawing.Point(42, 110);
            this.searchTxtBx.Name = "searchTxtBx";
            this.searchTxtBx.Size = new System.Drawing.Size(688, 22);
            this.searchTxtBx.TabIndex = 2;
            this.searchTxtBx.TextChanged += new System.EventHandler(this.searchTxtBx_TextChanged);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(824, 91);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(167, 41);
            this.refreshBtn.TabIndex = 3;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // customersDataGridView
            // 
            this.customersDataGridView.AllowUserToAddRows = false;
            this.customersDataGridView.AllowUserToDeleteRows = false;
            this.customersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.customersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customersDataGridView.Location = new System.Drawing.Point(42, 157);
            this.customersDataGridView.Name = "customersDataGridView";
            this.customersDataGridView.ReadOnly = true;
            this.customersDataGridView.RowHeadersWidth = 51;
            this.customersDataGridView.RowTemplate.Height = 24;
            this.customersDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customersDataGridView.Size = new System.Drawing.Size(949, 472);
            this.customersDataGridView.TabIndex = 4;
            // 
            // ViewCustomersPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.customersDataGridView);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.searchTxtBx);
            this.Controls.Add(this.searchLbl);
            this.Controls.Add(this.titleLbl);
            this.Name = "ViewCustomersPage";
            this.Size = new System.Drawing.Size(1046, 720);
            ((System.ComponentModel.ISupportInitialize)(this.customersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Label searchLbl;
        private System.Windows.Forms.TextBox searchTxtBx;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.DataGridView customersDataGridView;
    }
}
