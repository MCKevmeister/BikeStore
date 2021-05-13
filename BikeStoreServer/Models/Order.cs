using System;
using System.ComponentModel.DataAnnotations;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace BikeStoreServer.Models
{
    public class OrderModel
    {
        [BsonId] 
        public ObjectId OrderId { get; set; }
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