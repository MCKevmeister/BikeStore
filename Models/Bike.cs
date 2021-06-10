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
            LastModified = lastModified;
            StockAmount = stockAmount;
        }
        [BsonRepresentation(BsonType.ObjectId)] 
        public string Id { get; set; }

        public string Name { get; set; }
        public string ManufacturerId { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int Weight { get; set; }
        public DateTime LastModified { get; set; }
        public int StockAmount { get; set; }
    }
}