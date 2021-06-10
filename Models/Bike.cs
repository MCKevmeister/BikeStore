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
        [BsonElement("name")] [Required] public string Name { get; set; }
        [BsonElement("manufacturerId")] [Required] public string ManufacturerId { get; set; }
        [BsonElement("price")] [Required] public decimal Price { get; set; }
        [BsonElement("description")] [Required] public string Description { get; set; }
        [BsonElement("weight")] [Required] public int Weight { get; set; }
        [BsonElement("lastModified")] [Required] public DateTime LastModified { get; set; }
        [BsonElement("stockAmount")] [Required] public int StockAmount { get; set; }
    }
}