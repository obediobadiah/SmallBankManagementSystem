using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.IO;


namespace BANK_CUSTOMERS_MANAGEMENT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            _obj = this;
            if (!Form1.instance.pane3.Controls.ContainsKey("Home"))
            {
                Form1.instance.pane3.Controls.Clear();
                Home user = new Home();
                user.Dock = DockStyle.Fill;
                Form1.instance.pane3.Controls.Add(user);
            }
            Form1.instance.pane3.Controls["Home"].BringToFront();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-454MBGL;Initial Catalog=BANK_CUSTOMERS_Disseration_Project_DB;Integrated Security=True");

        Repports user = new Repports();
        ClientManagementMenu ClientManagementMenu = new ClientManagementMenu();
        static Form1 _obj;

        public static Form1 instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new Form1();
                }
                return _obj;
            }

        }


        public Panel pane3
        {
            get
            {
                return panel3;
            }
            set
            {
                panel3 = value;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            _obj = this;
            if (!Form1.instance.pane3.Controls.ContainsKey("Home"))
            {
                Form1.instance.pane3.Controls.Clear();
                Home user = new Home();
                user.Dock = DockStyle.Fill;
                Form1.instance.pane3.Controls.Add(user);
            }
            Form1.instance.pane3.Controls["Home"].BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _obj = this;
            if (!Form1.instance.pane3.Controls.ContainsKey("PersonnalDetails"))
            {
                Form1.instance.pane3.Controls.Clear();
                PersonnalDetails user = new PersonnalDetails();
                user.Dock = DockStyle.Fill;
                Form1.instance.pane3.Controls.Add(user);
            }
            Form1.instance.pane3.Controls["PersonnalDetails"].BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _obj = this;
            if (!Form1.instance.pane3.Controls.ContainsKey("TransactionMenu"))
            {
                Form1.instance.pane3.Controls.Clear();
                TransactionMenu user = new TransactionMenu();
                user.Dock = DockStyle.None;
                Form1.instance.pane3.Controls.Add(user);

            }
            Form1.instance.pane3.Controls["TransactionMenu"].BringToFront();
        }

        private void button_rapports_Click(object sender, EventArgs e)
        {
            _obj = this;

            if (!Form1.instance.pane3.Controls.ContainsKey("Repports"))
            {
                user.Dock = DockStyle.None;
                Form1.instance.pane3.Controls.Add(user);
                Form1.instance.pane3.Controls["Repports"].BringToFront();
                user.Location = new Point(780, 0);
            }

            else
            {
                user.Dock = DockStyle.None;
                Form1.instance.pane3.Controls.Remove(user);
            }
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            panel4.Height = button1.Height;
            panel4.Top = button1.Top;
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            panel4.Height = button2.Height;
            panel4.Top = button2.Top;
        }

        private void button3_MouseClick(object sender, MouseEventArgs e)
        {
            panel4.Height = button3.Height;
            panel4.Top = button3.Top;
        }

        private void button4_MouseClick(object sender, MouseEventArgs e)
        {
            panel4.Height = button4.Height;
            panel4.Top = button4.Top;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            _obj = this;

            if (!Form1.instance.pane3.Controls.ContainsKey("ClientManagementMenu"))
            {
                ClientManagementMenu.Dock = DockStyle.None;
                Form1.instance.pane3.Controls.Add(ClientManagementMenu);
                Form1.instance.pane3.Controls["ClientManagementMenu"].BringToFront();
                ClientManagementMenu.Location = new Point(0, 200);
            }

            else
            {
                ClientManagementMenu.Dock = DockStyle.None;
                Form1.instance.pane3.Controls.Remove(ClientManagementMenu);
            }
        }

        private void button5_MouseClick(object sender, MouseEventArgs e)
        {
            panel4.Height = button5.Height;
            panel4.Top = button5.Top;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            _obj = this;
            if (!Form1.instance.pane3.Controls.ContainsKey("Communications"))
            {
                Form1.instance.pane3.Controls.Clear();
                Communications user = new Communications();
                user.Dock = DockStyle.Fill;
                Form1.instance.pane3.Controls.Add(user);

            }
            Form1.instance.pane3.Controls["Communications"].BringToFront();
        }

        private void button7_MouseClick(object sender, MouseEventArgs e)
        {
            panel4.Height = button7.Height;
            panel4.Top = button7.Top;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to close??", "QUESTION", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                Close();
            }
            else
            {

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _obj = this;
            if (!Form1.instance.pane3.Controls.ContainsKey("AccountManagement"))
            {
                Form1.instance.pane3.Controls.Clear();
                AccountManagement user = new AccountManagement();
                user.Dock = DockStyle.Fill;
                Form1.instance.pane3.Controls.Add(user);
            }
            Form1.instance.pane3.Controls["AccountManagement"].BringToFront();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            AdministratorCreaation AdminRegistration = new AdministratorCreaation();
            AdminRegistration.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            showPicture();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToLongTimeString();
            label4.Text = DateTime.Now.ToLongDateString();
        }

        public void showPicture()
        {
            try
            {
                conn.Open();
                SqlCommand cmd2 = new SqlCommand("SELECT Picture FROM ADMINISTRATOR_DETAILS where ID_Number = '" + label_AdminName.Text + "'", conn);
                SqlDataReader da1 = cmd2.ExecuteReader();
                da1.Read();

                if (da1.HasRows)
                {
                    byte[] image = (byte[])da1["Picture"];
                    if (image == null)
                    {
                        roundedPicture1.Image = null;
                    }
                    else
                    {
                        MemoryStream stem = new MemoryStream(image);
                        roundedPicture1.Image = Image.FromStream(stem);
                    }
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void roundedPicture1_Click(object sender, EventArgs e)
        {
            AdministratorCreaation obj = new AdministratorCreaation();
            obj.Show();
        }
    }
}
