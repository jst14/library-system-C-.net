namespace LibrarySystem
{
    partial class Borrower
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Borrower));
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.directorySearcher2 = new System.DirectoryServices.DirectorySearcher();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Namelbl = new System.Windows.Forms.Label();
            this.BorrowerNametxtbox = new System.Windows.Forms.TextBox();
            this.BorrowerIDtxtbox = new System.Windows.Forms.TextBox();
            this.BorrowerIDlbl = new System.Windows.Forms.Label();
            this.ContactNolbl = new System.Windows.Forms.Label();
            this.ContactNotxtbox = new System.Windows.Forms.TextBox();
            this.DateBorrowedPicker = new System.Windows.Forms.DateTimePicker();
            this.DateBorrowedlbl = new System.Windows.Forms.Label();
            this.ChooseBooktxtbox = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.DateDuelbl = new System.Windows.Forms.Label();
            this.DateDuePicker = new System.Windows.Forms.DateTimePicker();
            this.ChooseBooklbl = new System.Windows.Forms.Label();
            this.BorrowFormgrpbox = new System.Windows.Forms.GroupBox();
            this.CoursecomboBox = new System.Windows.Forms.ComboBox();
            this.YearLvlcomboBox = new System.Windows.Forms.ComboBox();
            this.YearLevellbl = new System.Windows.Forms.Label();
            this.Courselbl = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.masterFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.booksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.BorrowFormgrpbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // directorySearcher2
            // 
            this.directorySearcher2.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher2.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher2.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(31, 51);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(443, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(27, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search Borrower";
            // 
            // Namelbl
            // 
            this.Namelbl.AutoSize = true;
            this.Namelbl.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold);
            this.Namelbl.Location = new System.Drawing.Point(48, 57);
            this.Namelbl.Name = "Namelbl";
            this.Namelbl.Size = new System.Drawing.Size(51, 19);
            this.Namelbl.TabIndex = 2;
            this.Namelbl.Text = "Name";
            // 
            // BorrowerNametxtbox
            // 
            this.BorrowerNametxtbox.Location = new System.Drawing.Point(52, 84);
            this.BorrowerNametxtbox.Multiline = true;
            this.BorrowerNametxtbox.Name = "BorrowerNametxtbox";
            this.BorrowerNametxtbox.Size = new System.Drawing.Size(373, 26);
            this.BorrowerNametxtbox.TabIndex = 3;
            // 
            // BorrowerIDtxtbox
            // 
            this.BorrowerIDtxtbox.Location = new System.Drawing.Point(52, 146);
            this.BorrowerIDtxtbox.Multiline = true;
            this.BorrowerIDtxtbox.Name = "BorrowerIDtxtbox";
            this.BorrowerIDtxtbox.Size = new System.Drawing.Size(163, 26);
            this.BorrowerIDtxtbox.TabIndex = 4;
            // 
            // BorrowerIDlbl
            // 
            this.BorrowerIDlbl.AutoSize = true;
            this.BorrowerIDlbl.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold);
            this.BorrowerIDlbl.Location = new System.Drawing.Point(48, 121);
            this.BorrowerIDlbl.Name = "BorrowerIDlbl";
            this.BorrowerIDlbl.Size = new System.Drawing.Size(95, 19);
            this.BorrowerIDlbl.TabIndex = 5;
            this.BorrowerIDlbl.Text = "Borrower ID";
            // 
            // ContactNolbl
            // 
            this.ContactNolbl.AutoSize = true;
            this.ContactNolbl.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold);
            this.ContactNolbl.Location = new System.Drawing.Point(244, 121);
            this.ContactNolbl.Name = "ContactNolbl";
            this.ContactNolbl.Size = new System.Drawing.Size(101, 19);
            this.ContactNolbl.TabIndex = 6;
            this.ContactNolbl.Text = "#Contact No.";
            // 
            // ContactNotxtbox
            // 
            this.ContactNotxtbox.Location = new System.Drawing.Point(248, 146);
            this.ContactNotxtbox.Multiline = true;
            this.ContactNotxtbox.Name = "ContactNotxtbox";
            this.ContactNotxtbox.Size = new System.Drawing.Size(177, 26);
            this.ContactNotxtbox.TabIndex = 7;
            // 
            // DateBorrowedPicker
            // 
            this.DateBorrowedPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateBorrowedPicker.Location = new System.Drawing.Point(167, 269);
            this.DateBorrowedPicker.Name = "DateBorrowedPicker";
            this.DateBorrowedPicker.Size = new System.Drawing.Size(121, 30);
            this.DateBorrowedPicker.TabIndex = 0;
            // 
            // DateBorrowedlbl
            // 
            this.DateBorrowedlbl.AutoSize = true;
            this.DateBorrowedlbl.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold);
            this.DateBorrowedlbl.Location = new System.Drawing.Point(48, 277);
            this.DateBorrowedlbl.Name = "DateBorrowedlbl";
            this.DateBorrowedlbl.Size = new System.Drawing.Size(115, 19);
            this.DateBorrowedlbl.TabIndex = 1;
            this.DateBorrowedlbl.Text = "Date Borrowed";
            // 
            // ChooseBooktxtbox
            // 
            this.ChooseBooktxtbox.FormattingEnabled = true;
            this.ChooseBooktxtbox.Location = new System.Drawing.Point(167, 229);
            this.ChooseBooktxtbox.Name = "ChooseBooktxtbox";
            this.ChooseBooktxtbox.Size = new System.Drawing.Size(237, 31);
            this.ChooseBooktxtbox.TabIndex = 11;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(389, 387);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(104, 37);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // DateDuelbl
            // 
            this.DateDuelbl.AutoSize = true;
            this.DateDuelbl.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold);
            this.DateDuelbl.Location = new System.Drawing.Point(48, 322);
            this.DateDuelbl.Name = "DateDuelbl";
            this.DateDuelbl.Size = new System.Drawing.Size(74, 19);
            this.DateDuelbl.TabIndex = 16;
            this.DateDuelbl.Text = "Date Due";
            // 
            // DateDuePicker
            // 
            this.DateDuePicker.CalendarForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DateDuePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateDuePicker.Location = new System.Drawing.Point(167, 316);
            this.DateDuePicker.Name = "DateDuePicker";
            this.DateDuePicker.Size = new System.Drawing.Size(121, 30);
            this.DateDuePicker.TabIndex = 17;
            // 
            // ChooseBooklbl
            // 
            this.ChooseBooklbl.AutoSize = true;
            this.ChooseBooklbl.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold);
            this.ChooseBooklbl.Location = new System.Drawing.Point(48, 232);
            this.ChooseBooklbl.Name = "ChooseBooklbl";
            this.ChooseBooklbl.Size = new System.Drawing.Size(100, 19);
            this.ChooseBooklbl.TabIndex = 12;
            this.ChooseBooklbl.Text = "Choose Book";
            // 
            // BorrowFormgrpbox
            // 
            this.BorrowFormgrpbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(237)))));
            this.BorrowFormgrpbox.Controls.Add(this.CoursecomboBox);
            this.BorrowFormgrpbox.Controls.Add(this.DateBorrowedPicker);
            this.BorrowFormgrpbox.Controls.Add(this.YearLvlcomboBox);
            this.BorrowFormgrpbox.Controls.Add(this.YearLevellbl);
            this.BorrowFormgrpbox.Controls.Add(this.Courselbl);
            this.BorrowFormgrpbox.Controls.Add(this.btnSave);
            this.BorrowFormgrpbox.Controls.Add(this.btnEdit);
            this.BorrowFormgrpbox.Controls.Add(this.btnUpdate);
            this.BorrowFormgrpbox.Controls.Add(this.btnAdd);
            this.BorrowFormgrpbox.Controls.Add(this.Namelbl);
            this.BorrowFormgrpbox.Controls.Add(this.BorrowerNametxtbox);
            this.BorrowFormgrpbox.Controls.Add(this.ContactNolbl);
            this.BorrowFormgrpbox.Controls.Add(this.ContactNotxtbox);
            this.BorrowFormgrpbox.Controls.Add(this.BorrowerIDlbl);
            this.BorrowFormgrpbox.Controls.Add(this.BorrowerIDtxtbox);
            this.BorrowFormgrpbox.Controls.Add(this.ChooseBooklbl);
            this.BorrowFormgrpbox.Controls.Add(this.DateDuePicker);
            this.BorrowFormgrpbox.Controls.Add(this.DateDuelbl);
            this.BorrowFormgrpbox.Controls.Add(this.ChooseBooktxtbox);
            this.BorrowFormgrpbox.Controls.Add(this.DateBorrowedlbl);
            this.BorrowFormgrpbox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.BorrowFormgrpbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(45)))), ((int)(((byte)(32)))));
            this.BorrowFormgrpbox.Location = new System.Drawing.Point(40, 110);
            this.BorrowFormgrpbox.Name = "BorrowFormgrpbox";
            this.BorrowFormgrpbox.Padding = new System.Windows.Forms.Padding(15, 12, 15, 12);
            this.BorrowFormgrpbox.Size = new System.Drawing.Size(520, 450);
            this.BorrowFormgrpbox.TabIndex = 16;
            this.BorrowFormgrpbox.TabStop = false;
            this.BorrowFormgrpbox.Text = "Borrower Details";
            // 
            // CoursecomboBox
            // 
            this.CoursecomboBox.FormattingEnabled = true;
            this.CoursecomboBox.Items.AddRange(new object[] {
            "BSIT",
            "BSCS",
            "BSCRIM",
            "BSHM",
            "BSN",
            "BSCE",
            "BSE",
            "BSME",
            "BSED",
            "BSA"});
            this.CoursecomboBox.Location = new System.Drawing.Point(111, 187);
            this.CoursecomboBox.Name = "CoursecomboBox";
            this.CoursecomboBox.Size = new System.Drawing.Size(120, 31);
            this.CoursecomboBox.TabIndex = 23;
            // 
            // YearLvlcomboBox
            // 
            this.YearLvlcomboBox.FormattingEnabled = true;
            this.YearLvlcomboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.YearLvlcomboBox.Location = new System.Drawing.Point(341, 190);
            this.YearLvlcomboBox.Name = "YearLvlcomboBox";
            this.YearLvlcomboBox.Size = new System.Drawing.Size(84, 31);
            this.YearLvlcomboBox.TabIndex = 22;
            // 
            // YearLevellbl
            // 
            this.YearLevellbl.AutoSize = true;
            this.YearLevellbl.Location = new System.Drawing.Point(255, 190);
            this.YearLevellbl.Name = "YearLevellbl";
            this.YearLevellbl.Size = new System.Drawing.Size(89, 23);
            this.YearLevellbl.TabIndex = 21;
            this.YearLevellbl.Text = "Year Level";
            // 
            // Courselbl
            // 
            this.Courselbl.AutoSize = true;
            this.Courselbl.Location = new System.Drawing.Point(48, 190);
            this.Courselbl.Name = "Courselbl";
            this.Courselbl.Size = new System.Drawing.Size(64, 23);
            this.Courselbl.TabIndex = 20;
            this.Courselbl.Text = "Course";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(591, 398);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(104, 37);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(141, 387);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(104, 37);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(18, 387);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(104, 37);
            this.btnEdit.TabIndex = 15;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(265, 387);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(104, 37);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(237)))));
            this.label2.Location = new System.Drawing.Point(30, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(362, 62);
            this.label2.TabIndex = 17;
            this.label2.Text = "Borrower Form";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Location = new System.Drawing.Point(15, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(680, 300);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(237)))));
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(45)))), ((int)(((byte)(32)))));
            this.groupBox1.Location = new System.Drawing.Point(600, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(15, 12, 15, 12);
            this.groupBox1.Size = new System.Drawing.Size(710, 450);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Borrower Records";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(45)))), ((int)(((byte)(32)))));
            this.menuStrip1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(237)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masterFilesToolStripMenuItem,
            this.transactionToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1350, 30);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // masterFilesToolStripMenuItem
            // 
            this.masterFilesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.booksToolStripMenuItem});
            this.masterFilesToolStripMenuItem.Name = "masterFilesToolStripMenuItem";
            this.masterFilesToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.masterFilesToolStripMenuItem.Text = "Master Files";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // booksToolStripMenuItem
            // 
            this.booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            this.booksToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.booksToolStripMenuItem.Text = "Books";
            this.booksToolStripMenuItem.Click += new System.EventHandler(this.booksToolStripMenuItem_Click);
            // 
            // transactionToolStripMenuItem
            // 
            this.transactionToolStripMenuItem.Name = "transactionToolStripMenuItem";
            this.transactionToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.transactionToolStripMenuItem.Text = "Transaction";
            this.transactionToolStripMenuItem.Click += new System.EventHandler(this.transactionToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.reportsToolStripMenuItem.Text = "Reports";
            this.reportsToolStripMenuItem.Click += new System.EventHandler(this.reportsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(81)))), ((int)(((byte)(44)))));
            this.pnlHeader.Controls.Add(this.label5);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 30);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1350, 70);
            this.pnlHeader.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(237)))));
            this.label5.Location = new System.Drawing.Point(11, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(344, 62);
            this.label5.TabIndex = 2;
            this.label5.Text = "Borrowers List";
            // 
            // Borrower
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(1350, 600);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BorrowFormgrpbox);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Borrower";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Borrower";
            this.Load += new System.EventHandler(this.Borrower_Load);
            this.BorrowFormgrpbox.ResumeLayout(false);
            this.BorrowFormgrpbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.DirectoryServices.DirectorySearcher directorySearcher2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Namelbl;
        private System.Windows.Forms.TextBox BorrowerNametxtbox;
        private System.Windows.Forms.TextBox BorrowerIDtxtbox;
        private System.Windows.Forms.Label BorrowerIDlbl;
        private System.Windows.Forms.Label ContactNolbl;
        private System.Windows.Forms.TextBox ContactNotxtbox;
        private System.Windows.Forms.DateTimePicker DateBorrowedPicker;
        private System.Windows.Forms.Label DateBorrowedlbl;
        private System.Windows.Forms.ComboBox ChooseBooktxtbox;
        private System.Windows.Forms.Button BorrowBtn;
        private System.Windows.Forms.Label DateDuelbl;
        private System.Windows.Forms.DateTimePicker DateDuePicker;
        private System.Windows.Forms.Label ChooseBooklbl;
        private System.Windows.Forms.GroupBox BorrowFormgrpbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox YearLvlcomboBox;
        private System.Windows.Forms.Label YearLevellbl;
        private System.Windows.Forms.Label Courselbl;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem masterFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem booksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ComboBox CoursecomboBox;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnUpdate;
    }
}