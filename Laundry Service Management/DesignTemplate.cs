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
                treeView1.Nodes.RemoveByKey("History payment");
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
                case "History payment":
                    mainContentPnl.Controls.Add(new ViewPayment());
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
