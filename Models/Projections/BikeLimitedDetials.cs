using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace BikeStore.Models.Projections
{
    public class BikeLimitedDetailsProjection
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId BikeId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
    }
}