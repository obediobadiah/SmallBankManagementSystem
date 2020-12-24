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
    public partial class AdministratorCreaation : Form
    {
        public AdministratorCreaation()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-454MBGL;Initial Catalog=BANK_CUSTOMERS_Disseration_Project_DB;Integrated Security=True");
        string imgLocation = "";

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_AdminFirstName.Text == "" || txt_AdminSecondName.Text == "" || txt_AdminFunction.Text == "" || cb_AdminNationality.Text == "" || txt_AdminEmail.Text == "" || txt_AdminUserName.Text == "" || txt_AdminPassword.Text == "")
            {
                MessageBox.Show("You cannot insert Administrator details without filling all required fields", "INFORMATION");
            }
            else
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd1 = new SqlCommand("INSERT into ADMINISTRATOR_DETAILS (First_Name,Second_Name,Fonction,Gender,Date_of_Birth,Nationality,E_Mail,User_Name,Password,Picture) values (@First_Name,@Second_Name,@Fonction,@Gender,@Date_of_Birth,@Nationality,@E_Mail,@User_Name,@Password,@Picture)", conn);


                    cmd1.Parameters.AddWithValue("@First_Name", txt_AdminFirstName.Text);
                    cmd1.Parameters.AddWithValue("@Second_Name", txt_AdminSecondName.Text);
                    cmd1.Parameters.AddWithValue("@Fonction", txt_AdminFunction.Text);

                    String gender = string.Empty;

                    if (rb_AdminMale.Checked)
                    {
                        gender = "Male";
                    }
                    else if (rb_AdminFemale.Checked)
                    {
                        gender = "Female";
                    }
                    cmd1.Parameters.AddWithValue("@Gender", gender);
                    cmd1.Parameters.AddWithValue("@Date_of_Birth", date_AdminBirth.Value.Date.ToShortDateString());
                    cmd1.Parameters.AddWithValue("@Nationality", cb_AdminNationality.SelectedItem);
                    cmd1.Parameters.AddWithValue("@E_Mail", txt_AdminEmail.Text);
                    cmd1.Parameters.AddWithValue("@User_Name", txt_AdminUserName.Text);
                    cmd1.Parameters.AddWithValue("@Password", txt_AdminPassword.Text);
                    cmd1.Parameters.Add(new SqlParameter("@Picture", savephoto()));
                    int i;
                    i = cmd1.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Administrator details saved successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    conn.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
        public byte[] savephoto()
        {
            MemoryStream stem = new MemoryStream();
            pictureBox2.Image.Save(stem, pictureBox2.Image.RawFormat);
            return stem.GetBuffer();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "jpg|*.jpg|jpeg|*.jpeg|bmp|*.bmp|png|*.png|all files|*.*";
            DialogResult res = open.ShowDialog();

            if (res == DialogResult.OK)
            {
                imgLocation = open.FileName.ToString();
                pictureBox2.ImageLocation = imgLocation;
            }
        }

        private void bunifuCustomDataGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.bunifuCustomDataGrid1.Rows[e.RowIndex];

                    label_IDNumber.Text = row.Cells["ID_Number"].Value.ToString();
                    txt_AdminFirstName.Text = row.Cells["First_Name"].Value.ToString();
                    txt_AdminSecondName.Text = row.Cells["Second_Name"].Value.ToString();
                    txt_AdminFunction.Text = row.Cells["Fonction"].Value.ToString();

                    if (row.Cells["Gender"].Value.Equals("Male"))
                        rb_AdminMale.Checked = true;
                    else
                        rb_AdminMale.Checked = false;

                    if (row.Cells["Gender"].Value.Equals("Female"))
                        rb_AdminFemale.Checked = true;
                    else
                        rb_AdminFemale.Checked = false;

                    date_AdminBirth.Text = row.Cells["Date_of_Birth"].Value.ToString();
                    cb_AdminNationality.Text = row.Cells["Nationality"].Value.ToString();
                    txt_AdminEmail.Text = row.Cells["E_mail"].Value.ToString();
                    txt_AdminUserName.Text = row.Cells["User_Name"].Value.ToString();
                    txt_AdminPassword.Text = row.Cells["Password"].Value.ToString();
                }
                PictureView();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        public void Display()
        {
            try
            {
                string qry = "SELECT * FROM ADMINISTRATOR_DETAILS";
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

        private void AdministratorCreaation_Load(object sender, EventArgs e)
        {
            Display();
        }

        public void PictureView()
        {
            try
            {
                conn.Open();
                SqlCommand cmd2 = new SqlCommand("SELECT Picture FROM ADMINISTRATOR_DETAILS where ID_Number = '" + label_IDNumber.Text + "'", conn);
                SqlDataReader da1 = cmd2.ExecuteReader();
                da1.Read();

                if (da1.HasRows)
                {
                    byte[] image = (byte[])da1["Picture"];
                    if (image == null)
                    {
                        pictureBox2.Image = null;
                    }
                    else
                    {
                        MemoryStream stem = new MemoryStream(image);
                        pictureBox2.Image = Image.FromStream(stem);
                    }
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd1 = new SqlCommand("UPDATE ADMINISTRATOR_DETAILS SET First_Name = @First_Name,Second_Name = @Second_Name,Fonction = @Fonction,Gender = @Gender,Date_of_Birth = @Date_of_Birth,Nationality = @Nationality,E_Mail = @E_Mail,User_Name = @User_Name,Password = @Password, Picture = @Picture WHERE ID_Number = @ID_Number", conn);

                cmd1.Parameters.AddWithValue("@ID_Number", label_IDNumber.Text);
                cmd1.Parameters.AddWithValue("@First_Name", txt_AdminFirstName.Text);
                cmd1.Parameters.AddWithValue("@Second_Name", txt_AdminSecondName.Text);
                cmd1.Parameters.AddWithValue("@Fonction", txt_AdminFunction.Text);

                String gender = string.Empty;

                if (rb_AdminMale.Checked)
                {
                    gender = "Male";
                }
                else if (rb_AdminFemale.Checked)
                {
                    gender = "Female";
                }
                cmd1.Parameters.AddWithValue("@Gender", gender);
                cmd1.Parameters.AddWithValue("@Date_of_Birth", date_AdminBirth.Value.Date.ToShortDateString());
                cmd1.Parameters.AddWithValue("@Nationality", cb_AdminNationality.SelectedItem);
                cmd1.Parameters.AddWithValue("@E_Mail", txt_AdminEmail.Text);
                cmd1.Parameters.AddWithValue("@User_Name", txt_AdminUserName.Text);
                cmd1.Parameters.AddWithValue("@Password", txt_AdminPassword.Text);
                cmd1.Parameters.Add(new SqlParameter("@Picture", savephoto()));
                int i;
                i = cmd1.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Administrator details modified successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                conn.Close();
                Display();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure that you want to delete??", "QUESTION", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd1 = new SqlCommand("DELETE FROM ADMINISTRATOR_DETAILS WHERE ID_Number = @ID_Number", conn);

                    cmd1.Parameters.AddWithValue("@ID_Number", label_IDNumber.Text);

                    int i;
                    i = cmd1.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Administrator details deleted successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
