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
    public partial class ClientManagementMenu : UserControl
    {
        public ClientManagementMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Form1.instance.pane3.Controls.ContainsKey("PersonnalDetailsManagement"))
            {
                Form1.instance.pane3.Controls.Clear();
                PersonnalDetailsManagement user = new PersonnalDetailsManagement();
                user.Dock = DockStyle.Fill;
                Form1.instance.pane3.Controls.Add(user);

            }
            Form1.instance.pane3.Controls["PersonnalDetailsManagement"].BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!Form1.instance.pane3.Controls.ContainsKey("BankAccountDetailsManagement"))
            {
                Form1.instance.pane3.Controls.Clear();
                BankAccountDetailsManagement user = new BankAccountDetailsManagement();
                user.Dock = DockStyle.Fill;
                Form1.instance.pane3.Controls.Add(user);

            }
            Form1.instance.pane3.Controls["BankAccountDetailsManagement"].BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!Form1.instance.pane3.Controls.ContainsKey("ApplicantDetailsManagement"))
            {
                Form1.instance.pane3.Controls.Clear();
                ApplicantDetailsManagement user = new ApplicantDetailsManagement();
                user.Dock = DockStyle.Fill;
                Form1.instance.pane3.Controls.Add(user);

            }
            Form1.instance.pane3.Controls["ApplicantDetailsManagement"].BringToFront();
        }
    }
}
