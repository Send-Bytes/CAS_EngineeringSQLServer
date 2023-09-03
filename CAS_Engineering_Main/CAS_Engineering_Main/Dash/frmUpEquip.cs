using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAS_Engineering_Main.Dash
{
    public partial class frmUpEquip : Form
    {
        public string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\KENNARD\Documents\GitHub\CAS_EngineeringSQLServer\CAS_Engineering_Main\CAS_Engineering_Main\dboCASEngineering.mdf;Integrated Security=True";//cone tion string
        SqlConnection connection;
        public frmUpEquip()
        {
            InitializeComponent();
        }

        private void btnUpEquip_Click(object sender, EventArgs e)
        {
            {
                // Get the selected equipment description
                string selectedDescription = dataGridView1.CurrentRow.Cells["E_Description"].Value.ToString();

                // Get the new quantity from the NumericUpDown control
                int newQuantity = (int)numericUpDown1.Value;

                // Update the quantity in the database
                try
                {
                    connection.Open();
                    SqlCommand updateCommand = new SqlCommand("UPDATE Equipment SET E_Quantity = @Quantity WHERE E_Description = @Description", connection);
                    updateCommand.Parameters.AddWithValue("@Quantity", newQuantity);
                    updateCommand.Parameters.AddWithValue("@Description", selectedDescription);
                    updateCommand.ExecuteNonQuery();

                    // Refresh the DataGridView
                    LoadEquipmentData();

                    MessageBox.Show("Quantity updated successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
                finally
                {
                    connection.Close();
                }
            }

        }

        private void frmUpEquip_Load(object sender, EventArgs e)
        {
            // Load equipment descriptions into the DataGridView
            LoadEquipmentData();
        }
        private void LoadEquipmentData()
        {
            try
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT E_Description FROM Equipment", connection);
                DataTable equipmentTable = new DataTable();
                adapter.Fill(equipmentTable);
                dataGridView1.DataSource = equipmentTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
        }
    }
}

