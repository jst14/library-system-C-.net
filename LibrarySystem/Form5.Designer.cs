namespace LibrarySystem
{
    partial class Form5
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDateReturn = new System.Windows.Forms.DateTimePicker();
            this.dtpDateBorrowed = new System.Windows.Forms.DateTimePicker();
            this.txtAccessionNum = new System.Windows.Forms.TextBox();
            this.txtBorrowerID = new System.Windows.Forms.TextBox();
            this.txtTransID = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpDateReturn);
            this.groupBox1.Controls.Add(this.dtpDateBorrowed);
            this.groupBox1.Controls.Add(this.txtAccessionNum);
            this.groupBox1.Controls.Add(this.txtBorrowerID);
            this.groupBox1.Controls.Add(this.txtTransID);
            this.groupBox1.Location = new System.Drawing.Point(20, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 165);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Transaction Details";
            // 
            // btnAdd — top left button (same position as Borrower)
            // 
            this.btnAdd.Location = new System.Drawing.Point(260, 27);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(56, 21);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave — top right button
            // 
            this.btnSave.Location = new System.Drawing.Point(325, 27);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(56, 21);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit — middle left button
            // 
            this.btnEdit.Location = new System.Drawing.Point(260, 55);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(56, 21);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnUpdate — middle right button
            // 
            this.btnUpdate.Location = new System.Drawing.Point(325, 55);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(56, 21);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete — bottom left button
            // 
            this.btnDelete.Location = new System.Drawing.Point(260, 83);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(56, 21);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1 - Transaction ID
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Transaction ID";
            // 
            // label2 - Borrower ID
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Borrower ID";
            // 
            // label3 - Accession No.
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Accession No.";
            // 
            // label4 - Date Borrowed
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Date Borrowed";
            // 
            // label5 - Date Return
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Date Return";
            // 
            // txtTransID
            // 
            this.txtTransID.Location = new System.Drawing.Point(110, 27);
            this.txtTransID.Name = "txtTransID";
            this.txtTransID.Size = new System.Drawing.Size(130, 20);
            this.txtTransID.TabIndex = 0;
            // 
            // txtBorrowerID
            // 
            this.txtBorrowerID.Location = new System.Drawing.Point(110, 55);
            this.txtBorrowerID.Name = "txtBorrowerID";
            this.txtBorrowerID.Size = new System.Drawing.Size(130, 20);
            this.txtBorrowerID.TabIndex = 1;
            // 
            // txtAccessionNum
            // 
            this.txtAccessionNum.Location = new System.Drawing.Point(110, 83);
            this.txtAccessionNum.Name = "txtAccessionNum";
            this.txtAccessionNum.Size = new System.Drawing.Size(130, 20);
            this.txtAccessionNum.TabIndex = 2;
            // 
            // dtpDateBorrowed
            // 
            this.dtpDateBorrowed.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateBorrowed.Location = new System.Drawing.Point(110, 111);
            this.dtpDateBorrowed.Name = "dtpDateBorrowed";
            this.dtpDateBorrowed.Size = new System.Drawing.Size(130, 20);
            this.dtpDateBorrowed.TabIndex = 3;
            // 
            // dtpDateReturn
            // 
            this.dtpDateReturn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateReturn.Location = new System.Drawing.Point(110, 137);
            this.dtpDateReturn.Name = "dtpDateReturn";
            this.dtpDateReturn.Size = new System.Drawing.Size(130, 20);
            this.dtpDateReturn.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.txtSearch);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(20, 200);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(400, 255);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Transaction Records";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(366, 184);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(78, 27);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(308, 20);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Search";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 475);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transaction";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDateReturn;
        private System.Windows.Forms.DateTimePicker dtpDateBorrowed;
        private System.Windows.Forms.TextBox txtAccessionNum;
        private System.Windows.Forms.TextBox txtBorrowerID;
        private System.Windows.Forms.TextBox txtTransID;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label6;
    }
}