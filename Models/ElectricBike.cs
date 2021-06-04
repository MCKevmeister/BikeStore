using System;
using System.ComponentModel.DataAnnotations;

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
        [Required] 
        private string Motor { get; set; }
    }
}