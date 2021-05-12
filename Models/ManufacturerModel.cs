using System.ComponentModel.DataAnnotations;
using MongoDB.Bson.Serialization.Attributes;

namespace Models
{
    public class ManufacturerModel
    {
        [BsonId]
        public int ManufacturerId { get; set; }
        [Required]
        public char ManufacturerName { get; set; }
    }
}