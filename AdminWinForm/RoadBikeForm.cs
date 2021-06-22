using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BikeStore.Models;
using BikeStore.RestApiClient;

namespace AdminWinForm
{
    public partial class RoadBikeForm : Form
    {
        private static IEnumerable<RoadBike> RoadBikes { get; set; }
        public static RoadBikeForm BuildRoadBikeForm()
        {
            var form = new RoadBikeForm();
            RoadBikes =  RestClient.GetRoadBikesAsync().Result;
            form.UpdateForm();
            return form;
        }
        private RoadBikeForm()
        {
            InitializeComponent();
            roadBikeDataGridView.DataSource = null;
            roadBikeDataGridView.MultiSelect = false;
            roadBikeDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            roadBikeDataGridView.AutoGenerateColumns = false;
        }
        private void UpdateForm()
        {
            roadBikeDataGridView.DataSource = null;
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