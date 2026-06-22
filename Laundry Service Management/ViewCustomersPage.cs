using Laundry_Service_Management.models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Laundry_Service_Management
{
    public partial class ViewCustomersPage : UserControl
    {
        private readonly List<User> customers = new List<User>();

        public ViewCustomersPage()
        {
            InitializeComponent();
            LoadCustomers();
        }

        private void LoadCustomers()
        {
            customers.Clear();

            try
            {
                Helper.conn.Open();
                SqlCommand cmd = Helper.conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT user_id, name, gender, phone_no, password, role, join_date FROM [Users] WHERE role = @role ORDER BY name";
                cmd.Parameters.AddWithValue("@role", "Customer");

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        customers.Add(ReadUser(reader));
                    }
                }
            }
            finally
            {
                if (Helper.conn.State == ConnectionState.Open)
                {
                    Helper.conn.Close();
                }
            }

            LoadTable();
        }

        private User ReadUser(SqlDataReader reader)
        {
            decimal.TryParse(reader["user_id"].ToString(), out var userId);
            DateTime.TryParse(reader["join_date"].ToString(), out var joinDate);
            var genderText = reader["gender"].ToString();

            return new User()
            {
                user_id = userId,
                name = reader["name"].ToString(),
                gender = string.IsNullOrEmpty(genderText) ? ' ' : genderText[0],
                phone_no = reader["phone_no"].ToString(),
                password = reader["password"].ToString(),
                role = reader["role"].ToString(),
                join_date = joinDate
            };
        }

        private void LoadTable()
        {
            var search = searchTxtBx.Text.Trim().ToLower();
            var filtered = customers.Where(c =>
                c.user_id.ToString().Contains(search) ||
                c.name.ToLower().Contains(search) ||
                c.gender.ToString().ToLower().Contains(search) ||
                c.phone_no.ToLower().Contains(search) ||
                c.join_date.ToString("dd/MM/yyyy").Contains(search)
            ).ToList();

            customersDataGridView.DataSource = null;
            customersDataGridView.DataSource = filtered;

            if (customersDataGridView.Columns["password"] != null)
            {
                customersDataGridView.Columns["password"].Visible = false;
            }

            if (customersDataGridView.Columns["role"] != null)
            {
                customersDataGridView.Columns["role"].Visible = false;
            }
        }

        private void searchTxtBx_TextChanged(object sender, EventArgs e)
        {
            LoadTable();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            LoadCustomers();
        }
    }
}
