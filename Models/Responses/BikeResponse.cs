namespace BikeStore.Models.Responses
{
    public class BikeResponse
    {
        public BikeResponse(Bike bike)
        {
            if (bike == null) return;
            Bike = bike;
        }

        public BikeResponse(bool success, string message, Bike bike = null)
        {
            Success = success;
            if (success)
            {
                Bike = bike;
                SuccessMessage = message;
            }
            else ErrorMessage = message;
        }

        private bool Success { get; set; }
        private string SuccessMessage { get; set; }
        private string ErrorMessage { get; set; }
        private Bike Bike { get; set; }
    }
}