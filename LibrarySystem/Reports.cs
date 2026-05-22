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
                query += " AND (name LIKE '%" + textBox1.Text + "%' ";
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
                sfd.Filter = "HTML Report (*.html)|*.html|PDF (*.pdf)|*.pdf";
                sfd.FileName = "LibraryReport.html";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        ExportToPDF(sfd.FileName);
                        MessageBox.Show("Report Exported Successfully!\n\nTo convert HTML to PDF, open the file in your web browser and use 'Print to PDF'.", "Success");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Export Failed");
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record To Export!", "Info");
            }
        }

        private void ExportToPDF(string filePath)
        {
            try
            {
                // Generate HTML content
                string htmlContent = GenerateHTMLReport();

                // Determine the file format based on extension
                if (filePath.EndsWith(".pdf", StringComparison.OrdinalIgnoreCase))
                {
                    // User selected PDF - save as HTML for now and inform user
                    filePath = filePath.Replace(".pdf", ".html");
                }

                // Save HTML file directly
                File.WriteAllText(filePath, htmlContent, Encoding.UTF8);

                MessageBox.Show("Report exported successfully to:\n\n" + filePath + 
                    "\n\nTo convert to PDF:\n1. Open the HTML file in your web browser\n2. Use Ctrl+P (Print)\n3. Select 'Save as PDF' and click Print", 
                    "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating report: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GenerateHTMLReport()
        {
            StringBuilder html = new StringBuilder();

            html.AppendLine("<!DOCTYPE html>");
            html.AppendLine("<html>");
            html.AppendLine("<head>");
            html.AppendLine("<meta charset=\"UTF-8\">");
            html.AppendLine("<title>Library Report</title>");
            html.AppendLine("<style>");
            html.AppendLine("body { font-family: Arial, sans-serif; margin: 20px; }");
            html.AppendLine(".header { background-color: #14213d; color: white; padding: 15px; text-align: center; }");
            html.AppendLine(".header-title { font-size: 18px; font-weight: bold; }");
            html.AppendLine(".header-subtitle { font-size: 12px; color: #b8860b; margin-top: 5px; }");
            html.AppendLine(".separator { background-color: #b8860b; height: 15px; margin: 10px 0; }");
            html.AppendLine(".title { text-align: center; font-size: 20px; font-weight: bold; margin: 20px 0 5px 0; }");
            html.AppendLine(".subtitle { text-align: center; font-size: 12px; color: #666; margin-bottom: 10px; }");
            html.AppendLine(".underline { border-top: 2px solid #b8860b; margin: 15px 0; }");
            html.AppendLine(".info-row { display: flex; justify-content: space-between; margin: 10px 0; font-size: 11px; }");
            html.AppendLine(".section-title { font-size: 12px; font-weight: bold; margin: 20px 0 10px 0; }");
            html.AppendLine("table { width: 100%; border-collapse: collapse; margin: 20px 0; font-size: 10px; }");
            html.AppendLine("th { background-color: #14213d; color: white; padding: 8px; text-align: center; border: 1px solid #ddd; }");
            html.AppendLine("td { padding: 8px; border: 1px solid #ddd; text-align: center; }");
            html.AppendLine("tr:nth-child(even) { background-color: #f9f9f9; }");
            html.AppendLine(".status-borrowed { background-color: #ffc8c8; }");
            html.AppendLine(".status-returned { background-color: #c8ffc8; }");
            html.AppendLine(".summary { display: flex; justify-content: space-between; margin: 20px 0; }");
            html.AppendLine(".summary-box { flex: 1; padding: 20px; margin: 0 10px; text-align: center; border: 1px solid #ddd; }");
            html.AppendLine(".summary-box.total { background-color: #e0e0e0; }");
            html.AppendLine(".summary-box.returned { background-color: #c8ffc8; }");
            html.AppendLine(".summary-box.borrowed { background-color: #ffc8c8; }");
            html.AppendLine(".summary-number { font-size: 24px; font-weight: bold; margin-bottom: 5px; }");
            html.AppendLine(".summary-label { font-size: 11px; }");
            html.AppendLine(".signatures { display: flex; justify-content: space-around; margin: 40px 0; }");
            html.AppendLine(".signature { text-align: center; }");
            html.AppendLine(".signature-line { border-top: 1px solid #000; width: 150px; margin: 20px auto 5px; }");
            html.AppendLine(".signature-name { font-size: 9px; }");
            html.AppendLine(".footer { text-align: center; font-size: 8px; color: #999; margin-top: 30px; }");
            html.AppendLine("@media print { body { margin: 0; padding: 10px; } }");
            html.AppendLine("</style>");
            html.AppendLine("</head>");
            html.AppendLine("<body>");

            // Header
            html.AppendLine("<div class=\"header\">");
            html.AppendLine("<div class=\"header-title\">UNIVERSITY OF CEBU – MAIN CAMPUS</div>");
            html.AppendLine("<div class=\"header-subtitle\">Sanciangko St. Cebu City, 6000 Cebu, Philippines</div>");
            html.AppendLine("</div>");
            html.AppendLine("<div class=\"separator\"></div>");

            // Title
            html.AppendLine("<div class=\"title\">LIBRARY REPORTS</div>");
            html.AppendLine("<div class=\"subtitle\">Book Borrowing & Return Records</div>");
            html.AppendLine("<div class=\"underline\"></div>");

            // Report Info
            html.AppendLine("<div class=\"info-row\">");
            html.AppendLine("<span>Report Type: Library Borrowing Summary</span>");
            html.AppendLine("<span>Academic Year: 2025-2026</span>");
            html.AppendLine("</div>");

            // Borrowing Records
            html.AppendLine("<div class=\"section-title\">BORROWING RECORDS</div>");
            html.AppendLine("<table>");
            html.AppendLine("<thead><tr>");

            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                html.AppendLine("<th>" + dataGridView1.Columns[i].HeaderText + "</th>");
            }

            html.AppendLine("</tr></thead>");
            html.AppendLine("<tbody>");

            int borrowedCount = 0;
            int returnedCount = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    string status = row.Cells[dataGridView1.Columns.Count - 1].Value?.ToString() ?? "";
                    string rowClass = "";

                    if (status.Equals("Borrowed", StringComparison.OrdinalIgnoreCase))
                    {
                        rowClass = "status-borrowed";
                        borrowedCount++;
                    }
                    else if (status.Equals("Returned", StringComparison.OrdinalIgnoreCase))
                    {
                        rowClass = "status-returned";
                        returnedCount++;
                    }

                    html.AppendLine("<tr class=\"" + rowClass + "\">");

                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        object cellValue = row.Cells[j].Value;
                        string cellText = cellValue != null ? cellValue.ToString() : "";
                        cellText = cellText.Replace("<", "&lt;").Replace(">", "&gt;").Replace("&", "&amp;");
                        html.AppendLine("<td>" + cellText + "</td>");
                    }

                    html.AppendLine("</tr>");
                }
            }

            html.AppendLine("</tbody>");
            html.AppendLine("</table>");

            // Summary
            html.AppendLine("<div class=\"section-title\">SUMMARY</div>");
            html.AppendLine("<div class=\"summary\">");

            int totalRecords = dataGridView1.Rows.Cast<DataGridViewRow>().Where(r => !r.IsNewRow).Count();

            html.AppendLine("<div class=\"summary-box total\">");
            html.AppendLine("<div class=\"summary-number\">" + totalRecords + "</div>");
            html.AppendLine("<div class=\"summary-label\">Total Records</div>");
            html.AppendLine("</div>");

            html.AppendLine("<div class=\"summary-box returned\">");
            html.AppendLine("<div class=\"summary-number\">" + returnedCount + "</div>");
            html.AppendLine("<div class=\"summary-label\">Returned</div>");
            html.AppendLine("</div>");

            html.AppendLine("<div class=\"summary-box borrowed\">");
            html.AppendLine("<div class=\"summary-number\">" + borrowedCount + "</div>");
            html.AppendLine("<div class=\"summary-label\">Currently Borrowed</div>");
            html.AppendLine("</div>");

            html.AppendLine("</div>");

            // Signatures
            html.AppendLine("<div class=\"signatures\">");
            html.AppendLine("<div class=\"signature\">");
            html.AppendLine("<div class=\"signature-line\"></div>");
            html.AppendLine("<div class=\"signature-name\">Library Staff on Duty</div>");
            html.AppendLine("</div>");
            html.AppendLine("<div class=\"signature\">");
            html.AppendLine("<div class=\"signature-line\"></div>");
            html.AppendLine("<div class=\"signature-name\">Library Head / Officer-in-Charge</div>");
            html.AppendLine("</div>");
            html.AppendLine("<div class=\"signature\">");
            html.AppendLine("<div class=\"signature-line\"></div>");
            html.AppendLine("<div class=\"signature-name\">Campus Director / Authorized Rep.</div>");
            html.AppendLine("</div>");
            html.AppendLine("</div>");

            // Footer
            html.AppendLine("<div class=\"footer\">");
            html.AppendLine("Generated on " + DateTime.Now.ToString("MMM dd, yyyy at hh:mm tt") + " | University of Cebu - Main Campus Library | Confidential Document");
            html.AppendLine("</div>");

            html.AppendLine("</body>");
            html.AppendLine("</html>");

            return html.ToString();
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
