using System.Collections.Generic;
using BikeStore.Models;

namespace WebApplication2.Models
{
    public class ManufacturersViewModel
    {
        public string Title { get; set; }
        public IEnumerable<Manufacturer> Manufacturers { get; set; }
    }
}