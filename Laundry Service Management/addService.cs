using Laundry_Service_Management.models;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Laundry_Service_Management
{
    public partial class addService : Form
    {
        private Service service;

        public addService(Service service)
        {
            InitializeComponent();
            this.service = service;
            LoadData();
        }

        private void LoadData()
        {
            txtBxServiceName.Text = service.name;
            priceNumericUpDown.Value = service.price;
            txtBxDesc.Text = service.description;
            activeChkBx.Checked = service.status;
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtBxServiceName.Text))
            {
                MessageBox.Show("Please enter service name.");
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txtBxDesc.Text))
            {
                MessageBox.Show("Please enter service description.");
                return false;
            }
            return true;
        }

        private void insertService()
        {
            Helper.conn.Open();
            string query = "INSERT INTO Services (name, description, price, status) " +
                $"VALUES (@name, @description, @price, @status)";
            SqlCommand cmd = new SqlCommand(query, Helper.conn);
            string name = txtBxServiceName.Text;
            string description = txtBxDesc.Text;
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@description", description);
            cmd.Parameters.AddWithValue("@price", priceNumericUpDown.Value);
            cmd.Parameters.AddWithValue("@status", activeChkBx.Checked);
            cmd.ExecuteNonQuery();
            Helper.conn.Close();
        }

        private void updateService()
        {
            Helper.conn.Open();
            string query = "UPDATE Services SET name = @name, description = @description, price = @price, status = @status WHERE service_id = @service_id";
            SqlCommand cmd = new SqlCommand(query, Helper.conn);
            string name = txtBxServiceName.Text;
            string description = txtBxDesc.Text;
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@description", description);
            cmd.Parameters.AddWithValue("@price", priceNumericUpDown.Value);
            cmd.Parameters.AddWithValue("@status", activeChkBx.Checked);
            cmd.Parameters.AddWithValue("@service_id", service.service_id);
            cmd.ExecuteNonQuery();
            Helper.conn.Close();
        }


        private void addBtn_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
            {
                return;
            }

            if (service.service_id == 0)
            {
                insertService();
                MessageBox.Show("Service added successfully!");
            }
            else
            {
                updateService();
                MessageBox.Show("Service added successfully!");
            }

            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
