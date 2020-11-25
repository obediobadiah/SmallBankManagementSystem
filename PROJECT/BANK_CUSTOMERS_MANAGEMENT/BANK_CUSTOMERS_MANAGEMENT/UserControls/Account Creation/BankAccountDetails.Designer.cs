namespace BANK_CUSTOMERS_MANAGEMENT
{
    partial class BankAccountDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BankAccountDetails));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.cb_BankAccountType = new System.Windows.Forms.ComboBox();
            this.button_save_acc_cr = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Date_BankAccountLimitDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.date_DateofCreation = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_BankAcccountIdentifier = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(538, 41);
            this.panel1.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(109, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "BANK ACCOUNT DETAILS";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(188, 292);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(196, 18);
            this.label20.TabIndex = 23;
            this.label20.Text = "BANK ACCOUNT TYPES";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(226, 198);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(98, 18);
            this.label23.TabIndex = 25;
            this.label23.Text = "IDENTIFIER";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cb_BankAccountType
            // 
            this.cb_BankAccountType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_BankAccountType.FormattingEnabled = true;
            this.cb_BankAccountType.Items.AddRange(new object[] {
            "Checking Account",
            "Savings Account"});
            this.cb_BankAccountType.Location = new System.Drawing.Point(97, 344);
            this.cb_BankAccountType.Name = "cb_BankAccountType";
            this.cb_BankAccountType.Size = new System.Drawing.Size(352, 26);
            this.cb_BankAccountType.TabIndex = 30;
            this.cb_BankAccountType.Text = "--Select--";
            this.cb_BankAccountType.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button_save_acc_cr
            // 
            this.button_save_acc_cr.BackColor = System.Drawing.Color.DodgerBlue;
            this.button_save_acc_cr.FlatAppearance.BorderSize = 0;
            this.button_save_acc_cr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_save_acc_cr.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_save_acc_cr.ForeColor = System.Drawing.Color.White;
            this.button_save_acc_cr.Image = ((System.Drawing.Image)(resources.GetObject("button_save_acc_cr.Image")));
            this.button_save_acc_cr.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_save_acc_cr.Location = new System.Drawing.Point(211, 592);
            this.button_save_acc_cr.Name = "button_save_acc_cr";
            this.button_save_acc_cr.Size = new System.Drawing.Size(133, 49);
            this.button_save_acc_cr.TabIndex = 28;
            this.button_save_acc_cr.Text = "FINISH";
            this.button_save_acc_cr.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_save_acc_cr.UseVisualStyleBackColor = false;
            this.button_save_acc_cr.Click += new System.EventHandler(this.button_save_acc_cr_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Date_BankAccountLimitDate);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(97, 412);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 116);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Savings Account Infos";
            // 
            // Date_BankAccountLimitDate
            // 
            this.Date_BankAccountLimitDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_BankAccountLimitDate.Location = new System.Drawing.Point(25, 75);
            this.Date_BankAccountLimitDate.Name = "Date_BankAccountLimitDate";
            this.Date_BankAccountLimitDate.Size = new System.Drawing.Size(311, 24);
            this.Date_BankAccountLimitDate.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(115, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Limit Date ( Delay )";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // date_DateofCreation
            // 
            this.date_DateofCreation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_DateofCreation.Location = new System.Drawing.Point(99, 127);
            this.date_DateofCreation.Name = "date_DateofCreation";
            this.date_DateofCreation.Size = new System.Drawing.Size(350, 24);
            this.date_DateofCreation.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(188, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 18);
            this.label2.TabIndex = 33;
            this.label2.Text = "DATE OF CREATION";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_BankAcccountIdentifier
            // 
            this.txt_BankAcccountIdentifier.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_BankAcccountIdentifier.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_BankAcccountIdentifier.Location = new System.Drawing.Point(97, 236);
            this.txt_BankAcccountIdentifier.Name = "txt_BankAcccountIdentifier";
            this.txt_BankAcccountIdentifier.Size = new System.Drawing.Size(352, 22);
            this.txt_BankAcccountIdentifier.TabIndex = 37;
            // 
            // BankAccountDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Controls.Add(this.txt_BankAcccountIdentifier);
            this.Controls.Add(this.date_DateofCreation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.cb_BankAccountType);
            this.Controls.Add(this.button_save_acc_cr);
            this.Name = "BankAccountDetails";
            this.Size = new System.Drawing.Size(538, 711);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button button_save_acc_cr;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker Date_BankAccountLimitDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox cb_BankAccountType;
        public System.Windows.Forms.DateTimePicker date_DateofCreation;
        private System.Windows.Forms.TextBox txt_BankAcccountIdentifier;
    }
}
