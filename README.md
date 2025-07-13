# 📘 UsersAPI – ASP.NET Core Web API (Lab 3)

This project is a CRUD-based ASP.NET Core Web API built in Visual Studio 2022 for Lab 3. It uses Entity Framework Core with both **InMemory** and **MS SQL Server** databases, and is tested using **Swagger** and **Postman**.

---

## 🧠 Lab Requirements Covered

- ✅ Create Web API using ASP.NET Core
- ✅ Use EF Core InMemory for testing
- ✅ Migrate to MS SQL Server
- ✅ Validate endpoints with SQL Server
- ✅ Push code and screenshots to Azure DevOps repo

---

## 🧰 Technologies Used

- ASP.NET Core Web API (.NET 7/8)
- Entity Framework Core (InMemory & SQL Server)
- SQL Server (via SSMS)
- Swagger UI
- Visual Studio 2022
- Azure DevOps (Git)

---

## 📑 Endpoints Implemented

| Method | Endpoint              | Description           |
|--------|------------------------|-----------------------|
| GET    | `/api/records`         | Get all users         |
| GET    | `/api/records/{id}`    | Get user by ID        |
| POST   | `/api/records`         | Add new user          |
| PUT    | `/api/records/{id}`    | Update existing user  |

---

## 🧪 Testing

- Swagger UI at `https://localhost:7136/swagger/index.html`
- Postman for API testing
- SQL Server (SSMS) used to verify data

---

## 💾 Database

- InMemory DB used for development testing
- Switched to MS SQL Server (`RecordContext`)
- Data seeded using `Program.cs`

---

## 📤 Submission Checklist

- ✅ Code pushed to Azure Repo
- ✅ Screenshots of working endpoints
- ✅ SQL Server table with data
- ✅ README.md included

---

## 📷 Screenshots (Attach Separately)

- Swagger showing GET/POST/PUT
- SSMS showing `dbo.Records` with sample data

---

> Created for Lab 3 – Week 9–10 Assignment  
> Instructor: *Priyanka Brojabasi*  
> Student: *Sharandeep kaur*  
