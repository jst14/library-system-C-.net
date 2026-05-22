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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void borrowerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Borrower Borrower = new Borrower();
            this.Close();
            Borrower.Show();
        }

        private void transactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Transactions Transactions = new Transactions();
            this.Close();
            Transactions.Show();
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports Reports = new Reports();
            this.Close();
            Reports.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
