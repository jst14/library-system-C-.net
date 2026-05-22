using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class Form5 : Form
    {
        private OleDbConnection con;

        public Form5()
        {
            InitializeComponent();
            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"Z:\\ZZ209\\LibrarySystem\\New Library System\\LibSys.mdb\"");
        }

        // AUTO-CREATES the transactions table if it does not exist yet
        private void createTableIfNotExists()
        {
            con.Open();
            try
            {
                OleDbCommand com = new OleDbCommand(
                    "CREATE TABLE transactions (" +
                    "trans_id TEXT(50), " +
                    "borrowerid TEXT(50), " +
                    "accession_number TEXT(50), " +
                    "date_borrowed DATETIME, " +
                    "date_return DATETIME)", con);
                com.ExecuteNonQuery();
                MessageBox.Show("Transactions table created successfully!", "Setup", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                // Table already exists — do nothing
            }
            finally
            {
                con.Close();
            }
        }

        private void loaddatagridview()
        {
            con.Open();
            OleDbCommand com = new OleDbCommand("Select * from transactions order by trans_id", con);
            com.ExecuteNonQuery();

            OleDbDataAdapter adap = new OleDbDataAdapter(com);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            createTableIfNotExists(); // Creates table automatically on first run
            loaddatagridview();
            dtpDateBorrowed.Value = DateTime.Today;
            dtpDateReturn.Value = DateTime.Today.AddDays(7);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand com = new OleDbCommand("Select * from transactions where borrowerid like '%" + txtSearch.Text + "%'", con);
            com.ExecuteNonQuery();

            OleDbDataAdapter adap = new OleDbDataAdapter(com);
            DataTable tab = new DataTable();
            adap.Fill(tab);
            dataGridView1.DataSource = tab;
            con.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand com = new OleDbCommand(
                "insert into transactions values('" + txtTransID.Text + "','"
                + txtBorrowerID.Text + "','" + txtAccessionNum.Text + "',#"
                + dtpDateBorrowed.Value.ToString("MM/dd/yyyy") + "#,#"
                + dtpDateReturn.Value.ToString("MM/dd/yyyy") + "#)", con);
            com.ExecuteNonQuery();

            MessageBox.Show("Successfully SAVED!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();
            loaddatagridview();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand com = new OleDbCommand(
                "insert into transactions values('" + txtTransID.Text + "','"
                + txtBorrowerID.Text + "','" + txtAccessionNum.Text + "',#"
                + dtpDateBorrowed.Value.ToString("MM/dd/yyyy") + "#,#"
                + dtpDateReturn.Value.ToString("MM/dd/yyyy") + "#)", con);
            com.ExecuteNonQuery();

            MessageBox.Show("Successfully SAVED!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();
            loaddatagridview();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            con.Open();
            string id = txtTransID.Text;

            DialogResult dr = MessageBox.Show("Are you sure you want to delete this?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                OleDbCommand com = new OleDbCommand("Delete from transactions where trans_id='" + id + "'", con);
                com.ExecuteNonQuery();
                MessageBox.Show("Successfully DELETED!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("CANCELLED!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            con.Close();
            loaddatagridview();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            con.Open();
            string id = txtTransID.Text;

            OleDbCommand com = new OleDbCommand(
                "Update transactions SET borrowerid='" + txtBorrowerID.Text
                + "', accession_number='" + txtAccessionNum.Text
                + "', date_borrowed=#" + dtpDateBorrowed.Value.ToString("MM/dd/yyyy")
                + "#, date_return=#" + dtpDateReturn.Value.ToString("MM/dd/yyyy")
                + "# where trans_id='" + id + "'", con);
            com.ExecuteNonQuery();

            MessageBox.Show("Successfully UPDATED!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();
            loaddatagridview();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTransID.Text = dataGridView1.Rows[e.RowIndex].Cells["trans_id"].Value.ToString();
            txtBorrowerID.Text = dataGridView1.Rows[e.RowIndex].Cells["borrowerid"].Value.ToString();
            txtAccessionNum.Text = dataGridView1.Rows[e.RowIndex].Cells["accession_number"].Value.ToString();
            dtpDateBorrowed.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["date_borrowed"].Value);
            dtpDateReturn.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["date_return"].Value);
        }
    }
}