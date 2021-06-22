
namespace NewAdminApp
{
    partial class RoadBikeForm
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.menuButton = new System.Windows.Forms.Button();
            this.viewItemButton = new System.Windows.Forms.Button();
            this.roadBikeDataGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BikeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.roadBikeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.titleLabel.Location = new System.Drawing.Point(0, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(1030, 55);
            this.titleLabel.TabIndex = 16;
            this.titleLabel.Text = "Road Bike Stock";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // menuButton
            // 
            this.menuButton.Location = new System.Drawing.Point(25, 404);
            this.menuButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(171, 42);
            this.menuButton.TabIndex = 14;
            this.menuButton.Text = "Main Menu";
            this.menuButton.UseVisualStyleBackColor = true;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // viewItemButton
            // 
            this.viewItemButton.Location = new System.Drawing.Point(25, 358);
            this.viewItemButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.viewItemButton.Name = "viewItemButton";
            this.viewItemButton.Size = new System.Drawing.Size(171, 42);
            this.viewItemButton.TabIndex = 15;
            this.viewItemButton.Text = "View Item";
            this.viewItemButton.UseVisualStyleBackColor = true;
            this.viewItemButton.Click += new System.EventHandler(this.viewRoadBikeButton_Click);
            // 
            // roadBikeDataGridView
            // 
            this.roadBikeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roadBikeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.BikeName,
            this.Price,
            this.Stock});
            this.roadBikeDataGridView.Location = new System.Drawing.Point(25, 58);
            this.roadBikeDataGridView.Name = "roadBikeDataGridView";
            this.roadBikeDataGridView.RowHeadersWidth = 51;
            this.roadBikeDataGridView.RowTemplate.Height = 29;
            this.roadBikeDataGridView.Size = new System.Drawing.Size(1006, 277);
            this.roadBikeDataGridView.TabIndex = 17;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Width = 125;
            // 
            // BikeName
            // 
            this.BikeName.HeaderText = "Name";
            this.BikeName.MinimumWidth = 6;
            this.BikeName.Name = "BikeName";
            this.BikeName.Width = 125;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.Width = 125;
            // 
            // Stock
            // 
            this.Stock.HeaderText = "Stock";
            this.Stock.MinimumWidth = 6;
            this.Stock.Name = "Stock";
            this.Stock.Width = 125;
            // 
            // RoadBikeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 539);
            this.Controls.Add(this.roadBikeDataGridView);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.viewItemButton);
            this.Name = "RoadBikeForm";
            this.Text = "Road Bike Form";
            ((System.ComponentModel.ISupportInitialize)(this.roadBikeDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.Button viewItemButton;
        private System.Windows.Forms.DataGridView roadBikeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn BikeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
    }
}