using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BikeStore.Models;
using BikeStore.RestApiClient;

namespace ClientWinForm
{
    public partial class ManufacturerForm : Form
    {
        private static List<Manufacturer> Manufacturers { get; set; }

        public async Task<ManufacturerForm> BuildManufacturerForm()
        {
            var manufacturerForm = new ManufacturerForm();
            Manufacturers = await RestClient.GetManufacturerNamesAsync();
            UpdateForm(Manufacturers);
            return manufacturerForm;
        }
        // Applying Factory Method to avoid Async methods in constructor
        // https://stackoverflow.com/questions/8145479/can-constructors-be-async
        
        private ManufacturerForm()
        {
            InitializeComponent();
        }
        private void UpdateForm(IEnumerable<Manufacturer> manufacturers)
        {
            try
            {
                //var manufacturers = await RestClient.GetManufacturerNamesAsync();
                foreach (var lvi in manufacturers.Select(manufacturer => new ListViewItem {Text = manufacturer.Name}))
                {
                    manufacturerListView.Items.Add(lvi);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.GetBaseException().Message);
                throw;
            }
            manufacturerListView.View = View.Details;

            // foreach (DataRow row in manufacturers.Rows)
            // {
            //     ListViewItem item = new ListViewItem(row[0].ToString());
            //     for (int i = 1; i < data.Columns.Count; i++)
            //     {
            //         item.SubItems.Add(row[i].ToString());
            //     }
            //     manufacturerListView.Items.Add(item);
            // }
            
            // manufacturerListView.Columns.Add("Name");
            // ListViewItem item1 = new("Merida");
            // ListViewItem item2 = new("Velectrix");
            // ListViewItem item3 = new("Norco");
            // manufacturerListView.Items.AddRange(new[] { item1, item2, item3 });
        }
        private void viewManufacturersBikesButton_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}
