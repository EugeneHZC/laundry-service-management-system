namespace Laundry_Service_Management
{
    partial class BookingsPage
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
            this.bookingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.laundryServiceManagementDbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.searchTxtBx = new System.Windows.Forms.TextBox();
            this.bookAppointmentBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.remarksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryaddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryfromshopmethodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliverytoshopmethodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servicetypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalamountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servicetimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingsDGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.bookingsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laundryServiceManagementDbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // bookingsBindingSource
            // 
            this.bookingsBindingSource.DataMember = "Bookings";
            this.bookingsBindingSource.DataSource = this.laundryServiceManagementDbDataSetBindingSource;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search by booking date/service time/service type";
            // 
            // searchTxtBx
            // 
            this.searchTxtBx.Location = new System.Drawing.Point(42, 110);
            this.searchTxtBx.Name = "searchTxtBx";
            this.searchTxtBx.Size = new System.Drawing.Size(688, 22);
            this.searchTxtBx.TabIndex = 2;
            this.searchTxtBx.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // bookAppointmentBtn
            // 
            this.bookAppointmentBtn.Location = new System.Drawing.Point(824, 91);
            this.bookAppointmentBtn.Name = "bookAppointmentBtn";
            this.bookAppointmentBtn.Size = new System.Drawing.Size(167, 41);
            this.bookAppointmentBtn.TabIndex = 3;
            this.bookAppointmentBtn.Text = "Book Appointment";
            this.bookAppointmentBtn.UseVisualStyleBackColor = true;
            this.bookAppointmentBtn.Click += new System.EventHandler(this.bookAppointmentBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Bookings";
            // 
            // remarksDataGridViewTextBoxColumn
            // 
            this.remarksDataGridViewTextBoxColumn.DataPropertyName = "remarks";
            this.remarksDataGridViewTextBoxColumn.HeaderText = "Remarks";
            this.remarksDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.remarksDataGridViewTextBoxColumn.Name = "remarksDataGridViewTextBoxColumn";
            this.remarksDataGridViewTextBoxColumn.ReadOnly = true;
            this.remarksDataGridViewTextBoxColumn.Width = 125;
            // 
            // deliveryaddressDataGridViewTextBoxColumn
            // 
            this.deliveryaddressDataGridViewTextBoxColumn.DataPropertyName = "delivery_address";
            this.deliveryaddressDataGridViewTextBoxColumn.HeaderText = "Delivery Address";
            this.deliveryaddressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.deliveryaddressDataGridViewTextBoxColumn.Name = "deliveryaddressDataGridViewTextBoxColumn";
            this.deliveryaddressDataGridViewTextBoxColumn.ReadOnly = true;
            this.deliveryaddressDataGridViewTextBoxColumn.Width = 125;
            // 
            // deliveryfromshopmethodDataGridViewTextBoxColumn
            // 
            this.deliveryfromshopmethodDataGridViewTextBoxColumn.DataPropertyName = "delivery_from_shop_method";
            this.deliveryfromshopmethodDataGridViewTextBoxColumn.HeaderText = "Delivery From Shop Method";
            this.deliveryfromshopmethodDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.deliveryfromshopmethodDataGridViewTextBoxColumn.Name = "deliveryfromshopmethodDataGridViewTextBoxColumn";
            this.deliveryfromshopmethodDataGridViewTextBoxColumn.ReadOnly = true;
            this.deliveryfromshopmethodDataGridViewTextBoxColumn.Width = 125;
            // 
            // deliverytoshopmethodDataGridViewTextBoxColumn
            // 
            this.deliverytoshopmethodDataGridViewTextBoxColumn.DataPropertyName = "delivery_to_shop_method";
            this.deliverytoshopmethodDataGridViewTextBoxColumn.HeaderText = "Delivery To Shop Method";
            this.deliverytoshopmethodDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.deliverytoshopmethodDataGridViewTextBoxColumn.Name = "deliverytoshopmethodDataGridViewTextBoxColumn";
            this.deliverytoshopmethodDataGridViewTextBoxColumn.ReadOnly = true;
            this.deliverytoshopmethodDataGridViewTextBoxColumn.Width = 125;
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "Status";
            this.status.MinimumWidth = 6;
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Width = 125;
            // 
            // servicetypeDataGridViewTextBoxColumn
            // 
            this.servicetypeDataGridViewTextBoxColumn.DataPropertyName = "service_type";
            this.servicetypeDataGridViewTextBoxColumn.HeaderText = "Service Type";
            this.servicetypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.servicetypeDataGridViewTextBoxColumn.Name = "servicetypeDataGridViewTextBoxColumn";
            this.servicetypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.servicetypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalamountDataGridViewTextBoxColumn
            // 
            this.totalamountDataGridViewTextBoxColumn.DataPropertyName = "total_amount";
            this.totalamountDataGridViewTextBoxColumn.HeaderText = "Total Amount";
            this.totalamountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalamountDataGridViewTextBoxColumn.Name = "totalamountDataGridViewTextBoxColumn";
            this.totalamountDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalamountDataGridViewTextBoxColumn.Width = 125;
            // 
            // servicetimeDataGridViewTextBoxColumn
            // 
            this.servicetimeDataGridViewTextBoxColumn.DataPropertyName = "service_time";
            this.servicetimeDataGridViewTextBoxColumn.HeaderText = "Service Time";
            this.servicetimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.servicetimeDataGridViewTextBoxColumn.Name = "servicetimeDataGridViewTextBoxColumn";
            this.servicetimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.servicetimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // bookingdateDataGridViewTextBoxColumn
            // 
            this.bookingdateDataGridViewTextBoxColumn.DataPropertyName = "booking_date";
            this.bookingdateDataGridViewTextBoxColumn.HeaderText = "Booking Date";
            this.bookingdateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bookingdateDataGridViewTextBoxColumn.Name = "bookingdateDataGridViewTextBoxColumn";
            this.bookingdateDataGridViewTextBoxColumn.ReadOnly = true;
            this.bookingdateDataGridViewTextBoxColumn.Width = 125;
            // 
            // bookingidDataGridViewTextBoxColumn
            // 
            this.bookingidDataGridViewTextBoxColumn.DataPropertyName = "booking_id";
            this.bookingidDataGridViewTextBoxColumn.HeaderText = "Booking ID";
            this.bookingidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bookingidDataGridViewTextBoxColumn.Name = "bookingidDataGridViewTextBoxColumn";
            this.bookingidDataGridViewTextBoxColumn.ReadOnly = true;
            this.bookingidDataGridViewTextBoxColumn.Width = 125;
            // 
            // bookingsDGV
            // 
            this.bookingsDGV.AllowUserToAddRows = false;
            this.bookingsDGV.AllowUserToDeleteRows = false;
            this.bookingsDGV.AutoGenerateColumns = false;
            this.bookingsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookingsDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookingidDataGridViewTextBoxColumn,
            this.bookingdateDataGridViewTextBoxColumn,
            this.servicetimeDataGridViewTextBoxColumn,
            this.totalamountDataGridViewTextBoxColumn,
            this.servicetypeDataGridViewTextBoxColumn,
            this.status,
            this.deliverytoshopmethodDataGridViewTextBoxColumn,
            this.deliveryfromshopmethodDataGridViewTextBoxColumn,
            this.deliveryaddressDataGridViewTextBoxColumn,
            this.remarksDataGridViewTextBoxColumn});
            this.bookingsDGV.DataSource = this.bookingsBindingSource;
            this.bookingsDGV.Location = new System.Drawing.Point(42, 159);
            this.bookingsDGV.Name = "bookingsDGV";
            this.bookingsDGV.ReadOnly = true;
            this.bookingsDGV.RowHeadersWidth = 51;
            this.bookingsDGV.RowTemplate.Height = 24;
            this.bookingsDGV.Size = new System.Drawing.Size(940, 389);
            this.bookingsDGV.TabIndex = 0;
            // 
            // BookingsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bookAppointmentBtn);
            this.Controls.Add(this.searchTxtBx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bookingsDGV);
            this.Name = "BookingsPage";
            this.Size = new System.Drawing.Size(1046, 720);
            ((System.ComponentModel.ISupportInitialize)(this.bookingsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource bookingsBindingSource;
        private System.Windows.Forms.BindingSource laundryServiceManagementDbDataSetBindingSource;
        private LaundryServiceManagementDbDataSet laundryServiceManagementDbDataSet;
        private LaundryServiceManagementDbDataSetTableAdapters.BookingsTableAdapter bookingsTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchTxtBx;
        private System.Windows.Forms.Button bookAppointmentBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarksDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryaddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryfromshopmethodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliverytoshopmethodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn servicetypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalamountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn servicetimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView bookingsDGV;
    }
}
