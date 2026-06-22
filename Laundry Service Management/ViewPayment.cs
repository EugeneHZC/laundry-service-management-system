using Laundry_Service_Management.models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Laundry_Service_Management
{
    public partial class ViewPayment : UserControl
    {
        private List<Payment> payments = new List<Payment>();

        public ViewPayment()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            Helper.conn.Open();
            SqlCommand cmd = Helper.conn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;

            string query;
            if (Helper.UserRole == "Customer")
            {
                query = @"SELECT p.payment_id, p.status, p.amount, p.payment_date, p.payment_method, p.card_number
                          FROM Payments p
                          INNER JOIN Bookings b ON p.payment_id = b.payment_id
                          WHERE b.user_id = @userId";
            }
            else
            {
                query = @"SELECT p.payment_id, p.status, p.amount, p.payment_date, p.payment_method, p.card_number
                          FROM Payments p";
            }

            cmd.CommandText = query;

            if (Helper.UserRole == "Customer")
                cmd.Parameters.AddWithValue("@userId", Helper.UserId);

            var reader = cmd.ExecuteReader();
            payments.Clear();

            while (reader.Read())
            {
                decimal.TryParse(reader["payment_id"].ToString(), out var payment_id);
                decimal.TryParse(reader["amount"].ToString(), out var amount);

                var payment = new Payment()
                {
                    payment_id = payment_id,
                    status = reader["status"].ToString(),
                    amount = amount,
                    payment_date = DateTime.Parse(reader["payment_date"].ToString()),
                    payment_method = reader["payment_method"].ToString(),
                    card_number = reader["card_number"].ToString()
                };

                payments.Add(payment);
            }

            LoadTable();
            Helper.conn.Close();
        }

        private void LoadTable()
        {
            string search = txtBxSearchPayment.Text.Trim().ToLower();

            var filtered = payments.Where(p =>
                p.payment_id.ToString().ToLower().Contains(search) ||
                p.status.ToLower().Contains(search) ||
                p.amount.ToString().Contains(search) ||
                p.payment_method.ToLower().Contains(search) ||
                p.payment_date.ToString().ToLower().Contains(search) ||
                p.card_number.ToLower().Contains(search)
            ).ToList();

            dgvPayment.DataSource = null;
            dgvPayment.DataSource = filtered;

            if (Helper.UserRole == "Customer")
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

        private void dgvPayment_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 6 && Helper.UserRole != "Customer")
            {
                e.Value = "Edit";
            }
        }

        private void dgvPayment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6 && Helper.UserRole != "Customer" && e.RowIndex >= 0)
            {
                var payment = dgvPayment.Rows[e.RowIndex].DataBoundItem as Payment;
                this.Hide();
                new PaymentCustomer(payment, 0).ShowDialog();
                this.Show();
            }
        }
    }
}
