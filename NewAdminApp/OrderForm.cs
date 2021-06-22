using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BikeStore.Models;
using BikeStore.RestApiClient;

namespace NewAdminApp
{
    public partial class OrderForm : Form
    {
        private static IEnumerable<Order> Orders { get; set; }
        private decimal TotalValueAllOrders { get; set; }
        public OrderForm()
        {
            InitializeComponent();
            ordersDataGridView.MultiSelect = false;
            ordersDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ordersDataGridView.AutoGenerateColumns = false;
            UpdateForm();
        }
        
        private async void UpdateForm()
        {
            Orders = await RestClient.GetOrdersAsync();
            ordersDataGridView.DataSource = null;
            ordersDataGridView.DataSource = Orders;
            TotalValueAllOrders = 0;
            foreach(var order in Orders)
            {
                TotalValueAllOrders += order.TotalAmount;
            }
            totalValueLabel.Text = $@"Total Value of Orders: {TotalValueAllOrders}";
        }

        private async void deleteOrderButton_Click(object sender, EventArgs e)
        {
            var id = (int)ordersDataGridView.SelectedRows[0].Cells[0].Value;
            DialogResult dialogResult = MessageBox.Show(@"Are you sure you want to delete this order?", @"caption",MessageBoxButtons.YesNo);
            if (dialogResult != DialogResult.Yes) return;
            await RestClient.DeleteOrderAsync(id);
            UpdateForm();
        }
        private void mainMenuButton_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new();
            mainForm.Show();
            Hide();
        }
    }
}