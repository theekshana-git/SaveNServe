# 🥫 SaveNServe – Smart Ingredient Substitution System

**SaveNServe** is a desktop-based smart ingredient tracking and substitution system built using **Windows Forms (C#)** and **SQL Server (SSMS)**. It helps users manage stock levels of ingredients, provides manual substitution options, and suggests automatic alternatives based on nutritional value, texture, and compatibility.

---

## 📁 Project Structure

SaveNServe/

├── SaveNServe/ → Main Windows Forms application

├── Database/ → Contains the SQL script to restore the database

├── .gitignore → Git ignore rules

├── SaveNServe.sln → Visual Studio solution file

└── README.md → Project documentation (this file)

---

## 🧑‍💻 Prerequisites

- [Visual Studio with .NET Framework support](https://visualstudio.microsoft.com/)
- [SQL Server + SQL Server Management Studio (SSMS)](https://aka.ms/ssmsfullsetup)

---

## 🛠️ Getting Started

### 1. Clone the Repository
```
git clone https://github.com/theekshana-git/SaveNServe.git
cd SaveNServe
```

🔀 If you're a collaborator working on a specific part (e.g., UI, DB, Logic), create a new branch:
```
git checkout -b feature/your-feature-name
```

### 2. Set Up the Database

1. Open SSMS
2. Open the script in: Database/smart_ingredient_db.sql
3. Run the script to create and populate the database
4. Update the connection string in your application settings (e.g., in App.config) to match your SQL Server instance


## 🚀 Running the Project

1. Open SaveNServe.sln in Visual Studio
2. Build the project
3. Run the Windows Forms App


## 👥 Collaboration Guide

### 👯 How to Contribute

Each collaborator should:

1. Create a branch for their specific module/feature:
```
git checkout -b feature/your-name-or-task
```

2. Make changes, then commit:
```
git add .
git commit -m "Add your meaningful message"
```

3. Push your branch:
```
git push origin feature/your-name-or-task
```

4. Once your work is ready, open a Pull Request on GitHub and assign it for review.


### 🗂 Suggested Branch Structure

* ```main``` – stable production-ready code
* ```feature/ui-dashboard``` – new UI components
* ```feature/db-setup``` – database schema updates
* ```feature/logic-substitutions``` – core ingredient logic
* ```fix/...``` – bug fixes


## 🧾 Notes

* 💾 Database schema is located in /Database/
* ⚙️ Core logic is organized in the code-behind files inside the SaveNServe directory
  
## 👨‍💻 Collaborators

* Gimhan Theekshana – Lead Developer & System Architect
* Rashmie Ramesha - UI Designer - Login & Dashboard Layout


## 📄 License
This project is for educational and demonstration purposes. Licensing terms will be finalized later.

---







