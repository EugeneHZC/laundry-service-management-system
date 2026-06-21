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
            this.txtBxStatus = new System.Windows.Forms.TextBox();
            this.txtBxPayment = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirmPayment = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblPaymentID = new System.Windows.Forms.Label();
            this.Payment = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rbCard
            // 
            this.rbCard.AutoSize = true;
            this.rbCard.Location = new System.Drawing.Point(348, 204);
            this.rbCard.Name = "rbCard";
            this.rbCard.Size = new System.Drawing.Size(137, 20);
            this.rbCard.TabIndex = 32;
            this.rbCard.TabStop = true;
            this.rbCard.Text = "Debit / Credit Card";
            this.rbCard.UseVisualStyleBackColor = true;
            // 
            // rbQR
            // 
            this.rbQR.AutoSize = true;
            this.rbQR.Location = new System.Drawing.Point(259, 206);
            this.rbQR.Name = "rbQR";
            this.rbQR.Size = new System.Drawing.Size(48, 20);
            this.rbQR.TabIndex = 31;
            this.rbQR.TabStop = true;
            this.rbQR.Text = "QR";
            this.rbQR.UseVisualStyleBackColor = true;
            // 
            // lblPaymentMethod
            // 
            this.lblPaymentMethod.AutoSize = true;
            this.lblPaymentMethod.Location = new System.Drawing.Point(103, 208);
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            this.lblPaymentMethod.Size = new System.Drawing.Size(111, 16);
            this.lblPaymentMethod.TabIndex = 30;
            this.lblPaymentMethod.Text = "Payment Method:";
            // 
            // dtpPayment
            // 
            this.dtpPayment.Location = new System.Drawing.Point(259, 253);
            this.dtpPayment.Name = "dtpPayment";
            this.dtpPayment.Size = new System.Drawing.Size(200, 22);
            this.dtpPayment.TabIndex = 29;
            // 
            // txtBxAmount
            // 
            this.txtBxAmount.Location = new System.Drawing.Point(259, 155);
            this.txtBxAmount.Name = "txtBxAmount";
            this.txtBxAmount.Size = new System.Drawing.Size(129, 22);
            this.txtBxAmount.TabIndex = 28;
            // 
            // txtBxStatus
            // 
            this.txtBxStatus.Location = new System.Drawing.Point(259, 303);
            this.txtBxStatus.Name = "txtBxStatus";
            this.txtBxStatus.Size = new System.Drawing.Size(129, 22);
            this.txtBxStatus.TabIndex = 27;
            // 
            // txtBxPayment
            // 
            this.txtBxPayment.Location = new System.Drawing.Point(259, 113);
            this.txtBxPayment.Name = "txtBxPayment";
            this.txtBxPayment.Size = new System.Drawing.Size(129, 22);
            this.txtBxPayment.TabIndex = 26;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(352, 385);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(133, 44);
            this.btnCancel.TabIndex = 25;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirmPayment
            // 
            this.btnConfirmPayment.Location = new System.Drawing.Point(106, 385);
            this.btnConfirmPayment.Name = "btnConfirmPayment";
            this.btnConfirmPayment.Size = new System.Drawing.Size(133, 44);
            this.btnConfirmPayment.TabIndex = 24;
            this.btnConfirmPayment.Text = "Confirm Payment";
            this.btnConfirmPayment.UseVisualStyleBackColor = true;
            this.btnConfirmPayment.Click += new System.EventHandler(this.btnConfirmPayment_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(103, 259);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(95, 16);
            this.lblDate.TabIndex = 23;
            this.lblDate.Text = "Payment Date:";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(103, 161);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(89, 16);
            this.lblAmount.TabIndex = 22;
            this.lblAmount.Text = "Total Amount:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(103, 309);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(47, 16);
            this.lblStatus.TabIndex = 21;
            this.lblStatus.Text = "Status:";
            // 
            // lblPaymentID
            // 
            this.lblPaymentID.AutoSize = true;
            this.lblPaymentID.Location = new System.Drawing.Point(103, 114);
            this.lblPaymentID.Name = "lblPaymentID";
            this.lblPaymentID.Size = new System.Drawing.Size(79, 16);
            this.lblPaymentID.TabIndex = 20;
            this.lblPaymentID.Text = "Payment ID:";
            // 
            // Payment
            // 
            this.Payment.AutoSize = true;
            this.Payment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Payment.Location = new System.Drawing.Point(103, 34);
            this.Payment.Name = "Payment";
            this.Payment.Size = new System.Drawing.Size(96, 25);
            this.Payment.TabIndex = 19;
            this.Payment.Text = "Payment";
            // 
            // PaymentCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 484);
            this.Controls.Add(this.rbCard);
            this.Controls.Add(this.rbQR);
            this.Controls.Add(this.lblPaymentMethod);
            this.Controls.Add(this.dtpPayment);
            this.Controls.Add(this.txtBxAmount);
            this.Controls.Add(this.txtBxStatus);
            this.Controls.Add(this.txtBxPayment);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirmPayment);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblPaymentID);
            this.Controls.Add(this.Payment);
            this.Name = "PaymentCustomer";
            this.Text = "Payment Customer";
            this.Load += new System.EventHandler(this.PaymentCustomer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbCard;
        private System.Windows.Forms.RadioButton rbQR;
        private System.Windows.Forms.Label lblPaymentMethod;
        private System.Windows.Forms.DateTimePicker dtpPayment;
        private System.Windows.Forms.TextBox txtBxAmount;
        private System.Windows.Forms.TextBox txtBxStatus;
        private System.Windows.Forms.TextBox txtBxPayment;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirmPayment;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblPaymentID;
        private System.Windows.Forms.Label Payment;
    }
}