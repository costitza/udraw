### Overview

uDraw is a drawing application (personal project) written in C# using Windows Forms. It uses an SQL Server database to store drawings (or session data) for retrieval and management. 
The project is intended as a personal project / learning tool, and can be expanded for more advanced features.

### Features
-> Create new drawings on a canvas.
-> Save drawings (or canvas states) into a SQL Server database.
-> Load previous drawings from the database.
-> Basic UI built using Windows Forms (menus, forms, controls).
-> Custom controls (e.g., double‐click detection, canvas drawing).
-> Configuration of database connection via config file.

### Getting Started
Prerequisites

Windows OS that supports .NET Windows Forms applications.
Visual Studio (or equivalent C# IDE) capable of opening .csproj projects.
SQL Server (or SQL Server Express) installed and accessible.
.NET Framework version compatible with the project (check the .csproj for exact target version).

### Installation

Clone the repository: git clone https://github.com/costitza/udraw.git  
Open the solution/project (Udraw.csproj) in Visual Studio.
Restore NuGet packages (if any) and build the project.
Ensure your database server is running and reachable.

### Database Setup

In the App.config (or DatabaseConfig.cs depending on how the config is handled), update the connection string to point to your SQL Server instance.
Create the required database and table(s) for storing drawings. (You may need to inspect DatabaseHelper.cs or other code to determine the required schema.)
Run the application; it should connect to the database and allow saving/loading drawings.

# Usage

Launch the application after building.
Use the menu to start a new drawing or load an existing one.
Use the painting canvas (via PaintingCanvas.cs) to draw shapes or freehand.
Use the Save dialog/form (SaveForm.cs) to commit your drawing to the database.
Use the Start Menu form (StartMenu.cs) or MenuForm (MenuForm.cs) to navigate between options.

## 🧑Author

**Ababei Raul**  
- ababeiraul13@gmail.com  
- [GitHub Profile](https://github.com/costitza)
