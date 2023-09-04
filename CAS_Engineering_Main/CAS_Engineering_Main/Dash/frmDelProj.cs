using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAS_Engineering_Main.Dash
{
    public partial class frmDelProj : Form
    {
        frmUpUsr upUsr;
        Form1 frm1;
        public frmDelProj()
        {
            InitializeComponent();
            frm1 = new Form1();
            upUsr = new frmUpUsr();
        }
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter dataAdapter;

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmDelProj_Load(object sender, EventArgs e)
        {
            string conString = frm1.conString;
            string sql = $"SELECT * FROM Projects";

            //Populate the dataGrid View
            upUsr.popDataGView(sql, conString);

            //Populating comboBox
            try
            {
                conn = new SqlConnection(conString);
                string sql_popCB = @"SELECT DISTINCT P_Status FROM Projects";
                if (conn.State == ConnectionState.Closed) { conn.Open(); }
                dataAdapter = new SqlDataAdapter(sql_popCB, conn);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds, "stat");
                cboS.DataSource = ds.Tables["stat"];
                cboS.DisplayMember = "P_Status";
                cboS.ValueMember = "P_Status";

                conn.Close();
                cboS.SelectedIndex = -1;
            }
            catch (SqlException ex) { MessageBox.Show("The following error occured: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string cString = frm1.conString;
            string sql = @"SELECT * FROM Projects WHERE P_Description LIKE '%" + textBox1.Text + "%'";
            upUsr.popDataGView(sql, cString);
        }

        private void cboS_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cString = frm1.conString;
            string sql = $"SELECT * FROM Projects WHERE P_Status = '{cboS.SelectedIndex.ToString()}'";
            upUsr.popDataGView(sql, cString);
        }

        private void btnDelProj_Click(object sender, EventArgs e)
        {
            try
            {
                string conStrin = frm1.conString;
                conn = new SqlConnection(conStrin);
                string reload = $"SELECT * FROM Projects";
                if (dataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a project to delete.", "No Project Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                DialogResult result = MessageBox.Show("Are you sure you want to delete this project?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Get the project ID from the selected row
                    int projectId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Project_ID"].Value);
                    txtPID.Text = projectId.ToString();

                    string sql = @"DELETE * Projects WHERE Project_ID = @pID";
                    if(conn.State == ConnectionState.Closed) { conn.Open(); }
                    cmd = new SqlCommand(sql,conn);
                    cmd.Parameters.AddWithValue("@pID", projectId);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Project deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Clearing textboxes
                    textBox1.Text = "";
                    cboS.SelectedIndex = -1;
                    txtPID.Text = "";

                    //reload dataGrid view
                    upUsr.popDataGView(reload, conStrin);



                }
            }
            catch (SqlException ex) { MessageBox.Show("The following error occured: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }
    }
}
