using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CAS_Engineering_Main.Dash
{
    public partial class frmUpUsr : Form
    {
        Form1 form1;
        public frmUpUsr()
        {
            InitializeComponent();
            form1 = new Form1();
        }
        //Declaring SQL classses necessary for database operations
        SqlConnection conn;
        SqlCommand com;
        SqlDataAdapter dataAdapter;

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        //Method to set all label controls backColor to transparent
        public void lblTranparent()
        {
            foreach (Control control in Controls)
            {
                if (control is Label label)
                {
                    label.BackColor = Color.Transparent;
                }
            }
        }
        //Method to populate the dataGridView
        public void popDataGView(string sql, string cString)
        {
            try
            {
                conn = new SqlConnection(cString);

                if (conn.State == ConnectionState.Closed) { conn.Open(); }

                dataAdapter = new SqlDataAdapter(sql, conn);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "people");
                dataGridView1.DataSource = dataSet;
                dataGridView1.DataMember = "people";
                conn.Close();
            }
            catch (SqlException ex) { MessageBox.Show("The following error occured: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }
        private void frmUpUsr_Load(object sender, EventArgs e)
        {
            string conString = form1.conString;
            label5.Visible = false; txtUPass.Visible = false;

            lblTranparent();
            gbUpUsr.BackColor = Color.Transparent;
            groupBox1.BackColor = Color.Transparent;

            //Displaying data in dataGrid View
            string sql = @"SELECT User_ID, FirstName, LastName, Rank FROM Users";
            popDataGView(sql,conString);

            //Populating the comboBox
            try
            {
                conn = new SqlConnection(conString);
                string sql_popCB = @"SELECT DISTINCT Rank FROM Users";
                if (conn.State == ConnectionState.Closed) { conn.Open(); }
                dataAdapter = new SqlDataAdapter(sql_popCB, conn);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds, "ranks");
                cboR.DataSource = ds.Tables["ranks"];
                cboR.DisplayMember = "Rank";
                cboR.ValueMember = "Rank";

                conn.Close();
                cboR.SelectedIndex = -1;
            }
            catch (SqlException ex) { MessageBox.Show("The following error occured: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //For the purpose of filtering by user name
            string conString = form1.conString;
            string sql = @"SELECT * FROM Users WHERE FirstName LIKE '%" + textBox2.Text + "%'";
            popDataGView(sql,conString);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //For the purpose of filtering by users ID
            string conString = form1.conString;
            if (int.TryParse(textBox1.Text, out int uID))
            {
                string sql = $"SELECT User_ID, FirstName, Lastname,Rank FROM Users WHERE User_ID = {uID}";
                popDataGView(sql,conString);
            }
            else { MessageBox.Show("Invalid Input.\nPlease try searching again", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Get the value of the "ID" column from the clicked cell
                int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ID"].Value);

                // Display the selected ID in the TextBox
                txtUID.Text = id.ToString();
            }
            else
            {
                // Clear the TextBox if a header cell or another non-content cell is clicked
                txtUID.Text = string.Empty;
            }
        }

        private void btnUPUsr_Click(object sender, EventArgs e)
        {
            try
            {
                if(int.TryParse(textBox1.Text, out int id))
                {
                    if(cboR.SelectedIndex != -1 && cboR.SelectedIndex.ToString() == "Administrator" || cboR.SelectedIndex.ToString() == "Project Manager")
                    {
                        label5.Visible = true; txtUPass.Visible = true;
                        if(txtUPass.Text != "")
                        {
                            string pass = txtUPass.Text;
                            string rank = cboR.SelectedIndex.ToString();
                            string sql = $"UPDATE Users SET Password = @pass , Rank = @ rank WHERE User_ID = @uID";

                            conn = new SqlConnection(form1.conString);
                            if(conn.State == ConnectionState.Closed) { conn.Open(); }

                            com = new SqlCommand(sql, conn);
                            com.Parameters.AddWithValue("@pass", pass);
                            com.Parameters.AddWithValue("@rank", rank);
                            com.Parameters.AddWithValue("@uID", id);
                            com.ExecuteNonQuery();
                            conn.Close();
                            MessageBox.Show("Update Successful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else { MessageBox.Show("Please insert a password","Error",MessageBoxButtons.OK, MessageBoxIcon.Error); }

                    }
                    else
                    {
                        /**If a demotion occurs i.e., rank goes from Administrator to Employee then the users password will be set to null and they
                        won't have access to the system */
                        if(cboR.SelectedIndex == -1) { MessageBox.Show("Please select a new rank", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                        else 
                        { 
                            MessageBox.Show("User password will be deleted", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            string sql_delPass = @"UPDATE Users SET Password = @pass, Rank = @rank WHERE User_ID = @uID";
                            string rank = cboR.SelectedIndex.ToString();
                            conn = new SqlConnection(form1.conString);
                            if (conn.State == ConnectionState.Closed) { conn.Open(); }
                            com = new SqlCommand(sql_delPass, conn);
                            com.Parameters.AddWithValue("@pass", null);
                            com.Parameters.AddWithValue("@rank", rank);
                            com.Parameters.AddWithValue("@uID", id);
                            com.ExecuteNonQuery();
                            conn.Close();
                            MessageBox.Show("Update Successful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else { MessageBox.Show("Please select the ID of User from database that you want to update", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information); }

            }
            catch(SqlException ex) { MessageBox.Show("The following error occured: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

    }
}

