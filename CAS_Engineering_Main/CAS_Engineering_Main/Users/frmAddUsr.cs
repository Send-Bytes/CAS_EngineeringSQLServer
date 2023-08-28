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

        private void frmAddUsr_Load(object sender, EventArgs e)
        {
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
    }
}
