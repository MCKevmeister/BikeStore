using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BikeStore.Models;
using BikeStore.RestApiClient;

namespace AdminWinForm
{
    public partial class ElectricBikeForm : Form
    {
        private static IEnumerable<ElectricBike> ElectricBikes { get; set; }
        private Manufacturer ManufacturerName { get; set; }
        //public static ElectricBikeForm BuildElectricBikeForm()
        //{ 
        //    var form = new ElectricBikeForm();
            
        //    form.UpdateForm();
        //    return form;
        //}
        public ElectricBikeForm()
        {
            InitializeComponent();
            UpdateForm();
            electricBikeDataGridView.DataSource = null;
            electricBikeDataGridView.MultiSelect = false;
            electricBikeDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            electricBikeDataGridView.AutoGenerateColumns = false;
        }
        private void UpdateForm()
        {
            electricBikeDataGridView.DataSource = null;
            ElectricBikes = RestClient.GetElectricBikesAsync().Result;
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
