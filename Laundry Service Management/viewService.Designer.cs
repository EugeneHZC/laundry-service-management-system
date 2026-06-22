namespace Laundry_Service_Management
{
    partial class viewService
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
            this.viewServicelbl = new System.Windows.Forms.Label();
            this.searchlbl = new System.Windows.Forms.Label();
            this.txtBxSearch = new System.Windows.Forms.TextBox();
            this.servicesDataGridView = new System.Windows.Forms.DataGridView();
            this.servicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.laundryServiceManagementDbDataSet = new Laundry_Service_Management.LaundryServiceManagementDbDataSet();
            this.addServiceBtn = new System.Windows.Forms.Button();
            this.servicesTableAdapter = new Laundry_Service_Management.LaundryServiceManagementDbDataSetTableAdapters.ServicesTableAdapter();
            this.tableAdapterManager = new Laundry_Service_Management.LaundryServiceManagementDbDataSetTableAdapters.TableAdapterManager();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Actions = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.servicesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laundryServiceManagementDbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // viewServicelbl
            // 
            this.viewServicelbl.AutoSize = true;
            this.viewServicelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewServicelbl.Location = new System.Drawing.Point(37, 32);
            this.viewServicelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.viewServicelbl.Name = "viewServicelbl";
            this.viewServicelbl.Size = new System.Drawing.Size(138, 25);
            this.viewServicelbl.TabIndex = 0;
            this.viewServicelbl.Text = "View Service";
            // 
            // searchlbl
            // 
            this.searchlbl.AutoSize = true;
            this.searchlbl.Location = new System.Drawing.Point(39, 79);
            this.searchlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.searchlbl.Name = "searchlbl";
            this.searchlbl.Size = new System.Drawing.Size(152, 16);
            this.searchlbl.TabIndex = 1;
            this.searchlbl.Text = "Search by service name";
            // 
            // txtBxSearch
            // 
            this.txtBxSearch.Location = new System.Drawing.Point(43, 110);
            this.txtBxSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtBxSearch.Name = "txtBxSearch";
            this.txtBxSearch.Size = new System.Drawing.Size(688, 22);
            this.txtBxSearch.TabIndex = 2;
            this.txtBxSearch.TextChanged += new System.EventHandler(this.txtBxSearch_TextChanged);
            // 
            // servicesDataGridView
            // 
            this.servicesDataGridView.AllowUserToAddRows = false;
            this.servicesDataGridView.AllowUserToDeleteRows = false;
            this.servicesDataGridView.AutoGenerateColumns = false;
            this.servicesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.servicesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.servicesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.status,
            this.Actions});
            this.servicesDataGridView.DataSource = this.servicesBindingSource;
            this.servicesDataGridView.Location = new System.Drawing.Point(43, 158);
            this.servicesDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.servicesDataGridView.Name = "servicesDataGridView";
            this.servicesDataGridView.ReadOnly = true;
            this.servicesDataGridView.RowHeadersWidth = 51;
            this.servicesDataGridView.Size = new System.Drawing.Size(901, 271);
            this.servicesDataGridView.TabIndex = 4;
            this.servicesDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.servicesDataGridView_CellContentClick);
            this.servicesDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.servicesDataGridView_CellFormatting);
            // 
            // servicesBindingSource
            // 
            this.servicesBindingSource.DataMember = "Services";
            this.servicesBindingSource.DataSource = this.laundryServiceManagementDbDataSet;
            // 
            // laundryServiceManagementDbDataSet
            // 
            this.laundryServiceManagementDbDataSet.DataSetName = "LaundryServiceManagementDbDataSet";
            this.laundryServiceManagementDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // addServiceBtn
            // 
            this.addServiceBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.addServiceBtn.ForeColor = System.Drawing.Color.White;
            this.addServiceBtn.Location = new System.Drawing.Point(777, 91);
            this.addServiceBtn.Margin = new System.Windows.Forms.Padding(4);
            this.addServiceBtn.Name = "addServiceBtn";
            this.addServiceBtn.Size = new System.Drawing.Size(167, 41);
            this.addServiceBtn.TabIndex = 5;
            this.addServiceBtn.Text = "Add Service";
            this.addServiceBtn.UseVisualStyleBackColor = false;
            this.addServiceBtn.Click += new System.EventHandler(this.addServiceBtn_Click);
            // 
            // servicesTableAdapter
            // 
            this.servicesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BookingsTableAdapter = null;
            this.tableAdapterManager.PaymentsTableAdapter = null;
            this.tableAdapterManager.ServiceBookingsTableAdapter = null;
            this.tableAdapterManager.ServicesTableAdapter = this.servicesTableAdapter;
            this.tableAdapterManager.UpdateOrder = Laundry_Service_Management.LaundryServiceManagementDbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "service_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Service ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "description";
            this.dataGridViewTextBoxColumn3.HeaderText = "Description";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "price";
            this.dataGridViewTextBoxColumn4.HeaderText = "Price";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "Status";
            this.status.MinimumWidth = 6;
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Actions
            // 
            this.Actions.HeaderText = "Actions";
            this.Actions.MinimumWidth = 6;
            this.Actions.Name = "Actions";
            this.Actions.ReadOnly = true;
            // 
            // viewService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.addServiceBtn);
            this.Controls.Add(this.servicesDataGridView);
            this.Controls.Add(this.txtBxSearch);
            this.Controls.Add(this.searchlbl);
            this.Controls.Add(this.viewServicelbl);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "viewService";
            this.Size = new System.Drawing.Size(1067, 720);
            ((System.ComponentModel.ISupportInitialize)(this.servicesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laundryServiceManagementDbDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label viewServicelbl;
        private System.Windows.Forms.Label searchlbl;
        private System.Windows.Forms.TextBox txtBxSearch;
        private LaundryServiceManagementDbDataSet laundryServiceManagementDbDataSet;
        private System.Windows.Forms.BindingSource servicesBindingSource;
        private LaundryServiceManagementDbDataSetTableAdapters.ServicesTableAdapter servicesTableAdapter;
        private LaundryServiceManagementDbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView servicesDataGridView;
        private System.Windows.Forms.Button addServiceBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn status;
        private System.Windows.Forms.DataGridViewLinkColumn Actions;
    }
}
