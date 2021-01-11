# Rosetta

Rosetta is a e-commerce backend application built using ASP.NET Core and Entity Framework Core.
This project follow the structure below:

![Project Structure](https://github.com/denislour/rosetta/blob/master/Assets/img/structure.png)

Rosetta using repository pattern
![Repository Pattern](https://github.com/denislour/rosetta/blob/master/Assets/img/pattern.png)

## Getting Started

Use these instructions to get the project up and running.

### Prerequisites

You will need the following tools:

- [Visual Studio Code or Visual Studio 2019](https://visualstudio.microsoft.com/vs/) (version 16.3 or later)
- [.NET Core SDK 3](https://dotnet.microsoft.com/download/dotnet-core/3.0)

### Setup

Follow these steps to get your development environment set up:

1. Clone the repository
2. At the root directory, restore required packages by running:
   ```
   dotnet restore
   ```
3. Next, build the solution by running:
   ```
   dotnet build
   ```
4. Once the front end has started, within the `\Src\WebUI` directory, launch the back end by running:
   ```
   dotnet run
   ```
5. Launch [https://localhost:5000/api](http://localhost:5000/api) in your browser to view the API

## Technologies

- .NET Core 3
- ASP.NET Core 3
- Entity Framework Core 3
- Angular 8

## Receipt

### Basic WebApi

- Preview the controllers, entity
- Connect, migrate database
- Separate project into 3 parts: API, Core, Infrastructure

### Architect

- Preview repository pattern
- Preview the middleware:
  - Get store context
  - Migrate database
  - Working with seed data
- Research lazy load and eager load

### Generic Repository

- Implementing the generic repository (for standard entity)
- Implementing the `specification pattern` (for special entity)
- Add Dto (Data transfer object) and mapping `Entity` to `Dto`
- Config static file

## License

This project is licensed under the MIT License - see the [LICENSE.md](https://github.com/denislour/rosetta/blob/master/LICENSE) file for details.
