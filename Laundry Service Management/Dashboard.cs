using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Laundry_Service_Management
{
    public partial class Dashboard : UserControl
    {
        private int completedBookings;
        private int scheduledBookings;
        private int pendingDeliveryBookings;
        private int currentYear = DateTime.Now.Year;

        public Dashboard()
        {
            InitializeComponent();
            LoadBookingStats();
            LoadCustomerStats();
            LoadRevenue();
            LoadChart();
        }

        private void LoadBookingStats()
        {
            Helper.conn.Open();

            SqlCommand cmd = Helper.conn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "SELECT COUNT(*) as total_bookings FROM [Bookings]";
            var totalBookingsResult = cmd.ExecuteScalar();
            totalBookingsTxtBx.Text = totalBookingsResult.ToString();

            cmd.CommandText = $"SELECT COUNT(*) as total_bookings FROM [Bookings] WHERE YEAR(booking_date) = {currentYear}";
            var totalBookingsThisYear = cmd.ExecuteScalar();
            totalBookingsThisYearTxtBx.Text = totalBookingsThisYear.ToString();

            cmd.CommandText = "SELECT COUNT(*) as scheduled_bookings FROM [Bookings] WHERE status = 'Scheduled'";
            scheduledBookings = (int)cmd.ExecuteScalar();
            scheduledBookingsTxtBx.Text = scheduledBookings.ToString();

            cmd.CommandText = "SELECT COUNT(*) as completed_bookings FROM [Bookings] WHERE status = 'Completed'";
            completedBookings = (int)cmd.ExecuteScalar();
            completedBookingsTxtBx.Text = completedBookings.ToString();

            cmd.CommandText = "SELECT COUNT(*) as pending_delivery_bookings FROM [Bookings] WHERE status = 'Pending Delivery'";
            pendingDeliveryBookings = (int)cmd.ExecuteScalar();
            pendingDeliveryTxtBx.Text = pendingDeliveryBookings.ToString();

            Helper.conn.Close();
        }

        private void LoadCustomerStats()
        {
            Helper.conn.Open();
            SqlCommand cmd = Helper.conn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;

            cmd.CommandText = "SELECT COUNT(*) as total_customers FROM [Users] WHERE role = 'Customer'";
            var totalCustomers = cmd.ExecuteScalar();
            totalCustomerTxtBx.Text = totalCustomers.ToString();

            cmd.CommandText = $"SELECT COUNT(*) as total_customers_this_year FROM [Users] WHERE role = 'Customer' AND YEAR(join_date) = {currentYear}";
            var totalCustomersThisYear = cmd.ExecuteScalar();
            totalCusThisYearTxtBx.Text = totalCustomersThisYear.ToString();

            Helper.conn.Close();
        }

        private void LoadRevenue()
        {
            Helper.conn.Open();

            SqlCommand cmd = Helper.conn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;

            cmd.CommandText = $"SELECT SUM(total_amount) AS total_revenue_this_year FROM [Bookings] WHERE status = 'Completed' AND YEAR(booking_date) = {currentYear}";
            var totalRevenueThisYear = cmd.ExecuteScalar();

            if (!decimal.TryParse(totalRevenueThisYear.ToString(), out var totalRevenueThisYearDec))
            {
                totalRevenueThisYearDec = 0;
            }

            totalRevenueThisYearTxtBx.Text = totalRevenueThisYearDec.ToString();

            cmd.CommandText = "SELECT SUM(total_amount) AS total_revenue FROM [Bookings] WHERE status = 'Completed'";
            var totalRevenue = cmd.ExecuteScalar();

            if (!decimal.TryParse(totalRevenue.ToString(), out var totalRevenueDec))
            {
                totalRevenueDec = 0;
            }

            totalRevenueTxtBx.Text = totalRevenueDec.ToString();
            var completedBookingsResult = int.Parse(completedBookingsTxtBx.Text);

            if (completedBookingsResult == 0)
            {
                averageRevenueTxtBx.Text = "0.00";
            }
            else
            {
                var averageRevenue = totalRevenueDec / completedBookingsResult;
                averageRevenueTxtBx.Text = averageRevenue.ToString();
            }

            Helper.conn.Close();
        }

        private void LoadChart()
        {
            // clear all existing charts
            bookingsChart.Series.Clear();
            // create a new bookings chart
            var series = new Series("Bookings");
            // set the chart type as pie chart
            series.ChartType = SeriesChartType.Pie;

            // add the data into the pie chart
            series.Points.AddXY("Scheduled", scheduledBookings);
            series.Points.AddXY("Completed", completedBookings);
            series.Points.AddXY("Pending Delivery", pendingDeliveryBookings);
            // add the chart into the chart object
            bookingsChart.Series.Add(series);
            // show the value as the label in the pie chart (instead of using the name as the label)
            series.IsValueShownAsLabel = true;

            Helper.conn.Open();

            SqlCommand cmd = Helper.conn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;

            cmd.CommandText = $"SELECT SUM(total_amount) AS total_revenue_this_year FROM [Bookings] WHERE status = 'Completed' AND YEAR(booking_date) = {currentYear}";
            var totalRevenueThisYear = cmd.ExecuteScalar();

            if (!decimal.TryParse(totalRevenueThisYear.ToString(), out var totalRevenueThisYearDec))
            {
                totalRevenueThisYearDec = 0;
            }

            cmd.CommandText = $"SELECT SUM(total_amount) AS total_revenue_prev_year FROM [Bookings] WHERE status = 'Completed' AND YEAR(booking_date) != {currentYear}";
            var totalRevenuePrevYear = cmd.ExecuteScalar();

            if (!decimal.TryParse(totalRevenuePrevYear.ToString(), out var totalRevenuePrevYearDec))
            {
                totalRevenuePrevYearDec = 0;
            }

            Helper.conn.Close();

            revenueChart.Series.Clear();
            var revenuePreviousYearSeries = new Series("Previous Year");
            revenuePreviousYearSeries.ChartType = SeriesChartType.Column;
            revenuePreviousYearSeries.Points.AddY(totalRevenuePrevYearDec);

            var revenueCurrentYearSeries = new Series("Current Year");
            revenueCurrentYearSeries.ChartType = SeriesChartType.Column;
            revenueCurrentYearSeries.Points.AddY(totalRevenueThisYearDec);

            revenueChart.ChartAreas[0].AxisX.Title = "Year";
            revenueChart.ChartAreas[0].AxisY.Title = "Revenue (RM)";
            revenueChart.ChartAreas[0].AxisX.LabelStyle.Enabled = false;

            revenueChart.Series.Add(revenuePreviousYearSeries);
            revenueChart.Series.Add(revenueCurrentYearSeries);
        }
    }
}
