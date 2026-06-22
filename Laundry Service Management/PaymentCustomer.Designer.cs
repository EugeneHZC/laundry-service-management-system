namespace Laundry_Service_Management
{
    partial class PaymentCustomer
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
            this.rbCard = new System.Windows.Forms.RadioButton();
            this.rbQR = new System.Windows.Forms.RadioButton();
            this.lblPaymentMethod = new System.Windows.Forms.Label();
            this.dtpPayment = new System.Windows.Forms.DateTimePicker();
            this.txtBxAmount = new System.Windows.Forms.TextBox();
            this.btnConfirmPayment = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.Payment = new System.Windows.Forms.Label();
            this.qrPicBx = new System.Windows.Forms.PictureBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.statusCmbBx = new System.Windows.Forms.ComboBox();
            this.cardNoTxtBx = new System.Windows.Forms.TextBox();
            this.cardNoLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qrPicBx)).BeginInit();
            this.SuspendLayout();
            // 
            // rbCard
            // 
            this.rbCard.AutoSize = true;
            this.rbCard.Location = new System.Drawing.Point(342, 219);
            this.rbCard.Name = "rbCard";
            this.rbCard.Size = new System.Drawing.Size(137, 20);
            this.rbCard.TabIndex = 32;
            this.rbCard.TabStop = true;
            this.rbCard.Text = "Debit / Credit Card";
            this.rbCard.UseVisualStyleBackColor = true;
            this.rbCard.CheckedChanged += new System.EventHandler(this.rbQR_CheckedChanged);
            // 
            // rbQR
            // 
            this.rbQR.AutoSize = true;
            this.rbQR.Location = new System.Drawing.Point(253, 219);
            this.rbQR.Name = "rbQR";
            this.rbQR.Size = new System.Drawing.Size(48, 20);
            this.rbQR.TabIndex = 31;
            this.rbQR.TabStop = true;
            this.rbQR.Text = "QR";
            this.rbQR.UseVisualStyleBackColor = true;
            this.rbQR.CheckedChanged += new System.EventHandler(this.rbQR_CheckedChanged);
            // 
            // lblPaymentMethod
            // 
            this.lblPaymentMethod.AutoSize = true;
            this.lblPaymentMethod.Location = new System.Drawing.Point(97, 221);
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            this.lblPaymentMethod.Size = new System.Drawing.Size(111, 16);
            this.lblPaymentMethod.TabIndex = 30;
            this.lblPaymentMethod.Text = "Payment Method:";
            // 
            // dtpPayment
            // 
            this.dtpPayment.CustomFormat = "dd/MM/yyyy";
            this.dtpPayment.Enabled = false;
            this.dtpPayment.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPayment.Location = new System.Drawing.Point(253, 126);
            this.dtpPayment.Name = "dtpPayment";
            this.dtpPayment.Size = new System.Drawing.Size(226, 22);
            this.dtpPayment.TabIndex = 29;
            // 
            // txtBxAmount
            // 
            this.txtBxAmount.Enabled = false;
            this.txtBxAmount.Location = new System.Drawing.Point(253, 82);
            this.txtBxAmount.Name = "txtBxAmount";
            this.txtBxAmount.Size = new System.Drawing.Size(226, 22);
            this.txtBxAmount.TabIndex = 28;
            // 
            // btnConfirmPayment
            // 
            this.btnConfirmPayment.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnConfirmPayment.ForeColor = System.Drawing.Color.White;
            this.btnConfirmPayment.Location = new System.Drawing.Point(227, 301);
            this.btnConfirmPayment.Name = "btnConfirmPayment";
            this.btnConfirmPayment.Size = new System.Drawing.Size(133, 44);
            this.btnConfirmPayment.TabIndex = 24;
            this.btnConfirmPayment.Text = "Confirm Payment";
            this.btnConfirmPayment.UseVisualStyleBackColor = false;
            this.btnConfirmPayment.Click += new System.EventHandler(this.btnConfirmPayment_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(97, 132);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(95, 16);
            this.lblDate.TabIndex = 23;
            this.lblDate.Text = "Payment Date:";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(97, 88);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(89, 16);
            this.lblAmount.TabIndex = 22;
            this.lblAmount.Text = "Total Amount:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(97, 178);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(47, 16);
            this.lblStatus.TabIndex = 21;
            this.lblStatus.Text = "Status:";
            // 
            // Payment
            // 
            this.Payment.AutoSize = true;
            this.Payment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Payment.Location = new System.Drawing.Point(72, 34);
            this.Payment.Name = "Payment";
            this.Payment.Size = new System.Drawing.Size(96, 25);
            this.Payment.TabIndex = 19;
            this.Payment.Text = "Payment";
            // 
            // qrPicBx
            // 
            this.qrPicBx.Image = global::Laundry_Service_Management.Properties.Resources.qr_sample;
            this.qrPicBx.Location = new System.Drawing.Point(548, 82);
            this.qrPicBx.Name = "qrPicBx";
            this.qrPicBx.Size = new System.Drawing.Size(302, 263);
            this.qrPicBx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.qrPicBx.TabIndex = 33;
            this.qrPicBx.TabStop = false;
            this.qrPicBx.Visible = false;
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(366, 301);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(87, 44);
            this.saveBtn.TabIndex = 34;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Visible = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.cancelBtn.ForeColor = System.Drawing.Color.White;
            this.cancelBtn.Location = new System.Drawing.Point(143, 301);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(78, 44);
            this.cancelBtn.TabIndex = 35;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Visible = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // statusCmbBx
            // 
            this.statusCmbBx.Enabled = false;
            this.statusCmbBx.FormattingEnabled = true;
            this.statusCmbBx.Items.AddRange(new object[] {
            "Pending",
            "Success",
            "Failed"});
            this.statusCmbBx.Location = new System.Drawing.Point(253, 175);
            this.statusCmbBx.Name = "statusCmbBx";
            this.statusCmbBx.Size = new System.Drawing.Size(226, 24);
            this.statusCmbBx.TabIndex = 36;
            // 
            // cardNoTxtBx
            // 
            this.cardNoTxtBx.Location = new System.Drawing.Point(253, 254);
            this.cardNoTxtBx.Name = "cardNoTxtBx";
            this.cardNoTxtBx.Size = new System.Drawing.Size(226, 22);
            this.cardNoTxtBx.TabIndex = 38;
            this.cardNoTxtBx.Visible = false;
            // 
            // cardNoLbl
            // 
            this.cardNoLbl.AutoSize = true;
            this.cardNoLbl.Location = new System.Drawing.Point(97, 260);
            this.cardNoLbl.Name = "cardNoLbl";
            this.cardNoLbl.Size = new System.Drawing.Size(90, 16);
            this.cardNoLbl.TabIndex = 37;
            this.cardNoLbl.Text = "Card Number:";
            this.cardNoLbl.Visible = false;
            // 
            // PaymentCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(924, 484);
            this.Controls.Add(this.cardNoTxtBx);
            this.Controls.Add(this.cardNoLbl);
            this.Controls.Add(this.statusCmbBx);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.qrPicBx);
            this.Controls.Add(this.rbCard);
            this.Controls.Add(this.rbQR);
            this.Controls.Add(this.lblPaymentMethod);
            this.Controls.Add(this.dtpPayment);
            this.Controls.Add(this.txtBxAmount);
            this.Controls.Add(this.btnConfirmPayment);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.Payment);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PaymentCustomer";
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.PaymentCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qrPicBx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbCard;
        private System.Windows.Forms.RadioButton rbQR;
        private System.Windows.Forms.Label lblPaymentMethod;
        private System.Windows.Forms.DateTimePicker dtpPayment;
        private System.Windows.Forms.TextBox txtBxAmount;
        private System.Windows.Forms.Button btnConfirmPayment;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label Payment;
        private System.Windows.Forms.PictureBox qrPicBx;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.ComboBox statusCmbBx;
        private System.Windows.Forms.TextBox cardNoTxtBx;
        private System.Windows.Forms.Label cardNoLbl;
    }
}