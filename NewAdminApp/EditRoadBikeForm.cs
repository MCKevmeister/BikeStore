using System;
using BikeStore.Models;

namespace NewAdminApp
{
    public partial class EditRoadBikeForm : EditItemDetails
    {
        private RoadBike _roadBike;
        public EditRoadBikeForm(RoadBike roadBike)
        {
            InitializeComponent();
            _roadBike = roadBike;
        }

        private void saveRoadBikeButton_Click(object sender, EventArgs e)
        {

        }
    }
}
