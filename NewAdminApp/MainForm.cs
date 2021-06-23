using System;
using System.Windows.Forms;

namespace NewAdminApp
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
            RoadBikeForm roadBikeStock = new();
            roadBikeStock.Show();
            Hide();
        }
        private void viewOrdersButton_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new();
            orderForm.Show();
            Hide();
        }
        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}