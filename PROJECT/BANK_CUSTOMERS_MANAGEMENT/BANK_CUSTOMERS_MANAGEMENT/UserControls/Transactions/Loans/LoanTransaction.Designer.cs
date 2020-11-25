namespace BANK_CUSTOMERS_MANAGEMENT
{
    partial class LoanTransaction
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoanTransaction));
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Loan_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Borrower = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Account_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount_In_Words = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Currency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Purpose = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Scheduler = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Limit_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_edit_deposit = new System.Windows.Forms.Button();
            this.button_delete_deposit = new System.Windows.Forms.Button();
            this.button_save_deposit = new System.Windows.Forms.Button();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.button_deposit_clear = new System.Windows.Forms.Button();
            this.button_print_deposit = new System.Windows.Forms.Button();
            this.cb_LoanScheduler = new System.Windows.Forms.ComboBox();
            this.cb_LoanCurrency = new System.Windows.Forms.ComboBox();
            this.date_LoanLimitDate = new System.Windows.Forms.DateTimePicker();
            this.Date_Loan = new System.Windows.Forms.DateTimePicker();
            this.panel13 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label_LoanTime = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_LoanAmountInWords = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_LoanPurpose = new System.Windows.Forms.TextBox();
            this.txt_LoanBorrower = new System.Windows.Forms.TextBox();
            this.txt_LoanAccountNumber = new System.Windows.Forms.TextBox();
            this.txt_LoanAmount = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.bunifuCards1.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.bunifuCustomDataGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Loan_Date,
            this.Borrower,
            this.Account_Number,
            this.Amount,
            this.Amount_In_Words,
            this.Currency,
            this.Purpose,
            this.Scheduler,
            this.Limit_Date,
            this.Time});
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.SteelBlue;
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.White;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(581, 68);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(558, 574);
            this.bunifuCustomDataGrid1.TabIndex = 22;
            // 
            // Loan_Date
            // 
            this.Loan_Date.HeaderText = "Loan Date";
            this.Loan_Date.Name = "Loan_Date";
            // 
            // Borrower
            // 
            this.Borrower.HeaderText = "Borrower";
            this.Borrower.Name = "Borrower";
            // 
            // Account_Number
            // 
            this.Account_Number.HeaderText = "Account Number";
            this.Account_Number.Name = "Account_Number";
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            // 
            // Amount_In_Words
            // 
            this.Amount_In_Words.HeaderText = "Amount In Words";
            this.Amount_In_Words.Name = "Amount_In_Words";
            // 
            // Currency
            // 
            this.Currency.HeaderText = "Currency";
            this.Currency.Name = "Currency";
            // 
            // Purpose
            // 
            this.Purpose.HeaderText = "Purpose";
            this.Purpose.Name = "Purpose";
            // 
            // Scheduler
            // 
            this.Scheduler.HeaderText = "Scheduler";
            this.Scheduler.Name = "Scheduler";
            // 
            // Limit_Date
            // 
            this.Limit_Date.HeaderText = "Limit Date";
            this.Limit_Date.Name = "Limit_Date";
            // 
            // Time
            // 
            this.Time.HeaderText = "Time";
            this.Time.Name = "Time";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_edit_deposit);
            this.groupBox1.Controls.Add(this.button_delete_deposit);
            this.groupBox1.Controls.Add(this.button_save_deposit);
            this.groupBox1.Location = new System.Drawing.Point(266, 646);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(653, 71);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // button_edit_deposit
            // 
            this.button_edit_deposit.BackColor = System.Drawing.Color.SeaGreen;
            this.button_edit_deposit.FlatAppearance.BorderSize = 0;
            this.button_edit_deposit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_edit_deposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_edit_deposit.ForeColor = System.Drawing.Color.White;
            this.button_edit_deposit.Image = ((System.Drawing.Image)(resources.GetObject("button_edit_deposit.Image")));
            this.button_edit_deposit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_edit_deposit.Location = new System.Drawing.Point(263, 15);
            this.button_edit_deposit.Name = "button_edit_deposit";
            this.button_edit_deposit.Size = new System.Drawing.Size(133, 49);
            this.button_edit_deposit.TabIndex = 24;
            this.button_edit_deposit.Text = "EDIT";
            this.button_edit_deposit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_edit_deposit.UseVisualStyleBackColor = false;
            // 
            // button_delete_deposit
            // 
            this.button_delete_deposit.BackColor = System.Drawing.Color.Maroon;
            this.button_delete_deposit.FlatAppearance.BorderSize = 0;
            this.button_delete_deposit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_delete_deposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_delete_deposit.ForeColor = System.Drawing.Color.White;
            this.button_delete_deposit.Image = ((System.Drawing.Image)(resources.GetObject("button_delete_deposit.Image")));
            this.button_delete_deposit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_delete_deposit.Location = new System.Drawing.Point(471, 16);
            this.button_delete_deposit.Name = "button_delete_deposit";
            this.button_delete_deposit.Size = new System.Drawing.Size(139, 49);
            this.button_delete_deposit.TabIndex = 26;
            this.button_delete_deposit.Text = "DELETE";
            this.button_delete_deposit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_delete_deposit.UseVisualStyleBackColor = false;
            // 
            // button_save_deposit
            // 
            this.button_save_deposit.BackColor = System.Drawing.Color.DodgerBlue;
            this.button_save_deposit.FlatAppearance.BorderSize = 0;
            this.button_save_deposit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_save_deposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_save_deposit.ForeColor = System.Drawing.Color.White;
            this.button_save_deposit.Image = ((System.Drawing.Image)(resources.GetObject("button_save_deposit.Image")));
            this.button_save_deposit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_save_deposit.Location = new System.Drawing.Point(53, 15);
            this.button_save_deposit.Name = "button_save_deposit";
            this.button_save_deposit.Size = new System.Drawing.Size(133, 49);
            this.button_save_deposit.TabIndex = 25;
            this.button_save_deposit.Text = "SAVE";
            this.button_save_deposit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_save_deposit.UseVisualStyleBackColor = false;
            this.button_save_deposit.Click += new System.EventHandler(this.button_save_deposit_Click);
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 20;
            this.bunifuCards1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.SkyBlue;
            this.bunifuCards1.Controls.Add(this.button_deposit_clear);
            this.bunifuCards1.Controls.Add(this.button_print_deposit);
            this.bunifuCards1.Controls.Add(this.cb_LoanScheduler);
            this.bunifuCards1.Controls.Add(this.cb_LoanCurrency);
            this.bunifuCards1.Controls.Add(this.date_LoanLimitDate);
            this.bunifuCards1.Controls.Add(this.Date_Loan);
            this.bunifuCards1.Controls.Add(this.panel13);
            this.bunifuCards1.Controls.Add(this.panel8);
            this.bunifuCards1.Controls.Add(this.panel9);
            this.bunifuCards1.Controls.Add(this.panel5);
            this.bunifuCards1.Controls.Add(this.panel11);
            this.bunifuCards1.Controls.Add(this.label2);
            this.bunifuCards1.Controls.Add(this.panel3);
            this.bunifuCards1.Controls.Add(this.label_LoanTime);
            this.bunifuCards1.Controls.Add(this.panel7);
            this.bunifuCards1.Controls.Add(this.label4);
            this.bunifuCards1.Controls.Add(this.panel10);
            this.bunifuCards1.Controls.Add(this.label8);
            this.bunifuCards1.Controls.Add(this.label3);
            this.bunifuCards1.Controls.Add(this.panel6);
            this.bunifuCards1.Controls.Add(this.label12);
            this.bunifuCards1.Controls.Add(this.panel2);
            this.bunifuCards1.Controls.Add(this.label5);
            this.bunifuCards1.Controls.Add(this.label10);
            this.bunifuCards1.Controls.Add(this.txt_LoanAmountInWords);
            this.bunifuCards1.Controls.Add(this.label9);
            this.bunifuCards1.Controls.Add(this.label6);
            this.bunifuCards1.Controls.Add(this.label11);
            this.bunifuCards1.Controls.Add(this.txt_LoanPurpose);
            this.bunifuCards1.Controls.Add(this.txt_LoanBorrower);
            this.bunifuCards1.Controls.Add(this.txt_LoanAccountNumber);
            this.bunifuCards1.Controls.Add(this.txt_LoanAmount);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(13, 68);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(560, 575);
            this.bunifuCards1.TabIndex = 20;
            // 
            // button_deposit_clear
            // 
            this.button_deposit_clear.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button_deposit_clear.FlatAppearance.BorderSize = 0;
            this.button_deposit_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_deposit_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_deposit_clear.ForeColor = System.Drawing.Color.White;
            this.button_deposit_clear.Image = ((System.Drawing.Image)(resources.GetObject("button_deposit_clear.Image")));
            this.button_deposit_clear.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_deposit_clear.Location = new System.Drawing.Point(469, 520);
            this.button_deposit_clear.Name = "button_deposit_clear";
            this.button_deposit_clear.Size = new System.Drawing.Size(35, 38);
            this.button_deposit_clear.TabIndex = 28;
            this.button_deposit_clear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_deposit_clear.UseVisualStyleBackColor = false;
            // 
            // button_print_deposit
            // 
            this.button_print_deposit.BackColor = System.Drawing.Color.DodgerBlue;
            this.button_print_deposit.FlatAppearance.BorderSize = 0;
            this.button_print_deposit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_print_deposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_print_deposit.ForeColor = System.Drawing.Color.White;
            this.button_print_deposit.Image = ((System.Drawing.Image)(resources.GetObject("button_print_deposit.Image")));
            this.button_print_deposit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_print_deposit.Location = new System.Drawing.Point(510, 520);
            this.button_print_deposit.Name = "button_print_deposit";
            this.button_print_deposit.Size = new System.Drawing.Size(35, 38);
            this.button_print_deposit.TabIndex = 27;
            this.button_print_deposit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_print_deposit.UseVisualStyleBackColor = false;
            // 
            // cb_LoanScheduler
            // 
            this.cb_LoanScheduler.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_LoanScheduler.FormattingEnabled = true;
            this.cb_LoanScheduler.Items.AddRange(new object[] {
            "After 1 Weeks",
            "After 2 Weeks",
            "After 3 Weeks",
            "After 4 Weeks",
            "After 1 Month",
            "After 2 Month",
            "After 3 Month",
            "After 4 Month",
            "After 5 Month",
            "After 6 Month",
            "After 7 Month",
            "After 8 Month",
            "After 9 Month",
            "After 10 Month",
            "After 11 Month",
            "After 12 Month",
            "After 1 Year",
            "After 2 Year",
            "After 3 Year",
            "After 4 Year",
            "After 5 Year",
            "After 6 Year",
            "After 7 Year",
            "After 8 Year",
            "After 9 Year",
            "After 10 Year"});
            this.cb_LoanScheduler.Location = new System.Drawing.Point(184, 415);
            this.cb_LoanScheduler.Name = "cb_LoanScheduler";
            this.cb_LoanScheduler.Size = new System.Drawing.Size(312, 26);
            this.cb_LoanScheduler.TabIndex = 10;
            this.cb_LoanScheduler.Text = "--Select--";
            // 
            // cb_LoanCurrency
            // 
            this.cb_LoanCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_LoanCurrency.FormattingEnabled = true;
            this.cb_LoanCurrency.Items.AddRange(new object[] {
            "Rwandan Francs",
            "Congolese Francs",
            "Burundian Francs",
            "Tanzanian Shilling",
            "Ugandan Shilling"});
            this.cb_LoanCurrency.Location = new System.Drawing.Point(184, 315);
            this.cb_LoanCurrency.Name = "cb_LoanCurrency";
            this.cb_LoanCurrency.Size = new System.Drawing.Size(312, 26);
            this.cb_LoanCurrency.TabIndex = 10;
            this.cb_LoanCurrency.Text = "--Select--";
            // 
            // date_LoanLimitDate
            // 
            this.date_LoanLimitDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_LoanLimitDate.Location = new System.Drawing.Point(184, 465);
            this.date_LoanLimitDate.Name = "date_LoanLimitDate";
            this.date_LoanLimitDate.Size = new System.Drawing.Size(311, 24);
            this.date_LoanLimitDate.TabIndex = 7;
            // 
            // Date_Loan
            // 
            this.Date_Loan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_Loan.Location = new System.Drawing.Point(184, 69);
            this.Date_Loan.Name = "Date_Loan";
            this.Date_Loan.Size = new System.Drawing.Size(311, 24);
            this.Date_Loan.TabIndex = 7;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.SkyBlue;
            this.panel13.Controls.Add(this.label13);
            this.panel13.Location = new System.Drawing.Point(-1, -1);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(559, 47);
            this.panel13.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(93, 11);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(375, 25);
            this.label13.TabIndex = 0;
            this.label13.Text = "INDIVIDUAL TRANSACTION DETAILS";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Black;
            this.panel8.Location = new System.Drawing.Point(184, 482);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(311, 2);
            this.panel8.TabIndex = 4;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Black;
            this.panel9.Location = new System.Drawing.Point(185, 287);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(311, 2);
            this.panel9.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Location = new System.Drawing.Point(184, 86);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(311, 2);
            this.panel5.TabIndex = 4;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.Black;
            this.panel11.Location = new System.Drawing.Point(185, 385);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(311, 2);
            this.panel11.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Borrower";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(184, 186);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(311, 2);
            this.panel3.TabIndex = 4;
            // 
            // label_LoanTime
            // 
            this.label_LoanTime.AutoSize = true;
            this.label_LoanTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_LoanTime.Location = new System.Drawing.Point(183, 520);
            this.label_LoanTime.Name = "label_LoanTime";
            this.label_LoanTime.Size = new System.Drawing.Size(45, 18);
            this.label_LoanTime.TabIndex = 1;
            this.label_LoanTime.Text = "Time";
            this.label_LoanTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Black;
            this.panel7.Location = new System.Drawing.Point(185, 441);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(311, 2);
            this.panel7.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 520);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tansaction Time";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Black;
            this.panel10.Location = new System.Drawing.Point(185, 341);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(311, 2);
            this.panel10.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(24, 271);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 18);
            this.label8.TabIndex = 1;
            this.label8.Text = "Amount In Words";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Account Number";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Location = new System.Drawing.Point(185, 235);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(311, 2);
            this.panel6.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(75, 473);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 18);
            this.label12.TabIndex = 2;
            this.label12.Text = "Limit Date";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(184, 137);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(311, 2);
            this.panel2.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(74, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "Loan Date";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(90, 369);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 18);
            this.label10.TabIndex = 2;
            this.label10.Text = "Purpose";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_LoanAmountInWords
            // 
            this.txt_LoanAmountInWords.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_LoanAmountInWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_LoanAmountInWords.Location = new System.Drawing.Point(185, 266);
            this.txt_LoanAmountInWords.Name = "txt_LoanAmountInWords";
            this.txt_LoanAmountInWords.Size = new System.Drawing.Size(311, 17);
            this.txt_LoanAmountInWords.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(85, 425);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 18);
            this.label9.TabIndex = 2;
            this.label9.Text = "Schedule";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(91, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 18);
            this.label6.TabIndex = 2;
            this.label6.Text = "Amount";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(82, 321);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 18);
            this.label11.TabIndex = 2;
            this.label11.Text = "Currency";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_LoanPurpose
            // 
            this.txt_LoanPurpose.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_LoanPurpose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_LoanPurpose.Location = new System.Drawing.Point(185, 364);
            this.txt_LoanPurpose.Name = "txt_LoanPurpose";
            this.txt_LoanPurpose.Size = new System.Drawing.Size(311, 17);
            this.txt_LoanPurpose.TabIndex = 3;
            // 
            // txt_LoanBorrower
            // 
            this.txt_LoanBorrower.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_LoanBorrower.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_LoanBorrower.Location = new System.Drawing.Point(184, 116);
            this.txt_LoanBorrower.Name = "txt_LoanBorrower";
            this.txt_LoanBorrower.Size = new System.Drawing.Size(311, 17);
            this.txt_LoanBorrower.TabIndex = 3;
            // 
            // txt_LoanAccountNumber
            // 
            this.txt_LoanAccountNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_LoanAccountNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_LoanAccountNumber.Location = new System.Drawing.Point(184, 165);
            this.txt_LoanAccountNumber.Name = "txt_LoanAccountNumber";
            this.txt_LoanAccountNumber.Size = new System.Drawing.Size(311, 17);
            this.txt_LoanAccountNumber.TabIndex = 3;
            // 
            // txt_LoanAmount
            // 
            this.txt_LoanAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_LoanAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_LoanAmount.Location = new System.Drawing.Point(185, 214);
            this.txt_LoanAmount.Name = "txt_LoanAmount";
            this.txt_LoanAmount.Size = new System.Drawing.Size(311, 17);
            this.txt_LoanAmount.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1152, 48);
            this.panel1.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(437, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOAN TRANSACTIONS";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LoanTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.bunifuCustomDataGrid1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bunifuCards1);
            this.Controls.Add(this.panel1);
            this.Name = "LoanTransaction";
            this.Size = new System.Drawing.Size(1152, 723);
            this.Load += new System.EventHandler(this.LoanTransaction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_edit_deposit;
        private System.Windows.Forms.Button button_delete_deposit;
        private System.Windows.Forms.Button button_save_deposit;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private System.Windows.Forms.Button button_deposit_clear;
        private System.Windows.Forms.Button button_print_deposit;
        private System.Windows.Forms.ComboBox cb_LoanCurrency;
        private System.Windows.Forms.DateTimePicker Date_Loan;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label_LoanTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_LoanAmountInWords;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_LoanPurpose;
        private System.Windows.Forms.TextBox txt_LoanBorrower;
        private System.Windows.Forms.TextBox txt_LoanAccountNumber;
        private System.Windows.Forms.TextBox txt_LoanAmount;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_LoanScheduler;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker date_LoanLimitDate;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Loan_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Borrower;
        private System.Windows.Forms.DataGridViewTextBoxColumn Account_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount_In_Words;
        private System.Windows.Forms.DataGridViewTextBoxColumn Currency;
        private System.Windows.Forms.DataGridViewTextBoxColumn Purpose;
        private System.Windows.Forms.DataGridViewTextBoxColumn Scheduler;
        private System.Windows.Forms.DataGridViewTextBoxColumn Limit_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.Timer timer1;
    }
}
