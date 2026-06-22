using Laundry_Service_Management.models;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Laundry_Service_Management
{
    public partial class ProfilePage : UserControl
    {
        private User profile;
        private bool isLoading = false;

        public ProfilePage()
        {
            InitializeComponent();
            LoadProfile();
        }

        private void LoadProfile()
        {
            isLoading = true;
            Helper.conn.Open();
            SqlCommand cmd = Helper.conn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"SELECT * FROM Users WHERE user_id = {Helper.UserId}";
            var reader = cmd.ExecuteReader();
            profile = new User()
            {
                user_id = Helper.UserId
            };

            while (reader.Read())
            {
                profile.name = reader["name"].ToString();
                profile.gender = reader["gender"].ToString()[0];
                profile.phone_no = reader["phone_no"].ToString();
                profile.password = reader["password"].ToString();
                profile.role = reader["role"].ToString();
                profile.join_date = DateTime.Parse(reader["join_date"].ToString());
            }

            usersBindingSource.DataSource = profile;
            maleRb.Checked = profile.gender == 'M';
            femaleRb.Checked = profile.gender == 'F';
            Helper.conn.Close();

            roleTxtBx.Focus();

            cancelBtn.Enabled = false;
            saveBtn.Enabled = false;

            isLoading = false;
        }

        private void TxtBx_TextChanged(object sender, System.EventArgs e)
        {
            if (!isLoading)
            {
                cancelBtn.Enabled = true;
                saveBtn.Enabled = true;
            }
        }

        private void Rb_CheckedChanged(object sender, System.EventArgs e)
        {
            if (!isLoading)
            {
                cancelBtn.Enabled = true;
                saveBtn.Enabled = true;
            }
        }

        private void cancelBtn_Click(object sender, System.EventArgs e)
        {
            LoadProfile();
        }

        private void saveBtn_Click(object sender, System.EventArgs e)
        {
            profile.gender = maleRb.Checked ? 'M' : 'F';

            Helper.conn.Open();

            string selectQuery = "SELECT * FROM Users WHERE phone_no = @phone_no AND user_id != @user_id";
            SqlCommand userCmd = new SqlCommand(selectQuery, Helper.conn);
            userCmd.Parameters.AddWithValue("@phone_no", profile.phone_no);
            userCmd.Parameters.AddWithValue("@user_id", profile.user_id);

            var reader = userCmd.ExecuteReader();

            if (reader.Read())
            {
                MessageBox.Show("Phone number already taken.");
                return;
            }

            reader.Close();

            string updateQuery = "UPDATE Users SET name = @name, gender = @gender, phone_no = @phone_no WHERE user_id = @user_id";
            SqlCommand updateCmd = new SqlCommand(updateQuery, Helper.conn);
            updateCmd.Parameters.AddWithValue("@name", profile.name);
            updateCmd.Parameters.AddWithValue("@gender", profile.gender);
            updateCmd.Parameters.AddWithValue("@phone_no", profile.phone_no);
            updateCmd.Parameters.AddWithValue("@user_id", profile.user_id);

            updateCmd.ExecuteNonQuery();
            MessageBox.Show("Profile updated successfully.");

            Helper.conn.Close();
            LoadProfile();
        }

        private void cancelChangeBtn_Click(object sender, EventArgs e)
        {
            oldPasswordTxtBx.Text = "";
            newPasswordTxtBx.Text = "";
            confirmPasswordTxtBx.Text = "";
            changePasswordgGrpBx.Visible = false;
        }

        private void changeBtn_Click(object sender, EventArgs e)
        {
            Helper.conn.Open();

            string selectQuery = "SELECT * FROM Users WHERE user_id = @user_id AND password = @password";
            SqlCommand userCmd = new SqlCommand(selectQuery, Helper.conn);
            userCmd.Parameters.AddWithValue("@user_id", profile.user_id);
            userCmd.Parameters.AddWithValue("@password", Helper.hash(oldPasswordTxtBx.Text));

            var reader = userCmd.ExecuteReader();
            if (!reader.Read())
            {
                MessageBox.Show("Incorrect old password.");
                Helper.conn.Close();
                reader.Close();
                return;
            }

            reader.Close();

            if (newPasswordTxtBx.Text != confirmPasswordTxtBx.Text)
            {
                MessageBox.Show("New password and confirm password must be the same.");
                Helper.conn.Close();
                return;
            }

            if (string.IsNullOrEmpty(newPasswordTxtBx.Text) || string.IsNullOrEmpty(confirmPasswordTxtBx.Text))
            {
                MessageBox.Show("Password field cannot be empty.");
                Helper.conn.Close();
                return;
            }

            string updateQuery = "UPDATE Users SET password = @password WHERE user_id = @user_id";
            SqlCommand updateCmd = new SqlCommand(updateQuery, Helper.conn);
            updateCmd.Parameters.AddWithValue("@password", Helper.hash(newPasswordTxtBx.Text));
            updateCmd.Parameters.AddWithValue("@user_id", profile.user_id);

            updateCmd.ExecuteNonQuery();
            MessageBox.Show("Password changed successfully.");

            Helper.conn.Close();
            LoadProfile();

            oldPasswordTxtBx.Text = "";
            newPasswordTxtBx.Text = "";
            confirmPasswordTxtBx.Text = "";
            changePasswordgGrpBx.Visible = false;
        }

        private void changePasswordBtn_Click(object sender, EventArgs e)
        {
            changePasswordgGrpBx.Visible = true;
        }
    }
}
