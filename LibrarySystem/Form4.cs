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
    public partial class Form4 : Form
    {
        private OleDbConnection con;

        public Form4()
        {
            InitializeComponent();
            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"C:\\Users\\John Simon\\Documents\\Visual Studio 2022\\Library System\\LibrarySystem\\LibSys.mdb\"");
        }

        private void loaddatagridview()
        {
            con.Open();
            OleDbCommand com = new OleDbCommand("Select * from borrowerid order by borrowerid", con);
            com.ExecuteNonQuery();

            OleDbDataAdapter adap = new OleDbDataAdapter(com);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            loaddatagridview();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand com = new OleDbCommand("Select * from borrowerid where name like '%" + txtName.Text + "%'", con);
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
            OleDbCommand com = new OleDbCommand("insert into borrowerid values('" + txtBorrowerID.Text + "','"
                + txtName.Text + "','" + txtContactNum.Text + "')", con);
            com.ExecuteNonQuery();

            MessageBox.Show("Successfully SAVED!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            con.Close();
            loaddatagridview();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand com = new OleDbCommand("insert into borrowerid values('" + txtBorrowerID.Text + "','"
                + txtName.Text + "','" + txtContactNum.Text + "')", con);
            com.ExecuteNonQuery();

            MessageBox.Show("Successfully SAVED!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            con.Close();
            loaddatagridview();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            con.Open();
            string id = txtBorrowerID.Text;

            DialogResult dr = MessageBox.Show("Are you sure you want to delete this?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                OleDbCommand com = new OleDbCommand("Delete from borrowerid where borrowerid='" + id + "'", con);
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
            string id = txtBorrowerID.Text;

            OleDbCommand com = new OleDbCommand("Update borrowerid SET name='" + txtName.Text + "', contactNum='" +
                txtContactNum.Text + "' where borrowerid='" + id + "'", con);
            com.ExecuteNonQuery();

            MessageBox.Show("Successfully UPDATED!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            con.Close();
            loaddatagridview();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBorrowerID.Text = dataGridView1.Rows[e.RowIndex].Cells["borrowerid"].Value.ToString();
            txtName.Text = dataGridView1.Rows[e.RowIndex].Cells["name"].Value.ToString();
            txtContactNum.Text = dataGridView1.Rows[e.RowIndex].Cells["contactNum"].Value.ToString();
        }
    }
}