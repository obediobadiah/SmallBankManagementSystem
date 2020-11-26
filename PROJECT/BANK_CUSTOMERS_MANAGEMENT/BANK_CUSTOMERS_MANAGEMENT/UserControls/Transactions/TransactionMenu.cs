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
    public partial class TransactionMenu : UserControl
    {
        public TransactionMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Form1.instance.pane3.Controls.ContainsKey("DepositTransaction"))
            {
                Form1.instance.pane3.Controls.Clear();
                DepositTransaction user = new DepositTransaction();
                user.Dock = DockStyle.Fill;
                Form1.instance.pane3.Controls.Add(user);
            }
            Form1.instance.pane3.Controls["DepositTransaction"].BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!Form1.instance.pane3.Controls.ContainsKey("WithdrawalTransaction"))
            {
                Form1.instance.pane3.Controls.Clear();
                WithdrawalTransaction user = new WithdrawalTransaction();
                user.Dock = DockStyle.Fill;
                Form1.instance.pane3.Controls.Add(user);
            }
            Form1.instance.pane3.Controls["WithdrawalTransaction"].BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!Form1.instance.pane3.Controls.ContainsKey("LoanTransaction"))
            {
                Form1.instance.pane3.Controls.Clear();
                LoanTransaction user = new LoanTransaction();
                user.Dock = DockStyle.None;
                Form1.instance.pane3.Controls.Add(user);
            }
            Form1.instance.pane3.Controls["LoanTransaction"].BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!Form1.instance.pane3.Controls.ContainsKey("RepaymentTransaction"))
            {
                Form1.instance.pane3.Controls.Clear();
                RepaymentTransaction user = new RepaymentTransaction();
                user.Dock = DockStyle.None;
                Form1.instance.pane3.Controls.Add(user);
            }
            Form1.instance.pane3.Controls["RepaymentTransaction"].BringToFront();
        }
    }
}
