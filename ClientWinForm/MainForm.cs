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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void updateCategoryListView()
        {
            categoryListView.Clear();
            categoryListView.View = View.Details;
            ListViewItem item1 = new("Mountian Bike");
            ListViewItem item2 = new("Electric Bike");
            categoryListView.Columns.Add("Categories", -2, HorizontalAlignment.Left);
            categoryListView.Items.AddRange(new ListViewItem[] { item1, item2 });
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            updateCategoryListView();
        }

        private void categoryListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
    }
}
