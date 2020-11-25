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

namespace BANK_CUSTOMERS_MANAGEMENT
{
    public partial class WithdrawalTransaction : UserControl
    {
        public WithdrawalTransaction()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=ULK_GISENYI;Initial Catalog=BANK_CUSTOMERS_MANAGEMENT;Integrated Security=True");

        private void button_save_deposit_Click(object sender, EventArgs e)
        {
            conn.Open();
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
            label_WithdrawalTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void WithdrawalTransaction_Load(object sender, EventArgs e)
        {
            timer1.Start();
            Display();
        }
        public void Display()
        {
            string qry = "SELECT * FROM WITHDRAWAL_TRANSACTION";
            SqlDataAdapter sda = new SqlDataAdapter(qry, conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            bunifuCustomDataGrid1.DataSource = dt;
        }

        private void button_edit_deposit_Click(object sender, EventArgs e)
        {
            conn.Open();
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
    }
}
