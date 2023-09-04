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

namespace CAS_Engineering_Main.Dash
{
    public partial class frmDelEquip : Form
    {
        public string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\KENNARD\Documents\GitHub\CAS_EngineeringSQLServer\CAS_Engineering_Main\CAS_Engineering_Main\dboCASEngineering.mdf;Integrated Security=True";//cone tion string
        public frmDelEquip()
        {
            InitializeComponent();
        }

        
        private void frmDelEquip_Load_1(object sender, EventArgs e)
        {
            // Initialize your database connection (SqlConnection)
            using (SqlConnection connection = new SqlConnection("YourConnectionStringHere"))
            {
                connection.Open();

                // Create a SQL command to select data from the Equipment table
                SqlCommand cmd = new SqlCommand("SELECT E_ID, E_Description, E_Manufacturer FROM Equipment", connection);

                // Create a DataTable to hold the data
                DataTable dt = new DataTable();

                // Use a SqlDataAdapter to fill the DataTable
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);

                // Bind the DataGridView to the DataTable
                dataGridView1.DataSource = dt;
            }
        }

        private void btnDeleteEquip_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected row's E_ID
                string selectedEID = dataGridView1.SelectedRows[0].Cells["E_ID"].Value.ToString();

                // Execute a DELETE SQL command to remove the selected item from the database
                using (SqlConnection connection = new SqlConnection("YourConnectionStringHere"))
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand("DELETE FROM Equipment WHERE E_ID = @EID", connection);
                    cmd.Parameters.AddWithValue("@EID", selectedEID);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        // Refresh the DataGridView to reflect the changes
                        frmDelEquip_Load_1(sender, e);
                        MessageBox.Show("Item deleted successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete item.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an item to delete.");
            }
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            DataView dv = ((DataTable)dataGridView1.DataSource).DefaultView;
            dv.RowFilter = $"E_ID LIKE '{txtID.Text}%'";
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            DataView dv = ((DataTable)dataGridView1.DataSource).DefaultView;
            dv.RowFilter = $"E_Description LIKE '%{txtDescription.Text}%'";
        }

        private void txtManufacturer_TextChanged(object sender, EventArgs e)
        {
            DataView dv = ((DataTable)dataGridView1.DataSource).DefaultView;
            dv.RowFilter = $"E_Manufacturer LIKE '%{txtManufacturer.Text}%'";
        }
    }
}
