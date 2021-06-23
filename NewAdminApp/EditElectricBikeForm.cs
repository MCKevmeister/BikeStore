using System;
using System.Globalization;
using BikeStore.Models;
using BikeStore.RestApiClient;

namespace NewAdminApp
{
    public partial class EditElectricBikeForm : EditItemDetails
    {
        private ElectricBike ElectricBike { get; set; }
        public EditElectricBikeForm(ElectricBike electricBike, string motor)
        {
            InitializeComponent();
            ElectricBike = electricBike;
            UpdateDisplay();
        }

        private void UpdateDisplay()
        {
            itemNameTextBox.Text = ElectricBike.Name;
            descriptionTextBox.Text = ElectricBike.Description;
            priceTextBox.Text = ElectricBike.Price.ToString(CultureInfo.InvariantCulture);
            stockTextBox.Text = ElectricBike.StockAmount.ToString();
            motorTextBox.Text = ElectricBike.Motor;
        }

        private async void saveElectricBikeButton_Click(object sender, EventArgs e)
        {
            ElectricBike.Name = itemNameTextBox.Text;
            ElectricBike.Description = descriptionTextBox.Text;
            ElectricBike.Price = Convert.ToDecimal(priceTextBox.Text);
            ElectricBike.StockAmount = Convert.ToInt32(stockTextBox.Text);
            //ElectricBike.ManufacturerId = await RestClient.GetManufacturerAsync(**) how do i do this?? Pass the id of the selected manufacturer
            ElectricBike.Motor = motorTextBox.Text;
            await RestClient.UpdateElectricBikeAsync(ElectricBike);
        }
    }
}
