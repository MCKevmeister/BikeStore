
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
            this.viewManufacturerButton = new System.Windows.Forms.Button();
            this.viewItemButton = new System.Windows.Forms.Button();
            this.viewCategoriesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bikeListView
            // 
            this.bikeListView.HideSelection = false;
            this.bikeListView.Location = new System.Drawing.Point(12, 46);
            this.bikeListView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bikeListView.Name = "bikeListView";
            this.bikeListView.Size = new System.Drawing.Size(730, 169);
            this.bikeListView.TabIndex = 0;
            this.bikeListView.UseCompatibleStateImageBehavior = false;
            // 
            // currentStockLabel
            // 
            this.currentStockLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.currentStockLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold);
            this.currentStockLabel.Location = new System.Drawing.Point(0, 0);
            this.currentStockLabel.Name = "currentStockLabel";
            this.currentStockLabel.Size = new System.Drawing.Size(754, 41);
            this.currentStockLabel.TabIndex = 1;
            this.currentStockLabel.Text = "Electric Bikes";
            this.currentStockLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.currentStockLabel.Click += new System.EventHandler(this.currentStockLabel_Click);
            // 
            // viewManufacturerButton
            // 
            this.viewManufacturerButton.Location = new System.Drawing.Point(25, 258);
            this.viewManufacturerButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.viewManufacturerButton.Name = "viewManufacturerButton";
            this.viewManufacturerButton.Size = new System.Drawing.Size(171, 34);
            this.viewManufacturerButton.TabIndex = 4;
            this.viewManufacturerButton.Text = "View Manufacturers";
            this.viewManufacturerButton.UseVisualStyleBackColor = true;
            // 
            // viewItemButton
            // 
            this.viewItemButton.Location = new System.Drawing.Point(25, 219);
            this.viewItemButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.viewItemButton.Name = "viewItemButton";
            this.viewItemButton.Size = new System.Drawing.Size(171, 34);
            this.viewItemButton.TabIndex = 5;
            this.viewItemButton.Text = "View Item";
            this.viewItemButton.UseVisualStyleBackColor = true;
            this.viewItemButton.Click += new System.EventHandler(this.viewItemButton_Click);
            // 
            // viewCategoriesButton
            // 
            this.viewCategoriesButton.Location = new System.Drawing.Point(25, 298);
            this.viewCategoriesButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.viewCategoriesButton.Name = "viewCategoriesButton";
            this.viewCategoriesButton.Size = new System.Drawing.Size(171, 34);
            this.viewCategoriesButton.TabIndex = 3;
            this.viewCategoriesButton.Text = "View Categories";
            this.viewCategoriesButton.UseVisualStyleBackColor = true;
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 346);
            this.Controls.Add(this.viewItemButton);
            this.Controls.Add(this.viewCategoriesButton);
            this.Controls.Add(this.viewManufacturerButton);
            this.Controls.Add(this.currentStockLabel);
            this.Controls.Add(this.bikeListView);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CategoryForm";
            this.Text = "View Item";
            this.Load += new System.EventHandler(this.CategoryForm_Load);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label currentStockLabel;

        #endregion

        private System.Windows.Forms.ListView bikeListView;
        private System.Windows.Forms.Button viewManufacturerButton;
        private System.Windows.Forms.Button viewItemButton;
        private System.Windows.Forms.Button viewCategoriesButton;
    }
}