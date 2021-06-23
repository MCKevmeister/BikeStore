
namespace NewAdminApp
{
    partial class ElectricBikeForm
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
            this.electricBikeDataGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BikeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.electricBikeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.titleLabel.Location = new System.Drawing.Point(0, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(1086, 55);
            this.titleLabel.TabIndex = 12;
            this.titleLabel.Text = "Electric Bike Stock";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // menuButton
            // 
            this.menuButton.Location = new System.Drawing.Point(25, 419);
            this.menuButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(171, 42);
            this.menuButton.TabIndex = 10;
            this.menuButton.Text = "Main Menu";
            this.menuButton.UseVisualStyleBackColor = true;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // viewItemButton
            // 
            this.viewItemButton.Location = new System.Drawing.Point(25, 373);
            this.viewItemButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.viewItemButton.Name = "viewItemButton";
            this.viewItemButton.Size = new System.Drawing.Size(171, 42);
            this.viewItemButton.TabIndex = 11;
            this.viewItemButton.Text = "View Item";
            this.viewItemButton.UseVisualStyleBackColor = true;
            this.viewItemButton.Click += new System.EventHandler(this.viewItemButton_Click);
            // 
            // electricBikeDataGridView
            // 
            this.electricBikeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.electricBikeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.BikeName,
            this.Price,
            this.Stock});
            this.electricBikeDataGridView.Location = new System.Drawing.Point(25, 49);
            this.electricBikeDataGridView.Name = "electricBikeDataGridView";
            this.electricBikeDataGridView.RowHeadersWidth = 51;
            this.electricBikeDataGridView.RowTemplate.Height = 29;
            this.electricBikeDataGridView.Size = new System.Drawing.Size(1049, 299);
            this.electricBikeDataGridView.TabIndex = 13;
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
            this.BikeName.HeaderText = "Bike Name";
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
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(228, 373);
            this.updateButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(171, 42);
            this.updateButton.TabIndex = 11;
            this.updateButton.Text = "Update Form";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // ElectricBikeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 510);
            this.Controls.Add(this.electricBikeDataGridView);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.viewItemButton);
            this.Name = "ElectricBikeForm";
            this.Text = "ElectricBikeForm";
            ((System.ComponentModel.ISupportInitialize)(this.electricBikeDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.Button viewItemButton;
        private System.Windows.Forms.DataGridView electricBikeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn BikeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.Button updateButton;
    }
}