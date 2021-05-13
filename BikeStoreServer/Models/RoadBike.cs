using System.ComponentModel.DataAnnotations;

namespace BikeStoreServer.Models
{
    public class RoadBike : Bike
    {
        [Required]
        public char BrakeType { get; set; }
    }
}