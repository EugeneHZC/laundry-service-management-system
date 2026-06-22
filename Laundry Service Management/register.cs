using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Laundry_Service_Management
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string gender = "";

            if (rdBtnMale.Checked)
                gender = "M";
            else if (rdBtnFemale.Checked)
                gender = "F";
            else
            {
                MessageBox.Show("Please select gender.");
                return;
            }

            if (txtBxName.Text == "" ||
               txtBxPhoneNum.Text == "" ||
               txtBxPassword.Text == "")
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            string query = @"INSERT INTO Users
                    (name, gender, phone_no, password, role, join_date)
                    VALUES
                    (@name, @gender, @phone, @password, @role, @joinDate)";

            SqlCommand cmd = new SqlCommand(query, Helper.conn);

            cmd.Parameters.AddWithValue("@name", txtBxName.Text.Trim());
            cmd.Parameters.AddWithValue("@gender", gender);
            cmd.Parameters.AddWithValue("@phone", txtBxPhoneNum.Text.Trim());
            cmd.Parameters.AddWithValue("@password", Helper.hash(txtBxPassword.Text.Trim()));

            // Customer register sendiri
            cmd.Parameters.AddWithValue("@role", "Customer");

            cmd.Parameters.AddWithValue("@joinDate", DateTime.Now.Date);

            try
            {
                Helper.conn.Open();

                int result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Registration Successful!");
                    Helper.conn.Close();

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Registration Failed!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Registration Failed!");
                Helper.conn.Close();
            }
        }

        private void register_Load(object sender, EventArgs e)
        {

        }

        private void linkLblLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
