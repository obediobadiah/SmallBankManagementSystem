namespace BANK_CUSTOMERS_MANAGEMENT
{
    partial class BankAccountDetailsManagement
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BankAccountDetailsManagement));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button_edit_deposit = new System.Windows.Forms.Button();
            this.button_delete_deposit = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txt_BankIdentifier = new System.Windows.Forms.TextBox();
            this.label_IDNumber = new System.Windows.Forms.Label();
            this.date_DateofCreation = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.Date_BankAccountLimitDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.cb_BankAccountType = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1152, 48);
            this.panel1.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nexa Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(358, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(467, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "ACCOUNT DETAILS MANAGEMENT";
            // 
            // bunifuCustomDataGrid1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.SteelBlue;
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.White;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(26, 187);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(543, 525);
            this.bunifuCustomDataGrid1.TabIndex = 19;
            this.bunifuCustomDataGrid1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuCustomDataGrid1_CellClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button_edit_deposit);
            this.groupBox4.Controls.Add(this.button_delete_deposit);
            this.groupBox4.Location = new System.Drawing.Point(592, 661);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(115, 55);
            this.groupBox4.TabIndex = 36;
            this.groupBox4.TabStop = false;
            // 
            // button_edit_deposit
            // 
            this.button_edit_deposit.BackColor = System.Drawing.Color.SeaGreen;
            this.button_edit_deposit.FlatAppearance.BorderSize = 0;
            this.button_edit_deposit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_edit_deposit.Font = new System.Drawing.Font("Nexa Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_edit_deposit.ForeColor = System.Drawing.Color.White;
            this.button_edit_deposit.Image = ((System.Drawing.Image)(resources.GetObject("button_edit_deposit.Image")));
            this.button_edit_deposit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_edit_deposit.Location = new System.Drawing.Point(17, 11);
            this.button_edit_deposit.Name = "button_edit_deposit";
            this.button_edit_deposit.Size = new System.Drawing.Size(35, 40);
            this.button_edit_deposit.TabIndex = 24;
            this.button_edit_deposit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_edit_deposit.UseVisualStyleBackColor = false;
            this.button_edit_deposit.Click += new System.EventHandler(this.button_edit_deposit_Click);
            // 
            // button_delete_deposit
            // 
            this.button_delete_deposit.BackColor = System.Drawing.Color.Maroon;
            this.button_delete_deposit.FlatAppearance.BorderSize = 0;
            this.button_delete_deposit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_delete_deposit.Font = new System.Drawing.Font("Nexa Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_delete_deposit.ForeColor = System.Drawing.Color.White;
            this.button_delete_deposit.Image = ((System.Drawing.Image)(resources.GetObject("button_delete_deposit.Image")));
            this.button_delete_deposit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_delete_deposit.Location = new System.Drawing.Point(58, 11);
            this.button_delete_deposit.Name = "button_delete_deposit";
            this.button_delete_deposit.Size = new System.Drawing.Size(37, 40);
            this.button_delete_deposit.TabIndex = 26;
            this.button_delete_deposit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_delete_deposit.UseVisualStyleBackColor = false;
            this.button_delete_deposit.Click += new System.EventHandler(this.button_delete_deposit_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txt_BankIdentifier);
            this.groupBox5.Controls.Add(this.label_IDNumber);
            this.groupBox5.Controls.Add(this.date_DateofCreation);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Controls.Add(this.label20);
            this.groupBox5.Controls.Add(this.label23);
            this.groupBox5.Controls.Add(this.cb_BankAccountType);
            this.groupBox5.Font = new System.Drawing.Font("Nexa Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.SteelBlue;
            this.groupBox5.Location = new System.Drawing.Point(592, 69);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(537, 590);
            this.groupBox5.TabIndex = 38;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Account Details";
            // 
            // txt_BankIdentifier
            // 
            this.txt_BankIdentifier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_BankIdentifier.Font = new System.Drawing.Font("Nexa Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_BankIdentifier.Location = new System.Drawing.Point(93, 249);
            this.txt_BankIdentifier.Name = "txt_BankIdentifier";
            this.txt_BankIdentifier.Size = new System.Drawing.Size(350, 26);
            this.txt_BankIdentifier.TabIndex = 45;
            this.txt_BankIdentifier.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_BankIdentifier_KeyPress);
            // 
            // label_IDNumber
            // 
            this.label_IDNumber.AutoSize = true;
            this.label_IDNumber.Font = new System.Drawing.Font("Nexa Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_IDNumber.Location = new System.Drawing.Point(96, 36);
            this.label_IDNumber.Name = "label_IDNumber";
            this.label_IDNumber.Size = new System.Drawing.Size(0, 36);
            this.label_IDNumber.TabIndex = 44;
            // 
            // date_DateofCreation
            // 
            this.date_DateofCreation.Font = new System.Drawing.Font("Nexa Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_DateofCreation.Location = new System.Drawing.Point(93, 130);
            this.date_DateofCreation.Name = "date_DateofCreation";
            this.date_DateofCreation.Size = new System.Drawing.Size(350, 26);
            this.date_DateofCreation.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nexa Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(182, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 20);
            this.label2.TabIndex = 42;
            this.label2.Text = "DATE OF CREATION";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.Date_BankAccountLimitDate);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Font = new System.Drawing.Font("Nexa Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.ForeColor = System.Drawing.Color.SteelBlue;
            this.groupBox6.Location = new System.Drawing.Point(91, 445);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(352, 116);
            this.groupBox6.TabIndex = 41;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Savings Account Infos";
            // 
            // Date_BankAccountLimitDate
            // 
            this.Date_BankAccountLimitDate.Font = new System.Drawing.Font("Nexa Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_BankAccountLimitDate.Location = new System.Drawing.Point(25, 75);
            this.Date_BankAccountLimitDate.Name = "Date_BankAccountLimitDate";
            this.Date_BankAccountLimitDate.Size = new System.Drawing.Size(311, 26);
            this.Date_BankAccountLimitDate.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nexa Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SteelBlue;
            this.label5.Location = new System.Drawing.Point(115, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Limit Date ( Delay )";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Nexa Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.SteelBlue;
            this.label20.Location = new System.Drawing.Point(182, 316);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(179, 20);
            this.label20.TabIndex = 36;
            this.label20.Text = "BANK ACCOUNT TYPES";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Nexa Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.SteelBlue;
            this.label23.Location = new System.Drawing.Point(220, 207);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(89, 20);
            this.label23.TabIndex = 37;
            this.label23.Text = "IDENTIFIER";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cb_BankAccountType
            // 
            this.cb_BankAccountType.Font = new System.Drawing.Font("Nexa Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_BankAccountType.FormattingEnabled = true;
            this.cb_BankAccountType.Items.AddRange(new object[] {
            "Checking Account",
            "Savings Account"});
            this.cb_BankAccountType.Location = new System.Drawing.Point(91, 368);
            this.cb_BankAccountType.Name = "cb_BankAccountType";
            this.cb_BankAccountType.Size = new System.Drawing.Size(352, 28);
            this.cb_BankAccountType.TabIndex = 39;
            this.cb_BankAccountType.Text = "--Select--";
            this.cb_BankAccountType.SelectedIndexChanged += new System.EventHandler(this.cb_BankAccountType_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.panel4);
            this.groupBox3.Controls.Add(this.txt_Search);
            this.groupBox3.Font = new System.Drawing.Font("Nexa Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.SteelBlue;
            this.groupBox3.Location = new System.Drawing.Point(26, 72);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(543, 109);
            this.groupBox3.TabIndex = 57;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Nexa Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ID Number",
            "Account Name"});
            this.comboBox1.Location = new System.Drawing.Point(21, 23);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(471, 28);
            this.comboBox1.TabIndex = 118;
            this.comboBox1.Text = "By";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DodgerBlue;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Nexa Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.Location = new System.Drawing.Point(498, 61);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(35, 38);
            this.button3.TabIndex = 38;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SteelBlue;
            this.panel4.Location = new System.Drawing.Point(21, 91);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(471, 2);
            this.panel4.TabIndex = 6;
            // 
            // txt_Search
            // 
            this.txt_Search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Search.Font = new System.Drawing.Font("Nexa Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Search.Location = new System.Drawing.Point(21, 70);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(471, 19);
            this.txt_Search.TabIndex = 5;
            // 
            // BankAccountDetailsManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.bunifuCustomDataGrid1);
            this.Controls.Add(this.panel1);
            this.Name = "BankAccountDetailsManagement";
            this.Size = new System.Drawing.Size(1152, 723);
            this.Load += new System.EventHandler(this.BankAccountDetailsManagement_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button_edit_deposit;
        private System.Windows.Forms.Button button_delete_deposit;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DateTimePicker date_DateofCreation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DateTimePicker Date_BankAccountLimitDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox cb_BankAccountType;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Label label_IDNumber;
        private System.Windows.Forms.TextBox txt_BankIdentifier;
    }
}
