using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAS_Engineering_Main.Dash
{
    public partial class frmDelUsr : Form
    {
        Form1 frm1;
        frmUpUsr upUsr;
        public frmDelUsr()
        {
            InitializeComponent();
            frm1 = new Form1();
            upUsr = new frmUpUsr();
        }
        SqlConnection con;
        SqlDataAdapter adapter;
        SqlCommand cmd;


        private void txtSearchN_TextChanged(object sender, EventArgs e)
        {
            string conString = frm1.conString;
            string sql = @"SELECT FROM Users WHERE FirstName LIKE '%" + txtSearchN + "%'";
            upUsr.popDataGView(sql,conString);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if(int.TryParse(txtSearch.Text,out int id))
            {
                string conString = frm1.conString;
                string sql = $"SELECT FROM Users WHERE User_ID = {id}";
                upUsr.popDataGView(sql, conString);
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Get the value of the "ID" column from the clicked cell
                int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ID"].Value);

                // Display the selected ID in the TextBox
                txtID.Text = id.ToString();
            }
            else
            {
                // Clear the TextBox if a header cell or another non-content cell is clicked
                txtID.Text = string.Empty;
            }
        }

        private void btnDelUser_Click(object sender, EventArgs e)
        {
            //Deleting user from database
            if(int.TryParse(txtID.Text,out int id))
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this item?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                string sql_delUsr = $"DELETE FROM Users WHERE User_ID = {id}";
                string cString = frm1.conString;
                
                con = new SqlConnection(cString);
                // Check the user's response
                if (result == DialogResult.Yes)
                {
                    if(con.State == ConnectionState.Closed) { con.Open(); }
                    adapter = new SqlDataAdapter();
                    cmd = new SqlCommand(sql_delUsr, con);
                    adapter.DeleteCommand = cmd;
                    adapter.DeleteCommand.ExecuteNonQuery();

                    con.Close();
                   

                    MessageBox.Show("Item deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // User canceled the deletion
                    MessageBox.Show("Deletion canceled.", "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else{ }
        }
    }
}
