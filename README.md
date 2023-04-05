# WebAPIC-

A web API built with .NET Entity Framework and connected to SQL Server. This API allows users to perform CRUD operations on a database of Characters.

# Demo

![ezgif com-video-to-gif](https://user-images.githubusercontent.com/89397795/230191728-9a5df19b-d34e-453a-8630-a690b9f0abb9.gif)

# Usage

To use the API, start the application in Visual Studio, _dotnet watch run_ and navigate to https://localhost:5001/swagger in your web browser.

# Endpoints

* GET http://localhost:5017/api/Character/getall: returns a list of all characters in the database.
* GET http://localhost:5017/api/Character/{id}: returns a specific character in the database.

# Packages

 * dotnet add package Swashbuckle.AspNetCore.SwaggerUI
 * dotnet add package Microsoft.EntityFrameworkCore.SQLServer
 * dotnet add package Microsoft.EntityFrameworkCore
 * dotnet add package Microsoft.EntityFrameworkCore.Design
 * dotnet tool install --global dotnet-ef
 * dotnet add package AutoMapper.Extensions.Microsoft.DependencyInjection --version 12.0.0
 
 
