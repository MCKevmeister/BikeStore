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
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            UpdateBikeListView();
        }
        private void UpdateBikeListView()
        {
            bikeListView.View = View.Details;
            bikeListView.Columns.Add("Name");
            bikeListView.Columns.Add("Price");
            bikeListView.Columns.Add("Stock");


            ListViewItem item1 = new("Merida eSpresso 500 EQ");
            item1.SubItems.Add("$2,299");
            item1.SubItems.Add("3");
            ListViewItem item2 = new("Velectrix Urban Hybrid Electric Bike Blue");
            item2.SubItems.Add("$5,250.00");
            item2.SubItems.Add("7");
            ListViewItem item3 = new("Norco Sight VLT C3 Electric All-Mountain Bike ");
            item3.SubItems.Add("$8,899");
            item3.SubItems.Add("5");
            
            var x = bikeListView.Width / 3;

            foreach (ColumnHeader column in bikeListView.Columns)
            {
                column.Width = x;
            }


            bikeListView.Items.AddRange(new[] { item1, item2, item3 });
        }

        private void viewItemButton_Click(object sender, EventArgs e)
        {
            var newForm = new ItemForm();
            newForm.Show();;
        }

        private void currentStockLabel_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}
