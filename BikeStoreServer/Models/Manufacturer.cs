using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace BikeStoreServer.Models
{
    public class Manufacturer
    {
        [BsonId]
        public ObjectId ManufacturerId { get; set; }
        [Required]
        public char ManufacturerName { get; set; }
        public IList<Bike> BikesMade { get; set; }
    }
}