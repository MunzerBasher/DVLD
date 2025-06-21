"# Driving & Vehicle License Department (DVLD)" 


A Desktop Application for Efficient License and Vehicle Management
DVLD is a robust desktop application designed to streamline the management of driving licenses and vehicle registrations. Built with a focus on efficiency and user-friendliness, it provides comprehensive features for handling various aspects of license and vehicle administration, from initial applications to renewals and test management.


Features

License Application Management:

Apply for local driving licenses.
Apply for international driving permits.
Manage the lifecycle of license applications (e.g., status tracking, approvals).

License Renewals:

Efficiently handle the renewal process for existing licenses.
Driving Test Management:
Schedule and manage various driving tests (e.g., written, practical).
Record test results and link them to applications.

License Detention & Release:

Feature to detain licenses for various reasons (e.g., violations).
Process the release of detained licenses.
Vehicle Registration (Implied by "Vehicle License Department"): While not explicitly listed in the prompt's features, the name "Vehicle License Department" suggests that the application would also manage vehicle registrations. This could include:
Registering new vehicles.
Managing vehicle ownership transfers.
Handling vehicle inspection records.

User-Friendly Interface:

Intuitive WinForms interface for ease of use.

Robust Data Management:
Securely stores and manages all license and vehicle-related data.

Technologies Used

.NET Framework (C#): The core framework and programming language for the application logic.
Windows Forms (WinForms): Used for developing the rich desktop user interface.
SQL Server: The relational database management system for storing application data.
T-SQL: Transact-SQL for managing and querying the SQL Server database.
ADO.NET: Provides data access capabilities to interact with the SQL Server database.
Architecture
The application is built with a 3-Tier Architecture, promoting modularity, maintainability, and scalability.

Presentation Layer (UI Tier): Developed using WinForms, this layer is responsible for displaying the user interface and handling user interactions. It communicates with the Business Logic Layer.
Business Logic Layer (BLL): This layer contains the core business rules and logic of the application. It acts as an intermediary between the Presentation Layer and the Data Access Layer, processing user requests, applying business rules, and coordinating data flow.
Data Access Layer (DAL): This layer is responsible for all interactions with the SQL Server database. It uses ADO.NET to perform CRUD (Create, Read, Update, Delete) operations, abstracting the database details from the other layers.
Prerequisites
Before running the DVLD application, ensure you have the following installed:

Visual Studio: (Recommended for development) Any recent version supporting .NET Framework.
.NET Framework: The specific version targeted by the project (details usually in the project file).
SQL Server: An instance of SQL Server (Express, Developer, or Enterprise edition) to host the application database.
SQL Server Management Studio (SSMS): (Recommended) For managing your SQL Server instance and database.
Installation
Clone the Repository:

Bash

git clone https://github.com/MunzerBasher/DVLD.git
cd DVLD

Restore NuGet Packages:
Open the solution in Visual Studio and allow NuGet to restore any necessary packages.

Database Setup:
Follow the instructions in the Database Setup section to set up your SQL Server database.

Configure Connection String:
Locate the App.config file (or Web.config if it's a web-related component, though for WinForms it's usually App.config) in your project. Update the connection string to point to your SQL Server instance.

Example App.config snippet:

XML

<configuration>
    <connectionStrings>
        <add name="DVLDConnectionString" connectionString="Data Source=YourServerName;Initial Catalog=DVLD_DB;Integrated Security=True" providerName="System.Data.SqlClient" />
    </connectionStrings>
</configuration>
          
Replace YourServerName with the name of your SQL Server instance (e.g., .\SQLEXPRESS, (localdb)\MSSQLLocalDB, or your server's IP address/hostname).
Ensure Initial Catalog matches the name you give your database (e.g., DVLD_DB).
Adjust Integrated Security=True if you're using SQL Server Authentication (then you'll need User ID=YourUsername;Password=YourPassword).
Build the Solution:
Build the entire solution in Visual Studio to compile the project.

Usage
Run the Application: After a successful build, you can run the application directly from Visual Studio (by pressing F5 or clicking the "Start" button).
Login: Upon launching, you will likely be presented with a login screen. Use the default credentials (if provided in documentation, otherwise you'll need to set up initial users in the database) or create a new user.
Navigate Features: Explore the various menus and forms to utilize the application's features for managing licenses, applications, tests, and vehicle registrations.
Database Setup
Create a New Database:
Using SQL Server Management Studio (SSMS), connect to your SQL Server instance.
Create a new database (e.g., named DVLD_DB).

Execute SQL Scripts:
Navigate to the Database folder in the project directory (or wherever the SQL scripts are located).
Execute the provided SQL scripts in the correct order to create tables, stored procedures, and initial data (if any). Typical order:

Schema.sql (for table creation)
StoredProcedures.sql (for stored procedures)
SeedData.sql (for initial data like admin users, lookups, etc.)
Example of how to execute a script in SSMS:

Open SSMS.
Connect to your server.
Select your DVLD_DB database from the dropdown.
Go to File > Open > File... and select your .sql script.
Click "Execute" or press F5.
Contributing
Contributions are welcome! If you'd like to contribute to DVLD, please follow these steps:

Fork the repository.
Create a new branch for your feature or bug fix: git checkout -b feature/your-feature-name or bugfix/your-bug-fix.
Make your changes and ensure tests pass.
Commit your changes: git commit -m "Add new feature"
Push to your branch: git push origin feature/your-feature-name
Create a pull request to the main or develop branch of the original repository.
License
This project is licensed under the MIT License - see the LICENSE file for details.




