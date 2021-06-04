using System.ComponentModel.DataAnnotations;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace BikeStore.Models
{
    [BsonIgnoreExtraElements]
    public class Manufacturer : IEntity
    {
        public Manufacturer(string name)
        {
            Name = name;
        }

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("name")] 
        [Required]
        public string Name { get; }
    }
}