using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BikeStore.Models;
using static ClientWinForm.ManufacturerForm;

namespace ClientWinForm
{
    public partial class MainForm : Form
    {
        private ManufacturerForm _manufacturerForm;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UpdateForm();
        }

        private void UpdateForm()
        {
        }
        private void categoryButton_Click(object sender, EventArgs e)
        {
            var categoryForm = new CategoryForm();
            categoryForm.Show();
        }

        private async Task manufacturerButton_Click(object sender, EventArgs e)
        {
            _manufacturerForm = await _manufacturerForm.BuildManufacturerForm();
            _manufacturerForm.Show();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
