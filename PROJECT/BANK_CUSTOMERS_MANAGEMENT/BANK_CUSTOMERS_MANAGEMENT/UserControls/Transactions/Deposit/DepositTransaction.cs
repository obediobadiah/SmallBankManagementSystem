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
    public partial class DepositTransaction : UserControl
    {
        public DepositTransaction()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=ULK_GISENYI;Initial Catalog=BANK_CUSTOMERS_Disseration_Project_DB;Integrated Security=True");
        private void DepositTransaction_Load(object sender, EventArgs e)
        {
            timer1.Start();
            Display();
            //conn.Open();
            //SqlCommand cmd = new SqlCommand("SELECT * FROM DEPOSIT_TRANSACTIONS");

        }

        private void button_save_deposit_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM BANK_ACCOUNT_DETAILS WHERE ID_Number = '" + txt_DepositAccountNumber.Text + "' AND Identifier = '" + txt_DepositAccountName.Text + "'", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                if(txt_DepositAccountName.Text == "" || txt_DepositAccountNumber.Text == " " || txt_DepositAmount.Text == "" || txt_DepositAmountInWord.Text == "" || txt_DepositDeposerName.Text == "" || txt_DepositNarration.Text == "" || cb_DepositCurrency.Text == "" || label_DepositTime.Text == "")
                {
                    MessageBox.Show("Make sure you complete all required fields");
                }
                else
                {
                    SqlCommand cmd1 = new SqlCommand("INSERT into DEPOSIT_TRANS (Account_Name,Account_Number,Deposer_Name,Transaction_Date,Transaction_Time,Amount,Amount_In_Words,Currency,Narration) values (@Account_Name,@Account_Number,@Deposer_Name,@Transaction_Date,@Transaction_Time,@Amount,@Amount_In_Words,@Currency,@Narration)", conn);

                    cmd1.Parameters.AddWithValue("@Account_Name", txt_DepositAccountName.Text);
                    cmd1.Parameters.AddWithValue("@Account_Number", txt_DepositAccountNumber.Text);
                    cmd1.Parameters.AddWithValue("@Deposer_Name", txt_DepositDeposerName.Text);
                    cmd1.Parameters.AddWithValue("@Transaction_Date", Date_Deposit.Value.Date.ToShortDateString());
                    cmd1.Parameters.AddWithValue("@Transaction_Time", label_DepositTime.Text);
                    cmd1.Parameters.AddWithValue("@Amount", txt_DepositAmount.Text);
                    cmd1.Parameters.AddWithValue("@Amount_In_Words", txt_DepositAmountInWord.Text);
                    cmd1.Parameters.AddWithValue("@Currency", cb_DepositCurrency.SelectedItem);
                    cmd1.Parameters.AddWithValue("@Narration", txt_DepositNarration.Text);

                    int i;
                    i = cmd1.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Deposit transaction done", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    Display();
                }

            }
            else
            {
                MessageBox.Show("The entered Account name and Account Number doesn't match", "Information");
            }
            conn.Close();

            //CommunicationsSender CommSend = new CommunicationsSender();
            //CommSend.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label_DepositTime.Text = DateTime.Now.ToLongTimeString();
        }
        public void Display()
        {
            string qry = "SELECT * FROM DEPOSIT_TRANS";
            SqlDataAdapter sda = new SqlDataAdapter(qry, conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            bunifuCustomDataGrid1.DataSource = dt;
        }

        private void bunifuCustomDataGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.bunifuCustomDataGrid1.Rows[e.RowIndex];

                ID_NumberLabel.Text = row.Cells["ID_Number"].Value.ToString();
                txt_DepositAccountName.Text = row.Cells["Account_Name"].Value.ToString();
                txt_DepositAccountNumber.Text = row.Cells["Account_Number"].Value.ToString();
                txt_DepositDeposerName.Text = row.Cells["Deposer_Name"].Value.ToString();
                Date_Deposit.Text = row.Cells["Transaction_Date"].Value.ToString();
                txt_DepositAmount.Text = row.Cells["Amount"].Value.ToString();
                txt_DepositAmountInWord.Text = row.Cells["Amount_In_Words"].Value.ToString();
                cb_DepositCurrency.Text = row.Cells["Currency"].Value.ToString();
                txt_DepositNarration.Text = row.Cells["Narration"].Value.ToString();
            }
        }

        private void button_edit_deposit_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM BANK_ACCOUNT_DETAILS WHERE ID_Number = '" + txt_DepositAccountNumber.Text + "' AND Identifier = '" + txt_DepositAccountName.Text + "'", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                if (txt_DepositAccountName.Text == "" || txt_DepositAccountNumber.Text == " " || txt_DepositAmount.Text == "" || txt_DepositAmountInWord.Text == "" || txt_DepositDeposerName.Text == "" || txt_DepositNarration.Text == "" || cb_DepositCurrency.Text == "" || label_DepositTime.Text == "")
                {
                    MessageBox.Show("Make sure you complete all required fields");
                }
                else
                {
                    SqlCommand cmd1 = new SqlCommand("UPDATE DEPOSIT_TRANS SET Account_Name = @Account_Name,Account_Number = @Account_Number,Deposer_Name = @Deposer_Name,Transaction_Date = @Transaction_Date,Transaction_Time = @Transaction_Time,Amount = @Amount,Amount_In_Words = @Amount_In_Words,Currency = @Currency,Narration = @Narration WHERE ID_Number = @ID_Number", conn);

                    cmd1.Parameters.AddWithValue("@ID_Number",ID_NumberLabel.Text);
                    cmd1.Parameters.AddWithValue("@Account_Name", txt_DepositAccountName.Text);
                    cmd1.Parameters.AddWithValue("@Account_Number", txt_DepositAccountNumber.Text);
                    cmd1.Parameters.AddWithValue("@Deposer_Name", txt_DepositDeposerName.Text);
                    cmd1.Parameters.AddWithValue("@Transaction_Date", Date_Deposit.Value.Date.ToShortDateString());
                    cmd1.Parameters.AddWithValue("@Transaction_Time", label_DepositTime.Text);
                    cmd1.Parameters.AddWithValue("@Amount", txt_DepositAmount.Text);
                    cmd1.Parameters.AddWithValue("@Amount_In_Words", txt_DepositAmountInWord.Text);
                    cmd1.Parameters.AddWithValue("@Currency", cb_DepositCurrency.SelectedItem);
                    cmd1.Parameters.AddWithValue("@Narration", txt_DepositNarration.Text);

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

        private void button_delete_deposit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure that you want to delete??", "QUESTION", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd1 = new SqlCommand("DELETE FROM DEPOSIT_TRANS WHERE ID_Number = @ID_Number", conn);

                    cmd1.Parameters.AddWithValue("@ID_Number", ID_NumberLabel.Text);

                    int i;
                    i = cmd1.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Deposit transaction details deleted successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        SqlCommand cmd = new SqlCommand("SELECT * FROM DEPOSIT_TRANS where Account_Number = '" + txt_Search.Text + "'", conn);
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
                        SqlCommand cmd = new SqlCommand("SELECT * FROM DEPOSIT_TRANS where Account_Name = '" + txt_Search.Text + "'", conn);
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_deposit_clear_Click(object sender, EventArgs e)
        {
            ID_NumberLabel.Text = "";
            txt_DepositAccountName.Text = "";
            txt_DepositAccountNumber.Text = "";
            txt_DepositDeposerName.Text = "";
            Date_Deposit.Text = "";
            label_DepositTime.Text = "";
            txt_DepositAmount.Text = "";
            txt_DepositAmountInWord.Text = "";
            cb_DepositCurrency.SelectedItem = "";
            txt_DepositNarration.Text = "";
        }

        private void button_print_deposit_Click(object sender, EventArgs e)
        {
            Deposit_Viewer DepositViewer = new Deposit_Viewer();
            Deposit_Slip cr = new Deposit_Slip();
            TextObject text = (TextObject)cr.ReportDefinition.Sections["Section3"].ReportObjects["Text47"];
            TextObject text1 = (TextObject)cr.ReportDefinition.Sections["Section3"].ReportObjects["Text46"];
            TextObject text2 = (TextObject)cr.ReportDefinition.Sections["Section3"].ReportObjects["Text45"];
            TextObject text3 = (TextObject)cr.ReportDefinition.Sections["Section3"].ReportObjects["Text44"];
            TextObject text4 = (TextObject)cr.ReportDefinition.Sections["Section3"].ReportObjects["Text43"];
            TextObject text5 = (TextObject)cr.ReportDefinition.Sections["Section3"].ReportObjects["Text42"];
            TextObject text6 = (TextObject)cr.ReportDefinition.Sections["Section3"].ReportObjects["Text41"];
            TextObject text7 = (TextObject)cr.ReportDefinition.Sections["Section3"].ReportObjects["Text40"];
            TextObject text8 = (TextObject)cr.ReportDefinition.Sections["Section3"].ReportObjects["Text39"];
            text.Text = txt_DepositAccountName.Text;
            text1.Text = txt_DepositAccountNumber.Text;
            text2.Text = txt_DepositDeposerName.Text;
            text3.Text = Date_Deposit.Text;
            text4.Text = label_DepositTime.Text;
            text5.Text = txt_DepositAmount.Text;
            text6.Text = txt_DepositAmountInWord.Text;
            text7.Text = cb_DepositCurrency.Text;
            text8.Text = txt_DepositNarration.Text;
            DepositViewer.crystalReportViewer1.ReportSource = cr;
            DepositViewer.Show();
        }
    }
}
