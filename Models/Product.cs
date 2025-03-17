using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Labb2Webbutveckling.Models
{
    public enum ProductStatus
    {
        Available,
        Unavailable
    }

    public enum ProductCategory
    {
        Clothes,
        Electronics,
        Food,
        Other
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

        // Make the enum stored as a String to better clarify the status of the Product
        [BsonRepresentation(BsonType.String)]
        public ProductCategory Category { get; set; } = ProductCategory.Other;
        
        [BsonRepresentation(BsonType.String)]
        public ProductStatus Status { get; set; } = ProductStatus.Available;
    }
}