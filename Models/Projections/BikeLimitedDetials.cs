﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Server.Models.Projections
{
    public class BikeLimitedDetialsProjection
    {
        [BsonId] 
        public ObjectId BikeId { get; set; }
        public string BikeName { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
    }
}