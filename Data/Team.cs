using MongoDB.Bson.Serialization.Attributes;

namespace TeamsAPI.Data
{
    public class Team
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }
        public string Name { get; set; }
        public List<int> Scores { get; set; }

        /*
        public int Score1 { get; set; }
        public int Score2 { get; set; }
        public int Score3 { get; set; }
        public int Score4 { get; set; }
        public int Score5 { get; set; }
        public int Score6 { get; set; }
        public int Score7 { get; set; }
        public int Score8 { get; set; }
        */
    }
}
