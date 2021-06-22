using System;
using System.Windows.Forms;

namespace AdminWinForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void viewElectricBikeStock_Click(object sender, EventArgs e)
        {
            ElectricBikeForm electricBikeStock = new();
            electricBikeStock.Show();
            Hide();
        }

        private void viewRoadBikeStock_Click(object sender, EventArgs e)
        {
            var roadBikeStock = RoadBikeForm.BuildRoadBikeForm();
            roadBikeStock.Show();
            Hide();
        }

        private void viewOrdersButton_Click(object sender, EventArgs e)
        {
            var orderForm = new OrderForm();
            orderForm.Show();
            Hide();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}