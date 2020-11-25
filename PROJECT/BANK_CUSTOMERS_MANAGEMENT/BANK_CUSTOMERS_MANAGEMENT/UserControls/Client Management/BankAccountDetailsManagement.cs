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
    public partial class BankAccountDetailsManagement : UserControl
    {
        public BankAccountDetailsManagement()
        {
            InitializeComponent();
            label5.Visible = false;
            Date_BankAccountLimitDate.Visible = false;
        }

        private void cb_BankAccountType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_BankAccountType.SelectedItem == "Savings Account")
            {
                label5.Visible = true;
                Date_BankAccountLimitDate.Visible = true;
            }
            else
            {
                label5.Visible = false;
                Date_BankAccountLimitDate.Visible = false;
            }
        }
    }
}
