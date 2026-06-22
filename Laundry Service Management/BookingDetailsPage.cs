using Laundry_Service_Management.models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Laundry_Service_Management
{
    public partial class BookingDetailsPage : Form
    {
        private Booking booking;

        public BookingDetailsPage(Booking booking)
        {
            InitializeComponent();
            addressTxtBx.Enabled = false;
            timeOfServiceDtp.ShowUpDown = true;
            this.booking = booking;
            LoadPage();

            if (Helper.UserRole != "Staff" && Helper.UserRole != "Admin")
            {
                statusLbl.Visible = false;
                statusCmbBx.Visible = false;
            }
            else
            {
                statusLbl.Visible = true;
                statusCmbBx.Visible = true;
            }

            dateOfServiceDtp.MinDate = DateTime.Now;
        }

        private bool ValidateInput()
        {
            if (serviceTypeCmbBx.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a service type.");
                return false;
            }
            else if (string.IsNullOrEmpty(dateOfServiceDtp.Value.ToString()) || string.IsNullOrEmpty(timeOfServiceDtp.Value.ToString()))
            {
                MessageBox.Show("Please select a valid date and time of service.");
                return false;
            }
            else if (DateTime.Parse($"{dateOfServiceDtp.Value.ToString("yyyy-MM-dd")} {timeOfServiceDtp.Value.ToString("HH:mm:ss")}") < DateTime.Now)
            {
                MessageBox.Show("Please select a date and time of service later than the current date time.");
                return false;
            }
            else if (!selfDeliveryRb.Checked && !deliveryToShopRb.Checked)
            {
                MessageBox.Show("Please select a delivery method to shop.");
                return false;
            }
            else if (servicesLsBx.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select at least one service.");
                return false;
            }
            else if (!deliveryFromShopRb.Checked && !selfPickupRb.Checked)
            {
                MessageBox.Show("Please select a collection method from shop.");
                return false;
            }
            else if (addressTxtBx.Enabled && string.IsNullOrEmpty(addressTxtBx.Text))
            {
                MessageBox.Show("Please enter a delivery address.");
                return false;
            }
            else if (Helper.UserRole != "Customer" && statusCmbBx.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a status to update.");
                return false;
            }

            return true;
        }

        private void LoadPage()
        {
            Helper.conn.Open();
            // get all available services
            SqlCommand cmd = Helper.conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM Services WHERE status = 1";
            var reader = cmd.ExecuteReader();
            var services = new List<Service>();
            while (reader.Read())
            {
                services.Add(
                    new Service()
                    {
                        service_id = (decimal)reader["service_id"],
                        name = reader["name"].ToString(),
                        description = reader["description"].ToString(),
                        price = (decimal)reader["price"]
                    }
                    );
            }
            Helper.conn.Close();

            servicesLsBx.DisplayMember = "name";
            servicesLsBx.ValueMember = "service_id";
            servicesLsBx.Items.Clear();
            servicesLsBx.DataSource = services;
            servicesLsBx.SelectedItems.Clear();

            if (booking.booking_id != 0)
            {
                Helper.conn.Open();
                string query = "SELECT * FROM ServiceBookings WHERE booking_id = @booking_id";
                cmd = new SqlCommand(query, Helper.conn);
                cmd.Parameters.AddWithValue("@booking_id", booking.booking_id);
                var serviceBookingsReader = cmd.ExecuteReader();
                var selectedServices = new List<decimal>();

                while (serviceBookingsReader.Read())
                {
                    selectedServices.Add(decimal.Parse(serviceBookingsReader["service_id"].ToString()));
                }

                serviceBookingsReader.Close();

                var filtered = services.Where(x => selectedServices.Contains(x.service_id)).ToList();

                serviceTypeCmbBx.Text = booking.service_type;
                filtered.ForEach(x => servicesLsBx.SelectedItems.Add(x));
                dateOfServiceDtp.Value = booking.service_time;
                timeOfServiceDtp.Value = booking.service_time;
                selfDeliveryRb.Checked = booking.delivery_to_shop_method == "Self Delivery";
                deliveryToShopRb.Checked = booking.delivery_to_shop_method == "Delivery";
                selfPickupRb.Checked = booking.delivery_from_shop_method == "Self Pickup";
                deliveryFromShopRb.Checked = booking.delivery_from_shop_method == "Delivery";
                addressTxtBx.Text = booking.delivery_address;
                remarksTxtBx.Text = booking.remarks;
                statusCmbBx.Text = booking.status;

                serviceTypeCmbBx.Enabled = false;
                dateOfServiceDtp.Enabled = false;
                timeOfServiceDtp.Enabled = false;
                selfDeliveryRb.Enabled = false;
                deliveryToShopRb.Enabled = false;
                servicesLsBx.Enabled = false;
                selfPickupRb.Enabled = false;
                deliveryFromShopRb.Enabled = false;
                addressTxtBx.Enabled = false;
                remarksTxtBx.Enabled = false;

                Helper.conn.Close();
            }

        }

        private decimal insertBookingGetId()
        {
            var bookingDate = DateTime.Now;
            var serviceTime = new DateTime(
                dateOfServiceDtp.Value.Year,
                dateOfServiceDtp.Value.Month,
                dateOfServiceDtp.Value.Day,
                timeOfServiceDtp.Value.Hour,
                timeOfServiceDtp.Value.Minute,
                timeOfServiceDtp.Value.Second
                );
            var totalAmount = 0;
            var serviceType = serviceTypeCmbBx.SelectedItem.ToString();
            var deliveryToShopMethod = selfDeliveryRb.Checked ? "Self Delivery" : "Delivery";
            var deliveryAddress = addressTxtBx.Text;
            var remarks = remarksTxtBx.Text;
            var deliveryFromShopMethod = selfPickupRb.Checked ? "Self Pickup" : "Delivery";

            Helper.conn.Open();
            string query = "INSERT INTO [Bookings] (booking_date, service_time, total_amount, service_type, status, delivery_from_shop_method, delivery_address, remarks, user_id, delivery_to_shop_method) " +
                "OUTPUT INSERTED.booking_id " +
                $"VALUES (@booking_date, @service_time, @total_amount, @service_type, 'Scheduled', @delivery_from_shop_method, @delivery_address, @remarks, @user_id, @delivery_to_shop_method)";
            SqlCommand cmd = new SqlCommand(query, Helper.conn);
            cmd.Parameters.AddWithValue("@booking_date", bookingDate.ToString("yyyy-MM-dd HH:mm:ss"));
            cmd.Parameters.AddWithValue("@service_time", serviceTime.ToString("yyyy-MM-dd HH:mm:ss"));
            cmd.Parameters.AddWithValue("@service_type", serviceType);
            cmd.Parameters.AddWithValue("@total_amount", totalAmount);
            cmd.Parameters.AddWithValue("@delivery_from_shop_method", deliveryFromShopMethod);
            cmd.Parameters.AddWithValue("@delivery_address", deliveryAddress);
            cmd.Parameters.AddWithValue("@remarks", remarks);
            cmd.Parameters.AddWithValue("@user_id", Helper.UserId);
            cmd.Parameters.AddWithValue("@delivery_to_shop_method", deliveryToShopMethod);

            var bookingId = (decimal)cmd.ExecuteScalar();
            Helper.conn.Close();
            return bookingId;
        }

        private decimal insertServiceBookingGetTotalAmount(decimal bookingId)
        {
            var services = servicesLsBx.SelectedItems.Cast<Service>().ToList();
            decimal total = 0;
            Helper.conn.Open();

            foreach (var s in services)
            {
                string query = "INSERT INTO ServiceBookings (amount, booking_id, service_id) " +
                    $"VALUES (@price, @booking_id, @service_id)";
                SqlCommand cmd = new SqlCommand(query, Helper.conn);
                cmd.Parameters.AddWithValue("@price", s.price);
                cmd.Parameters.AddWithValue("@booking_id", bookingId);
                cmd.Parameters.AddWithValue("@service_id", s.service_id);
                cmd.ExecuteNonQuery();
                total += s.price;
            }

            Helper.conn.Close();
            return total;
        }

        private void updateBookingAmount(decimal bookingId, decimal total)
        {
            Helper.conn.Open();
            string query = "UPDATE [Bookings] SET total_amount = @total WHERE booking_id = @booking_id";
            SqlCommand cmd = new SqlCommand(query, Helper.conn);
            cmd.Parameters.AddWithValue("@total", total);
            cmd.Parameters.AddWithValue("@booking_id", bookingId);
            cmd.ExecuteNonQuery();
            Helper.conn.Close();
        }

        private void updateStatus()
        {
            Helper.conn.Open();

            var status = statusCmbBx.SelectedItem.ToString();
            string query = "UPDATE [Bookings] SET status = @status WHERE booking_id = @booking_id";
            SqlCommand cmd = new SqlCommand(query, Helper.conn);
            cmd.Parameters.AddWithValue("@status", status);
            cmd.Parameters.AddWithValue("@booking_id", booking.booking_id);
            cmd.ExecuteNonQuery();

            Helper.conn.Close();
        }

        private void bookBtn_Click(object sender, System.EventArgs e)
        {
            if (!ValidateInput())
            {
                return;
            }

            if (Helper.UserRole == "Customer")
            {
                var bookingId = insertBookingGetId();
                var total = insertServiceBookingGetTotalAmount(bookingId);
                updateBookingAmount(bookingId, total);
                MessageBox.Show("Booking saved.");
            }
            else
            {
                updateStatus();
                MessageBox.Show("Status updated.");
            }

            this.Close();
        }

        private void cancelBtn_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void deliveryRb_CheckedChanged(object sender, EventArgs e)
        {
            if (deliveryToShopRb.Checked || deliveryFromShopRb.Checked)
            {
                addressTxtBx.Enabled = true;
            }
            else
            {
                addressTxtBx.Enabled = false;
            }
        }

        private void BookingDetailsPage_Load(object sender, EventArgs e)
        {

        }
    }
}
