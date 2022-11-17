# Gamification-project

A simple CRUD web API using C# .NET



appsettings.json -> Here you have to provide the connection string from the MongoDB ("mongodb://localhost:27017" etc.)



Team.cs -> Team obj. structure: { Id, Name, Scores[] }


    
TeamsService.cs -> methods for:
  - Returning a list of Teams
  - Returning only one Team with Id of param
  - Creating a Team
  - Updating a Team
  - Deleting a Team
  

Program.cs -> app.Run();
