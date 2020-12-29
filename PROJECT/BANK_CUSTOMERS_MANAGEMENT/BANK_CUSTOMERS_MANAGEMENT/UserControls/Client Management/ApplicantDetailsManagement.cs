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
using System.IO;

namespace BANK_CUSTOMERS_MANAGEMENT
{
    public partial class ApplicantDetailsManagement : UserControl
    {
        public ApplicantDetailsManagement()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-454MBGL;Initial Catalog=BANK_CUSTOMERS_Disseration_Project_DB;Integrated Security=True");
        string imgLocation = "";

        private void cb_PersonnalNationality_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_PersonnalCountryName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_edit_deposit_Click(object sender, EventArgs e)
        {
            if (txt_ApplicantIdentifier.Text == "" || txt_ApplicantFirstName.Text == "" || txt_ApplicantSecondName.Text == "" || txt_ApplicantPlaceOfBirth.Text == "" || cb_ApplicantNationality.Text == "" || cb_ApplicantMeritalStatus.Text == "" || txt_ApplicantNameOfSpouse.Text == "" || txt_ApplicantProffesional.Text == "" || cb_Applicantcode.Text == "" || txt_ApplicantMobileNumber.Text == "" || txt_ApplicantIdCard.Text == "" || txt_ApplicantConsideration.Text == "" || txt_ApplicantCountryName.Text == "" || txt_ApplicantProvince.Text == "" || txt_ApplicantTown.Text == "" || txt_ApplicantTownship.Text == "" || txt_ApplicantQuarter.Text == "" || txt_ApplicantAvenue.Text == "" || txt_ApplicantHouseNumber.Text == "")
            {
                MessageBox.Show("You miss some fields");
            }
            else
            {
                try
                {
                    conn.Open();

                    SqlCommand cmd1 = new SqlCommand("UPDATE APPLICANT_DETAILS SET  Identifier = @Identifier, First_Name = @First_Name, Second_Name = @Second_Name,Gender = @Gender,Date_of_Birth = @Date_of_Birth,Place_of_Birth = @Place_of_Birth,Nationality = @Nationality,Merital_Status = @Merital_Status,Name_of_Spouse = @Name_of_Spouse,Proffesion = @Proffesion,Mobile_Number_Code = @Mobile_Number_Code,Mobile_Number = @Mobile_Number,IDCard_Number = @IDCard_Number,Consideration = @Consideration, Country_Name = @Country_Name,Province = @Province,Town = @Town,Township = @Township,Quarter = @Quarter,Avenue = @Avenue,House_Number = @House_Number,Picture = @Picture WHERE ID_Number = @ID_Number", conn);

                    cmd1.Parameters.AddWithValue("@ID_Number", label_IDNumber.Text);
                    cmd1.Parameters.AddWithValue("@Identifier", txt_ApplicantIdentifier.Text);
                    cmd1.Parameters.AddWithValue("@First_Name", txt_ApplicantFirstName.Text);
                    cmd1.Parameters.AddWithValue("@Second_Name", txt_ApplicantSecondName.Text);

                    String gender = string.Empty;

                    if (rb_ApplicantMale.Checked)
                    {
                        gender = "Male";
                    }
                    else if (rb_ApplicantFemale.Checked)
                    {
                        gender = "Female";
                    }
                    cmd1.Parameters.AddWithValue("@Gender", gender);
                    cmd1.Parameters.AddWithValue("@Date_of_Birth", date_ApplicantBirth.Value.Date.ToShortDateString());
                    cmd1.Parameters.AddWithValue("@Place_of_Birth", txt_ApplicantPlaceOfBirth.Text);
                    cmd1.Parameters.AddWithValue("@Nationality", cb_ApplicantNationality.SelectedItem);
                    cmd1.Parameters.AddWithValue("@Merital_Status", cb_ApplicantMeritalStatus.SelectedItem);
                    cmd1.Parameters.AddWithValue("@Name_of_Spouse", txt_ApplicantNameOfSpouse.Text);
                    cmd1.Parameters.AddWithValue("@Proffesion", txt_ApplicantProffesional.Text);
                    cmd1.Parameters.AddWithValue("@Mobile_Number_Code", cb_Applicantcode.SelectedItem);
                    cmd1.Parameters.AddWithValue("@Mobile_Number", txt_ApplicantMobileNumber.Text);
                    cmd1.Parameters.AddWithValue("@IDCard_Number", txt_ApplicantIdCard.Text);
                    cmd1.Parameters.AddWithValue("@Consideration", txt_ApplicantConsideration.Text);
                    cmd1.Parameters.AddWithValue("@Country_Name", txt_ApplicantCountryName.Text);
                    cmd1.Parameters.AddWithValue("@Province", txt_ApplicantProvince.Text);
                    cmd1.Parameters.AddWithValue("@Town", txt_ApplicantTown.Text);
                    cmd1.Parameters.AddWithValue("@Township", txt_ApplicantTownship.Text);
                    cmd1.Parameters.AddWithValue("@Quarter", txt_ApplicantQuarter.Text);
                    cmd1.Parameters.AddWithValue("@Avenue", txt_ApplicantAvenue.Text);
                    cmd1.Parameters.AddWithValue("@House_Number", txt_ApplicantHouseNumber.Text);
                    cmd1.Parameters.Add(new SqlParameter("@Picture", savephoto()));

                    int i;
                    i = cmd1.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Applicants details edited successfully, Pass to the next level!!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    conn.Close();
                    Display();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "ID Number")
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM APPLICANT_DETAILS where  ID_Number LIKE '%" + txt_Search.Text + "%'", conn);
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
                    SqlCommand cmd = new SqlCommand("SELECT * FROM APPLICANT_DETAILS where First_Name LIKE '%" + txt_Search.Text + "%'", conn);
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
        public void Display()
        {
            try
            {
                string qry = "SELECT * FROM APPLICANT_DETAILS";
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

        private void ApplicantDetailsManagement_Load(object sender, EventArgs e)
        {
            Display();
        }

        private void bunifuCustomDataGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dvg = new DataGridView();
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.bunifuCustomDataGrid1.Rows[e.RowIndex];

                label_IDNumber.Text = row.Cells["ID_Number"].Value.ToString();
                txt_ApplicantIdentifier.Text = row.Cells["Identifier"].Value.ToString();
                txt_ApplicantFirstName.Text = row.Cells["First_Name"].Value.ToString();
                txt_ApplicantSecondName.Text = row.Cells["Second_Name"].Value.ToString();


                if (row.Cells["Gender"].Value.Equals("Male"))
                    rb_ApplicantMale.Checked = true;
                else
                    rb_ApplicantMale.Checked = false;

                if (row.Cells["Gender"].Value.Equals("Female"))
                    rb_ApplicantFemale.Checked = true;
                else
                    rb_ApplicantFemale.Checked = false;

                date_ApplicantBirth.Text = row.Cells["Date_of_Birth"].Value.ToString();
                txt_ApplicantPlaceOfBirth.Text = row.Cells["Place_of_Birth"].Value.ToString();
                cb_ApplicantNationality.Text = row.Cells["Nationality"].Value.ToString();
                cb_ApplicantMeritalStatus.Text = row.Cells["Merital_Status"].Value.ToString();
                txt_ApplicantNameOfSpouse.Text = row.Cells["Name_of_Spouse"].Value.ToString();
                txt_ApplicantProffesional.Text = row.Cells["Proffesion"].Value.ToString();
                cb_Applicantcode.Text = row.Cells["Mobile_Number_Code"].Value.ToString();
                txt_ApplicantMobileNumber.Text = row.Cells["Mobile_Number"].Value.ToString();
                txt_ApplicantIdCard.Text = row.Cells["IDCard_Number"].Value.ToString();
                txt_ApplicantConsideration.Text = row.Cells["Consideration"].Value.ToString();
                txt_ApplicantCountryName.Text = row.Cells["Country_Name"].Value.ToString();
                txt_ApplicantProvince.Text = row.Cells["Province"].Value.ToString();
                txt_ApplicantTown.Text = row.Cells["Town"].Value.ToString();
                txt_ApplicantTownship.Text = row.Cells["Township"].Value.ToString();
                txt_ApplicantQuarter.Text = row.Cells["Quarter"].Value.ToString();
                txt_ApplicantAvenue.Text = row.Cells["Avenue"].Value.ToString();
                txt_ApplicantHouseNumber.Text = row.Cells["House_Number"].Value.ToString();
            }
            PictureView();

        }

        public void PictureView()
        {
            try
            {
                conn.Open();
                SqlCommand cmd2 = new SqlCommand("SELECT Picture FROM APPLICANT_DETAILS where First_Name = '" + txt_ApplicantFirstName.Text + "'", conn);
                SqlDataReader da1 = cmd2.ExecuteReader();
                da1.Read();

                if (da1.HasRows)
                {
                    byte[] image = (byte[])da1["Picture"];
                    if (image == null)
                    {
                        pictureBox1.Image = null;
                    }
                    else
                    {
                        MemoryStream stem = new MemoryStream(image);
                        pictureBox1.Image = Image.FromStream(stem);
                    }
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        public byte[] savephoto()
        {
            MemoryStream stem = new MemoryStream();
            pictureBox1.Image.Save(stem, pictureBox1.Image.RawFormat);
            return stem.GetBuffer();
        }

        private void button_delete_deposit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure that you want to delete??", "QUESTION", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd1 = new SqlCommand("DELETE FROM APPLICANT_DETAILS WHERE ID_Number = @ID_Number", conn);

                    cmd1.Parameters.AddWithValue("@ID_Number", label_IDNumber.Text);

                    int i;
                    i = cmd1.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Applicant details deleted successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void cb_ApplicantMeritalStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_ApplicantMeritalStatus.SelectedItem == "Unmarried")
            {
                txt_ApplicantNameOfSpouse.Text = "--";
            }
            else if (cb_ApplicantMeritalStatus.SelectedItem == "Married")
            {
                txt_ApplicantNameOfSpouse.Text = "";
            }
        }
    }
}
