using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System;

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
    public partial class frmPayment : Form
    {
        private DataGridView dataGridView;
        private TextBox projectTextBox;
        private DateTimePicker datePicker;
        private TextBox amountReceivedTextBox;
        private TextBox balanceTextBox;
        private Button addPaymentButton;
        private SqlConnection sqlConnection;
        public frmPayment()
        {

            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView.Rows[e.RowIndex];
                string selectedDescription = selectedRow.Cells["P_Description"].Value.ToString();

                // kry die project id deur te kyk na die description wat gekies is
                string query = "SELECT Project_ID FROM Projects WHERE P_Description = @Description";
                using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
                {
                    cmd.Parameters.AddWithValue("@Description", selectedDescription);
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        int projectId = Convert.ToInt32(result);
                        projectTextBox.Text = projectId.ToString();

                        // kry van p kost en sit hom binne die textbox
                        query = "SELECT P_Cost FROM Projects WHERE Project_ID = @ProjectID";
                        using (SqlCommand costCmd = new SqlCommand(query, sqlConnection))
                        {
                            costCmd.Parameters.AddWithValue("@ProjectID", projectId);
                            object costResult = costCmd.ExecuteScalar();
                            if (costResult != null)
                            {
                                decimal pCost = Convert.ToDecimal(costResult);
                                amountReceivedTextBox.Text = pCost.ToString("F2");

                                // wys die balance en werk uit
                                query = "SELECT SUM(Amount_Received) FROM Payment WHERE Project_ID = @ProjectID";
                                using (SqlCommand balanceCmd = new SqlCommand(query, sqlConnection))
                                {
                                    balanceCmd.Parameters.AddWithValue("@ProjectID", projectId);
                                    object balanceResult = balanceCmd.ExecuteScalar();
                                    if (balanceResult != DBNull.Value)
                                    {
                                        decimal totalReceived = Convert.ToDecimal(balanceResult);
                                        balanceTextBox.Text = totalReceived.ToString("F2");
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void btnAddPay_Click(object sender, EventArgs e)
        {
            // kry id van textbox
            if (int.TryParse(projectTextBox.Text, out int projectId))
            {
                // kry die amoutn van textbox
                if (decimal.TryParse(amountReceivedTextBox.Text, out decimal amountReceived))
                {
                    // record 
                    string insertQuery = "INSERT INTO Payment (Project_ID, Payment_Date, Amount_Received) VALUES (@ProjectID, @PaymentDate, @AmountReceived)";
                    using (SqlCommand insertCmd = new SqlCommand(insertQuery, sqlConnection))
                    {
                        insertCmd.Parameters.AddWithValue("@ProjectID", projectId);
                        insertCmd.Parameters.AddWithValue("@PaymentDate", datePicker.Value);
                        insertCmd.Parameters.AddWithValue("@AmountReceived", amountReceived);
                        insertCmd.ExecuteNonQuery();
                    }

                    // werk balance uit
                    string updateQuery = "UPDATE Payment SET Balance = Balance - @AmountReceived WHERE Project_ID = @ProjectID";
                    using (SqlCommand updateCmd = new SqlCommand(updateQuery, sqlConnection))
                    {
                        updateCmd.Parameters.AddWithValue("@ProjectID", projectId);
                        updateCmd.Parameters.AddWithValue("@AmountReceived", amountReceived);
                        updateCmd.ExecuteNonQuery();
                    }

                    // Uwys die nuwe balance in die textbox
                    string balanceQuery = "SELECT Balance FROM Payment WHERE Project_ID = @ProjectID";
                    using (SqlCommand balanceCmd = new SqlCommand(balanceQuery, sqlConnection))
                    {
                        balanceCmd.Parameters.AddWithValue("@ProjectID", projectId);
                        object balanceResult = balanceCmd.ExecuteScalar();
                        if (balanceResult != DBNull.Value)
                        {
                            decimal newBalance = Convert.ToDecimal(balanceResult);
                            balanceTextBox.Text = newBalance.ToString("F2");
                        }
                    }

                    // messagebox met die nuwe balamnce
                    MessageBox.Show($"Payment added. New balance: {balanceTextBox.Text}", "Payment Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Invalid Amount Received. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Invalid Project ID. Please select a project from the list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmPayment_Load_1(object sender, EventArgs e)
        {
            // Sit dit binne datagrid 
            string query = "SELECT DISTINCT P_Description FROM Projects";
            SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConnection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView.DataSource = dataTable;
        }
    }
}