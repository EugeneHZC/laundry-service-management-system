using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Laundry_Service_Management
{
    public partial class register : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\ainat\\OneDrive\\Documents\\SEM4_26\\EVENT\\Project_EDP\\laundry-service-management-system\\Laundry Service Management\\LaundryServiceManagementDb.mdf\";Integrated Security=True");
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

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@name", txtBxName.Text.Trim());
            cmd.Parameters.AddWithValue("@gender", gender);
            cmd.Parameters.AddWithValue("@phone", txtBxPhoneNum.Text.Trim());
            cmd.Parameters.AddWithValue("@password", txtBxPassword.Text.Trim());

            // Customer register sendiri
            cmd.Parameters.AddWithValue("@role", "Customer");

            cmd.Parameters.AddWithValue("@joinDate", DateTime.Now.Date);

            try
            {
                connection.Open();

                int result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Registration Successful!");

                    login frm = new login();
                    frm.Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Registration Failed!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Registration Failed!");
            }
            finally
            {
                connection.Close();
            }
        }

        private void register_Load(object sender, EventArgs e)
        {

        }

        private void linkLblLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            login frm = new login();
            frm.Show();
            this.Hide();
        }
    }
}
