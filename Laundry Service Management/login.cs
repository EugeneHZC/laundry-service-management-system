using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laundry_Service_Management
{
    public partial class login : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\ainat\\OneDrive\\Documents\\SEM4_26\\EVENT\\Project_EDP\\laundry-service-management-system\\Laundry Service Management\\LaundryServiceManagementDb.mdf\";Integrated Security=True");
        public login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string role = "";

            if (rdBtnCustomer.Checked)
                role = "Customer";
            else if (rdBtnStaff.Checked)
                role = "Staff";
            else if (rdBtnAdmin.Checked)
                role = "Admin";
            else
            {
                MessageBox.Show("Please select a role.");
                return;
            }

            string name = txtBxName.Text.Trim();
            string password = txtBxPassword.Text.Trim();

            if (name == "" || password == "")
            {
                MessageBox.Show("Please enter name and password.");
                return;
            }

            string query = @"SELECT *
                     FROM Users
                     WHERE name=@name
                     AND password=@password
                     AND role=@role";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Parameters.AddWithValue("@role", role);

            try
            {
                connection.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    MessageBox.Show("Login Successful!");

                    if (role == "Customer")
                    {
                        Service frm = new Service ();
                        frm.Show();
                    }
                    else if (role == "Staff")
                    {
                        Dashboard frm = new Dashboard();
                        frm.Show();
                    }
                    else if (role == "Admin")
                    {
                        Dashboard frm = new Dashboard();
                        frm.Show();
                    }

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Name, Password or Role.");
                }

                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }


        }

        private void linkLblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            register frm = new register();
            frm.Show();
            this.Hide();
        }
    }
}
