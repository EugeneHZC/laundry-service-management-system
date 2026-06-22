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
            this.txtBxDesc = new System.Windows.Forms.TextBox();
            this.priceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.activeChkBx = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // serviceNamelbl
            // 
            this.serviceNamelbl.AutoSize = true;
            this.serviceNamelbl.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceNamelbl.Location = new System.Drawing.Point(167, 71);
            this.serviceNamelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.serviceNamelbl.Name = "serviceNamelbl";
            this.serviceNamelbl.Size = new System.Drawing.Size(108, 17);
            this.serviceNamelbl.TabIndex = 0;
            this.serviceNamelbl.Text = "Service Name :";
            // 
            // pricelbl
            // 
            this.pricelbl.AutoSize = true;
            this.pricelbl.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricelbl.Location = new System.Drawing.Point(167, 119);
            this.pricelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pricelbl.Name = "pricelbl";
            this.pricelbl.Size = new System.Drawing.Size(86, 17);
            this.pricelbl.TabIndex = 1;
            this.pricelbl.Text = "Price (RM) :";
            // 
            // desclbl
            // 
            this.desclbl.AutoSize = true;
            this.desclbl.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desclbl.Location = new System.Drawing.Point(167, 165);
            this.desclbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.desclbl.Name = "desclbl";
            this.desclbl.Size = new System.Drawing.Size(90, 17);
            this.desclbl.TabIndex = 2;
            this.desclbl.Text = "Description :";
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.addBtn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.ForeColor = System.Drawing.Color.White;
            this.addBtn.Location = new System.Drawing.Point(290, 275);
            this.addBtn.Margin = new System.Windows.Forms.Padding(4);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(117, 41);
            this.addBtn.TabIndex = 3;
            this.addBtn.Text = "Save";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.cancelBtn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.ForeColor = System.Drawing.Color.White;
            this.cancelBtn.Location = new System.Drawing.Point(432, 275);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(4);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(117, 41);
            this.cancelBtn.TabIndex = 4;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // txtBxServiceName
            // 
            this.txtBxServiceName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxServiceName.Location = new System.Drawing.Point(339, 68);
            this.txtBxServiceName.Margin = new System.Windows.Forms.Padding(4);
            this.txtBxServiceName.Name = "txtBxServiceName";
            this.txtBxServiceName.Size = new System.Drawing.Size(352, 25);
            this.txtBxServiceName.TabIndex = 5;
            // 
            // txtBxDesc
            // 
            this.txtBxDesc.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxDesc.Location = new System.Drawing.Point(339, 161);
            this.txtBxDesc.Margin = new System.Windows.Forms.Padding(4);
            this.txtBxDesc.Name = "txtBxDesc";
            this.txtBxDesc.Size = new System.Drawing.Size(352, 25);
            this.txtBxDesc.TabIndex = 7;
            // 
            // priceNumericUpDown
            // 
            this.priceNumericUpDown.DecimalPlaces = 2;
            this.priceNumericUpDown.Location = new System.Drawing.Point(339, 118);
            this.priceNumericUpDown.Maximum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            0});
            this.priceNumericUpDown.Name = "priceNumericUpDown";
            this.priceNumericUpDown.Size = new System.Drawing.Size(352, 22);
            this.priceNumericUpDown.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(167, 216);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Status :";
            // 
            // activeChkBx
            // 
            this.activeChkBx.AutoSize = true;
            this.activeChkBx.Location = new System.Drawing.Point(339, 216);
            this.activeChkBx.Name = "activeChkBx";
            this.activeChkBx.Size = new System.Drawing.Size(66, 20);
            this.activeChkBx.TabIndex = 10;
            this.activeChkBx.Text = "Active";
            this.activeChkBx.UseVisualStyleBackColor = true;
            // 
            // addService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(863, 364);
            this.Controls.Add(this.activeChkBx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.priceNumericUpDown);
            this.Controls.Add(this.txtBxDesc);
            this.Controls.Add(this.txtBxServiceName);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.desclbl);
            this.Controls.Add(this.pricelbl);
            this.Controls.Add(this.serviceNamelbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "addService";
            this.Text = "Service Details";
            ((System.ComponentModel.ISupportInitialize)(this.priceNumericUpDown)).EndInit();
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
        private System.Windows.Forms.TextBox txtBxDesc;
        private System.Windows.Forms.NumericUpDown priceNumericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox activeChkBx;
    }
}