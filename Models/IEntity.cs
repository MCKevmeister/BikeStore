using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace BikeStore.Models
{
    public interface IEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        ObjectId Id { get; set; }
    };
}