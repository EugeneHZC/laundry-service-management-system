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
            SqlCommand cmd = Helper.conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM Services";
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
                cmd.CommandText = $"SELECT * FROM ServiceBookings WHERE booking_id = {booking.booking_id}";
                var serviceBookingsReader = cmd.ExecuteReader();
                var selectedServices = new List<decimal>();

                while (serviceBookingsReader.Read())
                {
                    selectedServices.Add(decimal.Parse(serviceBookingsReader["service_id"].ToString()));
                }

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
            Helper.UserId = 1;
            Helper.conn.Open();
            SqlCommand cmd = Helper.conn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "INSERT INTO [Bookings] (booking_date, service_time, total_amount, service_type, status, delivery_from_shop_method, delivery_address, remarks, user_id, delivery_to_shop_method) " +
                "OUTPUT INSERTED.booking_id " +
                $"VALUES ('{bookingDate.ToString("yyyy-MM-dd HH:mm:ss")}', '{serviceTime.ToString("yyyy-MM-dd HH:mm:ss")}', {totalAmount}, '{serviceType}', 'Scheduled', '{deliveryFromShopMethod}', '{deliveryAddress}', '{remarks}', {Helper.UserId}, '{deliveryToShopMethod}')";

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
                SqlCommand cmd = Helper.conn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "INSERT INTO ServiceBookings (amount, booking_id, service_id) " +
                    $"VALUES ({s.price}, {bookingId}, {s.service_id})";
                cmd.ExecuteNonQuery();
                total += s.price;
            }

            Helper.conn.Close();
            return total;
        }

        private void updateBookingAmount(decimal bookingId, decimal total)
        {
            Helper.conn.Open();
            SqlCommand sqlCommand = Helper.conn.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = $"UPDATE [Bookings] SET total_amount = {total} WHERE booking_id = {bookingId}";
            sqlCommand.ExecuteNonQuery();
            Helper.conn.Close();
        }

        private void updateStatus()
        {
            Helper.conn.Open();

            SqlCommand sqlCommand = Helper.conn.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            var status = statusCmbBx.SelectedItem.ToString();
            sqlCommand.CommandText = $"UPDATE [Bookings] SET status = '{status}' WHERE booking_id = {booking.booking_id}";
            sqlCommand.ExecuteNonQuery();

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
