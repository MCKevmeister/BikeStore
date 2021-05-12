using System;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class ElectricBikeModel : BikeModel
    {
        [Required]
        public char Motor { get; set; }
    }
}