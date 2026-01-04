# 🧾 Sales Management System (ASP.NET Core)

## 📌 Overview

This project is a backend-focused sales management system built with ASP.NET Core.  
It was designed to practice **backend architecture, data modeling, and business logic enforcement** in a real-world domain.

The system manages core sales concepts such as products, customers, and orders.

---

## 🧱 Architecture

The application follows a layered architecture:

Controllers → Services → Data Access → Database


Each layer has a clear responsibility, improving maintainability and testability.

---

## 🔧 Tech Stack

- C#
- ASP.NET Core
- Entity Framework Core (ORM)
- Relational Database

---

## 🗄 Database Design

Key entities include:
- Customers
- Products
- Sales / Orders
- OrderItems

The database uses:
- Primary keys for entity identity
- Foreign keys for relationships
- Normalized tables to avoid duplication

Transactions are used where multiple operations must succeed together.

---

## ⚙️ Key Concepts Demonstrated

- RESTful API design
- Separation of concerns
- Business logic in service layer
- Database relationships and integrity
- Entity Framework Core usage
- Backend validation

---

## 🎯 Project Purpose

This project was built to strengthen backend development skills using ASP.NET Core and to apply clean architecture principles in a sales domain.
