using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Labb2Webbutveckling.Models
{
    public class Customer
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
        public string? FirstName { get; set; } = string.Empty;
        public string? LastName { get; set; } = string.Empty;
        public string? Email { get; set; } = string.Empty;
        public string? Adress { get; set; }
        public int PhoneNumber { get; set; }
    }
}