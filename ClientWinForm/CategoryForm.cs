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
            bikeListView.Columns.Add("Name", -2);
            bikeListView.Columns.Add("Price", -2);
            bikeListView.Columns.Add("Stock", -2);


            ListViewItem item1 = new("Foo");
            item1.SubItems.Add("$400");
            item1.SubItems.Add("3");
            ListViewItem item2 = new("Bar");
            item2.SubItems.Add("$300");
            item2.SubItems.Add("2");
            ListViewItem item3 = new("Baz");
            item3.SubItems.Add("$100");
            item3.SubItems.Add("23");
            
            int x = bikeListView.Width / 3;

            foreach (ColumnHeader column in bikeListView.Columns)
            {
                column.Width = x;
            }


            bikeListView.Items.AddRange(new[] { item1, item2, item3 });
        }
    }
}
