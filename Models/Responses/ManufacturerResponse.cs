namespace BikeStore.Models.Responses
{
    public class ManufacturerResponse
    {
        public ManufacturerResponse(Manufacturer manufacturer)
        {
            if (manufacturer == null) return;
            Manufacturer = manufacturer;
        }

        public ManufacturerResponse(bool success, string message, Manufacturer manufacturer  = null)
        {
            Success = success;
            if (success)
            {
                Manufacturer = manufacturer;
                SuccessMessage = message;
            }
            else ErrorMessage = message;
        }

        private bool Success { get; set; }
        private string SuccessMessage { get; set; }
        public string ErrorMessage { get; set; }
        private Manufacturer Manufacturer { get; set; }
    }
}