# MSFD EF Core Model App

## Overview
This console application demonstrates Entity Framework Core fundamentals using SQLite to manage HR data. The project implements a simple HR management system with employees and departments, showcasing Code-First migrations, entity relationships, and data seeding.

## Table of Contents
- [Technologies Used](#technologies-used)
- [Prerequisites](#prerequisites)
- [Getting Started](#getting-started)
- [Project Structure](#project-structure)
- [Database Models](#database-models)
- [Key Features](#key-features)
- [Usage](#usage)
- [Common EF Core Commands](#common-ef-core-commands)
- [Learning Outcomes](#learning-outcomes)

## Technologies Used
- .NET 9.0
- Entity Framework Core 9.0
- SQLite Database Provider
- C# 12

## Prerequisites
- .NET 9 SDK
- Visual Studio Code (or any C# IDE)
- EF Core CLI Tools

## Getting Started

1. **Clone the repository**
   ```bash
   git clone <your-repo-url>
   cd MSFD_EFCoreModelApp
   ```

2. **Install EF Core Tools**
   ```bash
   dotnet tool install --global dotnet-ef
   ```

3. **Restore packages**
   ```bash
   dotnet restore
   ```

4. **Create and apply migrations**
   ```bash
   dotnet ef migrations add InitialCreate
   dotnet ef database update
   ```

5. **Run the application**
   ```bash
   dotnet run
   ```

## Project Structure
```
MSFD_EFCoreModelApp/
│
├── Models/
│   ├── Employee.cs
│   ├── Department.cs
│   └── HRDbContext.cs
│
├── Migrations/
│
├── Program.cs
└── MSFD_EFCoreModelApp.csproj
```

## Database Models

### Employee
- **EmployeeID** (int) - Primary Key
- **FirstName** (string) - Required, Max Length: 50
- **LastName** (string) - Required, Max Length: 50
- **DateOfHire** (DateTime)
- **DepartmentID** (int) - Foreign Key
- **Department** - Navigation Property

### Department
- **DepartmentID** (int) - Primary Key
- **Name** (string)
- **Employees** - Collection Navigation Property

## Key Features

### 1. Code-First Approach
Define database schema using C# classes and generate the database through migrations.

### 2. Entity Relationships
Demonstrates one-to-many relationship between Department and Employee entities.

### 3. Fluent API Configuration
Uses Fluent API in `OnModelCreating` to configure:
- Required fields
- Maximum string lengths
- Foreign key relationships

### 4. Data Seeding
Pre-populates the database with sample departments and employees on creation.

### 5. SQLite Integration
Lightweight database perfect for development and learning purposes.

## Usage

The application creates an HR database with departments and employees. After running migrations, the database will contain:

**Sample Data:**
- HR Department
- Engineering Department
- Two sample employees assigned to different departments

## Common EF Core Commands

```bash
# Create a new migration
dotnet ef migrations add MigrationName

# Apply migrations to database
dotnet ef database update

# Remove last unapplied migration
dotnet ef migrations remove

# List all migrations
dotnet ef migrations list

# Generate SQL script
dotnet ef migrations script

# Drop database
dotnet ef database drop
```

## Key Concepts Demonstrated

- ✅ Setting up Entity Framework Core with SQLite
- ✅ Creating and configuring DbContext
- ✅ Defining entity models and relationships
- ✅ Using Code-First migrations
- ✅ Seeding data using Fluent API
- ✅ Implementing one-to-many relationships
- ✅ Applying constraints and validation rules

---

.NET 9.0 Console Application built for the Microsoft Back-End Development course as part of the Full-Stack Certification track. This console application demonstrates Entity Framework Core concepts including DbContext configuration, Code-First migrations, entity relationships, and data seeding using SQLite.