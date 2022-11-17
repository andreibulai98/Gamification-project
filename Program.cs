using TeamsAPI.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.Configure<TeamsDatabaseSettings>(builder.Configuration.GetSection("TeamsDatabaseSettings"));
builder.Services.AddSingleton<TeamsService>();
var app = builder.Build();

app.MapGet("/", () => "Teams API!");

app.MapGet("/api/teams", async(TeamsService teamsService) => await teamsService.Get());

app.MapGet("/api/teams/{id}", async(TeamsService teamsService, string id) =>
{
    var team = await teamsService.Get(id);
    return team is null ? Results.NotFound() : Results.Ok(team);
});

app.MapPost("/api/teams", async(TeamsService teamsService, Team team) =>
{
    await teamsService.Create(team);
    return Results.Ok();
});

app.Run();