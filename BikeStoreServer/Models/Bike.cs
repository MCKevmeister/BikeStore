using System;
using System.ComponentModel.DataAnnotations;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace BikeStoreServer.Models
{
    public class Bike
    {
        [BsonId]
        public ObjectId BikeId { get; set; }
        [Required]
        public Manufacturer ManufacturerId { get; set; }
        [Required]
        public char Name { get; set; }
        [Required]
        public decimal Price { get; set; }
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