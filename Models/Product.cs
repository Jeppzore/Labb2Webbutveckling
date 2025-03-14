using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Labb2Webbutveckling.Models
{
    public enum ProductStatus
    {
        Available,
        Unavailable
    }

    public class Product
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
        public string ProductNumber { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string Category { get; set; } = string.Empty;
        public ProductStatus Status { get; set; } = ProductStatus.Available;
    }
}