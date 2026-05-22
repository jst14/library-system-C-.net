using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void booksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Books Books = new Books();
            this.Close();
            Books.Show();
        }

        private void borrowerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 Borrower = new Form4();
            this.Close();
            Borrower.Show();
        }

        private void transactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 Transaction = new Form5();
            this.Close();
            Transaction.Show();
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 Reports = new Form6();
            this.Close();
            Reports.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}