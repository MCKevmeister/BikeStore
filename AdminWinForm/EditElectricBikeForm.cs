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
    public partial class EditElectricBikeForm : EditItemDetails
    {
        public string Motor { get; set; }
        public EditElectricBikeForm()
        {
            InitializeComponent();
        }

        private void saveElectricBikeButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
