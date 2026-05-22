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
    public partial class Form6 : Form
    {
        private OleDbConnection con;

        public Form6()
        {
            InitializeComponent();
            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"Z:\\ZZ209\\LibrarySystem\\New Library System\\LibSys.mdb\"");
        }

        private void loadAllTransactions()
        {
            con.Open();
            OleDbCommand com = new OleDbCommand(
                "SELECT t.trans_id, t.borrowerid, b.name, t.accession_number, bk.title, t.date_borrowed, t.date_return " +
                "FROM (transactions t " +
                "LEFT JOIN borrowerid b ON t.borrowerid = b.borrowerid) " +
                "LEFT JOIN book bk ON t.accession_number = bk.accession_number " +
                "ORDER BY t.trans_id", con);
            com.ExecuteNonQuery();

            OleDbDataAdapter adap = new OleDbDataAdapter(com);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void loadOverdue()
        {
            con.Open();
            string today = DateTime.Today.ToString("MM/dd/yyyy");
            OleDbCommand com = new OleDbCommand(
                "SELECT t.trans_id, t.borrowerid, b.name, t.accession_number, bk.title, t.date_borrowed, t.date_return " +
                "FROM (transactions t " +
                "LEFT JOIN borrowerid b ON t.borrowerid = b.borrowerid) " +
                "LEFT JOIN book bk ON t.accession_number = bk.accession_number " +
                "WHERE t.date_return < #" + today + "# " +
                "ORDER BY t.date_return", con);
            com.ExecuteNonQuery();

            OleDbDataAdapter adap = new OleDbDataAdapter(com);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            loadAllTransactions();
        }

        private void btnAllTransactions_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "All Transactions";
            loadAllTransactions();
        }

        private void btnOverdue_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Overdue Books";
            loadOverdue();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand com = new OleDbCommand(
                "SELECT t.trans_id, t.borrowerid, b.name, t.accession_number, bk.title, t.date_borrowed, t.date_return " +
                "FROM (transactions t " +
                "LEFT JOIN borrowerid b ON t.borrowerid = b.borrowerid) " +
                "LEFT JOIN book bk ON t.accession_number = bk.accession_number " +
                "WHERE b.name like '%" + txtSearch.Text + "%' OR bk.title like '%" + txtSearch.Text + "%' " +
                "ORDER BY t.trans_id", con);
            com.ExecuteNonQuery();

            OleDbDataAdapter adap = new OleDbDataAdapter(com);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
    }
}