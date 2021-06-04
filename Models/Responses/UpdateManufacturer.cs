namespace BikeStore.Models.Responses
{
    public class UpdateManufacturer
    {
        public Manufacturer OldManufacturer { get; set; }
        public Manufacturer NewManufacturer { get; set; }
    }
}