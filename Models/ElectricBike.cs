using System;
using System.ComponentModel.DataAnnotations;
using MongoDB.Bson.Serialization.Attributes;

namespace BikeStore.Models
{
    public class ElectricBike : Bike
    {
        public ElectricBike(string name, string manufacturerId, decimal price, string description, int weight,
            DateTime lastModified, int stockAmount, string motor) : base( name,  manufacturerId,  price,  description,  weight,
             lastModified,  stockAmount)
        {
            Motor = motor;
        }
        [BsonElement("motor")] [Required] public string Motor { get; set; }
    }
}