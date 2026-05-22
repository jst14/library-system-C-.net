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
    public partial class Borrower : Form
    {
        private OleDbConnection con;
        private Timer searchTimer;

        public Borrower()
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

        private void loadBooks()
        {
            try
            {
                if (con.State == ConnectionState.Open)
                    con.Close();

                con.Open();
                OleDbCommand com = new OleDbCommand("Select title from book", con);
                OleDbDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    ChooseBooktxtbox.Items.Add(reader["title"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading books: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        private void SetFieldsEnabled(bool enabled)
        {
            BorrowerNametxtbox.Enabled = enabled;
            ContactNotxtbox.Enabled = enabled;
            CoursecomboBox.Enabled = enabled;
            YearLvlcomboBox.Enabled = enabled;
            ChooseBooktxtbox.Enabled = enabled;
            DateBorrowedPicker.Enabled = enabled;
            DateDuePicker.Enabled = enabled;
        }

        private void SetButtonStates(bool saveEnabled, bool updateEnabled)
        {
            btnSave.Enabled = saveEnabled;
            btnUpdate.Enabled = updateEnabled;
            btnEdit.Enabled = !saveEnabled && !updateEnabled && !string.IsNullOrEmpty(BorrowerIDtxtbox.Text);
            btnAdd.Enabled = !saveEnabled && !updateEnabled;
        }

        private void ClearFields()
        {
            BorrowerIDtxtbox.Clear();
            BorrowerNametxtbox.Clear();
            ContactNotxtbox.Clear();
            CoursecomboBox.SelectedIndex = -1;
            YearLvlcomboBox.SelectedIndex = -1;
            ChooseBooktxtbox.SelectedIndex = -1;
            DateBorrowedPicker.Value = DateTime.Now;
            DateDuePicker.Value = DateTime.Now;
        }

        private void Borrower_Load(object sender, EventArgs e)
        {
            loaddatagridview();
            loadBooks();
            BorrowerIDtxtbox.ReadOnly = true;
            SetFieldsEnabled(false);
            SetButtonStates(false, false);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ClearFields();
            SetFieldsEnabled(true);
            SetButtonStates(true, false);
            BorrowerNametxtbox.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(BorrowerNametxtbox.Text) ||
                string.IsNullOrWhiteSpace(ContactNotxtbox.Text) ||
                string.IsNullOrWhiteSpace(CoursecomboBox.Text) ||
                string.IsNullOrWhiteSpace(YearLvlcomboBox.Text) ||
                string.IsNullOrWhiteSpace(ChooseBooktxtbox.Text))
            {
                MessageBox.Show("Please fill in all fields before proceeding.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (con.State == ConnectionState.Open)
                    con.Close();

                con.Open();
                OleDbCommand com = new OleDbCommand("insert into borrower ([name], contact, course, year_level, book_borrowed, date_borrowed, date_due, status) values('" +
                    BorrowerNametxtbox.Text + "','" +
                    ContactNotxtbox.Text + "','" +
                    CoursecomboBox.Text + "','" +
                    YearLvlcomboBox.Text + "','" +
                    ChooseBooktxtbox.Text + "','" +
                    DateBorrowedPicker.Value.ToString("yyyy-MM-dd") + "','" +
                    DateDuePicker.Value.ToString("yyyy-MM-dd") + "', 'Borrowed')", con);
                com.ExecuteNonQuery();
                MessageBox.Show("Successfully BORROWED!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            loaddatagridview();
            ClearFields();
            SetFieldsEnabled(false);
            SetButtonStates(false, false);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(BorrowerIDtxtbox.Text))
            {
                MessageBox.Show("Please select a borrower record to edit.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            SetFieldsEnabled(true);
            BorrowerIDtxtbox.Enabled = false;
            SetButtonStates(false, true);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(BorrowerNametxtbox.Text) ||
                string.IsNullOrWhiteSpace(ContactNotxtbox.Text) ||
                string.IsNullOrWhiteSpace(CoursecomboBox.Text) ||
                string.IsNullOrWhiteSpace(YearLvlcomboBox.Text) ||
                string.IsNullOrWhiteSpace(ChooseBooktxtbox.Text))
            {
                MessageBox.Show("Please fill in all fields before proceeding.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (con.State == ConnectionState.Open)
                    con.Close();

                con.Open();
                OleDbCommand com = new OleDbCommand("update borrower set [name]='" + BorrowerNametxtbox.Text +
                    "', contact='" + ContactNotxtbox.Text +
                    "', course='" + CoursecomboBox.Text +
                    "', year_level='" + YearLvlcomboBox.Text +
                    "', book_borrowed='" + ChooseBooktxtbox.Text +
                    "', date_borrowed='" + DateBorrowedPicker.Value.ToString("yyyy-MM-dd") +
                    "', date_due='" + DateDuePicker.Value.ToString("yyyy-MM-dd") +
                    "' where borrower_id=" + BorrowerIDtxtbox.Text, con);
                com.ExecuteNonQuery();
                MessageBox.Show("Successfully UPDATED!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            loaddatagridview();
            ClearFields();
            SetFieldsEnabled(false);
            SetButtonStates(false, false);
        }



        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(BorrowerIDtxtbox.Text))
            {
                MessageBox.Show("Please select a borrower to delete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (con.State == ConnectionState.Open)
                    con.Close();

                con.Open();
                string borrowerID = BorrowerIDtxtbox.Text;

                DialogResult dr = MessageBox.Show("Are you sure you want to delete this?", "Confirm deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    OleDbCommand com = new OleDbCommand("Delete from borrower where borrower_id=" + borrowerID, con);
                    com.ExecuteNonQuery();

                    MessageBox.Show("Successfully DELETED!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("CANCELLED!", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
            loaddatagridview();
            SetFieldsEnabled(false);
            SetButtonStates(false, false);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                BorrowerIDtxtbox.Text = row.Cells["borrower_id"].Value.ToString();
                BorrowerNametxtbox.Text = row.Cells["name"].Value.ToString();
                ContactNotxtbox.Text = row.Cells["contact"].Value.ToString();
                CoursecomboBox.Text = row.Cells["course"].Value.ToString();
                YearLvlcomboBox.Text = row.Cells["year_level"].Value.ToString();
                ChooseBooktxtbox.Text = row.Cells["book_borrowed"].Value.ToString();
                DateBorrowedPicker.Text = row.Cells["date_borrowed"].Value.ToString();
                DateDuePicker.Text = row.Cells["date_due"].Value.ToString();
                SetFieldsEnabled(false);
                SetButtonStates(false, false);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 Home = new Form2();
            this.Close();
            Home.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}