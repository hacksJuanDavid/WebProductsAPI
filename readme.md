## Endpoints API

### Get all Task and Category

```bash
GET /api/Task
GET /api/Category
```

### Get by id Task and Category

```bash
GET /api/Task/{id}
GET /api/Category/{id}
```

### Create Task and Category

```bash
POST /api/Task
POST /api/Category
```

### Update Task and Category

```bash
PUT /api/Task/{id}
PUT /api/Category/{id}
```

### Delete Task and Category

```bash
DELETE /api/Task/{id}
DELETE /api/Category/{id}
```

###

Create a Web Api with .Net Core 7.0

## Create a minimal web api

## 1. Create a new project

```bash
    dotnet new web
```

## Description

This is a simple Web Api project that uses .Net Core 7.0. It is a simple project that can be used as a starting point for a new project.

## Build the project

```bash

dotnet build

```

##

## Run the project

To run the project, you need to have .Net Core 7.0 installed. You can download it from [here](https://dotnet.microsoft.com/download/dotnet/7.0).

Once you have .Net Core 7.0 installed, you can run the project by executing the following command in the root folder of the project:

```bash

dotnet run

```

## Run the tests

To run the tests, you need to have .Net Core 7.0 installed. You can download it from [here](https://dotnet.microsoft.com/download/dotnet/7.0).

Once you have .Net Core 7.0 installed, you can run the tests by executing the following command in the root folder of the project:

```bash

dotnet test

```

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details

###

## Check version dotnet

```bash
dotnet --version
```

##

## Check packs nuget

```bash
dotnet list package
```

##

## Check tools

```bash
dotnet tool list --global

dotnet tool list --local

```

##

## Packs nuget used

Project 'WebApi' has the following package references
[net7.0]:
Top-level Package Requested Resolved

> Microsoft.EntityFrameworkCore 7.0.9 7.0.9  
> Microsoft.EntityFrameworkCore.Design 7.0.9 7.0.9  
> Npgsql.EntityFrameworkCore.PostgreSQL 7.0.4 7.0.4

##

## Add config tools local proyect

```bash
dotnet new tool-manifest

dotnet tool install dotnet-ef --version 7.0.9

```

##

## Commands used create migrations

```bash

dotnet ef migrations add InitialCreate

```

## Commands used to update database

```bash

dotnet ef database update

```

## Commands used remove migrations

```bash

dotnet ef migrations remove

```

##

## String connection add in the file appsettings.json

```bash
"ConnectionStrings": {
    "DefaultConnection": "Host=localhost;Port=5432;Database=postgres;Username=postgres;Password=postgres"
  }
```

##
