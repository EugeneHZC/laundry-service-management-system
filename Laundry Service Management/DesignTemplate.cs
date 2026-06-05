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
            if (this.DesignMode) return;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            mainContentPnl.Controls.Clear();

            switch (e.Node.Text)
            {
                case "Booking":
                    mainContentPnl.Controls.Add(new BookingsPage());
                    break;
                default:
                    break;
            }
        }
    }
}
