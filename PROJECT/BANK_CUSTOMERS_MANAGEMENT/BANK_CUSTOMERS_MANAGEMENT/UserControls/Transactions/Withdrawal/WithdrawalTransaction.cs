using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace BANK_CUSTOMERS_MANAGEMENT
{
    public partial class WithdrawalTransaction : UserControl
    {
        public WithdrawalTransaction()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-454MBGL;Initial Catalog=BANK_CUSTOMERS_Disseration_Project_DB;Integrated Security=True");

        CommunicationsSender obj = new CommunicationsSender();
        private void button_save_deposit_Click(object sender, EventArgs e)
        {
            try
            {
                
                SqlCommand cmd = new SqlCommand("SELECT * FROM BANK_ACCOUNT_DETAILS WHERE ID_Number = '" + txt_WithdrawalAccountNumber.Text + "' AND Identifier = '" + txt_WithdrawalAccountName.Text + "'", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    if (txt_WithdrawalAccountName.Text == "" || txt_WithdrawalAccountNumber.Text == " " || txt_WithdrawalAmount.Text == "" || txt_WithdrawalAmountInWord.Text == "" || txt_WithdrawalName.Text == "" || txt_WithdrwalNarration.Text == "" || cb_WithdrawalCurrency.Text == "" || label_WithdrawalTime.Text == "")
                    {
                        MessageBox.Show("Make sure you complete all required fields");
                    }
                    else
                    {
                        SqlCommand cmd2 = new SqlCommand("SELECT Account_Number FROM DEPOSIT_TRANSACTION WHERE Account_Number = '" + txt_WithdrawalAccountNumber.Text + "'", conn);
                        SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                        DataTable dt2 = new DataTable();
                        da2.Fill(dt2);
                        if (dt2.Rows.Count > 0)
                        {
                            conn.Open();
                            SqlCommand cmd1 = new SqlCommand("INSERT into WITHDRAWAL_TRANSACTION values (@Account_Name,@Account_Number,@Withdrawal_by,@Transaction_Date,@Transaction_Time,@Amount,@Amount_In_Words,@Currency,@Narration)", conn);

                            cmd1.Parameters.AddWithValue("@Account_Name", txt_WithdrawalAccountName.Text);
                            cmd1.Parameters.AddWithValue("@Account_Number", txt_WithdrawalAccountNumber.Text);
                            cmd1.Parameters.AddWithValue("@Withdrawal_by", txt_WithdrawalName.Text);
                            cmd1.Parameters.AddWithValue("@Transaction_Date", Date_Withdrawal.Value.Date.ToShortDateString());
                            cmd1.Parameters.AddWithValue("@Transaction_Time", label_WithdrawalTime.Text);
                            cmd1.Parameters.AddWithValue("@Amount", txt_WithdrawalAmount.Text);
                            cmd1.Parameters.AddWithValue("@Amount_In_Words", txt_WithdrawalAmountInWord.Text);
                            cmd1.Parameters.AddWithValue("@Currency", cb_WithdrawalCurrency.SelectedItem);
                            cmd1.Parameters.AddWithValue("@Narration", txt_WithdrwalNarration.Text);

                            int i;
                            i = cmd1.ExecuteNonQuery();
                            if (i > 0)
                            {
                                MessageBox.Show("Withdrawal transaction done", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            Display();
                            conn.Close();

                            CommunicationAccountNumber();
                            CommunicationMobileNumber();
                            message();
                            obj.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("This account is not yet eligible to withdrawal", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                }
                else
                {
                    MessageBox.Show("The entered Account name and Account Number doesn't match", "Information");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label_WithdrawalTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void WithdrawalTransaction_Load(object sender, EventArgs e)
        {
            timer1.Start();
            Display();
        }
        public void Display()
        {
            try
            {
                string qry = "SELECT * FROM WITHDRAWAL_TRANSACTION";
                SqlDataAdapter sda = new SqlDataAdapter(qry, conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                bunifuCustomDataGrid1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void button_edit_deposit_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM BANK_ACCOUNT_DETAILS WHERE ID_Number = '" + txt_WithdrawalAccountNumber.Text + "' AND Identifier = '" + txt_WithdrawalAccountName.Text + "'", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    if (txt_WithdrawalAccountName.Text == "" || txt_WithdrawalAccountNumber.Text == " " || txt_WithdrawalAmount.Text == "" || txt_WithdrawalAmountInWord.Text == "" || txt_WithdrawalName.Text == "" || txt_WithdrwalNarration.Text == "" || cb_WithdrawalCurrency.Text == "" || label_WithdrawalTime.Text == "")
                    {
                        MessageBox.Show("Make sure you complete all required fields");
                    }
                    else
                    {
                        conn.Open();
                        SqlCommand cmd1 = new SqlCommand("UPDATE WITHDRAWAL_TRANSACTION SET Account_Name = @Account_Name,Account_Number = @Account_Number,Withdrawal_by = @Withdrawal_by,Transaction_Date = @Transaction_Date,Transaction_Time = @Transaction_Time,Amount = @Amount,Amount_In_Words = @Amount_In_Words,Currency = @Currency,Narration = @Narration WHERE ID_Number = @ID_Number", conn);

                        cmd1.Parameters.AddWithValue("@ID_Number", ID_NumberLabel.Text);
                        cmd1.Parameters.AddWithValue("@Account_Name", txt_WithdrawalAccountName.Text);
                        cmd1.Parameters.AddWithValue("@Account_Number", txt_WithdrawalAccountNumber.Text);
                        cmd1.Parameters.AddWithValue("@Withdrawal_by", txt_WithdrawalName.Text);
                        cmd1.Parameters.AddWithValue("@Transaction_Date", Date_Withdrawal.Value.Date.ToShortDateString());
                        cmd1.Parameters.AddWithValue("@Transaction_Time", label_WithdrawalTime.Text);
                        cmd1.Parameters.AddWithValue("@Amount", txt_WithdrawalAmount.Text);
                        cmd1.Parameters.AddWithValue("@Amount_In_Words", txt_WithdrawalAmountInWord.Text);
                        cmd1.Parameters.AddWithValue("@Currency", cb_WithdrawalCurrency.SelectedItem);
                        cmd1.Parameters.AddWithValue("@Narration", txt_WithdrwalNarration.Text);

                        int i;
                        i = cmd1.ExecuteNonQuery();
                        if (i > 0)
                        {
                            MessageBox.Show("Withdrawal transaction details updated successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        Display();
                        conn.Close();

                        CommunicationAccountNumber();
                        CommunicationMobileNumber();
                        message();
                        obj.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("The entered Account name and Account Number doesn't match", "Information");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void bunifuCustomDataGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.bunifuCustomDataGrid1.Rows[e.RowIndex];

                    ID_NumberLabel.Text = row.Cells["ID_Number"].Value.ToString();
                    txt_WithdrawalAccountName.Text = row.Cells["Account_Name"].Value.ToString();
                    txt_WithdrawalAccountNumber.Text = row.Cells["Account_Number"].Value.ToString();
                    txt_WithdrawalName.Text = row.Cells["Withdrawal_by"].Value.ToString();
                    Date_Withdrawal.Text = row.Cells["Transaction_Date"].Value.ToString();
                    txt_WithdrawalAmount.Text = row.Cells["Amount"].Value.ToString();
                    txt_WithdrawalAmountInWord.Text = row.Cells["Amount_In_Words"].Value.ToString();
                    cb_WithdrawalCurrency.Text = row.Cells["Currency"].Value.ToString();
                    txt_WithdrwalNarration.Text = row.Cells["Narration"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
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
                    SqlCommand cmd1 = new SqlCommand("DELETE FROM WITHDRAWAL_TRANSACTION WHERE ID_Number = @ID_Number", conn);

                    cmd1.Parameters.AddWithValue("@ID_Number", ID_NumberLabel.Text);

                    int i;
                    i = cmd1.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Withdrawal transaction details deleted successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "Account Number") //")
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM WITHDRAWAL_TRANSACTION where Account_Number LIKE '%" + txt_Search.Text + "%'", conn);
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
            else if (comboBox1.SelectedItem == "Account Name") ////Date")
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM WITHDRAWAL_TRANSACTION where Account_Name LIKE '%" + txt_Search.Text + "%'", conn);
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
            else
            {
                MessageBox.Show("With what you wanna search??", "Question", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void button_deposit_clear_Click(object sender, EventArgs e)
        {
            txt_WithdrawalAccountName.Text = "";
            txt_WithdrawalAccountNumber.Text = "";
            txt_WithdrawalName.Text = "";
            txt_WithdrawalAmount.Text = "";
            txt_WithdrawalAmountInWord.Text = "";
            cb_WithdrawalCurrency.SelectedItem = "";
            txt_WithdrwalNarration.Text = "";
        }

        private void button_print_deposit_Click(object sender, EventArgs e)
        {
            Withdrawal_Viewer WithdrawalViewer = new Withdrawal_Viewer();
            Withdrawal_Slip cr = new Withdrawal_Slip();
            TextObject text = (TextObject)cr.ReportDefinition.Sections["Section3"].ReportObjects["Text47"];
            TextObject text1 = (TextObject)cr.ReportDefinition.Sections["Section3"].ReportObjects["Text46"];
            TextObject text2 = (TextObject)cr.ReportDefinition.Sections["Section3"].ReportObjects["Text45"];
            TextObject text3 = (TextObject)cr.ReportDefinition.Sections["Section3"].ReportObjects["Text44"];
            TextObject text4 = (TextObject)cr.ReportDefinition.Sections["Section3"].ReportObjects["Text43"];
            TextObject text5 = (TextObject)cr.ReportDefinition.Sections["Section3"].ReportObjects["Text42"];
            TextObject text6 = (TextObject)cr.ReportDefinition.Sections["Section3"].ReportObjects["Text41"];
            TextObject text7 = (TextObject)cr.ReportDefinition.Sections["Section3"].ReportObjects["Text40"];
            TextObject text8 = (TextObject)cr.ReportDefinition.Sections["Section3"].ReportObjects["Text39"];
            text.Text = txt_WithdrawalAccountName.Text;
            text1.Text = txt_WithdrawalAccountNumber.Text;
            text2.Text = txt_WithdrawalName.Text;
            text3.Text = Date_Withdrawal.Text;
            text4.Text = label_WithdrawalTime.Text;
            text5.Text = txt_WithdrawalAmount.Text;
            text6.Text = txt_WithdrawalAmountInWord.Text;
            text7.Text = cb_WithdrawalCurrency.Text;
            text8.Text = txt_WithdrwalNarration.Text;
            WithdrawalViewer.crystalReportViewer1.ReportSource = cr;
            WithdrawalViewer.Show();
        }

        public void CommunicationAccountNumber()
        {
            try
            {
                conn.Open();   
                SqlCommand cmd2 = new SqlCommand("SELECT ID_Number FROM BANK_ACCOUNT_DETAILS where Identifier = '" + txt_WithdrawalAccountName.Text + "'", conn);
                SqlDataAdapter da1 = new SqlDataAdapter(cmd2);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                if (dt1.Rows.Count > 0)
                {
                    obj.label_AccountNumber.Text = dt1.Rows[0]["ID_Number"].ToString();
                }
                else
                {
                    MessageBox.Show("This Account name does not exist in the Deposit storage", "Information", MessageBoxButtons.OK);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void message()
        {
            obj.txt_Message.Text = "The account named " + txt_WithdrawalAccountName.Text + " and Number " + obj.label_AccountNumber.Text + " on IMARA Cooperative of Savings and Credit have maked the Withdrawal transaction of " + txt_WithdrawalAmount.Text + " " + cb_WithdrawalCurrency.SelectedItem.ToString();
        }

        public void CommunicationMobileNumber()
        {
            try
            {
                string Code;
                string Number;

                conn.Open();
                SqlCommand cmd2 = new SqlCommand("SELECT Mobile_Number_Code,Mobile_Number FROM PERSONAL_DETAILS where First_Name = '" + txt_WithdrawalAccountName.Text + "'", conn);
                SqlDataAdapter da1 = new SqlDataAdapter(cmd2);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                if (dt1.Rows.Count > 0)
                {
                    Code = dt1.Rows[0]["Mobile_Number_Code"].ToString();
                    Number = dt1.Rows[0]["Mobile_Number"].ToString();

                    obj.txt_PhoneNumber.Text = Code + Number;
                }
                else
                {
                    MessageBox.Show("This Account name does not exist in the Deposit storage", "Information", MessageBoxButtons.OK);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
