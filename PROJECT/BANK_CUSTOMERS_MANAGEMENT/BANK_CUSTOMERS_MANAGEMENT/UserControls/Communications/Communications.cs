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
    public partial class Communications : UserControl
    {
        public Communications()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-454MBGL;Initial Catalog=BANK_CUSTOMERS_Disseration_Project_DB;Integrated Security=True");
        public void Display()
        {
            try
            {
                string qry = "SELECT * FROM MESSAGE_COMMUNICATION";
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

        private void Communications_Load(object sender, EventArgs e)
        {
            Display();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "Account Number")
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM MESSAGE_COMMUNICATION where Account_Number LIKE '%" + txt_Search.Text + "%'", conn);
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
            else if (comboBox1.SelectedItem == "Mobile Number")
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM MESSAGE_COMMUNICATION where Mobile_Number LIKE '%" + txt_Search.Text + "%'", conn);
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
                MessageBox.Show("With what do you wanna search??", "Question", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }
    }

}
