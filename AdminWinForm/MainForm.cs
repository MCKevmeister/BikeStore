using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminWinForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            itemListView.View = View.Details;
            itemListView.Columns.Add("Name");
            itemListView.Columns.Add("Price");
            itemListView.Columns.Add("Stock");


            ListViewItem item1 = new("Merida eSpresso 500 EQ");
            item1.SubItems.Add("$2,299");
            item1.SubItems.Add("3");
            ListViewItem item2 = new("Velectrix Urban Hybrid Electric Bike Blue");
            item2.SubItems.Add("$5,250.00");
            item2.SubItems.Add("7");
            ListViewItem item3 = new("Norco Sight VLT C3 Electric All-Mountain Bike ");
            item3.SubItems.Add("$8,899");
            item3.SubItems.Add("5");

            var x = itemListView.Width / 3;

            foreach (ColumnHeader column in itemListView.Columns)
            {
                column.Width = x;
            }


            itemListView.Items.AddRange(new[] { item1, item2, item3 });
        }

        private void categoryButton_Click(object sender, EventArgs e)
        {
            var itemForm = new ItemForm();
            itemForm.Show();
        }

        private void addItemButton_Click(object sender, EventArgs e)
        {
            var newItemForm = new EditItemDetials();
            newItemForm.Show();
        }

        private void viewOrdersButton_Click(object sender, EventArgs e)
        {
            var orderForm = new OrderForm();
            orderForm.Show();
        }
    }
}
