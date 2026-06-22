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
            this.paymentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.laundryServiceManagementDbDataSet = new Laundry_Service_Management.LaundryServiceManagementDbDataSet();
            this.paymentsTableAdapter = new Laundry_Service_Management.LaundryServiceManagementDbDataSetTableAdapters.PaymentsTableAdapter();
            this.paymentidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentmethodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.card_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Actions = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laundryServiceManagementDbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBxSearchPayment
            // 
            this.txtBxSearchPayment.Location = new System.Drawing.Point(53, 139);
            this.txtBxSearchPayment.Name = "txtBxSearchPayment";
            this.txtBxSearchPayment.Size = new System.Drawing.Size(603, 22);
            this.txtBxSearchPayment.TabIndex = 6;
            // 
            // lblSearchPayment
            // 
            this.lblSearchPayment.AutoSize = true;
            this.lblSearchPayment.Location = new System.Drawing.Point(50, 108);
            this.lblSearchPayment.Name = "lblSearchPayment";
            this.lblSearchPayment.Size = new System.Drawing.Size(550, 16);
            this.lblSearchPayment.TabIndex = 5;
            this.lblSearchPayment.Text = "Search payment by payment ID/status/amount/payment date/payment method/card numbe" +
    "r";
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
            this.dgvPayment.AllowUserToAddRows = false;
            this.dgvPayment.AllowUserToDeleteRows = false;
            this.dgvPayment.AutoGenerateColumns = false;
            this.dgvPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.paymentidDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.paymentdateDataGridViewTextBoxColumn,
            this.paymentmethodDataGridViewTextBoxColumn,
            this.card_number,
            this.Actions});
            this.dgvPayment.DataSource = this.paymentsBindingSource;
            this.dgvPayment.Location = new System.Drawing.Point(53, 189);
            this.dgvPayment.Name = "dgvPayment";
            this.dgvPayment.ReadOnly = true;
            this.dgvPayment.RowHeadersWidth = 51;
            this.dgvPayment.RowTemplate.Height = 24;
            this.dgvPayment.Size = new System.Drawing.Size(852, 263);
            this.dgvPayment.TabIndex = 8;
            this.dgvPayment.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPayment_CellContentClick);
            this.dgvPayment.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvPayment_CellFormatting);
            // 
            // paymentsBindingSource
            // 
            this.paymentsBindingSource.DataMember = "Payments";
            this.paymentsBindingSource.DataSource = this.laundryServiceManagementDbDataSet;
            // 
            // laundryServiceManagementDbDataSet
            // 
            this.laundryServiceManagementDbDataSet.DataSetName = "LaundryServiceManagementDbDataSet";
            this.laundryServiceManagementDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // paymentsTableAdapter
            // 
            this.paymentsTableAdapter.ClearBeforeFill = true;
            // 
            // paymentidDataGridViewTextBoxColumn
            // 
            this.paymentidDataGridViewTextBoxColumn.DataPropertyName = "payment_id";
            this.paymentidDataGridViewTextBoxColumn.HeaderText = "Payment ID";
            this.paymentidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.paymentidDataGridViewTextBoxColumn.Name = "paymentidDataGridViewTextBoxColumn";
            this.paymentidDataGridViewTextBoxColumn.ReadOnly = true;
            this.paymentidDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn.Width = 125;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            this.amountDataGridViewTextBoxColumn.Width = 125;
            // 
            // paymentdateDataGridViewTextBoxColumn
            // 
            this.paymentdateDataGridViewTextBoxColumn.DataPropertyName = "payment_date";
            this.paymentdateDataGridViewTextBoxColumn.HeaderText = "Payment Date";
            this.paymentdateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.paymentdateDataGridViewTextBoxColumn.Name = "paymentdateDataGridViewTextBoxColumn";
            this.paymentdateDataGridViewTextBoxColumn.ReadOnly = true;
            this.paymentdateDataGridViewTextBoxColumn.Width = 125;
            // 
            // paymentmethodDataGridViewTextBoxColumn
            // 
            this.paymentmethodDataGridViewTextBoxColumn.DataPropertyName = "payment_method";
            this.paymentmethodDataGridViewTextBoxColumn.HeaderText = "Payment Method";
            this.paymentmethodDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.paymentmethodDataGridViewTextBoxColumn.Name = "paymentmethodDataGridViewTextBoxColumn";
            this.paymentmethodDataGridViewTextBoxColumn.ReadOnly = true;
            this.paymentmethodDataGridViewTextBoxColumn.Width = 125;
            // 
            // card_number
            // 
            this.card_number.DataPropertyName = "card_number";
            this.card_number.HeaderText = "Card Number";
            this.card_number.MinimumWidth = 6;
            this.card_number.Name = "card_number";
            this.card_number.ReadOnly = true;
            this.card_number.Width = 125;
            // 
            // Actions
            // 
            this.Actions.HeaderText = "Actions";
            this.Actions.MinimumWidth = 6;
            this.Actions.Name = "Actions";
            this.Actions.ReadOnly = true;
            this.Actions.Width = 125;
            // 
            // ViewPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.dgvPayment);
            this.Controls.Add(this.txtBxSearchPayment);
            this.Controls.Add(this.lblSearchPayment);
            this.Controls.Add(this.lblHistoryPayment);
            this.Name = "ViewPayment";
            this.Size = new System.Drawing.Size(975, 620);
            this.Load += new System.EventHandler(this.ViewPayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laundryServiceManagementDbDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBxSearchPayment;
        private System.Windows.Forms.Label lblSearchPayment;
        private System.Windows.Forms.Label lblHistoryPayment;
        private System.Windows.Forms.DataGridView dgvPayment;
        private System.Windows.Forms.BindingSource paymentsBindingSource;
        private LaundryServiceManagementDbDataSet laundryServiceManagementDbDataSet;
        private LaundryServiceManagementDbDataSetTableAdapters.PaymentsTableAdapter paymentsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentmethodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn card_number;
        private System.Windows.Forms.DataGridViewLinkColumn Actions;
    }
}
