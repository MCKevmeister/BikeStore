using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BikeStore.Models;
using BikeStore.RestApiClient;

namespace NewAdminApp
{
    public partial class RoadBikeForm : Form
    {
        //private static IEnumerable<RoadBike> RoadBikes { get; set; }
        private static BindingSource _roadBikes;

        public RoadBikeForm()
        {
            InitializeComponent();
            UpdateForm();
            roadBikeDataGridView.DataSource = _roadBikes;
            roadBikeDataGridView.MultiSelect = false;
            roadBikeDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            roadBikeDataGridView.AutoGenerateColumns = false;
        }
        private async void UpdateForm()
        {
            _roadBikes = new BindingSource {await RestClient.GetRoadBikesAsync()};
        }
        private void menuButton_Click(object sender, EventArgs e)
        {
            var mainForm = new MainForm();
            mainForm.Show();
            Hide();
        }

        private async void viewRoadBikeButton_Click(object sender, EventArgs e)
        {
            var id = (int)roadBikeDataGridView.SelectedRows[0].Cells[0].Value;
            var selectedBike = await RestClient.GetRoadBikeAsync(id);
            var roadBikeForm = new EditRoadBikeForm(selectedBike);
            roadBikeForm.Show();
            Hide();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            UpdateForm();
        }
    }
}