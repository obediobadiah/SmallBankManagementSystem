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
    public partial class BankAccountDetails : UserControl
    {
        public BankAccountDetails()
        {
            InitializeComponent();
            label5.Visible = false;
            Date_BankAccountLimitDate.Visible = false;
        }
        SqlConnection conn = new SqlConnection(@"Data Source=ULK_GISENYI;Initial Catalog=BANK_CUSTOMERS_Disseration_Project_DB;Integrated Security=True");
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_BankAccountType.SelectedItem == "Savings Account")
            {
                label5.Visible = true;
                Date_BankAccountLimitDate.Visible = true;
            }
            else
            {
                label5.Visible = false;
                Date_BankAccountLimitDate.Visible = false;
            }
        }

        private void button_save_acc_cr_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand("SELECT First_Name FROM PERSONAL_DETAILS WHERE First_Name = '" + txt_BankAcccountIdentifier.Text + "'", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count >= 1)
            {
                MessageBox.Show("The Account Name  " + txt_BankAcccountIdentifier.Text + " has already account details in the system");
                clear();
            }
            else
            {
                if (date_DateofCreation.Text == "" || txt_BankAcccountIdentifier.Text == "" || cb_BankAccountType.Text == "")
                {
                    MessageBox.Show("You cannot end the procees without filling all required fields");
                }
                else if (cb_BankAccountType.SelectedItem == "Checking Account")
                {
                    conn.Open();
                    SqlCommand cmd1 = new SqlCommand("INSERT into BANK_ACCOUNT_DETAILS values (@Date_of_creation,@Identifier,@Bank_Account_Type,@Limit_Date)", conn);
                    cmd1.Parameters.AddWithValue("@Date_of_creation", date_DateofCreation.Value.Date.ToShortDateString());
                    cmd1.Parameters.AddWithValue("@Identifier", txt_BankAcccountIdentifier.Text);
                    cmd1.Parameters.AddWithValue("@Bank_Account_Type", cb_BankAccountType.SelectedItem);
                    cmd1.Parameters.AddWithValue("@Limit_Date", "----");

                    int i;
                    i = cmd1.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Process finished successfully, Account created", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    conn.Close();
                    clear();
                }
                else if (cb_BankAccountType.SelectedItem == "Savings Account")
                {
                    conn.Open();
                    SqlCommand cmd1 = new SqlCommand("INSERT into BANK_ACCOUNT_DETAILS values (@Date_of_creation,@Identifier,@Bank_Account_Type,@Limit_Date)", conn);

                    cmd1.Parameters.AddWithValue("@Date_of_creation", date_DateofCreation.Value.Date.ToShortDateString());
                    cmd1.Parameters.AddWithValue("@Identifier", txt_BankAcccountIdentifier.Text);
                    cmd1.Parameters.AddWithValue("@Bank_Account_Type", cb_BankAccountType.SelectedItem);
                    cmd1.Parameters.AddWithValue("@Limit_Date", Date_BankAccountLimitDate.Value.Date.ToShortDateString());

                    int i;
                    i = cmd1.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Process finished successfully, Account created", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    conn.Close();
                    clear();
                }
            }
            
        }
        public void clear()
        {
            date_DateofCreation.Text = "";
            txt_BankAcccountIdentifier.Text = "";
            cb_BankAccountType.SelectedItem = "";
            Date_BankAccountLimitDate.Text = "";
        }
            //CommunicationsSender CommSend = new CommunicationsSender();
            //CommSend.ShowDialog();
    }
}
