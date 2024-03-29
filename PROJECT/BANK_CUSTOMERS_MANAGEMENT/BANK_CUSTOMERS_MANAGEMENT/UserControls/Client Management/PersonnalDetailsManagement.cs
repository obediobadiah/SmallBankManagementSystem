﻿using System;
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
    public partial class PersonnalDetailsManagement : UserControl
    {
        public PersonnalDetailsManagement()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-454MBGL;Initial Catalog=BANK_CUSTOMERS_Disseration_Project_DB;Integrated Security=True");
        string imgLocation = "";


        private void button_save_acc_cr_Click(object sender, EventArgs e)
        {

        }

        private void button_edit_deposit_Click(object sender, EventArgs e)
        {
            if (txt_PersonnalFirstName.Text == "" || txt_PersonnalSecondName.Text == "" || date_PersonnalBirth.Text == "" || txt_PersonnalPlaceOfBirth.Text == "" || cb_PersonnalNationality.Text == "" || cb_PersonnalMeritalStatus.Text == "" || txt_PersonnalNameOfSpouse.Text == "" || txt_PersonnalProffesional.Text == "" || cb_Personnalcode.Text == "" || txt_PersonnalMobileNumber.Text == "" || txt_PersonnalCountryName.Text == "" || txt_PersonnalProvince.Text == "" || txt_PersonnalTown.Text == "" || txt_PersonnalTownship.Text == "" || txt_PersonnalQuarter.Text == "" || txt_PersonnalAvenue.Text == "" || txt_PersonalHouseNumber.Text == "")
            {
                MessageBox.Show("You cannot edit customer personal details without filling all required fields", "INFORMATION");
            }
            else
            {
                conn.Open();
                try
                {
                    
                    SqlCommand cmd1 = new SqlCommand("UPDATE PERSONAL_DETAILS SET  First_Name = @First_Name, Second_Name = @Second_Name,Gender = @Gender,Date_of_Birth = @Date_of_Birth,Place_of_Birth = @Place_of_Birth,Nationality = @Nationality,Merital_Status = @Merital_Status,Name_of_Spouse = @Name_of_Spouse,Proffesion = @Proffesion,Mobile_Number_Code = @Mobile_Number_Code,Mobile_Number = @Mobile_Number,IDCard_Number = @IDCard_Number,Country_Name = @Country_Name,Province = @Province,Town = @Town,Township = @Township,Quarter = @Quarter,Avenue = @Avenue,House_Number = @House_Number,Picture = @Picture WHERE ID_Number = @ID_Number", conn);

                    cmd1.Parameters.AddWithValue("@ID_Number", label_IDNumber.Text);
                    cmd1.Parameters.AddWithValue("@First_Name", txt_PersonnalFirstName.Text);
                    cmd1.Parameters.AddWithValue("@Second_Name", txt_PersonnalSecondName.Text);

                    String gender = string.Empty;

                    if (rb_PersonalMale.Checked)
                    {
                        gender = "Male";
                    }
                    else if (rb_PersonalFemale.Checked)
                    {
                        gender = "Female";
                    }
                    cmd1.Parameters.AddWithValue("@Gender", gender);
                    cmd1.Parameters.AddWithValue("@Date_of_Birth", date_PersonnalBirth.Value.Date.ToShortDateString());
                    cmd1.Parameters.AddWithValue("@Place_of_Birth",txt_PersonnalPlaceOfBirth.Text);
                    cmd1.Parameters.AddWithValue("@Nationality", cb_PersonnalNationality.SelectedItem);
                    cmd1.Parameters.AddWithValue("@Merital_Status",cb_PersonnalMeritalStatus.SelectedItem);
                    cmd1.Parameters.AddWithValue("@Name_of_Spouse",txt_PersonnalNameOfSpouse.Text);
                    cmd1.Parameters.AddWithValue("@Proffesion", txt_PersonnalProffesional.Text);
                    cmd1.Parameters.AddWithValue("@Mobile_Number_Code", cb_Personnalcode.SelectedItem);
                    cmd1.Parameters.AddWithValue("@Mobile_Number", txt_PersonnalMobileNumber.Text);
                    cmd1.Parameters.AddWithValue("@IDCard_Number", txt_PersonnalIdCard.Text);
                    cmd1.Parameters.AddWithValue("@Country_Name", txt_PersonnalCountryName.Text);
                    cmd1.Parameters.AddWithValue("@Province", txt_PersonnalProvince.Text);
                    cmd1.Parameters.AddWithValue("@Town", txt_PersonnalTown.Text);
                    cmd1.Parameters.AddWithValue("@Township", txt_PersonnalTownship.Text);
                    cmd1.Parameters.AddWithValue("@Quarter", txt_PersonnalQuarter.Text);
                    cmd1.Parameters.AddWithValue("@Avenue", txt_PersonnalAvenue.Text);
                    cmd1.Parameters.AddWithValue("@House_Number", txt_PersonalHouseNumber.Text);
                    cmd1.Parameters.Add(new SqlParameter("@Picture", savephoto()));


                    int i;
                    i = cmd1.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Customer personnal details edited successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                   
                   Display();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                conn.Close();
            }
        }
        public byte[] savephoto()
        {
            MemoryStream stem = new MemoryStream();
            pictureBox1.Image.Save(stem, pictureBox1.Image.RawFormat);
            return stem.GetBuffer();
        }
        public void Display()
        {
            try
            {
                string qry = "SELECT * FROM PERSONAL_DETAILS";
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
        private void PersonnalDetailsManagement_Load(object sender, EventArgs e)
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
                txt_PersonnalFirstName.Text = row.Cells["First_Name"].Value.ToString();
                txt_PersonnalSecondName.Text = row.Cells["Second_Name"].Value.ToString();


                if (row.Cells["Gender"].Value.Equals("Male"))
                    rb_PersonalMale.Checked = true;
                else
                    rb_PersonalMale.Checked = false;

                if (row.Cells["Gender"].Value.Equals("Female"))
                    rb_PersonalFemale.Checked = true;
                else
                    rb_PersonalFemale.Checked = false;

                date_PersonnalBirth.Text = row.Cells["Date_of_Birth"].Value.ToString();
                txt_PersonnalPlaceOfBirth.Text = row.Cells["Place_of_Birth"].Value.ToString();
                cb_PersonnalNationality.Text = row.Cells["Nationality"].Value.ToString();
                cb_PersonnalMeritalStatus.Text = row.Cells["Merital_Status"].Value.ToString();
                txt_PersonnalNameOfSpouse.Text = row.Cells["Name_of_Spouse"].Value.ToString();
                txt_PersonnalProffesional.Text = row.Cells["Proffesion"].Value.ToString();
                cb_Personnalcode.Text = row.Cells["Mobile_Number_Code"].Value.ToString();
                txt_PersonnalMobileNumber.Text = row.Cells["Mobile_Number"].Value.ToString();
                txt_PersonnalIdCard.Text = row.Cells["IDCard_Number"].Value.ToString();
                txt_PersonnalCountryName.Text = row.Cells["Country_Name"].Value.ToString();
                txt_PersonnalProvince.Text = row.Cells["Province"].Value.ToString();
                txt_PersonnalTown.Text = row.Cells["Town"].Value.ToString();
                txt_PersonnalTownship.Text = row.Cells["Township"].Value.ToString();
                txt_PersonnalQuarter.Text = row.Cells["Quarter"].Value.ToString();
                txt_PersonnalAvenue.Text = row.Cells["Avenue"].Value.ToString();
                txt_PersonalHouseNumber.Text = row.Cells["House_Number"].Value.ToString();
            }
            PictureView();

        }

        public void PictureView()
        {
            try
            {
                conn.Open();
                SqlCommand cmd2 = new SqlCommand("SELECT Picture FROM PERSONAL_DETAILS where First_Name = '" + txt_PersonnalFirstName.Text + "'", conn);
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

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "ID Number")
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM PERSONAL_DETAILS where  ID_Number LIKE '%" + txt_Search.Text + "%'", conn);
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
                    SqlCommand cmd = new SqlCommand("SELECT * FROM PERSONAL_DETAILS where First_Name LIKE '%" + txt_Search.Text + "%'", conn);
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
                    SqlCommand cmd1 = new SqlCommand("DELETE FROM PERSONAL_DETAILS WHERE ID_Number = @ID_Number", conn);

                    cmd1.Parameters.AddWithValue("@ID_Number", label_IDNumber.Text);

                    int i;
                    i = cmd1.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Customer personal details deleted successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void cb_PersonnalMeritalStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_PersonnalMeritalStatus.SelectedItem == "Unmarried")
            {
                txt_PersonnalNameOfSpouse.Text = "--";
            }
            else if (cb_PersonnalMeritalStatus.SelectedItem == "Married")
            {
                txt_PersonnalNameOfSpouse.Text = "";
            }
        }

        private void txt_PersonnalFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void txt_PersonnalSecondName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void txt_PersonnalPlaceOfBirth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void cb_PersonnalNationality_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void cb_PersonnalMeritalStatus_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void txt_PersonnalNameOfSpouse_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void txt_PersonnalCountryName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void txt_PersonnalProvince_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void txt_PersonnalTown_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void txt_PersonnalTownship_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void txt_PersonnalMobileNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt_PersonalHouseNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
