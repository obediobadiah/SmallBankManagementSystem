using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BANK_CUSTOMERS_MANAGEMENT
{
    public partial class RepaymentTransactions : UserControl
    {
        public RepaymentTransactions()
        {
            InitializeComponent();
        }

        private void button_save_deposit_Click(object sender, EventArgs e)
        {
            CommunicationsSender CommSend = new CommunicationsSender();
            CommSend.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label_RepaymentTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void RepaymentTransactions_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
