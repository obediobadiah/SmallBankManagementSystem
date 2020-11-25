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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {  
            Form1 obj2 = new Form1();
            obj2.ShowDialog();
            this.Close();
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
            AdministratorCreaation obj2 = new AdministratorCreaation();
            obj2.ShowDialog();
            this.Hide();
        }
    }
}
