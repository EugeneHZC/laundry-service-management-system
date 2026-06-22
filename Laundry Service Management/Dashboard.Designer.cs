namespace Laundry_Service_Management
{
    partial class Dashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pendingDeliveryTxtBx = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.bookingsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.totalBookingsThisYearTxtBx = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.completedBookingsTxtBx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.scheduledBookingsTxtBx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.totalBookingsTxtBx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.totalCusThisYearTxtBx = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.totalCustomerTxtBx = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.revenueChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.totalRevenueThisYearTxtBx = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.averageRevenueTxtBx = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.totalRevenueTxtBx = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookingsChart)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.revenueChart)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pendingDeliveryTxtBx);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.bookingsChart);
            this.groupBox1.Controls.Add(this.totalBookingsThisYearTxtBx);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.completedBookingsTxtBx);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.scheduledBookingsTxtBx);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.totalBookingsTxtBx);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(59, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(531, 568);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bookings Statistics";
            // 
            // pendingDeliveryTxtBx
            // 
            this.pendingDeliveryTxtBx.Location = new System.Drawing.Point(291, 166);
            this.pendingDeliveryTxtBx.Name = "pendingDeliveryTxtBx";
            this.pendingDeliveryTxtBx.ReadOnly = true;
            this.pendingDeliveryTxtBx.Size = new System.Drawing.Size(163, 22);
            this.pendingDeliveryTxtBx.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(31, 169);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(176, 16);
            this.label11.TabIndex = 13;
            this.label11.Text = "Pending for Pickup/Delivery:";
            // 
            // bookingsChart
            // 
            chartArea1.Name = "ChartArea1";
            this.bookingsChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.bookingsChart.Legends.Add(legend1);
            this.bookingsChart.Location = new System.Drawing.Point(56, 310);
            this.bookingsChart.Name = "bookingsChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.bookingsChart.Series.Add(series1);
            this.bookingsChart.Size = new System.Drawing.Size(398, 234);
            this.bookingsChart.TabIndex = 12;
            this.bookingsChart.Text = "chart1";
            // 
            // totalBookingsThisYearTxtBx
            // 
            this.totalBookingsThisYearTxtBx.Location = new System.Drawing.Point(291, 80);
            this.totalBookingsThisYearTxtBx.Name = "totalBookingsThisYearTxtBx";
            this.totalBookingsThisYearTxtBx.ReadOnly = true;
            this.totalBookingsThisYearTxtBx.Size = new System.Drawing.Size(163, 22);
            this.totalBookingsThisYearTxtBx.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Total Bookings This Year:";
            // 
            // completedBookingsTxtBx
            // 
            this.completedBookingsTxtBx.Location = new System.Drawing.Point(291, 210);
            this.completedBookingsTxtBx.Name = "completedBookingsTxtBx";
            this.completedBookingsTxtBx.ReadOnly = true;
            this.completedBookingsTxtBx.Size = new System.Drawing.Size(163, 22);
            this.completedBookingsTxtBx.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Completed Bookings:";
            // 
            // scheduledBookingsTxtBx
            // 
            this.scheduledBookingsTxtBx.Location = new System.Drawing.Point(291, 123);
            this.scheduledBookingsTxtBx.Name = "scheduledBookingsTxtBx";
            this.scheduledBookingsTxtBx.ReadOnly = true;
            this.scheduledBookingsTxtBx.Size = new System.Drawing.Size(163, 22);
            this.scheduledBookingsTxtBx.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Scheduled Bookings:";
            // 
            // totalBookingsTxtBx
            // 
            this.totalBookingsTxtBx.Location = new System.Drawing.Point(291, 37);
            this.totalBookingsTxtBx.Name = "totalBookingsTxtBx";
            this.totalBookingsTxtBx.ReadOnly = true;
            this.totalBookingsTxtBx.Size = new System.Drawing.Size(163, 22);
            this.totalBookingsTxtBx.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Bookings:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(54, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Dashboard";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.totalCusThisYearTxtBx);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.totalCustomerTxtBx);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(608, 85);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(483, 120);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Customer Statistics";
            // 
            // totalCusThisYearTxtBx
            // 
            this.totalCusThisYearTxtBx.Location = new System.Drawing.Point(291, 80);
            this.totalCusThisYearTxtBx.Name = "totalCusThisYearTxtBx";
            this.totalCusThisYearTxtBx.ReadOnly = true;
            this.totalCusThisYearTxtBx.Size = new System.Drawing.Size(163, 22);
            this.totalCusThisYearTxtBx.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(232, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Total Customer Registered This Year:";
            // 
            // totalCustomerTxtBx
            // 
            this.totalCustomerTxtBx.Location = new System.Drawing.Point(291, 37);
            this.totalCustomerTxtBx.Name = "totalCustomerTxtBx";
            this.totalCustomerTxtBx.ReadOnly = true;
            this.totalCustomerTxtBx.Size = new System.Drawing.Size(163, 22);
            this.totalCustomerTxtBx.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Total Customer Registered:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.revenueChart);
            this.groupBox3.Controls.Add(this.totalRevenueThisYearTxtBx);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.averageRevenueTxtBx);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.totalRevenueTxtBx);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(608, 223);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(483, 430);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Revenue";
            // 
            // revenueChart
            // 
            chartArea2.Name = "ChartArea1";
            this.revenueChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.revenueChart.Legends.Add(legend2);
            this.revenueChart.Location = new System.Drawing.Point(126, 193);
            this.revenueChart.Name = "revenueChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.revenueChart.Series.Add(series2);
            this.revenueChart.Size = new System.Drawing.Size(300, 213);
            this.revenueChart.TabIndex = 20;
            this.revenueChart.Text = "chart1";
            // 
            // totalRevenueThisYearTxtBx
            // 
            this.totalRevenueThisYearTxtBx.Location = new System.Drawing.Point(290, 87);
            this.totalRevenueThisYearTxtBx.Name = "totalRevenueThisYearTxtBx";
            this.totalRevenueThisYearTxtBx.ReadOnly = true;
            this.totalRevenueThisYearTxtBx.Size = new System.Drawing.Size(163, 22);
            this.totalRevenueThisYearTxtBx.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 90);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(192, 16);
            this.label10.TabIndex = 18;
            this.label10.Text = "Total Revenue This Year (RM):";
            // 
            // averageRevenueTxtBx
            // 
            this.averageRevenueTxtBx.Location = new System.Drawing.Point(290, 133);
            this.averageRevenueTxtBx.Name = "averageRevenueTxtBx";
            this.averageRevenueTxtBx.ReadOnly = true;
            this.averageRevenueTxtBx.Size = new System.Drawing.Size(163, 22);
            this.averageRevenueTxtBx.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(229, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "Average Revenue Per Booking (RM):";
            // 
            // totalRevenueTxtBx
            // 
            this.totalRevenueTxtBx.Location = new System.Drawing.Point(290, 43);
            this.totalRevenueTxtBx.Name = "totalRevenueTxtBx";
            this.totalRevenueTxtBx.ReadOnly = true;
            this.totalRevenueTxtBx.Size = new System.Drawing.Size(163, 22);
            this.totalRevenueTxtBx.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Total Revenue (RM):";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Name = "Dashboard";
            this.Size = new System.Drawing.Size(1290, 689);
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookingsChart)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.revenueChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox totalBookingsTxtBx;
        private System.Windows.Forms.TextBox scheduledBookingsTxtBx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox completedBookingsTxtBx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox totalCusThisYearTxtBx;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox totalCustomerTxtBx;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox totalBookingsThisYearTxtBx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox totalRevenueThisYearTxtBx;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox averageRevenueTxtBx;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox totalRevenueTxtBx;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox pendingDeliveryTxtBx;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataVisualization.Charting.Chart bookingsChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart revenueChart;
    }
}
