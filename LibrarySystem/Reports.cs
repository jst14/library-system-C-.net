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
using System.IO;

namespace LibrarySystem
{
    public partial class Reports : Form
    {
        private OleDbConnection con;
        public Reports()
        {
            InitializeComponent();
            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"C:\\Users\\John Simon\\Documents\\Visual Studio 2022\\Library System\\LibrarySystem\\LibSys.mdb\"");
        }

        private void loaddatagridview()
        {
            try
            {
                con.Open();
                OleDbCommand com = new OleDbCommand("Select * from borrower", con);
                OleDbDataAdapter adap = new OleDbDataAdapter(com);
                DataTable dt = new DataTable();
                adap.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                if (con.State == ConnectionState.Open) con.Close();
            }
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            loaddatagridview();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                // Select all records, then filter by date and name
                string query = "Select * from borrower where 1=1";
                
                // Date filtering (using date_borrowed)
                query += " and date_borrowed between '" + dateTimePicker1.Text + "' and '" + dateTimePicker2.Text + "'";

                // Search bar filtering (by name)
                query += "AND (name LIKE '%" + textBox1.Text + "%' ";
                query += "OR borrower_id LIKE '%" + textBox1.Text + "%' ";
                query += "OR contact LIKE '%" + textBox1.Text + "%' ";
                query += "OR course LIKE '%" + textBox1.Text + "%' ";
                query += "OR year_level LIKE '%" + textBox1.Text + "%' ";
                query += "OR book_borrowed LIKE '%" + textBox1.Text + "%' ";
                query += "OR date_borrowed LIKE '%" + textBox1.Text + "%' ";
                query += "OR date_due LIKE '%" + textBox1.Text + "%') ";


                OleDbCommand com = new OleDbCommand(query, con);
                OleDbDataAdapter adap = new OleDbDataAdapter(com);
                DataTable dt = new DataTable();
                adap.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                if (con.State == ConnectionState.Open) con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV (*.csv)|*.csv";
                sfd.FileName = "LibraryReport.csv";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            int columnCount = dataGridView1.Columns.Count;
                            string columnNames = "";
                            
                            // Check if the last row is the 'new row' which is usually blank
                            int rowCount = dataGridView1.Rows.Count;
                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                if (row.IsNewRow) rowCount--;
                            }

                            string[] outputCsv = new string[rowCount + 1];
                            for (int i = 0; i < columnCount; i++)
                            {
                                columnNames += dataGridView1.Columns[i].HeaderText.ToString() + ",";
                            }
                            outputCsv[0] = columnNames;

                            for (int i = 1; (i - 1) < rowCount; i++)
                            {
                                for (int j = 0; j < columnCount; j++)
                                {
                                    object cellValue = dataGridView1.Rows[i - 1].Cells[j].Value;
                                    string cellText = cellValue != null ? cellValue.ToString() : "";
                                    // Remove commas from content to avoid breaking CSV structure
                                    cellText = cellText.Replace(",", ";"); 
                                    outputCsv[i] += cellText + ",";
                                }
                            }

                            File.WriteAllLines(sfd.FileName, outputCsv, Encoding.UTF8);
                            MessageBox.Show("Data Exported Successfully!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record To Export!", "Info");
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

        private void transactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Transactions Transactions = new Transactions();
            this.Close();
            Transactions.Show();
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You're already on the page");
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 Home = new Form2();
            this.Close();
            Home.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
