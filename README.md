# TaskFlow API

TaskFlow API is a RESTful task management service built with ASP.NET Core.

The project demonstrates a layered architecture with controllers, services, repositories, DTOs, Entity Framework Core, SQLite and AutoMapper.

## Features

- Create tasks
- Get all tasks
- Get a task by ID
- Update tasks
- Delete tasks
- Search tasks by title or description
- Filter tasks by completion status
- DTO validation
- Automatic DTO-to-entity mapping with AutoMapper
- Swagger API documentation

## Technologies

- C#
- .NET 8
- ASP.NET Core Web API
- Entity Framework Core
- SQLite
- AutoMapper
- Swagger
- Git

## Architecture

```text
Controller
    ↓
Service
    ↓
Repository
    ↓
Entity Framework Core
    ↓
SQLite
API Endpoints
Method	Endpoint	Description
GET	/api/Tasks	Get all tasks
GET	/api/Tasks/{id}	Get task by ID
POST	/api/Tasks	Create a task
PUT	/api/Tasks/{id}	Update a task
DELETE	/api/Tasks/{id}	Delete a task
Search and filtering
GET /api/Tasks?search=AutoMapper
GET /api/Tasks?isCompleted=true
GET /api/Tasks?search=AutoMapper&isCompleted=true
Example request
{
  "title": "Finish TaskFlow API",
  "description": "Complete and publish the project",
  "dueDate": "2026-07-25T18:00:00Z"
}
Run locally
Clone the repository:
git clone https://github.com/kycile24/TaskFlow.Api.git
Open the project directory:
cd TaskFlow.Api
Restore dependencies:
dotnet restore
Apply database migrations:
dotnet ef database update
Run the application:
dotnet run
Open Swagger in the browser using the URL shown in the console.
Project structure
TaskFlow.Api
├── Controllers
├── Data
├── DTOs
├── Entities
├── Interfaces
├── Mappings
├── Repositories
├── Services
├── Migrations
└── Program.cs
Author

Oleksandr Kutsil
