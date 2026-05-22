namespace LibrarySystem
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.headerPanel = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.masterFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.booksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrowerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelShortcuts = new System.Windows.Forms.Panel();
            this.btnQuickBooks = new System.Windows.Forms.Button();
            this.btnQuickBorrower = new System.Windows.Forms.Button();
            this.btnQuickTransaction = new System.Windows.Forms.Button();
            this.btnQuickReports = new System.Windows.Forms.Button();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.headerPanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.panelShortcuts.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(45)))), ((int)(((byte)(32)))));
            this.headerPanel.Controls.Add(this.lblTitle);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 33);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1000, 80);
            this.headerPanel.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(134)))), ((int)(((byte)(11)))));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lblTitle.Size = new System.Drawing.Size(1000, 80);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "📚 Library Management System";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(45)))), ((int)(((byte)(32)))));
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masterFilesToolStripMenuItem,
            this.transactionToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1000, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // masterFilesToolStripMenuItem
            // 
            this.masterFilesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.booksToolStripMenuItem,
            this.borrowerToolStripMenuItem});
            this.masterFilesToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(237)))));
            this.masterFilesToolStripMenuItem.Name = "masterFilesToolStripMenuItem";
            this.masterFilesToolStripMenuItem.Size = new System.Drawing.Size(126, 29);
            this.masterFilesToolStripMenuItem.Text = "Master Files";
            // 
            // booksToolStripMenuItem
            // 
            this.booksToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(81)))), ((int)(((byte)(44)))));
            this.booksToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(237)))));
            this.booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            this.booksToolStripMenuItem.Size = new System.Drawing.Size(202, 30);
            this.booksToolStripMenuItem.Text = "📖 Books";
            this.booksToolStripMenuItem.Click += new System.EventHandler(this.booksToolStripMenuItem_Click);
            // 
            // borrowerToolStripMenuItem
            // 
            this.borrowerToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(81)))), ((int)(((byte)(44)))));
            this.borrowerToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(237)))));
            this.borrowerToolStripMenuItem.Name = "borrowerToolStripMenuItem";
            this.borrowerToolStripMenuItem.Size = new System.Drawing.Size(202, 30);
            this.borrowerToolStripMenuItem.Text = "👤 Borrower";
            this.borrowerToolStripMenuItem.Click += new System.EventHandler(this.borrowerToolStripMenuItem_Click);
            // 
            // transactionToolStripMenuItem
            // 
            this.transactionToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(237)))));
            this.transactionToolStripMenuItem.Name = "transactionToolStripMenuItem";
            this.transactionToolStripMenuItem.Size = new System.Drawing.Size(122, 29);
            this.transactionToolStripMenuItem.Text = "Transaction";
            this.transactionToolStripMenuItem.Click += new System.EventHandler(this.transactionToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(237)))));
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(89, 29);
            this.reportsToolStripMenuItem.Text = "Reports";
            this.reportsToolStripMenuItem.Click += new System.EventHandler(this.reportsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(237)))));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(56, 29);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(237)))));
            this.panelContent.Controls.Add(this.panelShortcuts);
            this.panelContent.Controls.Add(this.lblSubtitle);
            this.panelContent.Controls.Add(this.lblWelcome);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 113);
            this.panelContent.Name = "panelContent";
            this.panelContent.Padding = new System.Windows.Forms.Padding(40);
            this.panelContent.Size = new System.Drawing.Size(1000, 487);
            this.panelContent.TabIndex = 1;
            // 
            // panelShortcuts
            // 
            this.panelShortcuts.Controls.Add(this.btnQuickBooks);
            this.panelShortcuts.Controls.Add(this.btnQuickBorrower);
            this.panelShortcuts.Controls.Add(this.btnQuickTransaction);
            this.panelShortcuts.Controls.Add(this.btnQuickReports);
            this.panelShortcuts.Location = new System.Drawing.Point(40, 160);
            this.panelShortcuts.Name = "panelShortcuts";
            this.panelShortcuts.Size = new System.Drawing.Size(920, 280);
            this.panelShortcuts.TabIndex = 2;
            // 
            // btnQuickBooks
            // 
            this.btnQuickBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(84)))), ((int)(((byte)(60)))));
            this.btnQuickBooks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuickBooks.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(45)))), ((int)(((byte)(32)))));
            this.btnQuickBooks.FlatAppearance.BorderSize = 2;
            this.btnQuickBooks.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(134)))), ((int)(((byte)(11)))));
            this.btnQuickBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuickBooks.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnQuickBooks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(237)))));
            this.btnQuickBooks.Location = new System.Drawing.Point(20, 20);
            this.btnQuickBooks.Name = "btnQuickBooks";
            this.btnQuickBooks.Size = new System.Drawing.Size(200, 120);
            this.btnQuickBooks.TabIndex = 0;
            this.btnQuickBooks.Text = "📖\r\nBooks\r\nManagement";
            this.btnQuickBooks.UseVisualStyleBackColor = false;
            this.btnQuickBooks.Click += new System.EventHandler(this.booksToolStripMenuItem_Click);
            // 
            // btnQuickBorrower
            // 
            this.btnQuickBorrower.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(32)))));
            this.btnQuickBorrower.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuickBorrower.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(45)))), ((int)(((byte)(32)))));
            this.btnQuickBorrower.FlatAppearance.BorderSize = 2;
            this.btnQuickBorrower.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(134)))), ((int)(((byte)(11)))));
            this.btnQuickBorrower.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuickBorrower.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnQuickBorrower.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(237)))));
            this.btnQuickBorrower.Location = new System.Drawing.Point(260, 20);
            this.btnQuickBorrower.Name = "btnQuickBorrower";
            this.btnQuickBorrower.Size = new System.Drawing.Size(200, 120);
            this.btnQuickBorrower.TabIndex = 1;
            this.btnQuickBorrower.Text = "👤\r\nBorrower\r\n Form";
            this.btnQuickBorrower.UseVisualStyleBackColor = false;
            this.btnQuickBorrower.Click += new System.EventHandler(this.borrowerToolStripMenuItem_Click);
            // 
            // btnQuickTransaction
            // 
            this.btnQuickTransaction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(85)))), ((int)(((byte)(0)))));
            this.btnQuickTransaction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuickTransaction.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(45)))), ((int)(((byte)(32)))));
            this.btnQuickTransaction.FlatAppearance.BorderSize = 2;
            this.btnQuickTransaction.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(134)))), ((int)(((byte)(11)))));
            this.btnQuickTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuickTransaction.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnQuickTransaction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(237)))));
            this.btnQuickTransaction.Location = new System.Drawing.Point(500, 20);
            this.btnQuickTransaction.Name = "btnQuickTransaction";
            this.btnQuickTransaction.Size = new System.Drawing.Size(200, 120);
            this.btnQuickTransaction.TabIndex = 2;
            this.btnQuickTransaction.Text = "🔄\r\nTransactions\r\n Returns";
            this.btnQuickTransaction.UseVisualStyleBackColor = false;
            this.btnQuickTransaction.Click += new System.EventHandler(this.transactionToolStripMenuItem_Click);
            // 
            // btnQuickReports
            // 
            this.btnQuickReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(81)))), ((int)(((byte)(44)))));
            this.btnQuickReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuickReports.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(45)))), ((int)(((byte)(32)))));
            this.btnQuickReports.FlatAppearance.BorderSize = 2;
            this.btnQuickReports.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(134)))), ((int)(((byte)(11)))));
            this.btnQuickReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuickReports.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnQuickReports.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(237)))));
            this.btnQuickReports.Location = new System.Drawing.Point(740, 20);
            this.btnQuickReports.Name = "btnQuickReports";
            this.btnQuickReports.Size = new System.Drawing.Size(160, 120);
            this.btnQuickReports.TabIndex = 3;
            this.btnQuickReports.Text = "📊\r\nReports";
            this.btnQuickReports.UseVisualStyleBackColor = false;
            this.btnQuickReports.Click += new System.EventHandler(this.reportsToolStripMenuItem_Click);
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(81)))), ((int)(((byte)(44)))));
            this.lblSubtitle.Location = new System.Drawing.Point(40, 95);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(562, 28);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Select an option below or use the menu to manage your library";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(45)))), ((int)(((byte)(32)))));
            this.lblWelcome.Location = new System.Drawing.Point(40, 40);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(521, 46);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome to Your Library Portal";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library Management System";
            this.headerPanel.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            this.panelShortcuts.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem masterFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem booksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrowerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel panelShortcuts;
        private System.Windows.Forms.Button btnQuickBooks;
        private System.Windows.Forms.Button btnQuickBorrower;
        private System.Windows.Forms.Button btnQuickTransaction;
        private System.Windows.Forms.Button btnQuickReports;
    }
}