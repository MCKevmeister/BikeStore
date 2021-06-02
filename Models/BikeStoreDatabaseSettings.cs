namespace BikeStore.Models
{
    public class BikeStoreDatabaseSettings : IBikeStoreDatabaseSettings
    {
        public string OrderCollectionName { get; set; }
        public string ManufacturerCollectionName { get; set; }
        public string BikeCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
