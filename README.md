
<h1 align="center">🏦 Banking Management System</h1>
<p align="center">
  💻 A desktop banking system built with <strong>C# (.NET Framework)</strong>, <strong>WinForms</strong>, <strong>ADO.NET</strong>, and <strong>SQL Server</strong>.
</p>
<p align="center">
  ⚙️ Fully featured | 🔐 Dynamic Permissions | 💰 Real-time Transactions
</p>

---

## 💡 Overview

A complete **Banking Management System** developed as a desktop application using the **3-Tier Architecture** (Presentation, Business Logic, Data Access).

This system supports full user and account management, permission handling using **Bitwise Flags**, and real-time transaction logging. It aims to simulate real-world banking features in a scalable and organized structure.

---

## 🚀 Features

### ✅ 3-Tier Architecture
- Separation of concerns between UI, Business Logic, and Data Access  
- Scalable and maintainable project structure

### ✅ User Authentication
- Secure login system with username & password validation  
- Tracks login history for auditing (login audit log)

### ✅ User Roles & Permissions (Bitwise Flags)
- Permissions stored as integers using Bitwise AND logic  
- Dynamic checkbox-based UI to assign permissions  
- Buttons and features shown/hidden based on logged-in user’s permissions

### ✅ Client Management
- Add, Update, Delete, and Search for clients  
- Full CRUD operations connected to SQL Server

### ✅ User Management
- Add/Edit/Delete system users  
- Assign permissions and control access dynamically

### ✅ Bank Transactions
- Perform Deposits, Withdrawals, and Transfers  
- Display total balances and generate transaction history  
- Full transaction log updates in real-time in both UI and database

### ✅ Currency Exchange Module
- Simple calculator to convert between multiple currencies  
- Integrated directly in the UI

### ✅ Login Activity Tracking
- Logs all login events with timestamps  
- Useful for auditing and monitoring usage

### ✅ Validation & Error Handling
- Input validation across all forms  
- Basic error handling for robust and safe operation

### ✅ Responsive WinForms UI
- Organized via TabControls and buttons  
- Permission-based UI access: buttons are enabled/disabled based on role

---

## 🛠 Technologies Used

| Technology        | Description                             |
|------------------|-----------------------------------------|
| 💻 C#             | Application logic                       |
| 🧱 Windows Forms  | Desktop User Interface                  |
| 🔗 ADO.NET        | Database communication                  |
| 🗄️ SQL Server      | Backend database storage                |
| 🧠 Bitwise Flags  | Efficient permission management         |
| 🧩 3-Tier Pattern | DAL, BLL, and UI architecture           |

## 🖼️ UI Preview

> *(You can include screenshots here in a `/screenshots/` folder)*

📁 /screenshots/
┣ dashboard.png
┣ clients-form.png
┣ login-form.png
┗ permissions-ui.png

yaml
Copy
Edit

---

## 📦 Getting Started

1. **Clone the repo:**
```bash
git clone https://github.com/alieid123/Banking-Management-System.git
Open the .sln file in Visual Studio

Update SQL Server connection string in App.config

Run the project (Ctrl + F5)

👨‍💻 About Me
Hi, I'm Ali, a Computer Science student and passionate .NET developer.
This project reflects my learning journey into building structured, database-driven desktop applications.
I'm constantly learning and improving — stay tuned for future projects!

🔗 [LinkedIn](https://www.linkedin.com/in/aly-eid-867583345) 

