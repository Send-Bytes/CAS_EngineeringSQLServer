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

namespace CAS_Engineering_Main
{   
    
    public partial class frmProjects : Form
    {

        //Declare frm1 as a field at the class level
        private Form1 frm1;

        private DateTime startDate, endDate; //Store selected start and end Dates
        int clientID; // Store selected client ID

        public frmProjects()
        {
            InitializeComponent();

            //Initialize frm1 when the frmProjects instance is created
            frm1 = new Form1();
        }

        // Handle the click event of the "Add Project" button
        private void btnAddProject_Click(object sender, EventArgs e)
        {
            string conStr = frm1.conString; // Get connection string from Form1

            // Get values from input fields
            string pDescrip = txtPDescrip.Text;
            string pLocation = txtLocation.Text;
            string pStatus = txtPStatus.Text;
            string client = cmbClient.Text;
            double cost;


            using (SqlConnection con = new SqlConnection(conStr))
            {
                try
                {
                    if (double.TryParse(txtCost.Text, out cost))
                    {
                        // Check if required fields are filled
                        if ((cmbClient.Text == "") || (txtPDescrip.Text == "") || (startDate == null) || (endDate == null) || (txtLocation.Text == "") || (txtCost.Text == "") || (txtPStatus.Text == ""))
                        {
                            MessageBox.Show("A required field has not been entered");
                        }
                        else
                        {
                            con.Open();

                            // SQL query for inserting project data
                            string sql = $"INSERT INTO Projects (Client_ID, P_Description, P_StartDate, P_EndDate, P_Cost, P_Location, P_Status) " +
                                $"VALUES ({clientID},'{pDescrip}',{startDate},{endDate},{cost},'{pLocation}','{pStatus}')";

                            SqlDataAdapter adap = new SqlDataAdapter();
                            SqlCommand cmd = new SqlCommand(sql, con);

                            adap.InsertCommand = cmd;
                            cmd.ExecuteNonQuery();

                            con.Close();
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("Value inserted into Cost is invalid");
                    }
                }
                catch
                {

                }
            }
        }

        // Handle the form's load event
        private void frmProjects_Load(object sender, EventArgs e)
        {
            string conStr = frm1.conString;
            string fullName = string.Empty;

            using (SqlConnection con = new SqlConnection(conStr))
            {
                try
                {

                    con.Open();

                    // SQL query to retrieve client names
                    string sql = "SELECT FirstName, LastName FROM Client";

                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            cmbClient.Items.Clear();

                            while (reader.Read())
                            {
                                fullName = reader.GetValue(0).ToString() + " " + reader.GetValue(1).ToString();
                                cmbClient.Items.Add(fullName);
                            }
                        }
                    }

                    con.Close();

                }
                catch (SqlException ex)
                {
                    MessageBox.Show("An error occured: " + ex.Message);
                }
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        // Handle the "SelectedIndexChanged" event of the client combo box
        private void cmbClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            string conStr = frm1.conString;
            string firstName = string.Empty;
            string fullName = cmbClient.SelectedItem.ToString();

            for (int i = 0; i <= firstName.Length; i++)
            {
                if (fullName[i] != ' ')
                {
                    firstName += fullName[i];
                }
            }

            using (SqlConnection con = new SqlConnection(conStr))
            {
                string sql = "SELECT Client_ID, FirstName FROM Client";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (reader.GetValue(1).ToString() == firstName)
                            {
                                clientID = (int)reader.GetValue(0);
                                break;
                            }
                        }
                    }
                }
            }
        }

        // Handle the "DateSelected" event of the month calendar
        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            bool startDateChosen = false;

            try
            {
                if (startDateChosen == false)
                {
                    // Show confirmation message for selecting start date
                    DialogResult result = MessageBox.Show("Are you sure you want " + monthCalendar1.SelectionRange.Start.ToShortDateString() + " as your project start date?", "Start Date", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        startDate = monthCalendar1.SelectionRange.Start;
                        lblDisplayStartDate.Text = startDate.ToShortDateString();
                    }
                }
                else
                {
                    // Show confirmation message for selecting end date
                    DialogResult result = MessageBox.Show("Are you sre you want " + monthCalendar1.SelectionRange.Start.ToShortDateString() + " as your project end date?", "End Date", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        endDate = monthCalendar1.SelectionRange.Start; 
                        lblDisplayEndDate.Text = endDate.ToShortDateString();
                    }
                }
            }
            catch
            {

            }
        }
    }
}
