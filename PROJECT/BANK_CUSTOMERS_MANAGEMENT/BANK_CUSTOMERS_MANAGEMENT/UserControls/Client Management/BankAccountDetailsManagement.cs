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
    public partial class BankAccountDetailsManagement : UserControl
    {
        public BankAccountDetailsManagement()
        {
            InitializeComponent();
            label5.Visible = false;
            Date_BankAccountLimitDate.Visible = false;
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-454MBGL;Initial Catalog=BANK_CUSTOMERS_Disseration_Project_DB;Integrated Security=True");
        private void cb_BankAccountType_SelectedIndexChanged(object sender, EventArgs e)
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

        private void button_edit_deposit_Click(object sender, EventArgs e)
        {
            try
            {
                if (date_DateofCreation.Text == "" || txt_BankIdentifier.Text == "" || cb_BankAccountType.Text == "")
                {
                    MessageBox.Show("You cannot edit without filling all required fields");
                }
                else if (cb_BankAccountType.SelectedItem == "Checking Account")
                {
                    conn.Open();
                    SqlCommand cmd2 = new SqlCommand("UPDATE BANK_ACCOUNT_DETAILS SET Date_of_creation = @Date_of_creation, Identifier = @Identifier, Bank_Account_Type = @Bank_Account_Type, Limit_Date = @Limit_Date WHERE ID_Number = @ID_Number", conn);

                    cmd2.Parameters.AddWithValue("@ID_Number", label_IDNumber.Text);
                    cmd2.Parameters.AddWithValue("@Date_of_creation", date_DateofCreation.Value.Date.ToShortDateString());
                    cmd2.Parameters.AddWithValue("@Identifier", txt_BankIdentifier.Text);
                    cmd2.Parameters.AddWithValue("@Bank_Account_Type", cb_BankAccountType.SelectedItem);
                    cmd2.Parameters.AddWithValue("@Limit_Date", "----");

                    int i;
                    i = cmd2.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Bank details edited sucessfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    Display();
                    conn.Close();
                }
                else if (cb_BankAccountType.SelectedItem == "Savings Account")
                {
                    conn.Open();
                    SqlCommand cmd2 = new SqlCommand("UPDATE BANK_ACCOUNT_DETAILS SET Date_of_creation = @Date_of_creation, Identifier = @Identifier, Bank_Account_Type = @Bank_Account_Type, Limit_Date = @Limit_Date WHERE ID_Number = @ID_Number", conn);

                    cmd2.Parameters.AddWithValue("@ID_Number", label_IDNumber.Text);
                    cmd2.Parameters.AddWithValue("@Date_of_creation", date_DateofCreation.Value.Date.ToShortDateString());
                    cmd2.Parameters.AddWithValue("@Identifier", txt_BankIdentifier.Text);
                    cmd2.Parameters.AddWithValue("@Bank_Account_Type", cb_BankAccountType.SelectedItem);
                    cmd2.Parameters.AddWithValue("@Limit_Date", Date_BankAccountLimitDate.Value.Date.ToShortDateString());

                    int i;
                    i = cmd2.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Bank details edited sucessfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    conn.Close();
                    Display();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        public void Display()
        {
            try
            {
                string qry = "SELECT * FROM BANK_ACCOUNT_DETAILS";
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

        private void BankAccountDetailsManagement_Load(object sender, EventArgs e)
        {
            Display();
        }

        private void bunifuCustomDataGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.bunifuCustomDataGrid1.Rows[e.RowIndex];;


                if (row.Cells["Limit_Date"].Value.Equals("----"))
                {
                    label_IDNumber.Text = row.Cells["ID_Number"].Value.ToString();
                    date_DateofCreation.Text = row.Cells["Date_of_creation"].Value.ToString();
                    txt_BankIdentifier.Text = row.Cells["Identifier"].Value.ToString();
                    cb_BankAccountType.Text = row.Cells["Bank_Account_Type"].Value.ToString();
                    Date_BankAccountLimitDate.Visible = false;
                }
                else
                {
                    label_IDNumber.Text = row.Cells["ID_Number"].Value.ToString();
                    date_DateofCreation.Text = row.Cells["Date_of_creation"].Value.ToString();
                    txt_BankIdentifier.Text = row.Cells["Identifier"].Value.ToString();
                    cb_BankAccountType.Text = row.Cells["Bank_Account_Type"].Value.ToString();
                    Date_BankAccountLimitDate.Text = row.Cells["Limit_Date"].Value.ToString();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "ID Number")
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM BANK_ACCOUNT_DETAILS where  ID_Number = '" + txt_Search.Text + "'", conn);
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
            else if (comboBox1.SelectedItem == "First Name")
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM BANK_ACCOUNT_DETAILS where First_Name = '" + txt_Search.Text + "'", conn);
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

        private void button_delete_deposit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure that you want to delete??", "QUESTION", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd1 = new SqlCommand("DELETE FROM BANK_ACCOUNT_DETAILS WHERE ID_Number = @ID_Number", conn);

                    cmd1.Parameters.AddWithValue("@ID_Number", label_IDNumber.Text);

                    int i;
                    i = cmd1.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Customer bank details deleted successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
