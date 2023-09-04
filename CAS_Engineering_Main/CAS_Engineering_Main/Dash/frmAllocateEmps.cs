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
    public partial class frmAllocateEmps : Form
    {
        Form1 frm1;
        string conStr;

        public frmAllocateEmps()
        {
            InitializeComponent();
            frm1 = new Form1();
        }

        private void frmAllocateEmps_Load(object sender, EventArgs e)
        {
            try
            {

                conStr = frm1.conString;

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

                    sql = "SELECT FirstName, LastName FROM Clients";
                    cmd = new SqlCommand(sql, con);

                    reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        cmbEmp.Items.Clear();
                        string fName = reader.GetValue(0).ToString();
                        string lName = reader.GetValue(1).ToString();
                        cmbEmp.Items.Add(fName + " " + lName);
                    }

                    con.Close();
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show("An error occured: " + ex.Message);
            }
        }


        private void btnAllocate_Click(object sender, EventArgs e)
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

                    sql = "SELECT Client_ID, FirstName FROM Client";
                    string name = string.Empty;

                    for (int i = 0; i < cmbEmp.Text.Length; i++)
                    {
                        if (cmbEmp.Text == " ")
                        {
                            break;
                        }
                        else
                        {
                            name = name + cmbEmp.Text[i];
                        }
                    }

                    cmd = new SqlCommand(sql, con);
                    reader = cmd.ExecuteReader();
                    int clientId = 0;

                    while (reader.Read())
                    {
                        if (name == reader.GetValue(1).ToString())
                        {
                            clientId = Convert.ToInt32(reader.GetValue(0));
                        }
                    }

                    reader.Close();

                    sql = $"INSERT INTO Project_Emp (Project_ID, Employee_ID, Employee_Role) " +
                        $"VALUES ({projId}, {clientId}, '{txtRole.Text}')";

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
    }
}