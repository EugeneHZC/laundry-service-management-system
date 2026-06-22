using System;
using System.Windows.Forms;

namespace Laundry_Service_Management
{
    public partial class DesignTemplate : Form
    {
        public DesignTemplate()
        {
            InitializeComponent();
        }

        private void DesignTemplate_Load(object sender, EventArgs e)
        {
            if (Helper.UserRole != "Admin")
            {
                treeView1.Nodes.RemoveByKey("Dashboard");
                treeView1.Nodes.RemoveByKey("Staff Management");
            }

            if (Helper.UserRole == "Customer")
            {
                treeView1.Nodes.RemoveByKey("View Customers");
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            mainContentPnl.Controls.Clear();

            switch (e.Node.Text)
            {
                case "Dashboard":
                    mainContentPnl.Controls.Add(new Dashboard());
                    break;
                case "Staff Management":
                    mainContentPnl.Controls.Add(new StaffManagementPage());
                    break;
                case "View Customers":
                    mainContentPnl.Controls.Add(new ViewCustomersPage());
                    break;
                case "Service":
                    mainContentPnl.Controls.Add(new viewService());
                    break;
                case "History Payment":
                    mainContentPnl.Controls.Add(new ViewPayment());
                    break;
                case "Booking":
                    mainContentPnl.Controls.Add(new BookingsPage());
                    break;
                case "Profile":
                    mainContentPnl.Controls.Add(new ProfilePage());
                    break;
                case "Logout":
                    if (MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        MessageBox.Show("Logged out successfully.");
                        Helper.UserId = 0;
                        Helper.UserRole = "";
                        this.Close();
                    }
                    break;
                default:
                    break;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void mainContentPnl_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
