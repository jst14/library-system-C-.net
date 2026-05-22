using System;
using System.Drawing;
using System.Windows.Forms;

namespace LibrarySystem
{
    /// <summary>
    /// UI Helper for consistent styling across the application
    /// </summary>
    public static class UIHelper
    {
        /// <summary>
        /// Styles a button with library theme
        /// </summary>
        public static void StyleButton(Button button, bool isPrimary = true)
        {
            button.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 1;
            button.Cursor = Cursors.Hand;
            button.Height = 36;
            button.TextAlign = ContentAlignment.MiddleCenter;

            if (isPrimary)
            {
                button.BackColor = ColorScheme.PrimaryWood;
                button.ForeColor = ColorScheme.CreamWhite;
                button.FlatAppearance.BorderColor = ColorScheme.BrandBorder;
                button.FlatAppearance.MouseOverBackColor = ColorScheme.AccentGolden;
            }
            else
            {
                button.BackColor = ColorScheme.CreamWhite;
                button.ForeColor = ColorScheme.DarkText;
                button.FlatAppearance.BorderColor = ColorScheme.SoftBorder;
                button.FlatAppearance.MouseOverBackColor = Color.FromArgb(235, 225, 210);
            }
        }

        /// <summary>
        /// Styles a text box with library theme
        /// </summary>
        public static void StyleTextBox(TextBox textBox, bool multiLine = false)
        {
            textBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular);
            textBox.BackColor = ColorScheme.LightParchment;
            textBox.ForeColor = ColorScheme.DarkText;
            textBox.BorderStyle = BorderStyle.None;
            textBox.Multiline = multiLine;
            if (!multiLine)
                textBox.Height = 32;
        }

        /// <summary>
        /// Styles a label with library theme
        /// </summary>
        public static void StyleLabel(Label label, bool isTitle = false)
        {
            if (isTitle)
            {
                label.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
                label.ForeColor = ColorScheme.PrimaryDarkWood;
            }
            else
            {
                label.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
                label.ForeColor = ColorScheme.DarkText;
            }
            label.AutoSize = true;
        }

        /// <summary>
        /// Styles a group box with library theme
        /// </summary>
        public static void StyleGroupBox(GroupBox groupBox)
        {
            groupBox.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBox.ForeColor = ColorScheme.PrimaryDarkWood;
            groupBox.BackColor = ColorScheme.CreamWhite;
        }

        /// <summary>
        /// Styles a data grid view with library theme
        /// </summary>
        public static void StyleDataGridView(DataGridView dgv)
        {
            dgv.BackgroundColor = ColorScheme.LightParchment;
            dgv.GridColor = ColorScheme.SoftBorder;
            dgv.DefaultCellStyle.BackColor = ColorScheme.CreamWhite;
            dgv.DefaultCellStyle.ForeColor = ColorScheme.DarkText;
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 10F);
            dgv.DefaultCellStyle.Padding = new Padding(5);
            dgv.ColumnHeadersDefaultCellStyle.BackColor = ColorScheme.PrimaryWood;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = ColorScheme.CreamWhite;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(252, 250, 247);
            dgv.RowHeadersDefaultCellStyle.BackColor = ColorScheme.VintageGreen;
            dgv.RowHeadersDefaultCellStyle.ForeColor = ColorScheme.CreamWhite;
            dgv.AllowUserToResizeColumns = true;
            dgv.AllowUserToResizeRows = false;
            dgv.RowTemplate.Height = 28;
        }

        /// <summary>
        /// Styles a form with library theme background
        /// </summary>
        public static void StyleForm(Form form, bool includeHeader = true)
        {
            form.BackColor = ColorScheme.CreamWhite;
            form.Font = new Font("Segoe UI", 9F);
            form.ForeColor = ColorScheme.DarkText;

            if (includeHeader)
            {
                form.Padding = new Padding(0);
            }
        }

        /// <summary>
        /// Creates a header panel for forms
        /// </summary>
        public static Panel CreateHeaderPanel(string title)
        {
            Panel headerPanel = new Panel();
            headerPanel.BackColor = ColorScheme.PrimaryDarkWood;
            headerPanel.Height = 60;
            headerPanel.Dock = DockStyle.Top;

            Label titleLabel = new Label();
            titleLabel.Text = title;
            titleLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            titleLabel.ForeColor = ColorScheme.AccentGolden;
            titleLabel.AutoSize = false;
            titleLabel.TextAlign = ContentAlignment.MiddleLeft;
            titleLabel.Padding = new Padding(20, 0, 0, 0);
            titleLabel.Dock = DockStyle.Fill;

            headerPanel.Controls.Add(titleLabel);
            return headerPanel;
        }

        /// <summary>
        /// Adds visual separation between sections
        /// </summary>
        public static Panel CreateSeparator()
        {
            Panel separator = new Panel();
            separator.BackColor = ColorScheme.SoftBorder;
            separator.Height = 1;
            separator.Dock = DockStyle.Top;
            separator.Margin = new Padding(0, 10, 0, 10);
            return separator;
        }

        /// <summary>
        /// Styles a menu strip with library theme
        /// </summary>
        public static void StyleMenuStrip(MenuStrip menuStrip)
        {
            menuStrip.BackColor = ColorScheme.PrimaryDarkWood;
            menuStrip.ForeColor = ColorScheme.CreamWhite;
            menuStrip.Font = new Font("Segoe UI", 10F);

            foreach (ToolStripItem item in menuStrip.Items)
            {
                if (item is ToolStripMenuItem)
                {
                    item.ForeColor = ColorScheme.CreamWhite;
                }
            }
        }
    }
}
