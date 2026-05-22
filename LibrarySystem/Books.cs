using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb; // ADD 1


namespace LibrarySystem
{
    public partial class Books : Form
    {
        private OleDbConnection con; // ADD 2
        public Books()
        {
            InitializeComponent();
            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"C:\\Users\\John Simon\\Documents\\Visual Studio 2022\\Library System\\LibrarySystem\\LibSys.mdb\"");
        }

        // ADD 3
        private void loaddatagridview()
        {
            try
            {
                if (con.State == ConnectionState.Open)
                    con.Close();

                con.Open();
                OleDbCommand com = new OleDbCommand("Select* from book order by accession_number", con);

                OleDbDataAdapter adap = new OleDbDataAdapter(com);
                DataTable dt = new DataTable();
                adap.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        private void SetFieldsEnabled(bool enabled)
        {
            txtBookID.Enabled = enabled;
            txtTitle.Enabled = enabled;
            txtAuthor.Enabled = enabled;
        }

        private void SetButtonStates(bool listEnabled, bool updateEnabled)
        {
            Savebtn.Enabled = listEnabled;
            btnUpdate.Enabled = updateEnabled;
        }

        private void ClearFields()
        {
            txtBookID.Clear();
            txtTitle.Clear();
            txtAuthor.Clear();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Open)
                    con.Close();

                con.Open();
                OleDbCommand com = new OleDbCommand(
                    "SELECT * FROM book WHERE title LIKE @q OR author LIKE @q OR accession_number LIKE @q", con);

                com.Parameters.AddWithValue("@q", "%" + txtSearch.Text + "%");

                OleDbDataAdapter adap = new OleDbDataAdapter(com);
                DataTable tab = new DataTable();

                adap.Fill(tab);

                dataGridView1.DataSource = tab;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching records: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        private void Books_Load(object sender, EventArgs e)
        {
            loaddatagridview();
            SetFieldsEnabled(false);
            SetButtonStates(false, false);

            // Apply theme styling
            ApplyThemeStyling();
        }

        private void ApplyThemeStyling()
        {
            // Style text boxes
            UIHelper.StyleTextBox(txtBookID);
            UIHelper.StyleTextBox(txtTitle);
            UIHelper.StyleTextBox(txtAuthor);
            UIHelper.StyleTextBox(txtSearch);

            // Style labels
            UIHelper.StyleLabel(label1);
            UIHelper.StyleLabel(label2);
            UIHelper.StyleLabel(label3);
            UIHelper.StyleLabel(label4);

            // Style buttons
            UIHelper.StyleButton(btnAdd);
            UIHelper.StyleButton(btnEdit);
            UIHelper.StyleButton(btnDelete);
            UIHelper.StyleButton(Savebtn);
            UIHelper.StyleButton(btnUpdate);

            // Style group boxes
            UIHelper.StyleGroupBox(groupBox1);
            UIHelper.StyleGroupBox(groupBox2);

            // Style data grid view
            UIHelper.StyleDataGridView(dataGridView1);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ClearFields();
            SetFieldsEnabled(true);
            SetButtonStates(true, false);
            txtBookID.Focus();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtBookID.Text = dataGridView1.Rows[e.RowIndex].Cells["accession_number"].Value.ToString();
                txtTitle.Text = dataGridView1.Rows[e.RowIndex].Cells["title"].Value.ToString();
                txtAuthor.Text = dataGridView1.Rows[e.RowIndex].Cells["author"].Value.ToString();
                SetFieldsEnabled(false);
                SetButtonStates(false, false);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBookID.Text))
            {
                MessageBox.Show("Please select a book to delete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (con.State == ConnectionState.Open)
                    con.Close();

                con.Open();
                string num = txtBookID.Text;

                DialogResult dr = MessageBox.Show("Are you sure you want to delete this?", "Confirm deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    OleDbCommand com = new OleDbCommand("Delete from book where accession_number='" + num + "'", con);
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBookID.Text) || 
                string.IsNullOrWhiteSpace(txtTitle.Text) || 
                string.IsNullOrWhiteSpace(txtAuthor.Text))
            {
                MessageBox.Show("Please fill in all fields before proceeding.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (con.State == ConnectionState.Open)
                    con.Close();

                con.Open();
                string no = txtBookID.Text;

                OleDbCommand com = new OleDbCommand("Update book SET title='" + txtTitle.Text + "', author='" +
                    txtAuthor.Text + "'where accession_number='" + no + "'", con);
                com.ExecuteNonQuery();

                MessageBox.Show("Successfully UPDATED!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnList_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBookID.Text) || 
                string.IsNullOrWhiteSpace(txtTitle.Text) || 
                string.IsNullOrWhiteSpace(txtAuthor.Text))
            {
                MessageBox.Show("Please fill in all fields before proceeding.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (con.State == ConnectionState.Open)
                    con.Close();

                con.Open();
                OleDbCommand com = new OleDbCommand("insert into book values('" + txtBookID.Text + "','"
                    + txtTitle.Text + "','" + txtAuthor.Text + "')", con);
                com.ExecuteNonQuery();

                MessageBox.Show("Successfully SAVED!", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void booksToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            MessageBox.Show("You're already on the page");
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBookID.Text))
            {
                MessageBox.Show("Please select a book to edit.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            SetFieldsEnabled(true);
            txtBookID.Enabled = false; // Don't allow editing the ID (accession number)
            SetButtonStates(false, true);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
