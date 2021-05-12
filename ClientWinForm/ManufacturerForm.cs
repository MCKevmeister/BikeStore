using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientWinForm
{
    public partial class ManufacturerForm : Form
    {
        public ManufacturerForm()
        {
            InitializeComponent();
        }

        private void Manufacturer_Load(object sender, EventArgs e)
        {
            manufacturerListView.View = View.Details;
            manufacturerListView.Columns.Add("Name");
             
            ListViewItem item1 = new("Merida");
            ListViewItem item2 = new("Velectrix");
            ListViewItem item3 = new("Norco");

            manufacturerListView.Items.AddRange(new[] { item1, item2, item3 });
        }

        private void viewManufacturersBikesButton_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}
