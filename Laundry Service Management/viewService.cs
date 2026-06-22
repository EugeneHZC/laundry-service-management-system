using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Laundry_Service_Management.models;
using System.Data.SqlClient;

namespace Laundry_Service_Management
{
    public partial class viewService : UserControl
    {
        private List<Service> services = new List<Service>();
        public viewService()
        {
            InitializeComponent();
            LoadData();

            if (Helper.UserRole != "Admin") { 
                addServiceBtn.Visible = false; 
            }
        }

        private void LoadData() { 
            Helper.conn.Open(); 
            SqlCommand cmd = Helper.conn.CreateCommand(); 
            cmd.CommandType = System.Data.CommandType.Text; 
            var query = "SELECT * FROM Services"; 
            cmd.CommandText = query; 
            var reader = cmd.ExecuteReader(); 
            services.Clear(); 
            while (reader.Read()) { 
                decimal.TryParse(reader["service_id"].ToString(), out var service_id); 
                decimal.TryParse(reader["price"].ToString(), out var price); 
                Service service = new Service() { 
                    service_id = service_id, 
                    name = reader["name"].ToString(), 
                    description = reader["description"].ToString(), 
                    price = price }; services.Add(service); 
            } 
            reader.Close(); 
            LoadTable(); 
            Helper.conn.Close(); 
        }

        private void LoadTable() { 
            var search = txtBxSearch.Text.Trim().ToLower(); 
            var filtered = services.Where(s => 
            s.name.ToLower().Contains(search)).ToList(); 
            servicesDataGridView.DataSource = null; 
            servicesDataGridView.DataSource = filtered; 
        }

        private void servicesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.servicesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.laundryServiceManagementDbDataSet);

        }

        private void addServiceBtn_Click(object sender, EventArgs e)
        {
            addService asv = new addService(); 
            asv.ShowDialog(); 
            LoadData();
        }

        private void txtBxSearch_TextChanged(object sender, EventArgs e)
        {
            LoadTable();
        }
    }
}
