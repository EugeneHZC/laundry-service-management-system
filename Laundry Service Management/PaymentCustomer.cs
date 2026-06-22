using Laundry_Service_Management.models;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Laundry_Service_Management
{
    public partial class PaymentCustomer : Form
    {
        private Payment payment;
        private decimal bookingId;

        public PaymentCustomer(Payment payment, decimal bookingId)
        {
            InitializeComponent();
            this.payment = payment;
            this.bookingId = bookingId;
            LoadPage();

            if (Helper.UserRole != "Customer")
            {
                statusCmbBx.Enabled = true;
                btnConfirmPayment.Visible = false;
                cancelBtn.Visible = true;
                saveBtn.Visible = true;
                rbQR.Enabled = false;
                rbCard.Enabled = false;
                cardNoTxtBx.Enabled = false;
            }
        }

        private void PaymentCustomer_Load(object sender, EventArgs e)
        {

        }

        private void LoadPage()
        {
            txtBxAmount.Text = payment.amount.ToString("F2");
            txtBxAmount.Enabled = false;

            dtpPayment.Value = DateTime.Now;
            dtpPayment.Enabled = false;

            statusCmbBx.Text = "Pending";
            statusCmbBx.Enabled = false;

            rbQR.Checked = payment.payment_method == "QR";
            rbCard.Checked = payment.payment_method == "Debit / Credit Card";

            cardNoTxtBx.Text = payment.card_number;
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

        private decimal insertPaymentGetId()
        {
            var paymentMethod = rbQR.Checked ? "QR" : "Debit / Credit Card";
            var paymentDate = dtpPayment.Value;
            var amount = payment.amount;
            var status = "Pending";
            var cardNumber = cardNoTxtBx.Text;

            Helper.conn.Open();
            SqlCommand cmd = Helper.conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO Payments (amount, payment_date, payment_method, status, card_number) " +
                              "OUTPUT INSERTED.payment_id " +
                              "VALUES (@amount, @payment_date, @payment_method, @status, @card_number)";
            cmd.Parameters.AddWithValue("@amount", amount);
            cmd.Parameters.AddWithValue("@payment_date", paymentDate.ToString("yyyy-MM-dd HH:mm:ss"));
            cmd.Parameters.AddWithValue("@payment_method", paymentMethod);
            cmd.Parameters.AddWithValue("@status", status);
            cmd.Parameters.AddWithValue("@card_number", cardNumber);
            decimal paymentId = (decimal)cmd.ExecuteScalar();
            Helper.conn.Close();
            return paymentId;
        }

        private void updateBookingPaymentId(decimal paymentId)
        {
            Helper.conn.Open();
            SqlCommand cmd = Helper.conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE Bookings SET payment_id = @payment_id WHERE booking_id = @booking_id";
            cmd.Parameters.AddWithValue("@payment_id", paymentId);
            cmd.Parameters.AddWithValue("@booking_id", bookingId);
            cmd.ExecuteNonQuery();
            Helper.conn.Close();
        }

        private void updatePaymentStatus()
        {
            Helper.conn.Open();
            SqlCommand cmd = Helper.conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE Payments SET status = @status WHERE payment_id = @payment_id";
            cmd.Parameters.AddWithValue("@status", statusCmbBx.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@payment_id", payment.payment_id);
            cmd.ExecuteNonQuery();
            Helper.conn.Close();
        }

        private void btnConfirmPayment_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
                return;

            var paymentId = insertPaymentGetId();
            updateBookingPaymentId(paymentId);

            MessageBox.Show("Payment confirmed successfully!");
            this.Close();
        }

        private void rbQR_CheckedChanged(object sender, EventArgs e)
        {
            if (rbQR.Checked)
            {
                qrPicBx.Visible = true;
                cardNoLbl.Visible = false;
                cardNoTxtBx.Visible = false;
            }
            else
            {
                qrPicBx.Visible = false;
                cardNoLbl.Visible = true;
                cardNoTxtBx.Visible = true;
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            updatePaymentStatus();
            MessageBox.Show("Payment status updated successfully.");
            this.Close();
        }
    }
}
