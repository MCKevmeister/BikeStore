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

        private void MainForm_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(ex.Message, @"File Save Error");
            UpdateForm();
        }

        private void UpdateForm()
        {
            categoryListView.View = View.Details;
            categoryListView.Columns.Add("Name", -2);

            ListViewItem item1 = new("Electric Bike");
            ListViewItem item2 = new("Mountain Bike");
            ListViewItem item3 = new("Kids Bike");

            categoryListView.Items.AddRange(new[] { item1, item2, item3 });
        }
        private void categoryButton_Click(object sender, EventArgs e)
        {
            var categoryForm = new CategoryForm();
            categoryForm.Show();
        }

        private void manufacturerButton_Click(object sender, EventArgs e)
        {
            var newForm = new ManufacturerForm();
            newForm.Show();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
