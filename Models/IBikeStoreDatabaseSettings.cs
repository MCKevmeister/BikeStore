namespace BikeStore.Models
{
    public interface IBikeStoreDatabaseSettings
    {
        public string OrderCollectionName { get; set; }
        public string ManufacturerCollectionName { get; set; }
        string BikeCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}