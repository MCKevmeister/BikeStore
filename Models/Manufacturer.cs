using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.Options;

namespace BikeStore.Models
{
    public class Manufacturer : IEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId Id { get; set; }

        [BsonElement("name")] 
        [Required]
        public string Name { get; set; }

        // [BsonDictionaryOptions(DictionaryRepresentation.ArrayOfDocuments)]
        // [Required]
        // public Dictionary<string, int> BikeList { get; set; } //list or dictionary
    }
}