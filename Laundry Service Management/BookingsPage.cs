using Laundry_Service_Management.models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Laundry_Service_Management
{
    public partial class BookingsPage : UserControl
    {
        private List<Booking> bookings = new List<Booking>();

        public BookingsPage()
        {
            InitializeComponent();
            LoadData();

            if (Helper.UserRole != "Customer")
            {
                bookAppointmentBtn.Visible = false;
            }
        }

        private void LoadData()
        {
            Helper.conn.Open();
            SqlCommand cmd = Helper.conn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;

            var query = "SELECT * FROM Bookings";

            if (Helper.UserRole == "Customer")
            {
                query = $"SELECT * FROM Bookings WHERE user_id = {Helper.UserId}";
            }

            cmd.CommandText = query;
            var reader = cmd.ExecuteReader();
            bookings.Clear();

            while (reader.Read())
            {
                decimal.TryParse(reader["booking_id"].ToString(), out var booking_id);
                decimal.TryParse(reader["total_amount"].ToString(), out var total_amount);

                var booking = new Booking()
                {
                    booking_id = booking_id,
                    booking_date = DateTime.Parse(reader["booking_date"].ToString()),
                    service_time = DateTime.Parse(reader["service_time"].ToString()),
                    delivery_to_shop_method = reader["delivery_to_shop_method"].ToString(),
                    total_amount = total_amount,
                    service_type = reader["service_type"].ToString(),
                    status = "Scheduled",
                    delivery_from_shop_method = reader["delivery_from_shop_method"].ToString(),
                    delivery_address = reader["delivery_address"].ToString(),
                    remarks = reader["remarks"].ToString(),
                    user_id = Helper.UserId,
                    payment_id = null
                };

                bookings.Add(booking);
            }

            LoadTable();
            Helper.conn.Close();
        }

        private void LoadTable()
        {
            var search = searchTxtBx.Text.Trim().ToLower();
            var filtered = bookings.Where(b =>
                b.booking_date.ToString().ToLower().Contains(search) ||
                b.service_time.ToString().ToLower().Contains(search) ||
                b.service_type.ToLower().Contains(search)
                ).ToList();
            bookingsDGV.DataSource = null;
            bookingsDGV.DataSource = filtered;
        }

        private void textBox1_TextChanged(object sender, System.EventArgs e)
        {
            LoadTable();
        }

        private void bookAppointmentBtn_Click(object sender, EventArgs e)
        {
            new BookingDetailsPage().ShowDialog();
            LoadData();
        }
    }
}
