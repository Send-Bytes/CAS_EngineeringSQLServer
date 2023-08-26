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

namespace CAS_Engineering_Main
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\dboCASEngineering.mdf;Integrated Security=True");
            try
            {
                con.Open();
                MessageBox.Show("Connected!");
            }
            catch { MessageBox.Show("Error opening database"); }

            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Testing the new database

            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\CAS_Engineering.mdf;Integrated Security=True");
            try
            {
                conn.Open();
                MessageBox.Show("Connected");

                string query = "INSERT INTO YourTable (User_ID) VALUES (@id)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", 1);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data inserted");

            }
            catch (SqlException error)
            {
                MessageBox.Show("Error connecting to database" + error.ToString());
            }
            conn.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
