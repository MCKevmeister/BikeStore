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
        private string Name { get; set; }
        private string ManufacturerId { get; set; }
        private decimal Price { get; set; }
        private string Description { get; set; }
        private int Weight { get; set; }
        private DateTime LastModified { get; set; }
        private int StockAmount { get; set; }
    }
}