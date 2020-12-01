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
using System.Deployment.Application;

namespace BANK_CUSTOMERS_MANAGEMENT
{
    public partial class ApplicantDetails : UserControl
    {
        public ApplicantDetails()
        {
            InitializeComponent();
        }
            SqlConnection conn = new SqlConnection(@"Data Source=ULK_GISENYI;Initial Catalog=BANK_CUSTOMERS_Disseration_Project_DB;Integrated Security=True");
            string imgLocation = "";
            SqlCommand cmd;

        private void button_next_acc_cr_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to want to continue??", "QUESTION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (result == DialogResult.Yes)
            {
                if (txt_ApplicantIdentifier.Text == "" || txt_ApplicantFirstName.Text == "" || txt_ApplicantSecondName.Text == "" || txt_ApplicantPlaceOfBirth.Text == "" || cb_ApplicantNationality.Text == "" || cb_ApplicantMeritalStatus.Text == "" || txt_ApplicantNameOfSpouse.Text == "" || txt_ApplicantProffesional.Text == "" || cb_Applicantcode.Text == "" || txt_ApplicantMobileNumber.Text == "" || txt_ApplicantIdCard.Text == "" || txt_ApplicantConsideration.Text == "" || txt_ApplicantCountryName.Text == "" || txt_ApplicantProvince.Text == "" || txt_ApplicantTown.Text == "" || txt_ApplicantTownship.Text == "" || txt_ApplicantQuarter.Text == "" || txt_ApplicantAvenue.Text == "" || txt_ApplicantHouseNumber.Text == "")
                {
                    MessageBox.Show("You are not allowed to go to next step without saving Applicant details");
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

        private void cb_ApplicantMeritalStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_ApplicantMeritalStatus.SelectedItem == "Unmarried")
            {
                txt_ApplicantNameOfSpouse.Text = "--";
            }
        }
        public byte[] savephoto()
        {
            MemoryStream stem = new MemoryStream();
            pictureBox1.Image.Save(stem, pictureBox1.Image.RawFormat);
            return stem.GetBuffer();
        }
        private void button_save_applicant_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT Identifier FROM APPLICANT_DETAILS WHERE Identifier = '" + txt_ApplicantIdentifier.Text + "'",conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count >= 1)
            {
                DialogResult result = MessageBox.Show("The Account Name  "+ txt_ApplicantIdentifier.Text +" already has an applicant, Do you want to Add another applicant for this account?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (txt_ApplicantIdentifier.Text == "" || txt_ApplicantFirstName.Text == "" || txt_ApplicantSecondName.Text == "" || txt_ApplicantPlaceOfBirth.Text == "" || cb_ApplicantNationality.Text == "" || cb_ApplicantMeritalStatus.Text == "" || txt_ApplicantNameOfSpouse.Text == "" || txt_ApplicantProffesional.Text == "" || cb_Applicantcode.Text == "" || txt_ApplicantMobileNumber.Text == "" || txt_ApplicantIdCard.Text == "" || txt_ApplicantConsideration.Text == "" || txt_ApplicantCountryName.Text == "" || txt_ApplicantProvince.Text == "" || txt_ApplicantTown.Text == "" || txt_ApplicantTownship.Text == "" || txt_ApplicantQuarter.Text == "" || txt_ApplicantAvenue.Text == "" || txt_ApplicantHouseNumber.Text == "")
                    {
                        MessageBox.Show("You miss some fields");
                    }
                    else
                    {
                        Saved();
                    }
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
                if (txt_ApplicantIdentifier.Text == "" || txt_ApplicantFirstName.Text == "" || txt_ApplicantSecondName.Text == "" || txt_ApplicantPlaceOfBirth.Text == "" || cb_ApplicantNationality.Text == "" || cb_ApplicantMeritalStatus.Text == "" || txt_ApplicantNameOfSpouse.Text == "" || txt_ApplicantProffesional.Text == "" || cb_Applicantcode.Text == "" || txt_ApplicantMobileNumber.Text == "" || txt_ApplicantIdCard.Text == "" || txt_ApplicantConsideration.Text == "" || txt_ApplicantCountryName.Text == "" || txt_ApplicantProvince.Text == "" || txt_ApplicantTown.Text == "" || txt_ApplicantTownship.Text == "" || txt_ApplicantQuarter.Text == "" || txt_ApplicantAvenue.Text == "" || txt_ApplicantHouseNumber.Text == "")
                {
                    MessageBox.Show("You miss some fields");
                }
                else
                {
                    Saved();
                }
            }
        }

        public void Saved()
        {
            try
            {
                conn.Open();
                SqlCommand cmd1 = new SqlCommand("INSERT into APPLICANT_DETAILS values (@Identifier,@First_Name,@Second_Name,@Gender,@Date_of_Birth,@Place_of_Birth,@Nationality,@Merital_Status,@Name_of_Spouse,@Proffesion,@Mobile_Number_Code,@Mobile_Number,@IDCard_Number,@Consideration,@Country_Name,@Province,@Town,@Township,@Quarter,@Avenue,@House_Number,@Picture)", conn);

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
                    MessageBox.Show("Applicants details saved successfully, Pass to the next level!!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void cb_Identifier_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        // public void AlreadyExit()
        //{
        //    SqlCommand cmd = new SqlCommand("SELECT First_Name FROM PERSONAL_DETAILS WHERE Identifier = '" + txt_ApplicantIdentifier.Text + "'");
        //    SqlDataAdapter da = new SqlDataAdapter(cmd);
        //    DataTable dt = new DataTable();
        //    DataSet ds = new DataSet();

        //    da.Fill(ds);
        //    int i = ds.Tables[0].Rows.Count;
        //    if (i > 0)
        //    {
        //        MessageBox.Show("The Account Name already have an applicant", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        //    }
        //}
        private void ApplicantDetails_Load(object sender, EventArgs e)
        {

        }

        private void clear()
        {
            txt_ApplicantIdentifier.Text = "";
            txt_ApplicantFirstName.Text = "";
            txt_ApplicantSecondName.Text = "";
            date_ApplicantBirth.CustomFormat = "";
            txt_ApplicantPlaceOfBirth.Text = "";
            cb_ApplicantNationality.Text = "";
            cb_ApplicantMeritalStatus.Text = "";
            txt_ApplicantNameOfSpouse.Text = "";
            txt_ApplicantProffesional.Text = "";
            cb_Applicantcode.Text = "";
            txt_ApplicantMobileNumber.Text = "";
            txt_ApplicantIdCard.Text = "";
            txt_ApplicantConsideration.Text = "";
            txt_ApplicantCountryName.Text = "";
            txt_ApplicantProvince.Text = "";
            txt_ApplicantTown.Text = "";
            txt_ApplicantTownship.Text = "";
            txt_ApplicantQuarter.Text = "";
            txt_ApplicantAvenue.Text = "";
            txt_ApplicantHouseNumber.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
