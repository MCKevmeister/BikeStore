using System;
using System.ComponentModel.DataAnnotations;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace BikeStore.Models
{
    public class OrderModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        [Required] 
        public Bike BikeId { get; set; }
        [Required] 
        public char CustomerName { get; set; }
        [Required] 
        public char CustomerEmail { get; set; }
        [Required]
        public decimal TotalAmount { get; set; }
        [Required] 
        public DateTime OrderDate { get; set; }
    }
}