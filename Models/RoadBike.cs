using System.ComponentModel.DataAnnotations;

namespace BikeStore.Models
{
    public class RoadBike : Bike
    {
        [Required]
        public char BrakeType { get; set; }
    }
}