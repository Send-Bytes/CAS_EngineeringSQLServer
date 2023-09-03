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

        private void PopulateListBox()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT E_ID, E_Description FROM Equipment";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string equipmentDescription = reader["E_Description"].ToString();
                        listBoxEquipment.Items.Add(equipmentDescription);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listBoxEquipment.SelectedItem != null)
            {
                string equipmentDescriptionToDelete = listBoxEquipment.SelectedItem.ToString();

                // confirmation 
                DialogResult result = MessageBox.Show("Are you sure you want to delete this equipment?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Perform the deletion 
                    try
                    {
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();
                            string deleteQuery = "DELETE FROM Equipment WHERE E_Description = @EquipmentDescription";
                            SqlCommand cmd = new SqlCommand(deleteQuery, connection);
                            cmd.Parameters.AddWithValue("@EquipmentDescription", equipmentDescriptionToDelete);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Equipment deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Remove the selected item from the ListBox.
                            listBoxEquipment.Items.Remove(equipmentDescriptionToDelete);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an equipment to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmDelEquip_Load_1(object sender, EventArgs e)
        {
            PopulateListBox();
        }
    }
}
