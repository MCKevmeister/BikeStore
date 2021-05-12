using System;
using System.ComponentModel.DataAnnotations;
using MongoDB.Bson.Serialization.Attributes;

namespace Models
{
    public class BikeModel
    {
        [BsonId]
        public int BikeId { get; set; }
        [Required]
        public int ManufacturerId { get; set; }
        [Required]
        public char Name { get; set; }
        [Required]
        public decimal Cost { get; set; }
        [Required]
        public char Description { get; set; }
        [Required]
        public int Weight { get; set; }
        [Required]
        public DateTime LastModified { get; set; }
        [Required]
        public int StockAmount { get; set; }
    }
}