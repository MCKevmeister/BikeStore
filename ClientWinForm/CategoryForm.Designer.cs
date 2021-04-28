
namespace ClientWinForm
{
    partial class CategoryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bikeListView = new System.Windows.Forms.ListView();
            this.currentStockLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bikeListView
            // 
            this.bikeListView.HideSelection = false;
            this.bikeListView.Location = new System.Drawing.Point(12, 59);
            this.bikeListView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bikeListView.Name = "bikeListView";
            this.bikeListView.Size = new System.Drawing.Size(819, 218);
            this.bikeListView.TabIndex = 0;
            this.bikeListView.UseCompatibleStateImageBehavior = false;
            // 
            // currentStockLabel
            // 
            this.currentStockLabel.Location = new System.Drawing.Point(29, 24);
            this.currentStockLabel.Name = "currentStockLabel";
            this.currentStockLabel.Size = new System.Drawing.Size(100, 23);
            this.currentStockLabel.TabIndex = 1;
            this.currentStockLabel.Text = "Current Stock";
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 360);
            this.Controls.Add(this.currentStockLabel);
            this.Controls.Add(this.bikeListView);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CategoryForm";
            this.Text = "Electric Bikes";
            this.Load += new System.EventHandler(this.CategoryForm_Load);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label currentStockLabel;

        #endregion

        private System.Windows.Forms.ListView bikeListView;
    }
}