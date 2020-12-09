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
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-454MBGL;Initial Catalog=BANK_CUSTOMERS_Disseration_Project_DB;Integrated Security=True");

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
                SqlCommand cmd2 = new SqlCommand("SELECT Amount FROM LOAN_TRANSACTION WHERE Account_Number = '" + txt_LoanAccountNumber.Text + "'", conn);
                SqlDataAdapter da1 = new SqlDataAdapter(cmd2);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                if (dt1.Rows.Count == 1)
                {
                    MessageBox.Show("The Account Already Exists in the Loan storage");
                }
                else
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
            if (comboBox1.SelectedItem == "Account Number") //")
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM LOAN_TRANSACTION where Account_Number = '" + txt_Search.Text + "'", conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    bunifuCustomDataGrid1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (comboBox1.SelectedItem == "Account Name")
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM LOAN_TRANSACTION where Borrower = '" + txt_Search.Text + "'", conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    bunifuCustomDataGrid1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
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
                    SqlCommand cmd1 = new SqlCommand("UPDATE LOAN_TRANSACTION SET  Loan_Date = @Loan_Date,Borrower = @Borrower,Account_Number = @Account_Number,Amount = @Amount,Amount_In_Words = @Amount_In_Words,Currency = @Currency,Purpose = @Purpose,Schedule = @Schedule,Limit_Date = @Limit_Date,Transaction_Time = @Transaction_Time WHERE ID_Number = @ID_Number", conn);

                    cmd1.Parameters.AddWithValue("@ID_Number", ID_NumberLabel.Text);
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
                        MessageBox.Show("Loan transaction details updated successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void bunifuCustomDataGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.bunifuCustomDataGrid1.Rows[e.RowIndex];

                ID_NumberLabel.Text = row.Cells["ID_Number"].Value.ToString();
                Date_Loan.Text = row.Cells["Loan_Date"].Value.ToString();
                txt_LoanBorrower.Text = row.Cells["Borrower"].Value.ToString();
                txt_LoanAccountNumber.Text = row.Cells["Account_Number"].Value.ToString();
                txt_LoanAmount.Text = row.Cells["Amount"].Value.ToString();
                txt_LoanAmountInWords.Text = row.Cells["Amount_In_Words"].Value.ToString();
                cb_LoanCurrency.Text = row.Cells["Currency"].Value.ToString();
                txt_LoanPurpose.Text = row.Cells["Purpose"].Value.ToString();
                cb_LoanScheduler.Text = row.Cells["Schedule"].Value.ToString();
                date_LoanLimitDate.Text = row.Cells["Limit_Date"].Value.ToString();
                label_LoanTime.Text = row.Cells["Transaction_Time"].Value.ToString();
            }
        }

        private void button_delete_deposit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure that you want to delete??", "QUESTION", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd1 = new SqlCommand("DELETE FROM LOAN_TRANSACTION WHERE ID_Number = @ID_Number", conn);

                    cmd1.Parameters.AddWithValue("@ID_Number", ID_NumberLabel.Text);

                    int i;
                    i = cmd1.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show(" transaction details deleted successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    Display();
                    conn.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {

            }
        }

        private void button_deposit_clear_Click(object sender, EventArgs e)
        {
            ID_NumberLabel.Text = "";
            Date_Loan.Text = "";
            txt_LoanBorrower.Text = "";
            txt_LoanAccountNumber.Text = "";
            txt_LoanAmount.Text = "";
            txt_LoanAmountInWords.Text = "";
            cb_LoanCurrency.Text = "";
            txt_LoanPurpose.Text = "";
            cb_LoanScheduler.Text = "";
            date_LoanLimitDate.Text = "";
            label_LoanTime.Text = "";
        }

        private void button_print_deposit_Click(object sender, EventArgs e)
        {
            Loan_Viewer DepositViewer = new Loan_Viewer();
            Loan_Slip cr = new Loan_Slip();
            TextObject text = (TextObject)cr.ReportDefinition.Sections["Section3"].ReportObjects["Text47"];
            TextObject text1 = (TextObject)cr.ReportDefinition.Sections["Section3"].ReportObjects["Text46"];
            TextObject text2 = (TextObject)cr.ReportDefinition.Sections["Section3"].ReportObjects["Text45"];
            TextObject text3 = (TextObject)cr.ReportDefinition.Sections["Section3"].ReportObjects["Text44"];
            TextObject text4 = (TextObject)cr.ReportDefinition.Sections["Section3"].ReportObjects["Text43"];
            TextObject text5 = (TextObject)cr.ReportDefinition.Sections["Section3"].ReportObjects["Text42"];
            TextObject text6 = (TextObject)cr.ReportDefinition.Sections["Section3"].ReportObjects["Text41"];
            TextObject text7 = (TextObject)cr.ReportDefinition.Sections["Section3"].ReportObjects["Text40"];
            TextObject text8 = (TextObject)cr.ReportDefinition.Sections["Section3"].ReportObjects["Text39"];
            TextObject text9 = (TextObject)cr.ReportDefinition.Sections["Section3"].ReportObjects["Text3"];
            text.Text = Date_Loan.Text;
            text1.Text = txt_LoanBorrower.Text;
            text2.Text = txt_LoanAccountNumber.Text;
            text3.Text = txt_LoanAmount.Text;
            text4.Text = txt_LoanAmountInWords.Text;
            text5.Text = cb_LoanCurrency.Text;
            text6.Text = txt_LoanPurpose.Text;
            text7.Text = cb_LoanScheduler.Text;
            text8.Text = date_LoanLimitDate.Text;
            text9.Text = label_LoanTime.Text;
            DepositViewer.crystalReportViewer1.ReportSource = cr;
            DepositViewer.Show();
        }
    }
}
