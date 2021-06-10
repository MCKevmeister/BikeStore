using System;
using System.ComponentModel.DataAnnotations;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace BikeStore.Models
{
    public class Order : IEntity
    {
        [BsonRepresentation(BsonType.ObjectId)] 
        public string Id { get; set; }
        [BsonElement("bike")] [Required] public string BikeId { get; set; }
        [BsonElement("customerName")] [Required] public char CustomerName { get; set; }
        [BsonElement("customerEmail")] [Required] public char CustomerEmail { get; set; }
        [BsonElement("totalAmount")] [Required] public decimal TotalAmount { get; set; }
        [BsonElement("orderDate")] [Required] public DateTime OrderDate { get; set; }
    }
}