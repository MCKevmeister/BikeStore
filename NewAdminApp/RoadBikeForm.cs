using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using BikeStore.Models;
using BikeStore.RestApiClient;

namespace NewAdminApp
{
    public partial class RoadBikeForm : Form
    {
        private static IEnumerable<RoadBike> RoadBikes { get; set; }
        // public static RoadBikeForm BuildRoadBikeForm()
        // {
        //     var form = new RoadBikeForm();
        //     form.UpdateForm();
        //     return form;
        // }
        public RoadBikeForm()
        {
            InitializeComponent();
            UpdateForm();
            roadBikeDataGridView.DataSource = null;
            roadBikeDataGridView.MultiSelect = false;
            roadBikeDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            roadBikeDataGridView.AutoGenerateColumns = false;
        }
        private async void UpdateForm()
        {
            roadBikeDataGridView.DataSource = null;
            RoadBikes = await RestClient.GetRoadBikesAsync();
            roadBikeDataGridView.DataSource = RoadBikes;
        }
        private void menuButton_Click(object sender, EventArgs e)
        {
            var mainForm = new MainForm();
            mainForm.Show();
            Hide();
        }

        private void viewRoadBikeButton_Click(object sender, EventArgs e)
        {
            var id = (int)roadBikeDataGridView.SelectedRows[0].Cells[0].Value;
            var selectedBike = RestClient.GetRoadBikeAsync(id).Result;
            //var bikeDetails = new EditRoadBikeForm(selectedBike);
            //bikeDetails.Show();
            //Hide();
        }
    }
}