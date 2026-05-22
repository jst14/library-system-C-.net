using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace LibrarySystem
{
    public partial class Transactions : Form
    {
        private OleDbConnection con;
        private Timer searchTimer;

        public Transactions()
        {
            InitializeComponent();
            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"C:\\Users\\John Simon\\Documents\\Visual Studio 2022\\Library System\\LibrarySystem\\LibSys.mdb\"");

            // Initialize timer for search debouncing
            searchTimer = new Timer();
            searchTimer.Interval = 500; // Wait 500ms after typing stops
            searchTimer.Tick += SearchTimer_Tick;
        }

        private void loaddatagridview()
        {
            try
            {
                if (con.State == ConnectionState.Open)
                    con.Close();

                con.Open();
                OleDbCommand com = new OleDbCommand("Select * from borrower where status = 'Borrowed'", con);
                OleDbDataAdapter adap = new OleDbDataAdapter(com);
                DataTable dt = new DataTable();
                adap.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        private void Transactions_Load(object sender, EventArgs e)
        {
            loaddatagridview();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                string id = dataGridView1.CurrentRow.Cells["borrower_id"].Value.ToString();
                DialogResult dr = MessageBox.Show("Are you sure you want to return this book?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        if (con.State == ConnectionState.Open)
                            con.Close();

                        con.Open();
                        OleDbCommand com = new OleDbCommand("Update borrower SET status = 'Returned' where borrower_id=" + id, con);
                        com.ExecuteNonQuery();
                        MessageBox.Show("Book successfully returned!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loaddatagridview();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                    finally
                    {
                        if (con.State == ConnectionState.Open)
                            con.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a record to return.");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Reset the timer - it will fire if user stops typing for 500ms
            searchTimer.Stop();
            searchTimer.Start();
        }

        private void SearchTimer_Tick(object sender, EventArgs e)
        {
            searchTimer.Stop();
            PerformSearch();
        }

        private void PerformSearch()
        {
            try
            {
                if (con.State == ConnectionState.Open)
                    con.Close();

                con.Open();

                string query = "Select * from borrower where status = 'Borrowed' AND (";

                // Search bar filtering (by name)
                query += "name LIKE '%" + textBox1.Text + "%' ";
                query += "OR borrower_id LIKE '%" + textBox1.Text + "%' ";
                query += "OR contact LIKE '%" + textBox1.Text + "%' ";
                query += "OR course LIKE '%" + textBox1.Text + "%' ";
                query += "OR year_level LIKE '%" + textBox1.Text + "%' ";
                query += "OR book_borrowed LIKE '%" + textBox1.Text + "%' ";
                query += "OR date_borrowed LIKE '%" + textBox1.Text + "%' ";
                query += "OR date_due LIKE '%" + textBox1.Text + "%')";

                OleDbCommand com = new OleDbCommand(query, con);
                OleDbDataAdapter adap = new OleDbDataAdapter(com);
                DataTable dt = new DataTable();
                adap.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        private void booksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Books Books = new Books();
            this.Close();
            Books.Show();
        }

        private void borrowerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Borrower Borrower = new Borrower();
            this.Close();
            Borrower.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void transactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You're already on the page");
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports Reports = new Reports();
            this.Close();
            Reports.Show();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 Home = new Form2();
            this.Close();
            Home.Show();
        }
    }
}
