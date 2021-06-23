using System;
using System.Windows.Forms;
using BikeStore.RestApiClient;

namespace NewAdminApp
{
    public partial class ElectricBikeForm : Form
    {
        private static BindingSource _electricBikes;
        public ElectricBikeForm()
        {
            InitializeComponent();
            electricBikeDataGridView.DataSource = _electricBikes;
            electricBikeDataGridView.MultiSelect = false;
            electricBikeDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            electricBikeDataGridView.AutoGenerateColumns = true;
        }
        private async void UpdateForm()
        {
            electricBikeDataGridView.DataSource = null;
            _electricBikes = new BindingSource {await RestClient.GetElectricBikesAsync()};
            electricBikeDataGridView.DataSource = _electricBikes;
            var bindingManagerBase = electricBikeDataGridView.DataBindings.BindableComponent.BindingContext[_electricBikes];
        }
        private async void viewItemButton_Click(object sender, EventArgs e)
        {
            var id = (int)electricBikeDataGridView.SelectedRows[0].Cells[0].Value;
            var selectedBike = await RestClient.GetElectricBikeAsync(id);
            var electricBikeForm = new EditElectricBikeForm(selectedBike);
            electricBikeForm.Show();
            Hide();
        }
        private void menuButton_Click(object sender, EventArgs e)
        {
            var menu = new MainForm();
            menu.Show();
            Hide();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            UpdateForm();
        }
    }
}
