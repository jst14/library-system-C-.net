# LIBRARY SYSTEM - UI QUICK REFERENCE

## ?? COLOR QUICK PICK

### Main Colors (Copy-Paste Ready)
```
Header Bg:        Color.FromArgb(58, 45, 32)      // Dark Wood
Button Bg:        Color.FromArgb(120, 81, 44)     // Medium Wood
Accent/Hover:     Color.FromArgb(184, 134, 11)    // Golden
Form Bg:          Color.FromArgb(245, 243, 237)   // Cream
Input Bg:         Color.FromArgb(250, 248, 245)   // Parchment
Text:             Color.FromArgb(40, 30, 20)      // Dark Text
```

## ?? SPACING STANDARD
- Form padding: 30-50px
- Section spacing: 20-30px
- Element spacing: 10-15px
- Button spacing: 8-10px

## ?? BUTTON STYLING

**Primary (Save, Login, Add, Update):**
```csharp
button.FlatStyle = FlatStyle.Flat;
button.BackColor = Color.FromArgb(120, 81, 44);
button.ForeColor = Color.FromArgb(245, 243, 237);
button.FlatAppearance.BorderColor = Color.FromArgb(99, 65, 35);
button.FlatAppearance.MouseOverBackColor = Color.FromArgb(184, 134, 11);
button.Height = 36;
```

**Secondary (Cancel, Edit):**
```csharp
button.FlatStyle = FlatStyle.Flat;
button.BackColor = Color.FromArgb(245, 243, 237);
button.ForeColor = Color.FromArgb(40, 30, 20);
button.FlatAppearance.BorderColor = Color.FromArgb(200, 180, 160);
button.Height = 36;
```

## ?? TEXT BOX STYLING
```csharp
textBox.BackColor = Color.FromArgb(250, 248, 245);
textBox.ForeColor = Color.FromArgb(40, 30, 20);
textBox.Font = new Font("Segoe UI", 11F);
textBox.BorderStyle = BorderStyle.FixedSingle;
```

## ?? DATA GRID STYLING
```csharp
dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(120, 81, 44);
dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(245, 243, 237);
dgv.DefaultCellStyle.BackColor = Color.FromArgb(245, 243, 237);
dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(252, 250, 247);
dgv.RowTemplate.Height = 28;
```

## ??? LABEL STYLING
```csharp
// Title labels
label.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
label.ForeColor = Color.FromArgb(58, 45, 32);

// Field labels
label.Font = new Font("Segoe UI", 10F);
label.ForeColor = Color.FromArgb(40, 30, 20);
```

## ?? HELPER METHODS

```csharp
// One-line button styling
UIHelper.StyleButton(btnSave, isPrimary: true);

// One-line textbox styling
UIHelper.StyleTextBox(txtInput, multiLine: false);

// One-line label styling
UIHelper.StyleLabel(lblTitle, isTitle: true);

// Create header for any form
Panel header = UIHelper.CreateHeaderPanel("Page Title");
form.Controls.Add(header);

// Style entire form
DataFormStyler.StyleDataManagementForm(this, "?? Title");
DataFormStyler.StyleFormButtons(this);
DataFormStyler.StyleFormTextBoxes(this);
```

## ?? QUICK FONT SETTINGS

| Use Case | Font | Size | Style |
|----------|------|------|-------|
| Page Titles | Segoe UI | 20-22 | Bold |
| Section Titles | Segoe UI | 14-16 | Bold |
| Labels | Segoe UI | 10 | Regular |
| Input Fields | Segoe UI | 11 | Regular |
| Buttons | Segoe UI | 10-12 | Regular/Bold |

## ?? PROPER ALIGNMENT

**Left-Aligned (typical):**
```
Label X Position:   30px
Input X Position:   150px
```

**Centered (titles):**
```
ContentAlignment.MiddleCenter
```

**Right-Aligned (buttons):**
```
Use FlowLayoutPanel or calculate: Width - ButtonWidth - Margin
```

## ?? FORM SIZE RECOMMENDATIONS

| Form Type | Width | Height | Notes |
|-----------|-------|--------|-------|
| Login | 700 | 550 | Centered on screen |
| Data Entry | 900 | 650 | Balanced layout |
| List View | 1000 | 700 | Grid-focused |
| Reports | 1200 | 800 | Wide content area |

## ? 5-MINUTE FORM REDESIGN

1. Set form background: `this.BackColor = ColorScheme.CreamWhite;`
2. Add header: `Controls.Add(UIHelper.CreateHeaderPanel("Title"));`
3. Style buttons: `DataFormStyler.StyleFormButtons(this);`
4. Style inputs: `DataFormStyler.StyleFormTextBoxes(this);`
5. Style labels: `DataFormStyler.StyleFormLabels(this);`

## ?? EMOJI ICONS (Use in Text)

- Books: ?? ?? ?? ?? ??
- Users: ?? ?? ?? ?????
- Actions: ?? ? ? ?? ?? ? ?
- Info: ?? ?? ? ?
- Other: ?? ?? ?? ?? ??

## ?? SECONDARY COLORS FOR VARIATION

Different button colors for different purposes:
- **Books:** `Color.FromArgb(34, 84, 60)` - Green
- **Borrowers:** `Color.FromArgb(128, 0, 32)` - Maroon
- **Transactions:** `Color.FromArgb(204, 85, 0)` - Orange
- **Reports:** `Color.FromArgb(120, 81, 44)` - Wood

## ?? TEST CHECKLIST

Before shipping a form:
- [ ] Colors match color scheme
- [ ] Spacing is consistent (10-30px)
- [ ] Buttons are 36px height
- [ ] Text boxes are 32px height
- [ ] Font is Segoe UI
- [ ] High contrast for readability
- [ ] Hover effects work
- [ ] Aligned properly
- [ ] No hardcoded RGB values
- [ ] Uses UIHelper/DataFormStyler where possible

---

**For detailed information, see:** `IMPLEMENTATION_GUIDE.md`
