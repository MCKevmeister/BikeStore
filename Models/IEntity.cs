using System.ComponentModel.DataAnnotations;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace BikeStore.Models
{
    public interface IEntity
    {
        [BsonRepresentation(BsonType.ObjectId)] 
        string Id { get; set; }
    };
}