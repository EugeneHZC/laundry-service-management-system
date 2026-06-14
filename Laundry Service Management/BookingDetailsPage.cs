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
        public BookingDetailsPage()
        {
            InitializeComponent();
            LoadPage();
            addressTxtBx.Enabled = false;
            timeOfServiceDtp.ShowUpDown = true;

            if (Helper.UserId == 0)
            {
                //this.Close();
            }
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

        private void bookBtn_Click(object sender, System.EventArgs e)
        {
            var bookingId = insertBookingGetId();
            var total = insertServiceBookingGetTotalAmount(bookingId);
            updateBookingAmount(bookingId, total);
            MessageBox.Show("Booking saved.");
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
    }
}
