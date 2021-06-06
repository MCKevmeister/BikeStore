using System;
using System.ComponentModel.DataAnnotations;

namespace BikeStore.Models
{
    public class RoadBike : Bike
    {
        public RoadBike(string name, string manufacturerId, decimal price, string description, int weight,
            DateTime lastModified, int stockAmount, string breakType) : base( name,  manufacturerId,  price,  description,  weight,
            lastModified,  stockAmount)
        {
            BrakeType = breakType;
        }
        [Required]
        private string BrakeType { get; set; }
    }
}