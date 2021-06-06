using System;
using System.ComponentModel.DataAnnotations;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;

namespace BikeStore.Models
{
    public abstract class Bike : IEntity
    {
        protected Bike(string name, string manufacturerId, decimal price, string description, int weight,
            DateTime lastModified, int stockAmount)
        {
            Name = name;
            ManufacturerId = manufacturerId;
            Price = price;
            Description = description;
            Weight = weight;
            LastModified = new DateTime();
            StockAmount = stockAmount;
        }
        [BsonRepresentation(BsonType.ObjectId)] 
        public string Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        private string ManufacturerId { get; set; }
        [Required]
        private decimal Price { get; set; }
        [Required] 
        private string Description { get; set; }
        [Required]
        private int Weight { get; set; }
        [Required]
        private DateTime LastModified { get; set; }
        [Required] 
        private int StockAmount { get; set; }
    }
}