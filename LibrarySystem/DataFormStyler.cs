using System;
using System.Drawing;
using System.Windows.Forms;

namespace LibrarySystem
{
    /// <summary>
    /// Helper class to apply consistent styling to data management forms
    /// Implements the library theme with proper alignment and organization
    /// </summary>
    public static class DataFormStyler
    {
        /// <summary>
        /// Styles a complete data management form
        /// </summary>
        public static void StyleDataManagementForm(Form form, string title)
        {
            // Set form properties
            form.BackColor = ColorScheme.CreamWhite;
            form.Font = new Font("Segoe UI", 9F);
            form.ForeColor = ColorScheme.DarkText;

            // Create and add header
            Panel headerPanel = CreateHeaderPanel(title);
            form.Controls.Add(headerPanel);
            headerPanel.BringToFront();
        }

        /// <summary>
        /// Creates a properly styled header panel
        /// </summary>
        public static Panel CreateHeaderPanel(string title)
        {
            Panel headerPanel = new Panel();
            headerPanel.BackColor = ColorScheme.PrimaryDarkWood;
            headerPanel.Height = 70;
            headerPanel.Dock = DockStyle.Top;

            Label titleLabel = new Label();
            titleLabel.Text = title;
            titleLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            titleLabel.ForeColor = ColorScheme.AccentGolden;
            titleLabel.AutoSize = false;
            titleLabel.TextAlign = ContentAlignment.MiddleLeft;
            titleLabel.Padding = new Padding(30, 0, 0, 0);
            titleLabel.Dock = DockStyle.Fill;

            headerPanel.Controls.Add(titleLabel);
            return headerPanel;
        }

        /// <summary>
        /// Styles all buttons in a form
        /// </summary>
        public static void StyleFormButtons(Form form)
        {
            foreach (Control ctrl in GetAllControls(form))
            {
                if (ctrl is Button button)
                {
                    StyleFormButton(button);
                }
            }
        }

        /// <summary>
        /// Styles a single button
        /// </summary>
        private static void StyleFormButton(Button button)
        {
            // Determine button type by name
            bool isPrimary = button.Name.Contains("Save") || 
                           button.Name.Contains("Add") || 
                           button.Name.Contains("Update");

            button.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 1;
            button.Cursor = Cursors.Hand;
            button.Height = 36;

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
        /// Styles all text boxes in a form
        /// </summary>
        public static void StyleFormTextBoxes(Form form)
        {
            foreach (Control ctrl in GetAllControls(form))
            {
                if (ctrl is TextBox textBox)
                {
                    StyleFormTextBox(textBox);
                }
            }
        }

        /// <summary>
        /// Styles a single text box
        /// </summary>
        private static void StyleFormTextBox(TextBox textBox)
        {
            textBox.Font = new Font("Segoe UI", 11F);
            textBox.BackColor = ColorScheme.LightParchment;
            textBox.ForeColor = ColorScheme.DarkText;
            textBox.BorderStyle = BorderStyle.FixedSingle;
        }

        /// <summary>
        /// Styles all labels in a form
        /// </summary>
        public static void StyleFormLabels(Form form)
        {
            foreach (Control ctrl in GetAllControls(form))
            {
                if (ctrl is Label label)
                {
                    StyleFormLabel(label);
                }
            }
        }

        /// <summary>
        /// Styles a single label
        /// </summary>
        private static void StyleFormLabel(Label label)
        {
            label.Font = new Font("Segoe UI", 10F);
            label.ForeColor = ColorScheme.DarkText;
            label.AutoSize = true;
        }

        /// <summary>
        /// Styles all group boxes in a form
        /// </summary>
        public static void StyleFormGroupBoxes(Form form)
        {
            foreach (Control ctrl in GetAllControls(form))
            {
                if (ctrl is GroupBox groupBox)
                {
                    StyleFormGroupBox(groupBox);
                }
            }
        }

        /// <summary>
        /// Styles a single group box
        /// </summary>
        private static void StyleFormGroupBox(GroupBox groupBox)
        {
            groupBox.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBox.ForeColor = ColorScheme.PrimaryDarkWood;
            groupBox.BackColor = ColorScheme.CreamWhite;
        }

        /// <summary>
        /// Styles a data grid view
        /// </summary>
        public static void StyleFormDataGridView(DataGridView dgv)
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
            dgv.RowTemplate.Height = 28;
        }

        /// <summary>
        /// Recursive method to get all controls including those in containers
        /// </summary>
        private static System.Collections.Generic.IEnumerable<Control> GetAllControls(Control container)
        {
            foreach (Control control in container.Controls)
            {
                yield return control;
                foreach (Control subControl in GetAllControls(control))
                {
                    yield return subControl;
                }
            }
        }
    }
}
