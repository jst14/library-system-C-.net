# 📚 Arcadia Library System

> *"A library is not a luxury but one of the necessities of life."*
> — Henry Ward Beecher

---

## Overview

The **Arcadia Library System** is a desktop application built with **C# Windows Forms (.NET Framework)** and a **Microsoft Access (.mdb)** database. It is designed to help librarians and library staff manage day-to-day library operations — from cataloguing books and registering borrowers, to processing borrow/return transactions and generating reports.

The interface is styled with a **vintage library aesthetic** — warm wood tones, parchment backgrounds, and gold accents — so users feel the atmosphere of a real library even in a digital environment.

---

## Features at a Glance

| Module | What it does |
|---|---|
| 📖 Books | Add, update, delete, and search the book collection |
| 👤 Borrowers | Register, update, delete, and search library members |
| 🔄 Transactions | Record book borrowing and returns with due dates |
| 📊 Reports | View all transactions, overdue books, and library summaries |

---

## System Requirements

- **OS:** Windows 10 / 11
- **Runtime:** .NET Framework 4.7.2 or later
- **Database Driver:** Microsoft Access Database Engine (ACE OLEDB 12.0)
- **IDE (for development):** Visual Studio 2019 / 2022

> ⚠️ Make sure the **Microsoft Access Database Engine** is installed on the machine running the app. Download it from Microsoft's official site if needed.

---

## Project Structure

```
LibrarySystem/
│
├── Program.cs               # Application entry point
├── LibColors.cs             # Shared color palette and font constants (vintage theme)
├── DbHelper.cs              # Centralized database connection helper
│
├── Form1.cs / Designer.cs   # Login screen
├── Form2.cs / Designer.cs   # Main menu / dashboard
├── Form3.cs / Designer.cs   # Books master file (named class: Books)
├── Form4.cs / Designer.cs   # Borrowers master file
├── Form5.cs / Designer.cs   # Transactions (Borrow & Return)
├── Form6.cs / Designer.cs   # Reports
│
└── LibSys.mdb               # Microsoft Access database file
```

---

## Database Tables

### `book`
Stores the library's book collection.

| Column | Type | Description |
|---|---|---|
| `accession_number` | Text | Primary key — unique book ID |
| `title` | Text | Title of the book |
| `author` | Text | Author's name |

---

### `borrowerid`
Stores registered library members.

| Column | Type | Description |
|---|---|---|
| `borrowerid` | Text | Primary key — unique borrower ID |
| `name` | Text | Full name of the borrower |
| `contactNum` | Text | Contact number |

---

### `transactions`
Records all borrowing activity.

| Column | Type | Description |
|---|---|---|
| `trans_id` | Text | Primary key — unique transaction ID |
| `borrowerid` | Text | Foreign key → borrowerid table |
| `accession_number` | Text | Foreign key → book table |
| `date_borrowed` | DateTime | Date the book was borrowed |
| `date_return` | DateTime | Due date for returning the book |

---

## Module Guide

### 🔐 Login — Form1
The entry point of the system. Staff enter their credentials to access the main menu. Pressing **Enter** on the keyboard moves between fields and submits the form naturally.

---

### 🏛️ Main Menu — Form2
The dashboard that appears after login. It provides:
- A **menu bar** at the top with Master Files, Transaction, Reports, and Exit
- **Four quick-access buttons** for Books, Borrowers, Transaction, and Reports
- A **live clock** showing the current date and time
- A library quote for ambiance

Navigating to any module hides the menu and shows the selected form. Closing a module automatically brings the menu back.

---

### 📖 Books — Form3
Manages the library's physical book collection.

**Operations:**
- **Save** — Add a new book record using Book ID (accession number), title, and author
- **Update** — Edit the title or author of an existing book (select a row first)
- **Delete** — Remove a book from the system with a confirmation prompt
- **Search** — Live search by title or author as you type
- **Clear** — Reset all input fields

Click any row in the table to automatically populate the form fields for editing or deletion.

---

### 👤 Borrowers — Form4
Manages library members who are eligible to borrow books.

**Operations:**
- **Save** — Register a new borrower with their ID, full name, and contact number
- **Update** — Modify an existing borrower's name or contact (select a row first)
- **Delete** — Remove a borrower record with a confirmation prompt
- **Search** — Live search by name or borrower ID
- **Clear** — Reset all input fields

Click any row in the table to load that borrower's details into the form.

---

### 🔄 Transactions — Form5
Handles all book borrowing and return activities.

**Fields:**
- **Transaction ID** — Auto-generated unique ID (format: `TX-YYYYMMDDHHmm`)
- **Borrower ID** — ID of the member borrowing the book
- **Accession Number** — ID of the book being borrowed
- **Date Borrowed** — Date the book is taken out
- **Date Return** — Due date (defaults to 14 days from borrow date)

**Operations:**
- **Save** — Record a new borrow transaction
- **Update** — Edit an existing transaction's details
- **Delete** — Remove a transaction record
- **Search** — Filter by borrower ID or accession number

Overdue transactions are highlighted automatically when selected.

---

### 📊 Reports — Form6
Provides an overview of library activity for staff review.

**Views:**
- **All Transactions** — Full list of every borrow transaction, joined with borrower name and book title
- **Overdue Books** — Filters transactions where the return date has already passed
- **Search** — Search across borrower names and book titles simultaneously

The report grid displays: Transaction ID, Borrower ID, Borrower Name, Accession Number, Book Title, Date Borrowed, and Date Return.

---

## How to Run

1. Clone or download the project folder
2. Copy **`LibSys.mdb`** into the same folder as the compiled `.exe`
3. Open `LibrarySystem.sln` in Visual Studio
4. Build the solution (`Ctrl + Shift + B`)
5. Run the application (`F5`)

> The database path is resolved automatically relative to the `.exe` location using `DbHelper.cs` — no hardcoded paths needed.

---

## Key Bug Fixes Applied

| # | Location | Bug | Fix |
|---|---|---|---|
| 1 | Form2 | `this.Close()` destroyed the menu, making navigation to child forms permanent — you could never go back | Changed to `this.Hide()` with `FormClosed` event that restores the menu |
| 2 | Form3 (Books) | Search SQL was missing the `LIKE` keyword: `where title '%...'` | Fixed to `WHERE title LIKE ? OR author LIKE ?` with parameterized query |
| 3 | Form3 (Books) | `btnSave` INSERT was missing a comma between Book ID and Title values | Rewrote using named column INSERT with parameters |
| 4 | Form3 & Form5 | DB connection path hardcoded to a specific user's machine (`C:\Users\John Simon\...` and `Z:\ZZ209\...`) | Centralized in `DbHelper.cs`, resolved relative to the `.exe` |
| 5 | Form4 (Borrowers) | Search event used `txtName.Text` instead of `txtSearch.Text` | Fixed to use `txtSearch.Text` |
| 6 | All forms | Raw string concatenation in SQL queries (SQL injection risk) | Replaced with parameterized `OleDbCommand` queries throughout |
| 7 | All child forms | No way to return to the main menu | Added `← Menu` button on every form that calls `this.Close()` |

---

## Design Philosophy

The UI follows a **vintage library theme** to give users a sense of being in a real library:

- 🟫 **Wood tones** (`#3D2B1F`, `#6B4226`, `#A0673A`) for headers, buttons, and panels
- 🟡 **Gold accents** (`#C9952A`) for highlights, borders, and active states
- 📄 **Parchment backgrounds** (`#F5ECD7`, `#FAF4E8`) for content areas
- 🖋️ **Georgia / Segoe UI fonts** for a mix of classic and readable typography
- ✅ **Green (Sage)** for success actions, 🔴 **Burgundy** for deletions and warnings

All colors and fonts are defined once in `LibColors.cs` and shared across every form for consistency.

---

## Developer Notes

- All database operations are wrapped in `try/catch` with `DbHelper.ShowDbError()` for clean error handling
- The `transactions` table is auto-created on first launch if it does not exist yet (Form5 `EnsureTransactionsTable()`)
- `con.Open()` / `con.Close()` are managed with `using` blocks to prevent connection leaks
- The application closes cleanly through `Application.Exit()` from the Exit menu item

---

## Author

**John Simon**
Library System — C# .NET Windows Forms Project
Visual Studio 2022

---

*Built with care for every reader who walks through the library doors.*
