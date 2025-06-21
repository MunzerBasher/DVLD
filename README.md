# Driving & Vehicle License Department (DVLD)

## A Desktop Application for Efficient License and Vehicle Management

DVLD is a robust desktop application designed to streamline the management of driving licenses and vehicle registrations. Built with a focus on efficiency and user-friendliness, it provides comprehensive features for handling various aspects of license and vehicle administration, from initial applications to renewals and test management.

---

## Features

### License Application Management

* Apply for local driving licenses.
* Apply for international driving permits.
* Manage the lifecycle of license applications (e.g., status tracking, approvals).

### License Renewals

* Efficiently handle the renewal process for existing licenses.

### Driving Test Management

* Schedule and manage various driving tests (e.g., written, practical).
* Record test results and link them to applications.

### License Detention & Release

* Feature to detain licenses for various reasons (e.g., violations).
* Process the release of detained licenses.

### Vehicle Registration (Implied)

While not explicitly listed in the features, the name "Vehicle License Department" suggests that the application would also manage vehicle registrations:

* Registering new vehicles.
* Managing vehicle ownership transfers.
* Handling vehicle inspection records.

### User-Friendly Interface

* Intuitive WinForms interface for ease of use.

### Robust Data Management

* Securely stores and manages all license and vehicle-related data.

---

## Technologies Used

* **.NET Framework (C#):** Core framework and programming language for the application logic.
* **Windows Forms (WinForms):** For developing the desktop user interface.
* **SQL Server:** For storing application data.
* **T-SQL:** For managing and querying the database.
* **ADO.NET:** For interacting with SQL Server.

---

## Architecture

The application is built with a 3-Tier Architecture, promoting modularity, maintainability, and scalability:

### Presentation Layer (UI Tier)

* Developed using WinForms.
* Displays the UI and handles user interactions.
* Communicates with the Business Logic Layer.

### Business Logic Layer (BLL)

* Contains core business rules and logic.
* Acts as an intermediary between the Presentation and Data Access Layers.
* Processes user requests and coordinates data flow.

### Data Access Layer (DAL)

* Interacts with the SQL Server database.
* Uses ADO.NET for CRUD operations.
* Abstracts database details from other layers.

---

## Prerequisites

Ensure you have the following installed before running DVLD:

* **Visual Studio:** Any recent version supporting .NET Framework.
* **.NET Framework:** Specific version targeted by the project.
* **SQL Server:** Express, Developer, or Enterprise edition.
* **SQL Server Management Studio (SSMS):** For managing the database.

---

## Installation

### Clone the Repository

```bash
git clone https://github.com/MunzerBasher/DVLD.git
cd DVLD
```

### Restore NuGet Packages

Open the solution in Visual Studio and allow NuGet to restore the necessary packages.

### Database Setup

Follow the steps in the "Database Setup" section below.

### Configure Connection String

Update the `App.config` file in your project to point to your SQL Server instance:

```xml
<configuration>
    <connectionStrings>
        <add name="DVLDConnectionString" connectionString="Data Source=YourServerName;Initial Catalog=DVLD_DB;Integrated Security=True" providerName="System.Data.SqlClient" />
    </connectionStrings>
</configuration>
```

Replace `YourServerName` with the appropriate name or address (e.g., `.\SQLEXPRESS`, `(localdb)\MSSQLLocalDB`, or server IP). Adjust `Integrated Security` if using SQL Authentication.

### Build the Solution

Build the project in Visual Studio to compile.

---

## Usage

* **Run the Application:** Use F5 or the Start button in Visual Studio.
* **Login:** Use the default credentials or create users in the database.
* **Navigate Features:** Use menus/forms to manage licenses, applications, tests, and vehicles.

---

## Database Setup

### Create a New Database

Use SSMS to connect to SQL Server and create a new database (e.g., `DVLD_DB`).

### Execute SQL Scripts

Execute the scripts located in the `Database` folder in this order:

1. `Schema.sql` – Table creation
2. `StoredProcedures.sql` – Stored procedures
3. `SeedData.sql` – Admin users, lookup data, etc.

### Example in SSMS

1. Open SSMS and connect to your server
2. Select the `DVLD_DB` database
3. Open the `.sql` script
4. Click **Execute** or press **F5**

---

## Contributing

We welcome contributions! To contribute:

1. Fork the repository.
2. Create a branch:

   ```bash
   git checkout -b feature/your-feature-name
   ```
3. Make your changes and ensure tests pass.
4. Commit and push:

   ```bash
   git commit -m "Add new feature"
   git push origin feature/your-feature-name
   ```
5. Open a pull request to the `main` or `develop` branch.


