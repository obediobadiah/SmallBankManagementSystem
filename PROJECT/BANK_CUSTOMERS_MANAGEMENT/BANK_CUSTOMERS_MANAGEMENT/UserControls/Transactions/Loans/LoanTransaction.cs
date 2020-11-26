using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace BANK_CUSTOMERS_MANAGEMENT
{
    public partial class LoanTransaction : UserControl
    {
        public LoanTransaction()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=ULK_GISENYI;Initial Catalog=BANK_CUSTOMERS_Disseration_Project_DB;Integrated Security=True");

        private void LoanTransaction_Load(object sender, EventArgs e)
        {
            timer1.Start();
            Display();
        }

        private void button_save_deposit_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM BANK_ACCOUNT_DETAILS WHERE ID_Number = '" + txt_LoanAccountNumber.Text + "' AND Identifier = '" + txt_LoanBorrower.Text + "'", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                if (txt_LoanBorrower.Text == "" || txt_LoanAccountNumber.Text == " " || txt_LoanAmount.Text == "" || txt_LoanAmountInWords.Text == "" || txt_LoanPurpose.Text == "")
                {
                    MessageBox.Show("Make sure you complete all required fields");
                }
                else
                {
                    SqlCommand cmd1 = new SqlCommand("INSERT into LOAN_TRANSACTION values (@Loan_Date,@Borrower,@Account_Number,@Amount,@Amount_In_Words,@Currency,@Purpose,@Schedule,@Limit_Date,@Transaction_Time)", conn);

                    cmd1.Parameters.AddWithValue("@Loan_Date", Date_Loan.Value.Date.ToShortDateString());
                    cmd1.Parameters.AddWithValue("@Borrower", txt_LoanBorrower.Text);
                    cmd1.Parameters.AddWithValue("@Account_Number", txt_LoanAccountNumber.Text);
                    cmd1.Parameters.AddWithValue("@Amount", txt_LoanAmount.Text);
                    cmd1.Parameters.AddWithValue("@Amount_In_Words", txt_LoanAmountInWords.Text);
                    cmd1.Parameters.AddWithValue("@Currency", cb_LoanCurrency.SelectedItem);
                    cmd1.Parameters.AddWithValue("@Purpose", txt_LoanPurpose.Text);
                    cmd1.Parameters.AddWithValue("@Schedule", cb_LoanScheduler.SelectedItem);
                    cmd1.Parameters.AddWithValue("@Limit_Date", date_LoanLimitDate.Value.Date.ToShortDateString());
                    cmd1.Parameters.AddWithValue("@Transaction_Time", label_LoanTime.Text);

                    int i;
                    i = cmd1.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Loan transaction done", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    Display();
                }

            }
            else
            {
                MessageBox.Show("The entered Borrower name and Account Number doesn't match", "Information");
            }
            conn.Close();
            //CommunicationsSender CommSend = new CommunicationsSender();
            //CommSend.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label_LoanTime.Text = DateTime.Now.ToLongTimeString();
        }
        public void Display()
        {
            string qry = "SELECT * FROM LOAN_TRANSACTION";
            SqlDataAdapter sda = new SqlDataAdapter(qry, conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            bunifuCustomDataGrid1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button_edit_deposit_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM BANK_ACCOUNT_DETAILS WHERE ID_Number = '" + txt_LoanAccountNumber.Text + "' AND Identifier = '" + txt_LoanBorrower.Text + "'", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                if (txt_LoanBorrower.Text == "" || txt_LoanAccountNumber.Text == " " || txt_LoanAmount.Text == "" || txt_LoanAmountInWords.Text == "" || txt_LoanPurpose.Text == "")
                {
                    MessageBox.Show("Make sure you complete all required fields");
                }
                else
                {
                    SqlCommand cmd1 = new SqlCommand("UPDATE LOAN_TRANSACTION SET  Loan_Date = @Loan_Number,Borrower = @Borrower,Account_Number = @Account_Number,Amount = @Amount,Amount_In_Words = @Amount_In_Words,Currency = @Currency,Purpose = @Purpose,Schedule = @Schedule,Limit_Date = @Limit_Date,Transaction_Time = @Transaction_Time WHERE ID_Number = @ID_Number", conn);

                    cmd1.Parameters.AddWithValue("@ID_Number",ID_NumberLabel.Text)
                    cmd1.Parameters.AddWithValue("@Loan_Date", Date_Loan.Value.Date.ToShortDateString());
                    cmd1.Parameters.AddWithValue("@Borrower", txt_LoanBorrower.Text);
                    cmd1.Parameters.AddWithValue("@Account_Number", txt_LoanAccountNumber.Text);
                    cmd1.Parameters.AddWithValue("@Amount", txt_LoanAmount.Text);
                    cmd1.Parameters.AddWithValue("@Amount_In_Words", txt_LoanAmountInWords.Text);
                    cmd1.Parameters.AddWithValue("@Currency", cb_LoanCurrency.SelectedItem);
                    cmd1.Parameters.AddWithValue("@Purpose", txt_LoanPurpose.Text);
                    cmd1.Parameters.AddWithValue("@Schedule", cb_LoanScheduler.SelectedItem);
                    cmd1.Parameters.AddWithValue("@Limit_Date", date_LoanLimitDate.Value.Date.ToShortDateString());
                    cmd1.Parameters.AddWithValue("@Transaction_Time", label_LoanTime.Text);
                    int i;
                    i = cmd1.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Deposit transaction details updated successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    Display();
                }

            }
            else
            {
                MessageBox.Show("The entered Account name and Account Number doesn't match", "Information");
            }
            conn.Close();

        }
    }
}
