using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Labb2Webbutveckling.Models
{
    public class Order
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = ObjectId.GenerateNewId().ToString();

        [BsonRepresentation(BsonType.ObjectId)]
        public string CustomerId { get; set; } = null!;
        public List<OrderItem> Items { get; set; } = new();
        public decimal TotalPrice { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.UtcNow;
        public string Status { get; set; } = "Pending";
    }

    public class OrderItem
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string ProductId { get; set; } = null!;
        public int Quantity { get; set; }
    }
    
    public class UpdateStatusRequest
    {
        public string Status { get; set; } = "";
    }
}