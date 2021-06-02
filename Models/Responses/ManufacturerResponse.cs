using Newtonsoft.Json;

namespace BikeStore.Models.Responses
{
    public class ManufacturerResponse
    {
        public ManufacturerResponse(Manufacturer manufacturer)
        {
            if (manufacturer == null) return;
            Manufacturer = manufacturer;
        }
        
        [JsonProperty("movie", NullValueHandling = NullValueHandling.Ignore)]
        public Manufacturer Manufacturer { get; set; }
    }
}