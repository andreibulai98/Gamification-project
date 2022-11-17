# Gamification-project

A simple CRUD web API using C# .NET



appsettings.json -> Here you have to provide the connection string from the MongoDB ("mongodb://localhost:27017" etc.)



Team.cs -> Team obj. structure: { Id, Name, Scores[] }
           JSON MongoDB obj. structure:
{
   "Name": "Team 2",
   "Scores": [20, 15, 20, 15, 15, 20, 20, 20]
}
    
    
    
TeamsService.cs -> methods for:
  - Returning a list of Teams
  - Returning only one Team with Id of param
  - Creating a Team
  - Updating a Team
  - Deleting a Team
  

Program.cs -> app.Run();
