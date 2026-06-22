using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Laundry_Service_Management
{
    public partial class login : Form
    {
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

            SqlCommand cmd = new SqlCommand(query, Helper.conn);

            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@password", Helper.hash(password));
            cmd.Parameters.AddWithValue("@role", role);

            Form frm = new DesignTemplate();

            try
            {
                Helper.conn.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    MessageBox.Show("Login Successful!");
                    Helper.UserId = decimal.Parse(dr["user_id"].ToString());
                    Helper.UserRole = dr["role"].ToString();

                    Helper.conn.Close();
                    this.Hide();
                    frm.ShowDialog();
                    this.Show();

                    txtBxName.Text = "";
                    txtBxPassword.Text = "";
                    rdBtnCustomer.Checked = false;
                    rdBtnStaff.Checked = false;
                    rdBtnAdmin.Checked = false;
                }
                else
                {
                    MessageBox.Show("Invalid name, password or role.");
                }

                dr.Close();
                Helper.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void linkLblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            register frm = new register();
            frm.ShowDialog();
            this.Show();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
