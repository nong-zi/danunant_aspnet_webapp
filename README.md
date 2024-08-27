**<h1>Simple Web Application</h1>**

This ASP.NET mvc application is a super basic CRUD (Create, Read, Update, Delete) system designed for learning personal website development using MVC (Model-View-Controller) and C# programming language. It offers an interface for users to input edit and delete personal information including name, age, phone number, and address.</br>

Why I chose this framework?
- For learning MVC model 

**<h2>Technology Stack</h2>**

- ASP.NET core MVC with Entity Framework
- Microsoft SQL server management studio

**<h2>Reference Links</h2>**

This is guide I've been following along while I'm develping this project. In this video you will understand not just a code but the concept of MVC and How everything in this project works together. 
His explaination does not miss any detail so I highly recommend.
- https://www.youtube.com/watch?v=AopeJjkcRvU&t=8860s

Bootstrap Theme in this project
- https://bootswatch.com/vapor/

Bootstrap Icon
- https://getbootstrap.com/docs/5.0/getting-started/introduction/

**<h2>Packages Requirement</h2>**

Use NuGet package manager to search these packages

- Mircrosoft.EntityFrameworkCore
- Mircrosoft.EntityFrameworkCore.Design
- Mircrosoft.EntityFrameworkCore.SqlServer
- Mircrosoft.EntityFrameworkCore.Tools

**<h2>Create a database using Entity Framework Core</h2>**

Enter your SQL server URL in the connection string in appsetting.json.</br>
I am using localhost so my URL is "(LocalDb)\MSSQLLocalDB". </br>
I have included a "Person.cs" class for create a database inside Model folder

open package manager console

    Add-Migration InitialCreate
    Update-Database

**<h2>Run this application</h2>**

Just  open this project file in Mircrosoft Visual Studio 2022 and press http run button.
