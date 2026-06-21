namespace Laundry_Service_Management
{
    partial class ViewPayment
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
            this.txtBxSearchPayment = new System.Windows.Forms.TextBox();
            this.lblSearchPayment = new System.Windows.Forms.Label();
            this.lblHistoryPayment = new System.Windows.Forms.Label();
            this.dgvPayment = new System.Windows.Forms.DataGridView();
            this.laundryServiceManagementDbDataSet = new Laundry_Service_Management.LaundryServiceManagementDbDataSet();
            this.paymentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paymentsTableAdapter = new Laundry_Service_Management.LaundryServiceManagementDbDataSetTableAdapters.PaymentsTableAdapter();
            this.paymentidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentmethodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laundryServiceManagementDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBxSearchPayment
            // 
            this.txtBxSearchPayment.Location = new System.Drawing.Point(173, 128);
            this.txtBxSearchPayment.Name = "txtBxSearchPayment";
            this.txtBxSearchPayment.Size = new System.Drawing.Size(322, 22);
            this.txtBxSearchPayment.TabIndex = 6;
            // 
            // lblSearchPayment
            // 
            this.lblSearchPayment.AutoSize = true;
            this.lblSearchPayment.Location = new System.Drawing.Point(48, 131);
            this.lblSearchPayment.Name = "lblSearchPayment";
            this.lblSearchPayment.Size = new System.Drawing.Size(109, 16);
            this.lblSearchPayment.TabIndex = 5;
            this.lblSearchPayment.Text = "Search Payment:";
            // 
            // lblHistoryPayment
            // 
            this.lblHistoryPayment.AutoSize = true;
            this.lblHistoryPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistoryPayment.Location = new System.Drawing.Point(48, 54);
            this.lblHistoryPayment.Name = "lblHistoryPayment";
            this.lblHistoryPayment.Size = new System.Drawing.Size(169, 25);
            this.lblHistoryPayment.TabIndex = 4;
            this.lblHistoryPayment.Text = "History Payment";
            // 
            // dgvPayment
            // 
            this.dgvPayment.AutoGenerateColumns = false;
            this.dgvPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.paymentidDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.paymentdateDataGridViewTextBoxColumn,
            this.paymentmethodDataGridViewTextBoxColumn});
            this.dgvPayment.DataSource = this.paymentsBindingSource;
            this.dgvPayment.Location = new System.Drawing.Point(53, 189);
            this.dgvPayment.Name = "dgvPayment";
            this.dgvPayment.RowHeadersWidth = 51;
            this.dgvPayment.RowTemplate.Height = 24;
            this.dgvPayment.Size = new System.Drawing.Size(685, 263);
            this.dgvPayment.TabIndex = 8;
            // 
            // laundryServiceManagementDbDataSet
            // 
            this.laundryServiceManagementDbDataSet.DataSetName = "LaundryServiceManagementDbDataSet";
            this.laundryServiceManagementDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // paymentsBindingSource
            // 
            this.paymentsBindingSource.DataMember = "Payments";
            this.paymentsBindingSource.DataSource = this.laundryServiceManagementDbDataSet;
            // 
            // paymentsTableAdapter
            // 
            this.paymentsTableAdapter.ClearBeforeFill = true;
            // 
            // paymentidDataGridViewTextBoxColumn
            // 
            this.paymentidDataGridViewTextBoxColumn.DataPropertyName = "payment_id";
            this.paymentidDataGridViewTextBoxColumn.HeaderText = "payment_id";
            this.paymentidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.paymentidDataGridViewTextBoxColumn.Name = "paymentidDataGridViewTextBoxColumn";
            this.paymentidDataGridViewTextBoxColumn.ReadOnly = true;
            this.paymentidDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Width = 125;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "amount";
            this.amountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.Width = 125;
            // 
            // paymentdateDataGridViewTextBoxColumn
            // 
            this.paymentdateDataGridViewTextBoxColumn.DataPropertyName = "payment_date";
            this.paymentdateDataGridViewTextBoxColumn.HeaderText = "payment_date";
            this.paymentdateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.paymentdateDataGridViewTextBoxColumn.Name = "paymentdateDataGridViewTextBoxColumn";
            this.paymentdateDataGridViewTextBoxColumn.Width = 125;
            // 
            // paymentmethodDataGridViewTextBoxColumn
            // 
            this.paymentmethodDataGridViewTextBoxColumn.DataPropertyName = "payment_method";
            this.paymentmethodDataGridViewTextBoxColumn.HeaderText = "payment_method";
            this.paymentmethodDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.paymentmethodDataGridViewTextBoxColumn.Name = "paymentmethodDataGridViewTextBoxColumn";
            this.paymentmethodDataGridViewTextBoxColumn.Width = 125;
            // 
            // ViewPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvPayment);
            this.Controls.Add(this.txtBxSearchPayment);
            this.Controls.Add(this.lblSearchPayment);
            this.Controls.Add(this.lblHistoryPayment);
            this.Name = "ViewPayment";
            this.Size = new System.Drawing.Size(975, 620);
            this.Load += new System.EventHandler(this.ViewPayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laundryServiceManagementDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBxSearchPayment;
        private System.Windows.Forms.Label lblSearchPayment;
        private System.Windows.Forms.Label lblHistoryPayment;
        private System.Windows.Forms.DataGridView dgvPayment;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentmethodDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource paymentsBindingSource;
        private LaundryServiceManagementDbDataSet laundryServiceManagementDbDataSet;
        private LaundryServiceManagementDbDataSetTableAdapters.PaymentsTableAdapter paymentsTableAdapter;
    }
}
