

# 📚 LibraryNotebookApp

A desktop application built with **C# (.NET 8.0)** and **Windows Forms**, using **Entity Framework Core** and **SQLite** to manage library operations such as issuing, returning, viewing, and organizing books and student data.

---

## Features

-  Add, edit, and delete books
-  Add, search, and manage student profiles
-  Issue books to students with availability tracking
-  Return books with date logging and automatic quantity updates
-  Real-time search and filtering in DataGridViews
-  Organized with clean separation between UI and data access layers
-  Persistent storage using SQLite and EF Core
-  Built with best practices (Dependency Injection, Repository pattern)

---

## Diagramme de Classe
![library drawio](https://github.com/user-attachments/assets/dc7dca28-d2c8-4652-8d1a-0cff18397795)


---


## 🛠️ Technologies Used

- **.NET 8.0**
- **Windows Forms (WinForms)**
- **Entity Framework Core**
- **SQLite**
- **Dependency Injection (Microsoft.Extensions.DependencyInjection)**
- **Visual Studio 2022**

---

## Project Structure

```

LibraryNotebookApp/
│
├── LibraryNotebook/           # WinForms UI layer
│   ├── BookForm/              # Forms: AddBook, ViewBook
│   ├── StudentForm/           # Forms: AddStudent, ViewStudentInfo
│   ├── IssueBooks.cs          # Issue form
│   ├── ReturnBook.cs          # Return form
│   └── DashboardForm.cs       # Main navigation
│
├── LibraryNotebook.Data/      # Class Library (.NET Core)
│   ├── Context/               # DbContext
│   ├── Entities/              # Models: Book, Student, Issue
│   ├── Repositories/          # Repository pattern for data access
│   └── Migrations/            # EF Core migrations
│
├── library.db                 # SQLite database (auto-generated)
└── README.md                  # You are here

````

---

## Getting Started

### Requirements

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download)
- [Visual Studio 2022+](https://visualstudio.microsoft.com/)
- Windows OS

---

### Run the Project

1. **Clone the repository**:

```bash
git clone https://github.com/EyaZantour/LibraryApp.git
cd LibraryNotebookApp
````

2. **Open the solution** (`.sln`) in Visual Studio

3. **Build the solution**

4. **Run the project** from `DashboardForm`

---

## Entity Framework & Database

* Automatically creates `library.db` (SQLite)
* Uses migrations (`Add-Migration`, `Update-Database`)
* Follows clean separation between context, entities, and repositories

---

## Contributors

Developed by: **\[Eya Zantour & Binta Ball]**
Academic project for: **\[Ecole Polytechnique de Sousse ]**
Date: **May 2025**

---

## License

This project is for educational use.
You are free to fork and build upon it for learning purposes.

---




