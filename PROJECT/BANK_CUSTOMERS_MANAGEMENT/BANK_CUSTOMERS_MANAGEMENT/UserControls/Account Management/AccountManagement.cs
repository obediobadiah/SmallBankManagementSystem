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
using System.IO;

namespace BANK_CUSTOMERS_MANAGEMENT
{
    public partial class AccountManagement : UserControl
    {
        public AccountManagement()
        {
            InitializeComponent();

            label9.Visible = false;
            label10.Visible = false;
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-454MBGL;Initial Catalog=BANK_CUSTOMERS_Disseration_Project_DB;Integrated Security=True");

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void AccountManagement_Load(object sender, EventArgs e)
        {
            Display();
        }
        public void Display()
        {
            string qry = "SELECT First_Name, Second_Name, Gender, Nationality FROM PERSONAL_DETAILS";
            SqlDataAdapter sda = new SqlDataAdapter(qry, conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            bunifuCustomDataGrid1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AccountNumber();
            AccountType();
            LoanAmount();
            DepositBalance();
            WithdrawalBalance();
            BalanceCalculation();
        }
        public void AccountNumber()
        {
            try
            {
                conn.Open();
                SqlCommand cmd2 = new SqlCommand("SELECT ID_Number FROM BANK_ACCOUNT_DETAILS where Identifier = '" + label_FirstName.Text + "'", conn);
                SqlDataAdapter da1 = new SqlDataAdapter(cmd2);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                if (dt1.Rows.Count > 0)
                {
                    label_AccountNumber.Text = dt1.Rows[0]["ID_Number"].ToString();
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
        public void AccountType()
        {
            try
            {
                conn.Open();
                SqlCommand cmd2 = new SqlCommand("SELECT Bank_Account_Type FROM BANK_ACCOUNT_DETAILS where Identifier = '" + label_FirstName.Text + "'", conn);
                SqlDataAdapter da1 = new SqlDataAdapter(cmd2);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                if (dt1.Rows.Count > 0)
                {
                    label_AccountType.Text = dt1.Rows[0]["Bank_Account_Type"].ToString();
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        public void LoanAmount()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM LOAN_TRANSACTION WHERE Borrower = '" + label_FirstName.Text + "'", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    LoanDisplay();
                    LoanCurrencyDisplay();
                }
                else
                {
                    label_AccountLoan.Text = "-----";
                    label_Currency.Text = "";
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void PictureView()
        {
            try
            {
                conn.Open();
                    SqlCommand cmd2 = new SqlCommand("SELECT Picture FROM PERSONAL_DETAILS where First_Name = '" + label_FirstName.Text + "'", conn);
                    SqlDataReader da1 = cmd2.ExecuteReader();
                    da1.Read();
                
                    if (da1.HasRows)
                    {
                        byte[] image =(byte [])da1["Picture"];
                        if (image == null)
                        {
                            pictureBox2.Image = null;
                        }
                        else
                        {
                        MemoryStream stem = new MemoryStream(image);
                        pictureBox2.Image = Image.FromStream(stem);
                        }
                    conn.Close();
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        public void DepositBalance()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT SUM(Amount) as AmountSum FROM DEPOSIT_TRANSACTION WHERE Account_Name= '" + label_FirstName.Text + "'", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    label10.Text = dt.Rows[0]["AmountSum"].ToString();
                    BalanceCurrencyDisplay();
                }
                else
                {
                    label10.Text = "";
                    label_BalanceCurrency.Text = "";
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        public void WithdrawalBalance()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT SUM(Amount) as AmountSum FROM WITHDRAWAL_TRANSACTION WHERE Account_Name= '" + label_FirstName.Text + "'", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    label9.Text = dt.Rows[0]["AmountSum"].ToString();
                    BalanceCurrencyDisplay();
                }
                else
                {
                    label9.Text = "";
                    label_BalanceCurrency.Text = "";
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        public void BalanceCalculation()
        {

            if (label10.Text == "")
            {
                label_AccountBalance.Text = "----";
                label_BalanceCurrency.Text = "";
            }
            else
            {
                double DepTrans;
                double WithTrans;
                double result;
                DepTrans = Convert.ToDouble(label10.Text);
                WithTrans = Convert.ToDouble(label9.Text);

                result = DepTrans - WithTrans;
                label_AccountBalance.Text = result.ToString();
            }

        }
        private void bunifuCustomDataGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.bunifuCustomDataGrid1.Rows[e.RowIndex];

                label_FirstName.Text = row.Cells["First_Name"].Value.ToString();
                label_SecondName.Text = row.Cells["Second_Name"].Value.ToString();
                label_Gender.Text = row.Cells["Gender"].Value.ToString();
                label_Nationality.Text = row.Cells["Nationality"].Value.ToString();
            }
            PictureView();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM PERSONAL_DETAILS where First_Name = '" + txt_Search.Text + "'", conn);
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

        private void button_Account_management_Click(object sender, EventArgs e)
        {

        }
        public void LoanDisplay()
        {
            try
            {
                SqlCommand cmd2 = new SqlCommand("SELECT Amount FROM LOAN_TRANSACTION where Borrower = '" + label_FirstName.Text + "'", conn);
                SqlDataAdapter da1 = new SqlDataAdapter(cmd2);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                if (dt1.Rows.Count > 0)
                {
                    label_AccountLoan.Text = dt1.Rows[0]["Amount"].ToString();
                }
                else
                {
                    label_AccountLoan.Text = "----";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        public void LoanCurrencyDisplay()
        {
            try
            {
                SqlCommand cmd2 = new SqlCommand("SELECT Currency FROM LOAN_TRANSACTION where Borrower = '" + label_FirstName.Text + "'", conn);
                SqlDataAdapter da1 = new SqlDataAdapter(cmd2);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                if (dt1.Rows.Count > 0)
                {
                    label_Currency.Text = dt1.Rows[0]["Currency"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        public void BalanceCurrencyDisplay()
        {
            try
            {
                SqlCommand cmd2 = new SqlCommand("SELECT Currency FROM DEPOSIT_TRANSACTION where Account_Name = '" + label_FirstName.Text + "'", conn);
                SqlDataAdapter da1 = new SqlDataAdapter(cmd2);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                if (dt1.Rows.Count > 0)
                {
                    label_BalanceCurrency.Text = dt1.Rows[0]["Currency"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}
