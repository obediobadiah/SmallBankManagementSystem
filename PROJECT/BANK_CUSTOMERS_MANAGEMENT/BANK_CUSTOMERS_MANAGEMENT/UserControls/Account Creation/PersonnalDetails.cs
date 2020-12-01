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
using System.IO;
using System.Drawing.Imaging;
using Microsoft.VisualBasic;

namespace BANK_CUSTOMERS_MANAGEMENT
{
    public partial class PersonnalDetails : UserControl
    {
        public PersonnalDetails()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=ULK_GISENYI;Initial Catalog=BANK_CUSTOMERS_Disseration_Project_DB;Integrated Security=True");
        string imgLocation = "";

        private void button_next_acc_cr_Click(object sender, EventArgs e)
        {
            if (cb_ApplicantReq.SelectedItem == "YES")
            {
                DialogResult result = MessageBox.Show("Are you sure to want to continue??", "QUESTION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (txt_FirstName.Text == "" || txt_SecondName.Text == "" || date_Birth.Text == "" || txt_PlaceOfBirth.Text == "" || cb_Nationality.Text == "" || cb_MeritalStatus.Text == "" || txt_NameOfSpouse.Text == "" || txt_Proffesional.Text == "" || cb_code.Text == "" || txt_MobileNumber.Text == "" || txt_CountryName.Text == "" || txt_Province.Text == "" || txt_Town.Text == "" || txt_Township.Text == "" || txt_Quarter.Text == "" || txt_Avenue.Text == "" || txt_HouseNumber.Text == "")
                    {
                        MessageBox.Show("You are not allowed to go to next step without completing all Personnal details required");
                    }
                    else
                    {
                        if (!Form1.instance.pane3.Controls.ContainsKey("ApplicantDetails"))
                        {
                            Form1.instance.pane3.Controls.Clear();
                            ApplicantDetails user = new ApplicantDetails();
                            user.Dock = DockStyle.Fill;
                            Form1.instance.pane3.Controls.Add(user);
                        }
                        Form1.instance.pane3.Controls["ApplicantDetails"].BringToFront();
                    }

                }
                else
                {
                    DialogResult Result = MessageBox.Show("Obligated to make the Applicants requirement", "WARMING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (cb_ApplicantReq.SelectedItem == "NO")
            {
                DialogResult result = MessageBox.Show("Are you sure to want to continue??", "QUESTION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (txt_FirstName.Text == "" || txt_SecondName.Text == "" || date_Birth.Text == "" || txt_PlaceOfBirth.Text == "" || cb_Nationality.Text == "" || cb_MeritalStatus.Text == "" || txt_NameOfSpouse.Text == "" || txt_Proffesional.Text == "" || cb_code.Text == "" || txt_MobileNumber.Text == "" || txt_CountryName.Text == "" || txt_Province.Text == "" || txt_Town.Text == "" || txt_Township.Text == "" || txt_Quarter.Text == "" || txt_Avenue.Text == "" || txt_HouseNumber.Text == "")
                    {
                        MessageBox.Show("You are not allowed to go to next step without completing all Personnal details required");
                    }
                    else
                    {
                        if (!Form1.instance.pane3.Controls.ContainsKey("BankAccountDetails"))
                        {
                            Form1.instance.pane3.Controls.Clear();
                            BankAccountDetails user = new BankAccountDetails();
                            user.Dock = DockStyle.None;
                            Form1.instance.pane3.Controls.Add(user);
                            user.Location = new Point(250, 0);
                        }
                        Form1.instance.pane3.Controls["BankAccountDetails"].BringToFront();
                    }
                }
                else
                {

                }
            }
        }

        private void cb_MeritalStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_MeritalStatus.SelectedItem == "Unmarried")
            {
                txt_NameOfSpouse.Text = "--";
            }
        }

        private void cb_ApplicantReq_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PersonnalDetails_Load(object sender, EventArgs e)
        {

        }
        public byte[] savephoto()
        {
            MemoryStream stem = new MemoryStream();
            pictureBox1.Image.Save(stem, pictureBox1.Image.RawFormat);
            return stem.GetBuffer();
        }
        private void button_save_acc_cr_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT First_Name FROM PERSONAL_DETAILS WHERE First_Name = '" + txt_FirstName.Text + "'", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count >= 1)
            {
                    MessageBox.Show("The Account Name  " + txt_FirstName.Text + " already exit in the system");
            }
            else if (txt_FirstName.Text == "" || txt_SecondName.Text == "" || date_Birth.Text == "" || txt_PlaceOfBirth.Text == "" || cb_Nationality.Text == "" || cb_MeritalStatus.Text == "" || txt_NameOfSpouse.Text == "" || txt_Proffesional.Text == "" || cb_code.Text == "" || txt_MobileNumber.Text == "" || txt_CountryName.Text == "" || txt_Province.Text == "" || txt_Town.Text == "" || txt_Township.Text == "" || txt_Quarter.Text == "" || txt_Avenue.Text == "" || txt_HouseNumber.Text == "")
                {
                    MessageBox.Show("You cannot end the procees without filling all required fields", "INFORMATION");
                }
                else
                {
                    try
                    {
                        conn.Open();
                        SqlCommand cmd1 = new SqlCommand("INSERT into PERSONAL_DETAILS values (@First_Name,@Second_Name,@Gender,@Date_of_Birth,@Place_of_Birth,@Nationality,@Merital_Status,@Name_of_Spouse,@Proffesion,@Mobile_Number_Code,@Mobile_Number,@IDCard_Number,@Country_Name,@Province,@Town,@Township,@Quarter,@Avenue,@House_Number,@Picture)", conn);

                        cmd1.Parameters.AddWithValue("@First_Name", txt_FirstName.Text);
                        cmd1.Parameters.AddWithValue("@Second_Name", txt_SecondName.Text);

                        String gender = string.Empty;

                        if (rb_Male.Checked)
                        {
                            gender = "Male";
                        }
                        else if (rb_Female.Checked)
                        {
                            gender = "Female";
                        }
                            cmd1.Parameters.AddWithValue("@Gender", gender);
                            cmd1.Parameters.AddWithValue("@Date_of_Birth", date_Birth.Value.Date.ToShortDateString());
                            cmd1.Parameters.AddWithValue("@Place_of_Birth", txt_PlaceOfBirth.Text);
                            cmd1.Parameters.AddWithValue("@Nationality", cb_Nationality.SelectedItem);
                            cmd1.Parameters.AddWithValue("@Merital_Status", cb_MeritalStatus.SelectedItem);
                            cmd1.Parameters.AddWithValue("@Name_of_Spouse", txt_NameOfSpouse.Text);
                            cmd1.Parameters.AddWithValue("@Proffesion", txt_Proffesional.Text);
                            cmd1.Parameters.AddWithValue("@Mobile_Number_Code", cb_code.SelectedItem);
                            cmd1.Parameters.AddWithValue("@Mobile_Number", txt_MobileNumber.Text);
                            cmd1.Parameters.AddWithValue("@IDCard_Number", txt_IdCard.Text);
                            cmd1.Parameters.AddWithValue("@Country_Name", txt_CountryName.Text);
                            cmd1.Parameters.AddWithValue("@Province", txt_Province.Text);
                            cmd1.Parameters.AddWithValue("@Town", txt_Town.Text);
                            cmd1.Parameters.AddWithValue("@Township", txt_Township.Text);
                            cmd1.Parameters.AddWithValue("@Quarter", txt_Quarter.Text);
                            cmd1.Parameters.AddWithValue("@Avenue", txt_Avenue.Text);
                            cmd1.Parameters.AddWithValue("@House_Number", txt_HouseNumber.Text);
                            cmd1.Parameters.Add(new SqlParameter("@Picture",savephoto()));
                        int i;
                        i = cmd1.ExecuteNonQuery();
                        if (i > 0)
                        {
                            MessageBox.Show("Personnal details saved successfully, Pass to the next level!!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        conn.Close();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "jpg|*.jpg|jpeg|*.jpeg|bmp|*.bmp|png|*.png|all files|*.*";
            DialogResult res = open.ShowDialog();

            if (res == DialogResult.OK)
            {
                 imgLocation = open.FileName.ToString();
                 pictureBox1.ImageLocation = imgLocation;
            }
        }

        private void rb_Female_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
