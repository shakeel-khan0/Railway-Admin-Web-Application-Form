# Railway Admin Panel

## Introduction
This railway admin panel is a web-based application developed using C# and ASP.NET on WinForms. It is designed to automate the administrative processes of railway stations, including managing bookings, trains, and related records. The panel is restricted to admin use only, allowing them to add, delete, and update data efficiently.

## Features
- Admin dashboard for managing trains and bookings
- Add, delete, and update functionalities for train records
- User-friendly interface for managing railway schedules
- Database integration for storing and accessing records

## Technologies Used
- C# and ASP.NET
- SQL Server for database management
- Visual Studio as the development environment
- SQL Server Management Studio (SSMS) for database handling

## How to Run

### Prerequisites
- **Visual Studio** with **ASP.NET** and **C# development** workload installed.
  - You can install the required components from the **Visual Studio Installer**.
- **SQL Server** and **SQL Server Management Studio (SSMS)** for managing the database.
  - Ensure SSMS is installed for connecting and managing your SQL database.

### Setup and Installation

1. **Clone the Repository:**
   - Clone this repository to your local machine using the following command:
     ```bash
     git clone https://github.com/yourusername/railway-admin-panel.git
     ```

2. **Open the Project:**
   - Open the project in **Visual Studio** by navigating to the `.sln` file.
   - **Note**: **Railway-Admin** and **Railway-Admin.sln** is in same folder or directory.

3. **Database Setup:**
   - Open **SQL Server Management Studio (SSMS)**.
   - Create a new database for the railway system.
   - Use the provided SQL scripts (if available) or manually set up the required tables for managing trains and bookings.

4. **Connect Database to Visual Studio Project:**
   - In **Visual Studio**, open the `web.config` or connection file where the database connection string is stored.
   - Replace the existing connection string with your SQL Server database connection details.

5. **Run the Project:**
   - Build and run the project from **Visual Studio** by pressing `F5` or using the run button.

6. **Admin Access:**
   - Once the project runs, you can log in as an admin to access the full features of the panel.
   - Default ID, pass for admin login is "ID = khan", "pass = khan786"
