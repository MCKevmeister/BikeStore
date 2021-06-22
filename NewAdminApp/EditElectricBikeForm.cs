using System;
using BikeStore.Models;

namespace NewAdminApp
{
    public partial class EditElectricBikeForm : EditItemDetails
    {
        private string Motor { get; set; }
        private ElectricBike ElectricBike { get; set; }
        
        public EditElectricBikeForm(ElectricBike electricBike)
        {
            InitializeComponent();
            ElectricBike = electricBike;
            UpdateDisplay();
        }

        private void UpdateDisplay()
        {
            
        }

        private void saveElectricBikeButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
