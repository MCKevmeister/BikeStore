using System.Windows.Forms;

namespace NewAdminApp
{
    public partial class EditItemDetails : Form
    {
        protected EditItemDetails()
        {
            InitializeComponent();
        }
        public string itemName { get; set; }
        public string itemDescription { get; set; }
        public decimal price { get; set; }
        public int stock { get; set; }
        public string manufacturer { get; set; }
        
        private void exitButton_Click(object sender, System.EventArgs e)
        {
            MainForm mainForm = new();
            mainForm.Show();
            Hide();
        }
    }
}