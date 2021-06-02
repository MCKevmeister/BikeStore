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

        public ManufacturerResponse(bool success, string message)
        {
            Success = success;
            if (success) SuccessMessage = message;
            else ErrorMessage = message;
        }
        public bool Success { get; set; }
        public string SuccessMessage { get; set; }
        public string ErrorMessage { get; set; }
        public Manufacturer Manufacturer { get; set; }
    }
}