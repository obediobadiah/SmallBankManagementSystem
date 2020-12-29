using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace BANK_CUSTOMERS_MANAGEMENT
{
    public partial class CommunicationsSender : Form
    {
        public CommunicationsSender()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-454MBGL;Initial Catalog=BANK_CUSTOMERS_Disseration_Project_DB;Integrated Security=True");
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(txt_PhoneNumber.Text == "" || txt_Message.Text =="")
            {
                MessageBox.Show("Make sure all required informations are filled");
            }
            else
            {
                MessageSender();
                Save();
            }

        }

        public void MessageSender()
        {
            try
            {
                var accountSid = "AC740f653389f8611072ddeb1c5f2eda4a";
                var authToken = "611fffbbfe5b1795c1d9855f4b48b587";

                TwilioClient.Init(accountSid, authToken);

                var messageOptions = new CreateMessageOptions(
                    new PhoneNumber(txt_PhoneNumber.Text));
                messageOptions.From = new PhoneNumber("+12565619943");
                messageOptions.Body = txt_Message.Text;

                System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                var message = MessageResource.Create(messageOptions);
                MessageBox.Show(message.Body);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Save()
        {
            try
            { 
                conn.Open();
                SqlCommand cmd1 = new SqlCommand("INSERT into MESSAGE_COMMUNICATION (Account_Number,Mobile_Number,Message) values (@Account_Number,@Mobile_Number,@Message)", conn);


                cmd1.Parameters.AddWithValue("@Account_Number", label_AccountNumber.Text);
                cmd1.Parameters.AddWithValue("@Mobile_Number", txt_PhoneNumber.Text);
                cmd1.Parameters.AddWithValue("@Message", txt_Message.Text);

                int i;
                i = cmd1.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Data communications saved successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                conn.Close();

            }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
        }
    }
}
