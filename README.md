# Lab9

Objective:
The objective of this project was to develop a multi-platform application using .NET MAUI, implementing the Model-View-ViewModel (MVVM) design pattern. The application manages employee records through a SQLite database, providing functionalities to insert new records and display existing ones.

Key Components:

Model:

An Employee class representing individual employee records.
Fields include Social Insurance Number (SIN), Full Name, and Hire Date.
Implemented SQLite declarative tags for database setup.

Service:

DataConstants.cs: Shared constants for database management.
DataAccess.cs: Manages SQLite connection, table creation, and seed data insertion.
Includes methods for insert and retrieval operations.

User Interface (UI):

Single MainPage displaying a list of employees.
Components for adding new employee records.
Optional functionalities for updating, deleting, and searching records.

ViewModel:

Binds data and commands between the UI and the underlying data model.
Ensures records load and display upon application startup.
Validates user input for new employee SINs to ensure 9-digit format.

Technologies Used:

Visual Studio Mac with .NET 7.
NuGet packages: CommunityToolkit.Mvvm for MVVM support, sqlite-net-pcl, and SQLitePCLRaw.bundle_green for SQLite database handling.

Conclusion:

This project demonstrates the implementation of a database-driven application using .NET MAUI and MVVM architecture. By following these steps, developers can create robust multi-platform applications for managing data effectively.
