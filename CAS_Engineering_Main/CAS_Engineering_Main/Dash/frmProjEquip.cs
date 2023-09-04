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
    public partial class frmProjEquip : Form
    {
        Form1 frm1;
        string conStr;
        public frmProjEquip()
        {
            InitializeComponent();
            frm1 = new Form1();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                conStr = frm1.conString;

                using (SqlConnection con = new SqlConnection(conStr))
                {
                    con.Open();

                    string sql = "SELECT Project_ID, P_Description FROM Projects";

                    SqlCommand cmd = new SqlCommand(sql, con);
                    SqlDataReader reader = cmd.ExecuteReader();

                    int projId = 0;
                    while (reader.Read())
                    {
                        if (cmbProjId.Text == reader.GetValue(1).ToString())
                        {
                            projId = Convert.ToInt32(reader.GetValue(0));
                        }
                    }

                    reader.Close();

                    sql = "SELECT E_ID, E_Description FROM Equipment";

                    cmd = new SqlCommand(sql, con);
                    reader = cmd.ExecuteReader();
                    int eId = 0;

                    while (reader.Read())
                    {
                        if (cmbEquip.Text == reader.GetValue(1).ToString())
                        {
                            eId = Convert.ToInt32(reader.GetValue(0));
                        }
                    }

                    int qty = Convert.ToInt32(numericUpDown1.Value);

                    sql = $"INSERT INTO Project_Equip (Project_ID, Equipment_ID, Quantity_Received) " +
                        $"VALUES ({projId}, {eId}, {qty})";

                    cmd = new SqlCommand(sql, con);
                    SqlDataAdapter adap = new SqlDataAdapter();

                    adap.InsertCommand = cmd;
                    cmd.ExecuteNonQuery();

                    con.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("An error occured: " + ex.Message);
            }



        }

        private void frmProjEquip_Load_1(object sender, EventArgs e)
        {
            try
            {
                string conStr = frm1.conString;

                using (SqlConnection con = new SqlConnection(conStr))
                {
                    string sql = "SELECT P_Description FROM Projects";

                    con.Open();

                    SqlCommand cmd = new SqlCommand(sql, con);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        cmbProjId.Items.Clear();
                        cmbProjId.Items.Add(reader.GetValue(0));
                    }

                    reader.Close();

                    sql = "SELECT E_Description FROM Equipment";
                    cmd = new SqlCommand(sql, con);

                    reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        cmbEquip.Items.Clear();
                        cmbEquip.Items.Add(reader.GetValue(0));
                    }

                    con.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("An error occured: " + ex.Message);
            }
        }
    }
}
