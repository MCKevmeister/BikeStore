using System;
using System.ComponentModel.DataAnnotations;
using MongoDB.Bson.Serialization.Attributes;

namespace Models
{
    public class OrderModel
    {
        [BsonId] 
        public int OrderId { get; set; }
        [Required] 
        public int BikeId { get; set; }
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