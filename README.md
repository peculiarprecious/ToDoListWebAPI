# ToDoList Web API

A RESTful API built with ASP.NET Core Web API, converted from a Console Application to a fully functional Web API. This project demonstrates core Web API concepts including Controllers, Models Services, and Swagger documentation.


## Tech Stack

| Technology | Purpose |
|---|---|
| C# / ASP.NET Core | Core framework |
| .NET 8 | Runtime |
| Swagger / OpenAPI | API documentation & testing |
| In-Memory Storage | Data storage List (no database yet) |


## Project Structure

ToDoListWebAPI/
??? Controllers/
?   ??? TodosController.cs    # Handles HTTP requests
??? Models/
?   ??? ToDoTask.cs           # Task data model
??? Services/
?   ??? ToDoService.cs        # Business logic / CRUD operations
??? Program.cs                # App entry point & configuration
??? ToDoListWebAPI.csproj     # Project dependencies



## How to Use

### Installation

1. Clone the repository
   
2. Navigate to the project folder
   
3. Restore dependencies
   
4. Run the project
   
5. Open Swagger UI in your browser
   

## API Endpoints

### Base URL

https://localhost:{port}/api/todos

### Endpoints

| Method | Endpoint | Description | Request Body |
|--------|----------|-------------|--------------|
| `GET` | `/api/todos` | Get all tasks | None |
| `GET` | `/api/todos/{id}` | Get task by ID | None |
| `POST` | `/api/todos` | Add a new task | `"Task description"` |
| `PUT` | `/api/todos/{id}` | Update task description | `"New description"` |
| `PUT` | `/api/todos/{id}/complete` | Mark task as complete | None |
| `DELETE` | `/api/todos/{id}` | Delete a task | None |


## HTTP Status Codes

| Status Code | Meaning |
|---|---|
| `200 OK` | Request successful |
| `201 Created` | Task successfully created |
| `400 Bad Request` | Invalid input (e.g. empty description) |
| `404 Not Found` | Task with given ID does not exist |


## Architecture

This project follows a 3-Layer Architecture**:


HTTP Request
     ?
Controller        ? Handles HTTP requests and responses
     ?
Service           ? Contains business logic
     ?
In-Memory List    ? Stores data (temporary)


### Key Concepts Used
- **Dependency Injection** — `ToDoService` is injected into the controller automatically
- **REST Conventions** — proper use of HTTP methods and status codes
- **Separation of Concerns** — Models, Services, and Controllers are in separate layers


## ?? Conversion from Console App

This project was originally a **Console Application** and was converted to a Web API:

| Console App | Web API |
|---|---|
| `Program.cs` menu loop | Controller endpoints |
| `Console.ReadLine()` | HTTP Request body / params |
| `Console.WriteLine()` | JSON Response |
| `ToDoManager.cs` | `ToDoService.cs` (same logic!) |
| `ToDoTask.cs` | `ToDoTask.cs` (same model!) |


## Roadmap

- [x] Basic CRUD operations
- [x] Swagger documentation
- [ ] Connect to a real database (Entity Framework Core)
- [ ] Add Data Transfer Objects (DTOs)
- [ ] Add input validation (FluentValidation)
- [ ] Add Authentication & Authorization (JWT)
- [ ] Add Unit Tests
- [ ] Deploy to Azure


## Author

**Precious Nwajei**
- GitHub: [@peculiarprecious](https://github.com/peculiarprecious)
