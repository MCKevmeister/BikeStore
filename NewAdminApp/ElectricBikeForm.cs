using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BikeStore.Models;
using BikeStore.RestApiClient;

namespace NewAdminApp
{
    public partial class ElectricBikeForm : Form
    {
        private static IEnumerable<ElectricBike> ElectricBikes { get; set; }
        private Manufacturer ManufacturerName { get; set; }
        public ElectricBikeForm()
        {
            InitializeComponent();
            electricBikeDataGridView.DataSource = null;
            electricBikeDataGridView.MultiSelect = false;
            electricBikeDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            electricBikeDataGridView.AutoGenerateColumns = false;
        }
        private async void UpdateForm()
        {
            electricBikeDataGridView.DataSource = null;
            ElectricBikes = await RestClient.GetElectricBikesAsync();
            electricBikeDataGridView.DataSource = ElectricBikes;
        }
        private void viewItemButton_Click(object sender, EventArgs e)
        {
            //var selectedRow = electricBikesDataGridView.SelectedRows;
        }
        private void menuButton_Click(object sender, EventArgs e)
        {
            var menu = new MainForm();
            menu.Show();
            Hide();
        }
    }
}
