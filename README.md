# 🏥 Campus Health Service Management System

## 📌 About the Project

The **Campus Health Service Management System** is a desktop-based healthcare management application developed using **C# Windows Forms** and **MySQL**.

The system is designed to help a campus health service manage student and staff healthcare activities, including appointments, patient records, emergencies, follow-ups, and reports.

The application provides different functionality based on the user's role, helping staff manage healthcare services efficiently through a centralized system.

---

## 🎯 Project Objectives

The main objectives of the system are to:

* Manage student and staff patient information.
* Allow patients to book, cancel, and reschedule appointments.
* Allow receptionists to manage appointments and patient information.
* Record urgent/emergency cases.
* Allow nurses/doctors to search and view patient records.
* Record and update patient follow-ups.
* Allow managers to view appointment and patient information.
* Generate reports from stored healthcare data.
* Store and manage healthcare information using a MySQL database.

---

## 👥 User Roles

The system includes the following main roles:

### 👤 Student / Staff

Students and staff can:

* Book appointments.
* View their appointments.
* Cancel appointments.
* Reschedule appointments.

### 🧑‍💼 Receptionist

The receptionist can:

* Manage appointments.
* Search for patients.
* Check patient information.
* Record urgent/emergency cases.
* Assist with appointment management.

### 👩‍⚕️ Nurse / Doctor

The nurse/doctor can:

* Search for patients.
* View patient records.
* View appointments.
* Record follow-ups.
* Update follow-up status.

### 👨‍💼 Manager

The manager can:

* View patient information.
* View staff information.
* View appointments.
* View historical information.
* View healthcare service statistics.
* Generate reports.

---

## 🛠️ Technologies Used

| Technology        | Purpose                          |
| ----------------- | -------------------------------- |
| **C#**            | Application programming language |
| **Windows Forms** | Desktop graphical user interface |
| **.NET 8**        | Application framework            |
| **MySQL**         | Database management              |
| **MySql.Data**    | Connection between C# and MySQL  |
| **Visual Studio** | Development environment          |
| **Git**           | Version control                  |
| **GitHub**        | Source code repository           |

---

## 🗄️ Database

The application uses **MySQL** to store and manage the system's data.

The database contains information related to areas such as:

* Patients
* Appointments
* Emergency cases
* Follow-ups
* Staff
* Appointment slots

The C# application connects to the MySQL database through a database connection class.

---

## 📊 System Features

### 🔐 Login

Users can log into the system and access functionality according to their role.

### 📅 Appointment Management

The system supports appointment management, including:

* Booking appointments
* Cancelling appointments
* Rescheduling appointments
* Searching appointments
* Viewing appointment information

### 🚨 Emergency Management

Reception staff can record urgent/emergency healthcare cases.

### 🧑‍⚕️ Patient Records

Nurses/doctors can search and view patient information and manage follow-up records.

### 📈 Dashboard

The manager dashboard provides an overview of healthcare activities using information such as:

* Appointment counts
* Appointment types
* Appointment statuses
* Patient information

### 📄 Reports

The system provides functionality for generating reports based on healthcare information stored in the database.

---

## 📁 Project Structure

```text
Campus Health Service
│
├── Campus Health Service.sln
│
├── Campus Health Service
│   ├── LogIn.cs
│   ├── Manager
│   ├── Nurse
│   ├── Receptionist
│   ├── Properties
│   ├── DBConnection.cs
│   └── ...
│
└── Published
    └── Published application files
```

---

## ▶️ How to Run the Project

### 1. Clone the repository

```bash
git clone https://github.com/Jobe-web/Campus-Health-Service.git
```

### 2. Open the project

Open:

```text
Campus Health Service.sln
```

using **Visual Studio**.

### 3. Configure MySQL

Make sure MySQL is installed and running.

Create/import the required **Campus Health Service** database and configure the database connection string in the project.

### 4. Build the project

In Visual Studio:

```text
Build → Build Solution
```

### 5. Run the application

Press:

```text
F5
```

or select:

```text
Start
```

from Visual Studio.

---

## 📦 Published Version

A published version of the Windows Forms application is included in the repository.

The published application can be found in the project's published output folder.

> **Note:** The application requires the required database environment and configuration to connect to MySQL.

---

## 🔒 Security Note

The project uses a MySQL database connection. Database passwords and other sensitive credentials should **not** be committed to a public GitHub repository.

Before deploying the application, configure the database connection securely.
