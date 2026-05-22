using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb; // ADD 1
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


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
            con.Open();
            OleDbCommand com = new OleDbCommand("Select* from book order by accession_number", con);
            com.ExecuteNonQuery();

            OleDbDataAdapter adap = new OleDbDataAdapter(com);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand com = new OleDbCommand("Select * from book where title '%" + txtSearch.Text + "%'", con);
            com.ExecuteNonQuery();

            OleDbDataAdapter adap = new OleDbDataAdapter(com);
            DataTable tab = new DataTable();

            adap.Fill(tab);

            dataGridView1.DataSource = tab;

            con.Close();
        }

        private void Books_Load(object sender, EventArgs e)
        {
            loaddatagridview();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand com = new OleDbCommand("insert into book values('" + txtBookID.Text + "','"
                + txtTitle.Text + "','" + txtAuthor.Text + "')", con);
            com.ExecuteNonQuery();

            MessageBox.Show("Successfully SAVED!", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            con.Close();

            loaddatagridview();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBookID.Text = dataGridView1.Rows[e.RowIndex].Cells["accession_number"].Value.ToString();
            txtTitle.Text = dataGridView1.Rows[e.RowIndex].Cells["title"].Value.ToString();
            txtAuthor.Text = dataGridView1.Rows[e.RowIndex].Cells["author"].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            con.Open();
            string num = txtBookID.Text;

            DialogResult dr = MessageBox.Show("Are you sure you want to delete this?", "Confirm deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                OleDbCommand com = new OleDbCommand("Delete from book where accession_number='" + num + "'", con);
                com.ExecuteNonQuery();

                MessageBox.Show("Successfully DELETED!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("CANCELLED!", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            con.Close();
            loaddatagridview();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            con.Open();
            string no;
            no = txtBookID.Text;

            OleDbCommand com = new OleDbCommand("Update book SET title='" + txtTitle.Text + "', author='" +
                txtAuthor.Text + "'where accession_number='" + no + "'", con);
            com.ExecuteNonQuery();

            MessageBox.Show("Successfully UPDATED!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();

            loaddatagridview();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand com = new OleDbCommand("insert into book values('" + txtBookID.Text +
            txtTitle.Text + "','" + txtAuthor.Text + "')", con);
            com.ExecuteNonQuery();
            MessageBox.Show("Successfully SAVED!", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();
            loaddatagridview();
        }
    }
}
            
    

