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
using System.IO;

namespace BANK_CUSTOMERS_MANAGEMENT
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }


        Form1 obj2 = new Form1();
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-454MBGL;Initial Catalog=BANK_CUSTOMERS_Disseration_Project_DB;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            UsernameValidation();
        }

        public void UsernameValidation()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM ADMINISTRATOR_DETAILS WHERE User_Name= '" + txt_UserName.Text + "'", conn);
                SqlDataAdapter da1 = new SqlDataAdapter(cmd);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                if (dt1.Rows.Count >= 1)
                {
                    PasswordValidation();
                }
                else
                {
                    MessageBox.Show("The entered username is not recognize in the system", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void PasswordValidation()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM ADMINISTRATOR_DETAILS WHERE Password = '" + txt_Password.Text + "'", conn);
                SqlDataAdapter da1 = new SqlDataAdapter(cmd);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                if (dt1.Rows.Count >= 1)
                {
                    LoginValidation();
                }
                else
                {
                    MessageBox.Show("The entered password doesn't belong to the username","Information",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void LoginValidation()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM ADMINISTRATOR_DETAILS WHERE User_Name= '" + txt_UserName.Text + "' and Password = '" + txt_Password.Text + "'", conn);
                SqlDataAdapter da1 = new SqlDataAdapter(cmd);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                if (dt1.Rows.Count >= 1)
                {
                    showAdminName();
                    obj2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("The entered UserName and Password is wrong", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void showAdminName()
        {
            try
            {
                SqlCommand cmd2 = new SqlCommand("SELECT First_Name FROM ADMINISTRATOR_DETAILS where User_Name = '" + txt_UserName.Text + "'", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd2);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    obj2.label1.Text = dt.Rows[0]["First_Name"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to close??", "QUESTION", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                this.Hide();
            }
            else
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
