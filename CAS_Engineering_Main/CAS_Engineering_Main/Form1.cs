using CAS_Engineering_Main.Dash;
using CAS_Engineering_Main.Users;
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
        /**This is where the program officially starts. Once user logs in and their creddentials are valid, they
        will be directed to a dashboard relevantt to their rank to perform neccessary tasks on the system*/

        //Global Connection string
        public string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\dboCASEngineering.mdf;Integrated Security=True";

        //SQL classes needed to perform necessary database operations
        SqlConnection con;
        SqlCommand command;
        SqlDataReader dataReader;

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
            frmDashPM frmDashPM = new frmDashPM();
            frmDashPM.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string sql = @"SELECT * FROM Users WHERE FirstName = @uName AND Password = @pass";

            //If statement that will check if the user inserted a password or not
            if (txtPassword.Text == "")
            {
                errorPassword.SetError(txtPassword, "Please enter a password");
                txtPassword.Focus();
            }
            else
            {
                try
                {
                    //Opening connection to the database
                    con= new SqlConnection(conString); 
                    con.Open();

                    command = new SqlCommand(sql, con);
                    command.Parameters.AddWithValue("@uName", txtUName.Text);
                    command.Parameters.AddWithValue("@pass",txtPassword.Text);

                    dataReader= command.ExecuteReader();

                    if (dataReader.Read())
                    {
                        if(txtPassword.Text == dataReader.GetValue(2).ToString())
                        {
                            if(dataReader.GetValue(1).ToString() == "Administrator")
                            {
                                //Dashboard for Administrators will be displayed
                                frmDashPM pmDash = new frmDashPM();
                                this.Hide();
                                pmDash.Show();
                            }
                            else if(dataReader.GetValue(1).ToString() == "Project Manager")
                            {
                                //If user that is signing in is not an administrator then the dashboard for Project Managers will be displayed
                                frmDashPM pmDash = new frmDashPM();
                                this.Hide();
                                pmDash.Show();
                            }
                            else
                            {
                                //If user is not an administrator or a project manager then they dont have any access to anything
                                MessageBox.Show("Access has not been granted yet", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid Password", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtPassword.Text = "";
                            txtPassword.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Credentials.\nPlease ensure that correct credentials are entered", "Credential Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtUName.Text = "";
                        txtPassword.Text = "";
                        txtUName.Focus();
                    }
                    
                    dataReader.Close();
                    //Closing connecton to database
                    con.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("The following error has occured: " + ex.ToString(), "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }

        private void lblNewUsr_Click(object sender, EventArgs e)
        {
            frmAddUsr addUsr = new frmAddUsr();
            this.Hide();
            addUsr.Show();
        }
    }
}
