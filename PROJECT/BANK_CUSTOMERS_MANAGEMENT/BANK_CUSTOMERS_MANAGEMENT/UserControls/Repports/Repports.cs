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
    public partial class Repports : UserControl
    {
        public Repports()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Deposit_Transaction_Report_Viewer DepositTransactionViewer = new Deposit_Transaction_Report_Viewer();
            DepositTransactionViewer.Show();
        }
    }
}
