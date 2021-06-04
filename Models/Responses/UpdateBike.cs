namespace BikeStore.Models.Responses
{
    public class UpdateBike
    {
        public Bike OldBike{ get; set; }
        public Bike NewBike { get; set; }
    }
}