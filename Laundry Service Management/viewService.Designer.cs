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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(viewService));
            this.viewServicelbl = new System.Windows.Forms.Label();
            this.searchlbl = new System.Windows.Forms.Label();
            this.txtBxSearch = new System.Windows.Forms.TextBox();
            this.laundryServiceManagementDbDataSet = new Laundry_Service_Management.LaundryServiceManagementDbDataSet();
            this.servicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.servicesTableAdapter = new Laundry_Service_Management.LaundryServiceManagementDbDataSetTableAdapters.ServicesTableAdapter();
            this.tableAdapterManager = new Laundry_Service_Management.LaundryServiceManagementDbDataSetTableAdapters.TableAdapterManager();
            this.servicesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.servicesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.servicesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addServiceBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.laundryServiceManagementDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingNavigator)).BeginInit();
            this.servicesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.servicesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // viewServicelbl
            // 
            this.viewServicelbl.AutoSize = true;
            this.viewServicelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewServicelbl.Location = new System.Drawing.Point(28, 26);
            this.viewServicelbl.Name = "viewServicelbl";
            this.viewServicelbl.Size = new System.Drawing.Size(111, 20);
            this.viewServicelbl.TabIndex = 0;
            this.viewServicelbl.Text = "View Service";
            // 
            // searchlbl
            // 
            this.searchlbl.AutoSize = true;
            this.searchlbl.Location = new System.Drawing.Point(29, 64);
            this.searchlbl.Name = "searchlbl";
            this.searchlbl.Size = new System.Drawing.Size(121, 13);
            this.searchlbl.TabIndex = 1;
            this.searchlbl.Text = "Search by service name";
            // 
            // txtBxSearch
            // 
            this.txtBxSearch.Location = new System.Drawing.Point(32, 89);
            this.txtBxSearch.Name = "txtBxSearch";
            this.txtBxSearch.Size = new System.Drawing.Size(517, 20);
            this.txtBxSearch.TabIndex = 2;
            this.txtBxSearch.TextChanged += new System.EventHandler(this.txtBxSearch_TextChanged);
            // 
            // laundryServiceManagementDbDataSet
            // 
            this.laundryServiceManagementDbDataSet.DataSetName = "LaundryServiceManagementDbDataSet";
            this.laundryServiceManagementDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // servicesBindingSource
            // 
            this.servicesBindingSource.DataMember = "Services";
            this.servicesBindingSource.DataSource = this.laundryServiceManagementDbDataSet;
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
            // servicesBindingNavigator
            // 
            this.servicesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.servicesBindingNavigator.BindingSource = this.servicesBindingSource;
            this.servicesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.servicesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.servicesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.servicesBindingNavigatorSaveItem});
            this.servicesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.servicesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.servicesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.servicesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.servicesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.servicesBindingNavigator.Name = "servicesBindingNavigator";
            this.servicesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.servicesBindingNavigator.Size = new System.Drawing.Size(784, 25);
            this.servicesBindingNavigator.TabIndex = 3;
            this.servicesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // servicesBindingNavigatorSaveItem
            // 
            this.servicesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.servicesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("servicesBindingNavigatorSaveItem.Image")));
            this.servicesBindingNavigatorSaveItem.Name = "servicesBindingNavigatorSaveItem";
            this.servicesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.servicesBindingNavigatorSaveItem.Text = "Save Data";
            this.servicesBindingNavigatorSaveItem.Click += new System.EventHandler(this.servicesBindingNavigatorSaveItem_Click);
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
            this.dataGridViewTextBoxColumn4});
            this.servicesDataGridView.DataSource = this.servicesBindingSource;
            this.servicesDataGridView.Location = new System.Drawing.Point(32, 128);
            this.servicesDataGridView.Name = "servicesDataGridView";
            this.servicesDataGridView.Size = new System.Drawing.Size(441, 220);
            this.servicesDataGridView.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "service_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "service_id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn2.HeaderText = "name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "description";
            this.dataGridViewTextBoxColumn3.HeaderText = "description";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "price";
            this.dataGridViewTextBoxColumn4.HeaderText = "price";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // addServiceBtn
            // 
            this.addServiceBtn.Location = new System.Drawing.Point(618, 74);
            this.addServiceBtn.Name = "addServiceBtn";
            this.addServiceBtn.Size = new System.Drawing.Size(125, 33);
            this.addServiceBtn.TabIndex = 5;
            this.addServiceBtn.Text = "ADD SERVICE";
            this.addServiceBtn.UseVisualStyleBackColor = true;
            this.addServiceBtn.Click += new System.EventHandler(this.addServiceBtn_Click);
            // 
            // viewService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.addServiceBtn);
            this.Controls.Add(this.servicesDataGridView);
            this.Controls.Add(this.servicesBindingNavigator);
            this.Controls.Add(this.txtBxSearch);
            this.Controls.Add(this.searchlbl);
            this.Controls.Add(this.viewServicelbl);
            this.Name = "viewService";
            this.Size = new System.Drawing.Size(784, 585);
            ((System.ComponentModel.ISupportInitialize)(this.laundryServiceManagementDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingNavigator)).EndInit();
            this.servicesBindingNavigator.ResumeLayout(false);
            this.servicesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.servicesDataGridView)).EndInit();
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
        private System.Windows.Forms.BindingNavigator servicesBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton servicesBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView servicesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button addServiceBtn;
    }
}
