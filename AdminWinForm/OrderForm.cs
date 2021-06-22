using System;
using System.Collections.Generic;

using System.Windows.Forms;
using BikeStore.Models;
using BikeStore.RestApiClient;

namespace AdminWinForm
{
    public partial class OrderForm : Form
    {
        private static IEnumerable<Order> Orders { get; set; }
        private decimal totalValueAllOrders { get; set; }
        public OrderForm()
        {
            InitializeComponent();
            UpdateForm();
        }
        
        private void UpdateForm()
        {
            ordersDataGridView.MultiSelect = false;
            ordersDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ordersDataGridView.AutoGenerateColumns = false;
            Orders = RestClient.GetOrdersAsync().Result;
            ordersDataGridView.DataSource = null;
            ordersDataGridView.DataSource = Orders;
            totalValueAllOrders = 0;
            foreach(var order in Orders)
            {
                totalValueAllOrders += order.TotalAmount;
            }
            totalValueLabel.Text = $"Total Vlaue of Orders: {totalValueAllOrders}";
        }

        private async void deleteOrderButton_Click(object sender, EventArgs e)
        {
            int Id = (int)ordersDataGridView.SelectedRows[0].Cells[0].Value;
            DialogResult dialogResult = MessageBox.Show(@"Are you sure you want to delete this order?", "caption", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                await RestClient.DeleteOrderAsync(Id);
                UpdateForm();
            }
        }
        private void mainMenuButton_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new();
            mainForm.Show();
            Hide();
        }
    }
}