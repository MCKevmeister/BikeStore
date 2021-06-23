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
            ordersDataGridView.DataSource = Orders;
            ordersDataGridView.MultiSelect = false;
            ordersDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ordersDataGridView.AutoGenerateColumns = false;
        }
        private async void UpdateForm()
        {
            Orders = null;
            Orders = await RestClient.GetOrdersAsync();
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
            var dialogResult = MessageBox.Show(@"Are you sure you want to delete this order?", @"caption",MessageBoxButtons.YesNo);
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
        private void updateFormButton_Click(object sender, EventArgs e)
        {
            UpdateForm();
        }
    }
}