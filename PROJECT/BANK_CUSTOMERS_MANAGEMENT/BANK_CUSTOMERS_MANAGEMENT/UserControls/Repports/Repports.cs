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
    public partial class Repports : UserControl
    {
        public Repports()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-454MBGL;Initial Catalog=BANK_CUSTOMERS_Disseration_Project_DB;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            Deposit_Transaction_Report_Viewer DepositTransactionViewer = new Deposit_Transaction_Report_Viewer();
            DepositTransactionViewer.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Withdrawal_Transaction_Report_Viewer WithdrawalTransactionViewer = new Withdrawal_Transaction_Report_Viewer();
            WithdrawalTransactionViewer.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Loan_Transaction_Report_Viewer LoanTransactionViewer = new Loan_Transaction_Report_Viewer();
            LoanTransactionViewer.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Repayment_Transaction_Report_Viewer RepaymentTransactionViewer = new Repayment_Transaction_Report_Viewer();
            RepaymentTransactionViewer.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Account_Informations_Report_Viewer AccountReport = new Account_Informations_Report_Viewer();
            AccountReport.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Customer_List_Report_Viewer CustomerList = new Customer_List_Report_Viewer();
            CustomerList.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Communications_Report_Viewer CommunicationViewer = new Communications_Report_Viewer();
            CommunicationViewer.ShowDialog();
        }
    }
}
