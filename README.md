# Shop Management System

## Overview
The **Shop Management System** is a desktop application built with C# and WinForms. It is designed to manage products, customers, and bills efficiently. The system allows adding, updating, deleting, and viewing records from a database, along with user authentication for secure access.

## Features
- **Login System**: Provides authentication for secure access.
- **Product Management**: Add, update, delete, and view product details.
- **Customer Management**: Add, update, delete, and view customer details.
- **Bill Management**: Navigate to billing (to be implemented).
- **Responsive UI**: User-friendly and interactive interface built with WinForms.
- **Database Integration**: Uses a local SQL Server database to store and retrieve information.

## Technologies Used
- **Language**: C#
- **Framework**: .NET Framework (Windows Forms)
- **Database**: SQL Server (LocalDB)
- **IDE**: Visual Studio

## Prerequisites
- Visual Studio installed on your system.
- .NET Framework runtime.
- SQL Server LocalDB.

## Setup Instructions
1. Clone or download the repository to your local system.
2. Open the solution file (`ShopManagementSystem.sln`) in Visual Studio.
3. Ensure the database file (`ShopManagementSystem.mdf`) is available.
4. Update the connection string in the code if the database location changes.
5. Build and run the application.

## Database Schema
### Products Table
| Column       | Type          | Description              |
|--------------|---------------|--------------------------|
| `ProId`      | `nvarchar`    | Product ID (Primary Key) |
| `ProName`    | `nvarchar`    | Product Name            |
| `ProCategory`| `nvarchar`    | Product Category        |
| `Quantity`   | `int`         | Product Quantity        |
| `UnitPrice`  | `float`       | Product Unit Price      |

### Customers Table
| Column       | Type          | Description              |
|--------------|---------------|--------------------------|
| `CusId`      | `nvarchar`    | Customer ID (Primary Key)|
| `CusName`    | `nvarchar`    | Customer Name           |
| `CusPhone`   | `nvarchar`    | Customer Phone Number   |

## How to Use
1. **Login**:
   - Enter `Admin` as the username and `Password` as the password.
   - Click **Login**.
2. **Navigate**:
   - After logging in, you can switch between Products, Customers, and Billing modules.
3. **Manage Records**:
   - Use **Add**, **Update**, **Delete**, and **Reset** buttons to manage records.
