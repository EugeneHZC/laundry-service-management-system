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
    public partial class PaymentCustomer : Form
    {
        public static SqlConnection conn = new SqlConnection(
        @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\alyaa\laundry-service-management-system\Laundry Service Management\LaundryServiceManagementDb.mdf;Integrated Security=True");

        private Payment payment;
        public PaymentCustomer(Payment payment)
        {
            InitializeComponent();
            this.payment = payment;
            LoadPage();
        }

        private void PaymentCustomer_Load(object sender, EventArgs e)
        {

        }

        private void LoadPage()
        {
            txtBxPayment.Text = "(Auto Generated)";
            txtBxPayment.Enabled = false;

            txtBxAmount.Text = payment.amount.ToString("0.00");
            txtBxAmount.Enabled = false;

            dtpPayment.Value = DateTime.Now;
            dtpPayment.Enabled = false;

            txtBxStatus.Text = "Pending";
            txtBxStatus.Enabled = false;
        }

        private bool ValidateInput()
        {
            if (!rbQR.Checked && !rbCard.Checked)
            {
                MessageBox.Show("Please select a payment method.");
                return false;
            }

            return true;
        }

        private void insertPayment()
        {
            var paymentMethod = rbQR.Checked ? "QR" : "Debit / Credit Card";
            var paymentDate = dtpPayment.Value;
            var amount = payment.amount;
            var status = "Completed";
            var bookingId = payment.booking_id;

            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO Payments (amount, payment_date, payment_method, status, booking_id) " +
                              $"VALUES ({amount}, '{paymentDate:yyyy-MM-dd HH:mm:ss}', '{paymentMethod}', '{status}', {bookingId})";
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void btnConfirmPayment_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
                return;

            insertPayment();

            MessageBox.Show("Payment confirmed successfully!");
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
