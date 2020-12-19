using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BANK_CUSTOMERS_MANAGEMENT
{
    public partial class CommunicationsSender : Form
    {
        public CommunicationsSender()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (comboBox1.SelectedItem == "Account Creation")
            //{
            //    BankAccountDetails BankAcc = new BankAccountDetails();
            //    textBox3.Text = BankAcc.cb_BankAccountIdentifier.SelectedItem + "" + BankAcc.cb_BankAccountType.SelectedItem + BankAcc.date_DateofCreation.Value.Date.ToShortDateString();
            //}
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
