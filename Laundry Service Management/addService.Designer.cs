namespace Laundry_Service_Management
{
    partial class addService
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
            this.serviceNamelbl = new System.Windows.Forms.Label();
            this.pricelbl = new System.Windows.Forms.Label();
            this.desclbl = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.txtBxServiceName = new System.Windows.Forms.TextBox();
            this.txtBxPrice = new System.Windows.Forms.TextBox();
            this.txtBxDesc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // serviceNamelbl
            // 
            this.serviceNamelbl.AutoSize = true;
            this.serviceNamelbl.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceNamelbl.Location = new System.Drawing.Point(125, 58);
            this.serviceNamelbl.Name = "serviceNamelbl";
            this.serviceNamelbl.Size = new System.Drawing.Size(90, 15);
            this.serviceNamelbl.TabIndex = 0;
            this.serviceNamelbl.Text = "Service Name :";
            // 
            // pricelbl
            // 
            this.pricelbl.AutoSize = true;
            this.pricelbl.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricelbl.Location = new System.Drawing.Point(125, 97);
            this.pricelbl.Name = "pricelbl";
            this.pricelbl.Size = new System.Drawing.Size(70, 15);
            this.pricelbl.TabIndex = 1;
            this.pricelbl.Text = "Price (RM) :";
            // 
            // desclbl
            // 
            this.desclbl.AutoSize = true;
            this.desclbl.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desclbl.Location = new System.Drawing.Point(125, 134);
            this.desclbl.Name = "desclbl";
            this.desclbl.Size = new System.Drawing.Size(76, 15);
            this.desclbl.TabIndex = 2;
            this.desclbl.Text = "Description :";
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(254, 212);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 3;
            this.addBtn.Text = "ADD";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.Location = new System.Drawing.Point(350, 212);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 4;
            this.cancelBtn.Text = "CANCEL";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // txtBxServiceName
            // 
            this.txtBxServiceName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxServiceName.Location = new System.Drawing.Point(254, 55);
            this.txtBxServiceName.Name = "txtBxServiceName";
            this.txtBxServiceName.Size = new System.Drawing.Size(265, 21);
            this.txtBxServiceName.TabIndex = 5;
            // 
            // txtBxPrice
            // 
            this.txtBxPrice.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxPrice.Location = new System.Drawing.Point(254, 94);
            this.txtBxPrice.Name = "txtBxPrice";
            this.txtBxPrice.Size = new System.Drawing.Size(265, 21);
            this.txtBxPrice.TabIndex = 6;
            // 
            // txtBxDesc
            // 
            this.txtBxDesc.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxDesc.Location = new System.Drawing.Point(254, 131);
            this.txtBxDesc.Name = "txtBxDesc";
            this.txtBxDesc.Size = new System.Drawing.Size(265, 21);
            this.txtBxDesc.TabIndex = 7;
            // 
            // addService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 711);
            this.Controls.Add(this.txtBxDesc);
            this.Controls.Add(this.txtBxPrice);
            this.Controls.Add(this.txtBxServiceName);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.desclbl);
            this.Controls.Add(this.pricelbl);
            this.Controls.Add(this.serviceNamelbl);
            this.Name = "addService";
            this.Text = "addService";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label serviceNamelbl;
        private System.Windows.Forms.Label pricelbl;
        private System.Windows.Forms.Label desclbl;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.TextBox txtBxServiceName;
        private System.Windows.Forms.TextBox txtBxPrice;
        private System.Windows.Forms.TextBox txtBxDesc;
    }
}