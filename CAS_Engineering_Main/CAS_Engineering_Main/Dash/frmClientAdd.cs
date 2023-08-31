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
    public partial class frmClientAdd : Form
    {
        Form1 frm1;

        public frmClientAdd()
        {
            InitializeComponent();

            frm1 = new Form1();
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            //Retrieving connection string from Form1
            string conStr = frm1.conString;

            //Receiving inputs
            string firstName = txtFName.Text;
            string lastName = txtFName.Text;

            using (SqlConnection con = new SqlConnection(conStr))
            {
                try
                {
                    //Validating if input fields are null
                    if ((txtFName.Text == "") || (txtLName.Text == ""))
                    {
                        MessageBox.Show("A required field was not entered");
                    }
                    else
                    {
                        con.Open();

                        //SQL query for inserting data into Client table
                        string sql = $"INSERT INTO Client (FirstName, LastName) " +
                            $"VALUES ('{firstName}','{lastName}')";

                        SqlDataAdapter adap = new SqlDataAdapter();
                        SqlCommand cmd = new SqlCommand(sql, con);

                        adap.InsertCommand = cmd;
                        cmd.ExecuteNonQuery();

                        con.Close();
                    }
                }
                catch(SqlException ex)
                {
                    MessageBox.Show("An error occured: " + ex.Message);
                }
            }
        }
    }
}
