using Laundry_Service_Management.models;
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

            if (Helper.UserRole != "Customer")
            {
                joinDateLbl.Visible = false;
                joinDateTxtBx.Visible = false;
            }
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
            SqlCommand cmd = Helper.conn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;

            cmd.CommandText = $"SELECT * FROM Users WHERE phone_no = '{profile.phone_no}' AND user_id != {profile.user_id}";
            var reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                MessageBox.Show("Phone number already taken.");
                return;
            }

            cmd.CommandText = $"UPDATE Users SET name = '{profile.name}', gender = '{profile.gender}', phone_no = '{profile.phone_no}' WHERE user_id = {Helper.UserId}";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Profile updated successfully.");

            Helper.conn.Close();
            LoadProfile();
        }
    }
}
