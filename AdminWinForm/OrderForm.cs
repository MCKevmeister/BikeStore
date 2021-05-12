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
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            orderListView.View = View.Details;
            orderListView.Columns.Add("Order Number", -2, HorizontalAlignment.Left);
            orderListView.Columns.Add("Date", -2, HorizontalAlignment.Left);
            orderListView.Columns.Add("Name", -2, HorizontalAlignment.Left);
            orderListView.Columns.Add("Email", -2, HorizontalAlignment.Left);
            orderListView.Columns.Add("Item", -2, HorizontalAlignment.Left);
            orderListView.Columns.Add("Quantity", -2, HorizontalAlignment.Left);
            orderListView.Columns.Add("Total Amount", -2, HorizontalAlignment.Left);

            ListViewItem item1 = new("1121");
            item1.SubItems.Add("4/4/2021");
            item1.SubItems.Add("Mark");
            item1.SubItems.Add("markchristison@gmail.com");
            item1.SubItems.Add("Merida eSpresso 500 EQ");
            item1.SubItems.Add("1");
            item1.SubItems.Add("$4900.00");
            item1.SubItems.Add("Completed");
            ListViewItem item2 = new("1212");
            item2.SubItems.Add("5/4/2021");
            item2.SubItems.Add("John");
            item2.SubItems.Add("johnsptens@gmail.com");
            item2.SubItems.Add("Velectrix Urban Hybrid Electric Bike Blue");
            item2.SubItems.Add("1");
            item2.SubItems.Add("$5,250.00");
            item2.SubItems.Add("Pending");
            ListViewItem item3 = new("4532");
            item3.SubItems.Add("2/4/2021");
            item3.SubItems.Add("Stephen");
            item3.SubItems.Add("steve@gmail.com");
            item3.SubItems.Add("Norco Sight VLT C3 Electric All-Mountain Bike");
            item3.SubItems.Add("1");
            item3.SubItems.Add("$8,899");
            item3.SubItems.Add("Deleted");

            orderListView.Items.AddRange(new[] { item1, item2, item3 });
        }
    }
}