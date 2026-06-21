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
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            mainContentPnl.Controls.Clear();

            switch (e.Node.Text)
            {
                case "Dashboard":
                    mainContentPnl.Controls.Add(new Dashboard());
                    break;
                case "Booking":
                    mainContentPnl.Controls.Add(new BookingsPage());
                    break;
                case "Profile":
                    mainContentPnl.Controls.Add(new ProfilePage());
                    break;
                default:
                    break;
            }
        }
    }
}
