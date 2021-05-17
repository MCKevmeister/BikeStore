using System.ComponentModel.DataAnnotations;

namespace BikeStore.Models
{
    public class ElectricBike : Bike
    {
        [Required]
        public char Motor { get; set; }
    }
}