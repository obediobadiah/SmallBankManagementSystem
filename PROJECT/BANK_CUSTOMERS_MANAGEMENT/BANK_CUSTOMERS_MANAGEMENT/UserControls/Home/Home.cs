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
using System.Data.Sql;

namespace BANK_CUSTOMERS_MANAGEMENT
{
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=ULK_GISENYI;Initial Catalog=BANK_CUSTOMERS_Disseration_Project_DB;Integrated Security=True");
        private void Home_Load(object sender, EventArgs e)
        {
            Personal_Total_Viewer();
            Deposit_Total_Viewer();
            Withdrawal_Total_Viewer();
            Loan_Total_Viewer();
            Repayment_Total_Viewer();
            MessageCommunication_Total_Viewer();
        }
        public void Personal_Total_Viewer()
        {
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT count (*) AS MyCount FROM BANK_ACCOUNT_DETAILS";
            conn.Open();

            int ReturnValue = (int)cmd.ExecuteScalar();
            label2.Text = ReturnValue.ToString();
            conn.Close();
        }
        public void Deposit_Total_Viewer()
        {
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT count (*) AS MyCount FROM DEPOSIT_TRANS";
            conn.Open();

            int ReturnValue = (int)cmd.ExecuteScalar();
            label6.Text = ReturnValue.ToString();
            conn.Close();
        }
        public void Withdrawal_Total_Viewer()
        {
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT count (*) AS MyCount FROM WITHDRAWAL_TRANSACTION";
            conn.Open();

            int ReturnValue = (int)cmd.ExecuteScalar();
            label8.Text = ReturnValue.ToString();
            conn.Close();
        }
        public void Loan_Total_Viewer()
        {
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT count (*) AS MyCount FROM LOAN_TRANSACTION";
            conn.Open();

            int ReturnValue = (int)cmd.ExecuteScalar();
            label10.Text = ReturnValue.ToString();
            conn.Close();
        }
        public void Repayment_Total_Viewer()
        {
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT count (*) AS MyCount FROM REPAYMENT_TRANSACTION";
            conn.Open();

            int ReturnValue = (int)cmd.ExecuteScalar();
            label12.Text = ReturnValue.ToString();
            conn.Close();
        }
        public void MessageCommunication_Total_Viewer()
        {
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT count (*) AS MyCount FROM MESSAGE_COMMUNICATION";
            conn.Open();

            int ReturnValue = (int)cmd.ExecuteScalar();
            label14.Text = ReturnValue.ToString();
            conn.Close();
        }
    }
}
