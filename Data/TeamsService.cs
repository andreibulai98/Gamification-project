using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace TeamsAPI.Data
{
    public class TeamsService
    {
        private readonly IMongoCollection<Team> _teams;

        public TeamsService(IOptions<TeamsDatabaseSettings> options)
        {
            var mongoClient = new MongoClient(options.Value.ConnectionString);

            _teams = mongoClient.GetDatabase(options.Value.DatabaseName).GetCollection<Team>(options.Value.TeamsCollectionName);
        }

        // Returning a list of Teams
        public async Task<List<Team>> Get() => await _teams.Find(_ => true).ToListAsync();

        // Returning only one Team with Id of param.
        public async Task<Team> Get(string id) => 
            await _teams.Find(t => t.Id == id).FirstOrDefaultAsync();

        // Creating a Team
        public async Task Create(Team newTeam) => 
            await _teams.InsertOneAsync(newTeam);

        // Updating a Team
        public async Task Update(string id, Team updateTeam) => 
            await _teams.ReplaceOneAsync(t => t.Id == id, updateTeam);

        // Deleting a Team
        public async Task Remove(string id) =>
            await _teams.DeleteOneAsync(t => t.Id == id);
    }
}
