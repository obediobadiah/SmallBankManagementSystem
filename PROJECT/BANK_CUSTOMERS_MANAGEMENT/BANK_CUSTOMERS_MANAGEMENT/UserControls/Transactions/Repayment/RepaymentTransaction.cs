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

namespace BANK_CUSTOMERS_MANAGEMENT
{
    public partial class RepaymentTransaction : UserControl
    {
        public RepaymentTransaction()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=ULK_GISENYI;Initial Catalog=BANK_CUSTOMERS_Disseration_Project_DB;Integrated Security=True");
        private void button_save_deposit_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM BANK_ACCOUNT_DETAILS WHERE ID_Number = '" + txt_RepaymentAccountNumber.Text + "' AND Identifier = '" + txt_RepaymentBorrower.Text + "'", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                if (txt_RepaymentBorrower.Text == " " || txt_RepaymentAccountNumber.Text == "" || txt_RepaymentAmount.Text == "" || txt_RepaymentAmountInWords.Text == "" || label_RemainingAmount.Text=="")
                {
                    MessageBox.Show("Make sure you complete all required fields");
                }
                else
                {
                    SqlCommand cmd1 = new SqlCommand("INSERT into REPAYMENT_TRANSACTION values (@Loan_Date,@Borrower,@Account_Number,@Amount,@Amount_In_Words,@Remaining_Time,@Transaction_Time)", conn);

                    cmd1.Parameters.AddWithValue("@Loan_Date", Date_Loan.Value.Date.ToShortDateString());
                    cmd1.Parameters.AddWithValue("@Borrower", txt_RepaymentBorrower.Text);
                    cmd1.Parameters.AddWithValue("@Account_Number", txt_RepaymentAccountNumber.Text);
                    cmd1.Parameters.AddWithValue("@Amount", txt_RepaymentAmount.Text);
                    cmd1.Parameters.AddWithValue("@Amount_In_Words", txt_RepaymentAmountInWords.Text);
                    cmd1.Parameters.AddWithValue("@Remaining_Time", label_RemainingAmount.Text);
                    cmd1.Parameters.AddWithValue("@Transaction_Time", label_RepaymentTime.Text);

                    int i;
                    i = cmd1.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Repayment transaction done", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    Display();
                }

            }
            else
            {
                MessageBox.Show("The entered Borrower name and Account Number doesn't match", "Information");
            }
            conn.Close();
        }

        private void RepaymentTransaction_Load(object sender, EventArgs e)
        {
            timer1.Start();
            Display();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label_RepaymentTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void bunifuCustomDataGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.bunifuCustomDataGrid1.Rows[e.RowIndex];

                ID_NumberLabel.Text = row.Cells["ID_Number"].Value.ToString();
                Date_Loan.Text = row.Cells["Loan_Date"].Value.ToString();
                txt_RepaymentBorrower.Text = row.Cells["Borrower"].Value.ToString();
                txt_RepaymentAccountNumber.Text = row.Cells["Account_Number"].Value.ToString();
                //txt_RepaymentAmount.Text = row.Cells["Amount"].Value.ToString();
                txt_RepaymentAmountInWords.Text = row.Cells["Amount_In_Words"].Value.ToString();
                label_RepaymentTime.Text = row.Cells["Transaction_Time"].Value.ToString();
            }
        }
        public void Display()
        {
            string qry = "SELECT * FROM REPAYMENT_TRANSACTION";
            SqlDataAdapter sda = new SqlDataAdapter(qry, conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            bunifuCustomDataGrid1.DataSource = dt;
        }

        private void label_LoanAmount_Click(object sender, EventArgs e)
        {

        }

        private void txt_RepaymentAccountNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_RepaymentAccountNumber_MouseLeave(object sender, EventArgs e)
        {

        }

        private void txt_RepaymentAmount_MouseLeave(object sender, EventArgs e)
        {

        }

        private void txt_RepaymentAmount_TextChanged(object sender, EventArgs e)
        {
            if (txt_RepaymentAmount.Text == "")
            {

            }
            else
            {
                try
                {
                    int LoanAmount;
                    int RepaymentAmount;
                    int RemainingAmount;
                    LoanAmount = Convert.ToInt32(label_LoanAmount.Text);
                    RepaymentAmount = Convert.ToInt32(txt_RepaymentAmount.Text);
                    RemainingAmount = LoanAmount - RepaymentAmount;
                    label_RemainingAmount.Text = RemainingAmount.ToString();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            conn.Open();
            SqlCommand cmd1 = new SqlCommand("SELECT Amount FROM REPAYMENT_TRANSACTION WHERE Account_Number = '" + txt_RepaymentAccountNumber.Text + "'", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                /*DialogResult result = */MessageBox.Show("The Account Exists in the repayment storage", "Information"/*, MessageBoxButtons.YesNo, MessageBoxIcon.Question*/);
                //if (result == DialogResult.OK)
                //{
                //    SqlCommand cmd2 = new SqlCommand("SELECT Amount FROM LOAN_TRANSACTION WHERE Account_Number = '" + txt_RepaymentAccountNumber.Text + "'", conn);
                //    SqlDataAdapter da1 = new SqlDataAdapter(cmd2);
                //    DataTable dt1 = new DataTable();
                //    da1.Fill(dt1);
                //    if (dt1.Rows.Count > 0)
                //    {
                //        label_LoanAmount.Text = dt1.Rows[0]["Amount"].ToString();
                //    }
                //    else
                //    {
                //        MessageBox.Show("The Account Number that you make doesn't Exists in the Loan Storage");
                //    }
                //}
                //else
                //{
                      
                //}
                
            }
            else
            {
                SqlCommand cmd2 = new SqlCommand("SELECT Amount FROM LOAN_TRANSACTION WHERE Account_Number = '" + txt_RepaymentAccountNumber.Text + "'", conn);
                SqlDataAdapter da1 = new SqlDataAdapter(cmd2);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                if (dt1.Rows.Count == 1)
                {
                    label_LoanAmount.Text = dt1.Rows[0]["Amount"].ToString();
                }
                else
                {
                    MessageBox.Show("The Account Number that you make doesn't Exists in the Loan Storage");
                }

            }
            conn.Close();
        }
    }
}
