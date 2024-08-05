# Education Platform System API

## About

Education Platform System is an ASP.NET Web API that can enable students and instructors to manage classrooms and educational content.

### How to Run

1. Clone the repository

`git clone https://github.com/renanmms/Education-Platform.git`

2. Navigate to the project directory

`cd ./Education-Platform/src`

3. Install dependencies

`dotnet restore`

4. Configure the database connection string in the `appsettings.json` with the `EducationPlatformCS` key value

```json
"ConnectionStrings": {
  "EducationPlatformCS": ""
}
```

5. Run the migrations using the `dotnet-ef` global tool cli

`dotnet ef database update -s ../EducationPlatform.API/EducationPlatform.API.csproj`

### Technologies Used

* C#
* .NET 8.0
* SQL Server
* Entity Framework Core
* FluentValidator

### Software Engineering Concepts

* Clean Architecture
* CQRS (Command Query Responsability Segregation)
* Result Pattern
* Repository Pattern

## Feedback and Support

For feedback, feature requests, or support, please open an issue in this GitHub repository.
