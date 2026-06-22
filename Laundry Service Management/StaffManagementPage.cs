using Laundry_Service_Management.models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Laundry_Service_Management
{
    public partial class StaffManagementPage : UserControl
    {
        private readonly List<User> staff = new List<User>();
        private decimal selectedStaffId = 0;

        public StaffManagementPage()
        {
            InitializeComponent();
            LoadStaff();
        }

        private void LoadStaff()
        {
            staff.Clear();

            try
            {
                Helper.conn.Open();
                SqlCommand cmd = Helper.conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT user_id, name, gender, phone_no, password, role, join_date FROM [Users] WHERE role = @role ORDER BY name";
                cmd.Parameters.AddWithValue("@role", "Staff");

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        staff.Add(ReadUser(reader));
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
            var filtered = staff.Where(s =>
                s.user_id.ToString().Contains(search) ||
                s.name.ToLower().Contains(search) ||
                s.gender.ToString().ToLower().Contains(search) ||
                s.phone_no.ToLower().Contains(search) ||
                s.join_date.ToString("dd/MM/yyyy").Contains(search)
            ).ToList();

            staffDataGridView.DataSource = null;
            staffDataGridView.DataSource = filtered;

            if (staffDataGridView.Columns["password"] != null)
            {
                staffDataGridView.Columns["password"].Visible = false;
            }

            if (staffDataGridView.Columns["role"] != null)
            {
                staffDataGridView.Columns["role"].Visible = false;
            }
        }

        private void ClearForm()
        {
            selectedStaffId = 0;
            nameTxtBx.Clear();
            phoneTxtBx.Clear();
            passwordTxtBx.Clear();
            genderCmbBx.SelectedIndex = -1;
            joinDatePicker.Value = DateTime.Today;
            staffDataGridView.ClearSelection();
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(nameTxtBx.Text) ||
                string.IsNullOrWhiteSpace(phoneTxtBx.Text) ||
                string.IsNullOrWhiteSpace(passwordTxtBx.Text) ||
                genderCmbBx.SelectedIndex < 0)
            {
                MessageBox.Show("Please fill in all staff details.", "Staff Management", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
            {
                return;
            }

            try
            {
                Helper.conn.Open();
                SqlCommand cmd = Helper.conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO [Users] ([name], [gender], [phone_no], [password], [role], [join_date]) VALUES (@name, @gender, @phone_no, @password, @role, @join_date)";
                AddStaffParameters(cmd);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                if (Helper.conn.State == ConnectionState.Open)
                {
                    Helper.conn.Close();
                }
            }

            ClearForm();
            LoadStaff();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (selectedStaffId == 0)
            {
                MessageBox.Show("Please select a staff member to update.", "Staff Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!ValidateForm())
            {
                return;
            }

            try
            {
                Helper.conn.Open();
                SqlCommand cmd = Helper.conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE [Users] SET [name] = @name, [gender] = @gender, [phone_no] = @phone_no, [password] = @password, [role] = @role, [join_date] = @join_date WHERE [user_id] = @user_id AND [role] = @role";
                AddStaffParameters(cmd);
                cmd.Parameters.AddWithValue("@user_id", selectedStaffId);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                if (Helper.conn.State == ConnectionState.Open)
                {
                    Helper.conn.Close();
                }
            }

            ClearForm();
            LoadStaff();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (selectedStaffId == 0)
            {
                MessageBox.Show("Please select a staff member to delete.", "Staff Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var result = MessageBox.Show("Delete this staff member?", "Staff Management", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
            {
                return;
            }

            try
            {
                Helper.conn.Open();
                SqlCommand cmd = Helper.conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE FROM [Users] WHERE [user_id] = @user_id AND [role] = @role";
                cmd.Parameters.AddWithValue("@user_id", selectedStaffId);
                cmd.Parameters.AddWithValue("@role", "Staff");
                cmd.ExecuteNonQuery();
            }
            finally
            {
                if (Helper.conn.State == ConnectionState.Open)
                {
                    Helper.conn.Close();
                }
            }

            ClearForm();
            LoadStaff();
        }

        private void AddStaffParameters(SqlCommand cmd)
        {
            cmd.Parameters.AddWithValue("@name", nameTxtBx.Text.Trim());
            cmd.Parameters.AddWithValue("@gender", genderCmbBx.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@phone_no", phoneTxtBx.Text.Trim());
            cmd.Parameters.AddWithValue("@password", passwordTxtBx.Text.Trim());
            cmd.Parameters.AddWithValue("@role", "Staff");
            cmd.Parameters.AddWithValue("@join_date", joinDatePicker.Value.Date);
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void searchTxtBx_TextChanged(object sender, EventArgs e)
        {
            LoadTable();
        }

        private void staffDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            var selectedStaff = staffDataGridView.Rows[e.RowIndex].DataBoundItem as User;
            if (selectedStaff == null)
            {
                return;
            }

            selectedStaffId = selectedStaff.user_id;
            nameTxtBx.Text = selectedStaff.name;
            phoneTxtBx.Text = selectedStaff.phone_no;
            passwordTxtBx.Text = selectedStaff.password;
            genderCmbBx.SelectedItem = selectedStaff.gender.ToString();
            joinDatePicker.Value = selectedStaff.join_date == DateTime.MinValue ? DateTime.Today : selectedStaff.join_date;
        }
    }
}
