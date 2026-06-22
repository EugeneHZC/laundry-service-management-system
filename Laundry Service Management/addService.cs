using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Laundry_Service_Management.models;

namespace Laundry_Service_Management
{
    public partial class addService : Form
    {
        public addService()
        {
            InitializeComponent();
        }

        private bool ValidateInput() { 
            if (string.IsNullOrWhiteSpace(txtBxServiceName.Text)) { 
                MessageBox.Show("Please enter service name."); 
                return false; 
            } else if (string.IsNullOrWhiteSpace(txtBxDesc.Text)) { 
                MessageBox.Show("Please enter service description."); 
                return false; 
            } else if (string.IsNullOrWhiteSpace(txtBxPrice.Text)) { 
                MessageBox.Show("Please enter price."); 
                return false; 
            } else if (!decimal.TryParse(txtBxPrice.Text, out _)) { 
                MessageBox.Show("Price must be a number."); 
                return false; 
            } 
            return true; 
        }

        private void insertService() { 
            Helper.conn.Open(); 
            SqlCommand cmd = Helper.conn.CreateCommand(); 
            cmd.CommandType = CommandType.Text; 
            string name = txtBxServiceName.Text; 
            string description = txtBxDesc.Text; 
            decimal price = Convert.ToDecimal(txtBxPrice.Text); 
            cmd.CommandText = "INSERT INTO Services (name, description, price) " + 
                $"VALUES ('{name}', '{description}', {price})"; 
            cmd.ExecuteNonQuery(); 
            Helper.conn.Close(); 
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) { 
                return; 
            }
            
            insertService(); 
            MessageBox.Show("Service added successfully!"); 
            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
