# Task Management System

## 🚀 Overview
This **Task Management System** is a Windows Forms application built using **C#**, **Entity Framework (EF)**, and **LINQ**. It provides an intuitive interface for managing tasks efficiently, tracking performance, and generating insightful reports. The system includes **user and category management**, along with **charts and reports** to analyze task execution and statistics.

## 🎯 Key Features
- ✅ **Task Management**: Create, edit, delete, and filter tasks easily.
- ✅ **Admin Dashboard**: Manage users and categories efficiently.
- ✅ **Reports & Analytics**: View task counts, execution times, and performance reports.
- ✅ **Visual Charts**: Display task progress and statistics with graphical insights.
- ✅ **Custom Controls**: Designed with a modern UI for a seamless experience.
- ✅ **Smart Filtering & Sorting**: Prioritize tasks based on due date and urgency.

## 🛠️ Technologies Used
- **C# WinForms** - For the user interface.
- **Entity Framework (EF)** - For database operations.
- **LINQ** - For querying data efficiently.
- **SQL Server** - As the database management system.
- **Custom Controls** - For a modern and enhanced user experience.

## 📂 Project Structure
```
TaskManagementSystem/
│── TaskManagementSystem.sln        # Solution file
│── MainForm.cs                      # Main UI logic
│── Models/                          # Contains entity models
│── Database/                        # SQL Database scripts
│── Reports/                         # Report generation files
│── CustomControls/                  # Custom UI elements
│── bin/                             # Compiled output files
│── obj/                             # Temporary object files
│── README.md                        # This file
```

## 🗃️ Database Schema (SQL Server)
The application uses **SQL Server** as the database. Below is the schema:

### Tables:
1. **Users**
   - `UserId` (Primary Key, int, Identity)
   - `Username` (nvarchar, Unique)
   - `PasswordHash` (nvarchar)

2. **Categories**
   - `CategoryId` (Primary Key, int, Identity)
   - `CategoryName` (nvarchar, Unique)

3. **Tasks**
   - `TaskId` (Primary Key, int, Identity)
   - `Title` (nvarchar)
   - `Description` (nvarchar)
   - `DueDate` (datetime)
   - `Status` (nvarchar)
   - `CategoryId` (Foreign Key → Categories)
   - `UserId` (Foreign Key → Users)

## 📥 Installation & Setup
### Prerequisites:
- Install **Visual Studio** with **.NET Framework**.
- Install **SQL Server** and **SQL Server Management Studio (SSMS)**.

### Steps to Run the Project:
1. **Clone the Repository**
   ```sh
   git clone https://github.com/qassemshaban7/ManagementSystem.git
   cd ManagementSystem
   ```

2. **Setup the Database**
   - Open **SQL Server Management Studio (SSMS)**.
   - In Consol Package Manager `Update-Database`.
   
3. **Update Connection String**
   - Open `App.config`.
   - Modify the `connectionString` to match your **SQL Server**.

4. **Run the Application**
   - Open `ManagementSystem.sln` in **Visual Studio**.
   - Build and run the project.

## 📊 Reports & Analytics
- Admin can generate reports to track:
  - **Total number of tasks completed.**
  - **Pending vs. completed tasks.**
  - **Execution time of tasks.**
  - **User activity.**
- Graphical reports with **charts and insights** for better visualization.

## 🔒 User Roles & Permissions
| Role      | Permissions |
|-----------|------------|
| **Admin** | Manage users, categories, tasks, and generate reports. |
| **User**  | Create, edit, delete personal tasks. |

🚀 Happy Coding! 😊

