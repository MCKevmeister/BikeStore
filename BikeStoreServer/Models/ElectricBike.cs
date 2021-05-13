using System.ComponentModel.DataAnnotations;

namespace BikeStoreServer.Models
{
    public class ElectricBike : Bike
    {
        [Required]
        public char Motor { get; set; }
    }
}