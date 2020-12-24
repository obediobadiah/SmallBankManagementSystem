using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BANK_CUSTOMERS_MANAGEMENT
{
    public partial class Deposit_Transaction_Report_Viewer : Form
    {
        public Deposit_Transaction_Report_Viewer()
        {
            InitializeComponent();
        }

        Form1 obj2 = new Form1();
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-454MBGL;Initial Catalog=BANK_CUSTOMERS_Disseration_Project_DB;Integrated Security=True");
        private void button3_Click(object sender, EventArgs e)
        {
            Deposit_Transaction_Reports cr = new Deposit_Transaction_Reports();

            SqlCommand cmd = new SqlCommand("SELECT ID_Number, Account_Name,Account_Number,Deposer_Name, Transaction_Date,Transaction_Time,Amount,Amount_In_Words,Currency FROM DEPOSIT_TRANSACTION where  Account_Number = '" + txt_Search.Text + "'", conn);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet dt = new DataSet();
            da.Fill(dt, "DEPOSIT_TRANSACTION");
            cr.SetDataSource(dt.Tables["DEPOSIT_TRANSACTION"]);

            //crystalReportViewer1.ReportSource = cr;
            //crystalReportViewer1.Refresh();

            //if (comboBox1.SelectedItem == "Account Number")
            //{
            //    try
            //    {
            //        SqlCommand cmd = new SqlCommand("SELECT ID_Number, Account_Name,Account_Number,Deposer_Name, Transaction_Date,Transaction_Time,Amount,Amount_In_Words,Currency FROM DEPOSIT_TRANSACTION where  Account_Number = '" + txt_Search.Text + "'", conn);
            //        SqlDataAdapter da = new SqlDataAdapter(cmd);
            //        DataSet dt = new DataSet();
            //        da.Fill(dt);
            //        cr.SetDataSource(dt.Tables["DEPOSIT_TRANSACTION"]);
            //        crystalReportViewer1.ReportSource = cr;
            //        crystalReportViewer1.Refresh();
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message);
            //    }
            //}
            //else if (comboBox1.SelectedItem == "Account Name")
            //{
            //    try
            //    {
            //        SqlCommand cmd = new SqlCommand("SELECT * FROM PERSONAL_DETAILS where First_Name = '" + txt_Search.Text + "'", conn);
            //        SqlDataAdapter da = new SqlDataAdapter(cmd);
            //        DataTable dt = new DataTable();
            //        da.Fill(dt);
            //        //bunifuCustomDataGrid1.DataSource = dt;
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message);
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("With what you wanna search??", "Question", MessageBoxButtons.OK, MessageBoxIcon.Question);
            //}
        }

        private void Deposit_Transaction_Report_Viewer_Load(object sender, EventArgs e)
        {
            crystalReportViewer1.Refresh();
        }
    }
}
