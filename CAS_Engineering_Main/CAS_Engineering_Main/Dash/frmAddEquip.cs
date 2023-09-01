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
    public partial class frmAddEquip : Form
    {
        Form1 frm1;
        
        public frmAddEquip()
        {
            InitializeComponent();

            //Initializing frm1 variable at class level
            frm1 = new Form1();
        }

        private void btnAddEquip_Click(object sender, EventArgs e)
        {
            try
            {
                //Retrieve connection string from Form1
                string conStr = frm1.conString;

                //Receiving inputs
                string eDescript = txtEDes.Text;
                string eManu = txtEManufac.Text;
                double price;
                int qty = (int)numericUpDown1.Value;

                using (SqlConnection con = new SqlConnection(conStr))
                {
                    //Validating if input fields are null or not
                    if ((txtEDes.Text == "") || (txtEManufac.Text == "") || ((int)numericUpDown1.Value == 0))
                    {
                        MessageBox.Show("Required fields are not entered");
                    }
                    else
                    {
                        if (double.TryParse(txtPrice.Text, out price))
                        {
                            
                            con.Open();

                            //SQL query for inserting values into the Equipment table
                            string sql = $"INSERT INTO Equipment (E_Description, E_Manufacturer, E_Price, E_Quantity) " +
                                $"VALUES ('{eDescript}','{eManu}',{price},{qty})";

                            SqlDataAdapter adap = new SqlDataAdapter();
                            SqlCommand cmd = new SqlCommand(sql, con);

                            adap.InsertCommand = cmd;
                            cmd.ExecuteNonQuery();

                            con.Close();
                        }
                        else
                        {
                            MessageBox.Show("Value for price invalid");
                        }
                    }
                    
                }
            }
            catch(SqlException ex)
            {
                MessageBox.Show("An error occured: " + ex.Message);
            }
        }
    }
}
