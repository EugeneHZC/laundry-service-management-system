namespace Laundry_Service_Management
{
    partial class BookingDetailsPage
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
            this.serviceTypeCmbBx = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.selfPickupRb = new System.Windows.Forms.RadioButton();
            this.deliveryFromShopRb = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.addressTxtBx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.servicesLsBx = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.deliveryToShopRb = new System.Windows.Forms.RadioButton();
            this.selfDeliveryRb = new System.Windows.Forms.RadioButton();
            this.remarksTxtBx = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.timeOfServiceDtp = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateOfServiceDtp = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusCmbBx = new System.Windows.Forms.ComboBox();
            this.statusLbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Service Type:";
            // 
            // serviceTypeCmbBx
            // 
            this.serviceTypeCmbBx.FormattingEnabled = true;
            this.serviceTypeCmbBx.Items.AddRange(new object[] {
            "Self Service",
            "Worker Service"});
            this.serviceTypeCmbBx.Location = new System.Drawing.Point(321, 55);
            this.serviceTypeCmbBx.Name = "serviceTypeCmbBx";
            this.serviceTypeCmbBx.Size = new System.Drawing.Size(203, 25);
            this.serviceTypeCmbBx.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Collection Method From Shop:";
            // 
            // selfPickupRb
            // 
            this.selfPickupRb.AutoSize = true;
            this.selfPickupRb.Location = new System.Drawing.Point(321, 305);
            this.selfPickupRb.Name = "selfPickupRb";
            this.selfPickupRb.Size = new System.Drawing.Size(102, 21);
            this.selfPickupRb.TabIndex = 3;
            this.selfPickupRb.TabStop = true;
            this.selfPickupRb.Text = "Self Pickup";
            this.selfPickupRb.UseVisualStyleBackColor = true;
            // 
            // deliveryFromShopRb
            // 
            this.deliveryFromShopRb.AutoSize = true;
            this.deliveryFromShopRb.Location = new System.Drawing.Point(443, 305);
            this.deliveryFromShopRb.Name = "deliveryFromShopRb";
            this.deliveryFromShopRb.Size = new System.Drawing.Size(81, 21);
            this.deliveryFromShopRb.TabIndex = 4;
            this.deliveryFromShopRb.TabStop = true;
            this.deliveryFromShopRb.Text = "Delivery";
            this.deliveryFromShopRb.UseVisualStyleBackColor = true;
            this.deliveryFromShopRb.CheckedChanged += new System.EventHandler(this.deliveryRb_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 344);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Address to Deliver:";
            // 
            // addressTxtBx
            // 
            this.addressTxtBx.Location = new System.Drawing.Point(321, 342);
            this.addressTxtBx.Multiline = true;
            this.addressTxtBx.Name = "addressTxtBx";
            this.addressTxtBx.Size = new System.Drawing.Size(203, 94);
            this.addressTxtBx.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Service Available:";
            // 
            // servicesLsBx
            // 
            this.servicesLsBx.FormattingEnabled = true;
            this.servicesLsBx.ItemHeight = 17;
            this.servicesLsBx.Location = new System.Drawing.Point(321, 200);
            this.servicesLsBx.Name = "servicesLsBx";
            this.servicesLsBx.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.servicesLsBx.Size = new System.Drawing.Size(203, 89);
            this.servicesLsBx.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(103, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Delivery Method To Shop:";
            // 
            // deliveryToShopRb
            // 
            this.deliveryToShopRb.AutoSize = true;
            this.deliveryToShopRb.Location = new System.Drawing.Point(130, 3);
            this.deliveryToShopRb.Name = "deliveryToShopRb";
            this.deliveryToShopRb.Size = new System.Drawing.Size(81, 21);
            this.deliveryToShopRb.TabIndex = 11;
            this.deliveryToShopRb.TabStop = true;
            this.deliveryToShopRb.Text = "Delivery";
            this.deliveryToShopRb.UseVisualStyleBackColor = true;
            this.deliveryToShopRb.CheckedChanged += new System.EventHandler(this.deliveryRb_CheckedChanged);
            // 
            // selfDeliveryRb
            // 
            this.selfDeliveryRb.AutoSize = true;
            this.selfDeliveryRb.Location = new System.Drawing.Point(8, 3);
            this.selfDeliveryRb.Name = "selfDeliveryRb";
            this.selfDeliveryRb.Size = new System.Drawing.Size(110, 21);
            this.selfDeliveryRb.TabIndex = 10;
            this.selfDeliveryRb.TabStop = true;
            this.selfDeliveryRb.Text = "Self Delivery";
            this.selfDeliveryRb.UseVisualStyleBackColor = true;
            // 
            // remarksTxtBx
            // 
            this.remarksTxtBx.Location = new System.Drawing.Point(321, 455);
            this.remarksTxtBx.Multiline = true;
            this.remarksTxtBx.Name = "remarksTxtBx";
            this.remarksTxtBx.Size = new System.Drawing.Size(203, 94);
            this.remarksTxtBx.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(103, 457);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Remarks:";
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.cancelBtn.ForeColor = System.Drawing.Color.White;
            this.cancelBtn.Location = new System.Drawing.Point(146, 627);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(110, 37);
            this.cancelBtn.TabIndex = 14;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(365, 627);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(110, 37);
            this.saveBtn.TabIndex = 15;
            this.saveBtn.Text = "Pay";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.bookBtn_Click);
            // 
            // timeOfServiceDtp
            // 
            this.timeOfServiceDtp.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeOfServiceDtp.Location = new System.Drawing.Point(321, 128);
            this.timeOfServiceDtp.Name = "timeOfServiceDtp";
            this.timeOfServiceDtp.Size = new System.Drawing.Size(203, 25);
            this.timeOfServiceDtp.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(103, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Time of Service:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(103, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "Date of Service:";
            // 
            // dateOfServiceDtp
            // 
            this.dateOfServiceDtp.CustomFormat = "dd/MM/yyyy";
            this.dateOfServiceDtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateOfServiceDtp.Location = new System.Drawing.Point(321, 91);
            this.dateOfServiceDtp.Name = "dateOfServiceDtp";
            this.dateOfServiceDtp.Size = new System.Drawing.Size(203, 25);
            this.dateOfServiceDtp.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.selfDeliveryRb);
            this.panel1.Controls.Add(this.deliveryToShopRb);
            this.panel1.Location = new System.Drawing.Point(310, 164);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 28);
            this.panel1.TabIndex = 20;
            // 
            // statusCmbBx
            // 
            this.statusCmbBx.FormattingEnabled = true;
            this.statusCmbBx.Items.AddRange(new object[] {
            "Scheduled",
            "Pending Delivery",
            "Completed"});
            this.statusCmbBx.Location = new System.Drawing.Point(321, 570);
            this.statusCmbBx.Name = "statusCmbBx";
            this.statusCmbBx.Size = new System.Drawing.Size(203, 25);
            this.statusCmbBx.TabIndex = 22;
            // 
            // statusLbl
            // 
            this.statusLbl.AutoSize = true;
            this.statusLbl.Location = new System.Drawing.Point(103, 573);
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(54, 17);
            this.statusLbl.TabIndex = 21;
            this.statusLbl.Text = "Status:";
            // 
            // BookingDetailsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(647, 711);
            this.Controls.Add(this.statusCmbBx);
            this.Controls.Add(this.statusLbl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateOfServiceDtp);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.timeOfServiceDtp);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.remarksTxtBx);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.servicesLsBx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.addressTxtBx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.deliveryFromShopRb);
            this.Controls.Add(this.selfPickupRb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.serviceTypeCmbBx);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "BookingDetailsPage";
            this.Text = "Book Service";
            this.Load += new System.EventHandler(this.BookingDetailsPage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox serviceTypeCmbBx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton selfPickupRb;
        private System.Windows.Forms.RadioButton deliveryFromShopRb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox addressTxtBx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox servicesLsBx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton deliveryToShopRb;
        private System.Windows.Forms.RadioButton selfDeliveryRb;
        private System.Windows.Forms.TextBox remarksTxtBx;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.DateTimePicker timeOfServiceDtp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateOfServiceDtp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox statusCmbBx;
        private System.Windows.Forms.Label statusLbl;
    }
}