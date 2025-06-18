# PayrollSystem - Windows Forms App (.NET Framework)

A simple Payroll Management System built with C# and Windows Forms for beginners. This project helps you learn the basics of Windows Forms development, object-oriented programming, and payroll calculations in C#.

---

## Table of Contents

- [Overview](#overview)
- [Features](#features)
- [Getting Started](#getting-started)
  - [Prerequisites](#prerequisites)
  - [How to Create the Project](#how-to-create-the-project)
  - [Running the Application](#running-the-application)
- [Project Structure](#project-structure)
- [How It Works](#how-it-works)
- [Contributing](#contributing)
- [License](#license)

---

## Overview

PayrollSystem is a beginner-friendly Windows Forms (.NET Framework) application for managing basic employee payroll operations. It demonstrates:

- How to create a Windows Forms project in Visual Studio
- How to organize code with multiple files and classes
- Basic payroll calculation logic

---

## Features

- Add employee details (ID, name, daily rate, working days, overtime, deductions)
- Calculate net salary for an employee
- Simple, easy-to-understand code and UI

---

## Getting Started

### Prerequisites

- Windows Operating System
- [Visual Studio 2019/2022 or later](https://visualstudio.microsoft.com/)
- .NET Framework 4.7.2 or newer (included with Visual Studio)

### How to Create the Project

1. **Open Visual Studio.**
2. Click **Create a new project**.
3. Search for and select **Windows Forms App (.NET Framework)** (C#).
4. Click **Next**.
5. Enter the project name: `PayrollSystem`.
6. Choose a location and click **Create**.
7. Select the desired .NET Framework version (e.g., 4.8) and click **Create**.

> For more details, see the [official tutorial](https://learn.microsoft.com/en-us/dotnet/desktop/winforms/overview/?view=netdesktop-8.0)[3].

### Running the Application

- Press **F5** or click **Start** in Visual Studio to build and run the application.

---

## Project Structure

```
PayrollSystem/
│
├── Program.cs              // Entry point of the application
├── Employee.cs             // Employee class definition
├── PayrollCalculator.cs    // Payroll calculation logic
├── EmployeeDatabase.cs     // In-memory employee list
├── MainForm.cs             // Main form logic (UI code)
└── MainForm.Designer.cs    // Main form layout (auto-generated)
```

---

## How It Works

- **Add Employee:** Enter employee details and click "Add Employee" to store them in memory.
- **Calculate Salary:** Enter an employee's ID and click "Calculate" to see the net salary, including overtime and deductions.

The code is heavily commented to help beginners understand each step.

---

## Contributing

Pull requests are welcome! Please open an issue first to discuss what you would like to change or improve.

---

## License

This project is open-source and available under the [MIT License](LICENSE).

---

## Windows Forms Resources

- [Windows Forms for .NET Samples][3]
- [Windows Forms topic on GitHub][1]
- [How to add a README to your Visual Studio project][6]

---

[1]: https://github.com/topics/windows-forms-csharp  
[3]: https://github.com/dotnet/samples/blob/main/windowsforms/README.md  
[6]: https://stackoverflow.com/questions/31890717/adding-a-readme-md-file-to-a-c-sharp-project-in-visual-studio-2015

[1] https://github.com/topics/windows-forms-csharp
[2] https://github.com/topics/windows-forms
[3] https://github.com/dotnet/samples/blob/main/windowsforms/README.md
[4] https://github.com/dotnet/winforms
[5] https://github.com/stimulsoft/Samples-Dashboards-WinForms-WPF-CSharp/blob/master/README.md
[6] https://stackoverflow.com/questions/31890717/adding-a-readme-md-file-to-a-c-sharp-project-in-visual-studio-2015
[7] https://github.com/MiguelCosta/sample-windows-forms
[8] https://github.com/smokindinesh/Csharp-windows-form-sample/blob/master/README.md
[9] https://github.com/topics/winforms-application?l=c%23
[10] https://github.com/dotnet/winforms/blob/main/pkg/Microsoft.Dotnet.WinForms.ProjectTemplates/readme.md
