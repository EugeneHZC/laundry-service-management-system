using Laundry_Service_Management.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laundry_Service_Management
{
    public partial class ViewPayment : UserControl
    {
        private List<Payment> payments = new List<Payment>();

        public static SqlConnection conn = new SqlConnection(
        @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\alyaa\laundry-service-management-system\Laundry Service Management\LaundryServiceManagementDb.mdf;Integrated Security=True");

        private string UserRole = "Customer";
        private int UserId = 1;

        public ViewPayment()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;

            string query;
            if (UserRole == "Customer")
            {
                query = @"SELECT p.payment_id, p.status, p.amount, p.payment_date, p.payment_method, p.booking_id
                          FROM Payments p
                          INNER JOIN Bookings b ON p.booking_id = b.booking_id
                          WHERE b.user_id = @userId";
            }
            else
            {
                query = @"SELECT payment_id, status, amount, payment_date, payment_method, booking_id
                          FROM Payments";
            }

            cmd.CommandText = query;

            if (UserRole == "Customer")
                cmd.Parameters.AddWithValue("@userId", UserId);

            var reader = cmd.ExecuteReader();
            payments.Clear();

            while (reader.Read())
            {
                decimal.TryParse(reader["payment_id"].ToString(), out var payment_id);
                decimal.TryParse(reader["amount"].ToString(), out var amount);
                decimal.TryParse(reader["booking_id"].ToString(), out var booking_id);

                var payment = new Payment()
                {
                    payment_id = payment_id,
                    status = reader["status"].ToString(),
                    amount = amount,
                    payment_date = DateTime.Parse(reader["payment_date"].ToString()),
                    payment_method = reader["payment_method"].ToString(),
                    booking_id = booking_id
                };

                payments.Add(payment);
            }

            LoadTable();
            conn.Close();
        }

        private void LoadTable()
        {
            string search = txtBxSearchPayment.Text.Trim().ToLower();

            var filtered = payments.Where(p =>
                p.booking_id.ToString().ToLower().Contains(search) ||
                p.payment_id.ToString().ToLower().Contains(search) ||
                p.status.ToLower().Contains(search) ||
                p.payment_method.ToLower().Contains(search) ||
                p.payment_date.ToString().ToLower().Contains(search)
            ).ToList();

            dgvPayment.DataSource = null;
            dgvPayment.DataSource = filtered;

            if (UserRole == "Customer")
            {
                if (dgvPayment.Columns.Count > 6)
                    dgvPayment.Columns[6].Visible = false;
            }
        }

        private void txtBxSearchPayment_TextChanged(object sender, EventArgs e)
        {
            LoadTable();
        }

        private void ViewPayment_Load(object sender, EventArgs e)
        {
            
        }
    }
}
