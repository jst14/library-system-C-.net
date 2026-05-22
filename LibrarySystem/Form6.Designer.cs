namespace LibrarySystem
{
    partial class Form6
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnAllTransactions = new System.Windows.Forms.Button();
            this.btnOverdue = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(145, 20);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "All Transactions";
            // btnAllTransactions
            this.btnAllTransactions.Location = new System.Drawing.Point(24, 45);
            this.btnAllTransactions.Name = "btnAllTransactions";
            this.btnAllTransactions.Size = new System.Drawing.Size(110, 25);
            this.btnAllTransactions.TabIndex = 1;
            this.btnAllTransactions.Text = "All Transactions";
            this.btnAllTransactions.UseVisualStyleBackColor = true;
            this.btnAllTransactions.Click += new System.EventHandler(this.btnAllTransactions_Click);
            // btnOverdue
            this.btnOverdue.Location = new System.Drawing.Point(145, 45);
            this.btnOverdue.Name = "btnOverdue";
            this.btnOverdue.Size = new System.Drawing.Size(110, 25);
            this.btnOverdue.TabIndex = 2;
            this.btnOverdue.Text = "Overdue Books";
            this.btnOverdue.UseVisualStyleBackColor = true;
            this.btnOverdue.Click += new System.EventHandler(this.btnOverdue_Click);
            // groupBox1
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(20, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 310);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Records";
            // dataGridView1
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(538, 245);
            this.dataGridView1.TabIndex = 2;
            // txtSearch
            this.txtSearch.Location = new System.Drawing.Point(78, 25);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(470, 20);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // label1
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search";
            // Form6
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 415);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOverdue);
            this.Controls.Add(this.btnAllTransactions);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnAllTransactions;
        private System.Windows.Forms.Button btnOverdue;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
    }
}