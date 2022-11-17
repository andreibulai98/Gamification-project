namespace TeamsAPI.Data
{
    public class TeamsDatabaseSettings
    {
        public string ConnectionString { get; set; } = string.Empty;
        public string DatabaseName { get; set; } = string.Empty;
        public string TeamsCollectionName { get; set; } = string.Empty;
    }
}
