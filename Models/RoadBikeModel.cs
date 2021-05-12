using System;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class RoadBikeModel : BikeModel
    {
        [Required]
        public char BrakeType { get; set; }
    }
}