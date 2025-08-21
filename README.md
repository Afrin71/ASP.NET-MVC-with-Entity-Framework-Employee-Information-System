Project: ASP.NET-MVC-with-Entity-Framework-Employee-Information-System

The web application is built with ASP.NET MVC and Entity Framework (Code First). It demonstrates how to build an Employee Management System where you can add, view, update, and delete employee records from a SQL Server database.

Technologies Used
ASP.NET MVC
C#
Entity Framework (Code First)
SQL Server
Razor Views

Features
Create Employee → Add new employee records
Get Employees → Retrieve and display all employees in a list
Edit Employee → Update employee details
Delete Employee → Remove employee from the database
Details View → Display detailed information for a single employee

Project Structure

Models
EmployeeModel.cs → Entity with properties EmployeeId, EmployeeName, EmpSalary, Designation
UsersContext.cs → Database context inheriting from DbContext

Controllers
HomeController.cs (or EmployeeController.cs) → Contains all CRUD action methods (Create, GetEmployee, Edit, Delete, Details)

Views
Strongly-typed Razor Views for each action (Create.cshtml, GetEmployee.cshtml, Edit.cshtml, Delete.cshtml, Details.cshtml)


How It Works
Create → The Create view displays a form to add an employee. Data is saved using Employees.Add() and SaveChanges().
GetEmployee → Fetches all employees from the database using ToList() and shows them in a table.
Edit → Retrieves an employee by ID, populates the form, and updates the record with EntityState.Modified.

Delete → Prompts confirmation, then removes the record with Employees.Remove().

Details → Shows complete employee information for the selected ID.
