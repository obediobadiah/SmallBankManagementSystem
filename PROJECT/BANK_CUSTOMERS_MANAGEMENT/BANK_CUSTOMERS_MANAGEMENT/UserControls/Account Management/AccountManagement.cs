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
        }

        SqlConnection conn = new SqlConnection(@"Data Source=ULK_GISENYI;Initial Catalog=BANK_CUSTOMERS_Disseration_Project_DB;Integrated Security=True");

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
            AccountBalance();
        }
        public void AccountNumber()
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
            conn.Close();
        }
        public void AccountType()
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
        public void LoanAmount()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM LOAN_TRANSACTION WHERE Borrower = '" + label_FirstName.Text + "'", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                SqlCommand cmd2 = new SqlCommand("SELECT (Amount,Currency) FROM LOAN_TRANSACTION where Borrower = '" + label_FirstName.Text + "'", conn);
                SqlDataAdapter da1 = new SqlDataAdapter(cmd2);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                if (dt1.Rows.Count > 0)
                {
                    label_AccountLoan.Text = dt1.Rows[0]["Amount"].ToString();
                    label_Currency.Text = dt1.Rows[1]["Currency"].ToString();
                }
                
            }
            else
            {
                label_AccountLoan.Text = "-----";
            }
            conn.Close();

        }

        public void PictureView()
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
                    //BinaryReader red = new BinaryReader(stem);
                    pictureBox2.Image = Image.FromStream(stem);
                    }
                conn.Close();
                }
        }
        public void AccountBalance()
        {
            conn.Open();
            SqlCommand cmd2 = new SqlCommand("SELECT SUM(CAST(Amount AS INTEGER)) FROM DEPOSIT_TRANS WHERE Account_Name= '" + label_FirstName.Text + "'", conn);
            SqlDataAdapter da1 = new SqlDataAdapter(cmd2);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            if (dt1.Rows.Count > 0)
            {
                label_AccountBalance.Text = dt1.Rows[0]["Amount"].ToString();
            }
            conn.Close();
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
    }
}
