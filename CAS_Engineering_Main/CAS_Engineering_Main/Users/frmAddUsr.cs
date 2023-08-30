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

namespace CAS_Engineering_Main.Users
{
    public partial class frmAddUsr : Form
    {
        //Sql classess needed to perform the neccessary databse operations
        SqlConnection con;
        SqlCommand command;
        SqlDataAdapter dataAdapter;
        public frmAddUsr()
        {
            InitializeComponent();
        }
        //Method to check if all textboxes have been filled
        public bool AllTextboxesFilled() 
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox textBox)
                {
                    if (string.IsNullOrWhiteSpace(textBox.Text))
                    {
                        return false; // At least one textbox is empty
                    }
                }
            }
            return true; // All textboxes are filled
        }
        //Method to clear all textboxes
        public void ClearTextboxes()
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Clear();
                }
            }
        }
       
        private void frmAddUsr_Load(object sender, EventArgs e)
        {
            lblPass.Visible = false; txtPass.Visible = false; //Will only be displayed based on the rank selected

            /**When the form loads the comboBox for rank will be populated with the 3 types of
            ranks stored in the database*/

            //Creating an instance of the Login form to access the connection string
            Form1 frmLog = new Form1();

            string popComboB = $"SELECT DISTINCT Rank FROM Users";

            try
            {
                con = new SqlConnection(frmLog.conString);

                //Opening connection to the database
                if(con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                dataAdapter = new SqlDataAdapter(popComboB, con);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds,"rank");
                comboBox1.DisplayMember = "Rank";
                comboBox1.ValueMember = "Rank";
                comboBox1.DataSource = ds.Tables["rank"];

                con.Close();
                comboBox1.SelectedIndex = -1;

            }
            catch(SqlException sqlEx) { MessageBox.Show("The following unexcepted error has occured: " + sqlEx.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
           

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /**To determine which rank has been selected and based on the selected rank the textbox to insert a password will be 
             * displayed */
            if (comboBox1.SelectedIndex.ToString() == "Administrator" || comboBox1.SelectedIndex.ToString() == "Project Manager")
            {
                lblPass.Visible = true; txtPass.Visible = true;
                
            }
            else
            {
                lblPass.Visible = false; txtPass.Visible = false;
            }
        }

        private void btnAddUsr_Click(object sender, EventArgs e)
        {
            /**Once add new user button is clciked new users will be added to the database but the values inserted into the database 
             is dependant on the rank selected by users*/

            try
            {
                //Opening connection to the database
                if(con.State==ConnectionState.Closed) { con.Open(); }

                if(comboBox1.SelectedIndex != -1 && comboBox1.SelectedIndex.ToString() == "Administrator" || comboBox1.SelectedIndex.ToString() == "Project Manager")
                {
                    if(txtPass.Text != "")
                    {
                        string sql_insert = $"INSERT INTO Users (Rank,Password,FirstName,LastName,ID_Number,Contact_Number,Email_Address,Date_Of_Birth,Emergency_Contact,Next_Of_Kin) VALUES(@rank,@pass,@name,@lName,@id,@cn,@eAdd,@dob,@EC,@nof)";
                        command = new SqlCommand(sql_insert, con);
                        command.Parameters.AddWithValue("@rank", comboBox1.SelectedIndex.ToString());
                        command.Parameters.AddWithValue("@pass", txtPass.Text);
                        command.Parameters.AddWithValue("@name", txtName.Text);
                        command.Parameters.AddWithValue("@lName", txtLName.Text);
                        command.Parameters.AddWithValue("@id", txtIDNum.Text);
                        command.Parameters.AddWithValue("@cn", txtContact.Text);
                        command.Parameters.AddWithValue("@eAdd", txtEmail.Text);
                        command.Parameters.AddWithValue("@dob", mTxtDOB.Text);
                        command.Parameters.AddWithValue("@EC", txtECN.Text);
                        command.Parameters.AddWithValue("@nof", txtECName.Text);

                        command.ExecuteNonQuery();

                    }
                    else { MessageBox.Show("Please enter a password before continuing","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning); txtPass.Focus(); }
                   
                }
                else
                {
                    if (AllTextboxesFilled()) //If this method doesn't work just remove it, it's at the beginning
                    {
                        string sql_insert = $"INSERT INTO Users (Rank,FirstName,LastName,ID_Number,Contact_Number,Email_Address,Date_Of_Birth,Emergency_Contact,Next_Of_Kin) VALUES(@rank,@name,@lName,@id,@cn,@eAdd,@dob,@EC,@nof)";
                        command = new SqlCommand(sql_insert, con);
                        command.Parameters.AddWithValue("@rank", comboBox1.SelectedIndex.ToString());
                       
                        command.Parameters.AddWithValue("@name", txtName.Text);
                        command.Parameters.AddWithValue("@lName", txtLName.Text);
                        command.Parameters.AddWithValue("@id", txtIDNum.Text);
                        command.Parameters.AddWithValue("@cn", txtContact.Text);
                        command.Parameters.AddWithValue("@eAdd", txtEmail.Text);
                        command.Parameters.AddWithValue("@dob", mTxtDOB.Text);
                        command.Parameters.AddWithValue("@EC", txtECN.Text);
                        command.Parameters.AddWithValue("@nof", txtECName.Text);

                        command.ExecuteNonQuery();

                    }
                    else { MessageBox.Show("Please enusre all fields are filled in.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); }

                }
                con.Close();
                MessageBox.Show("New user added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Clearing all textboxes and comobox selection
                ClearTextboxes();
                comboBox1.SelectedIndex = -1;
                txtName.Focus();

            }
            catch(SqlException er) { MessageBox.Show("The following error has occured: " + er.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            //When user is done registering new users they'll be redirected to the login page
            Form1 frmLogin = new Form1();
            this.Hide();
            frmLogin.Show();
        }

        private void mTxtDOB_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
