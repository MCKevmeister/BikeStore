
namespace ClientWinForm
{
    partial class ManufacturerForm
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
            this.MainLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.viewCategoriesButton = new System.Windows.Forms.Button();
            this.viewManufacturersBikesButton = new System.Windows.Forms.Button();
            this.manufacturerListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // MainLabel
            // 
            this.MainLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MainLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.MainLabel.Location = new System.Drawing.Point(0, 0);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(754, 55);
            this.MainLabel.TabIndex = 9;
            this.MainLabel.Text = "Select a Manufacturer";
            this.MainLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 22);
            this.label1.TabIndex = 10;
            // 
            // viewCategoriesButton
            // 
            this.viewCategoriesButton.Location = new System.Drawing.Point(24, 322);
            this.viewCategoriesButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.viewCategoriesButton.Name = "viewCategoriesButton";
            this.viewCategoriesButton.Size = new System.Drawing.Size(194, 42);
            this.viewCategoriesButton.TabIndex = 7;
            this.viewCategoriesButton.Text = "View Categories";
            this.viewCategoriesButton.UseVisualStyleBackColor = true;
            // 
            // viewManufacturersBikesButton
            // 
            this.viewManufacturersBikesButton.Location = new System.Drawing.Point(24, 274);
            this.viewManufacturersBikesButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.viewManufacturersBikesButton.Name = "viewManufacturersBikesButton";
            this.viewManufacturersBikesButton.Size = new System.Drawing.Size(194, 42);
            this.viewManufacturersBikesButton.TabIndex = 8;
            this.viewManufacturersBikesButton.Text = "View Manufacturers Bikes";
            this.viewManufacturersBikesButton.UseVisualStyleBackColor = true;
            this.viewManufacturersBikesButton.Click += new System.EventHandler(this.viewManufacturersBikesButton_Click);
            // 
            // manufacturerListView
            // 
            this.manufacturerListView.HideSelection = false;
            this.manufacturerListView.Location = new System.Drawing.Point(12, 58);
            this.manufacturerListView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.manufacturerListView.Name = "manufacturerListView";
            this.manufacturerListView.Size = new System.Drawing.Size(730, 210);
            this.manufacturerListView.TabIndex = 5;
            this.manufacturerListView.UseCompatibleStateImageBehavior = false;
            // 
            // ManufacturerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 432);
            this.Controls.Add(this.MainLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.viewCategoriesButton);
            this.Controls.Add(this.viewManufacturersBikesButton);
            this.Controls.Add(this.manufacturerListView);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ManufacturerForm";
            this.Text = "Manufacturer";
            this.Load += new System.EventHandler(this.Manufacturer_Load);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.ListView manufacturerListView;

        #endregion

        private System.Windows.Forms.Label MainLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button viewCategoriesButton;
        private System.Windows.Forms.Button viewManufacturersBikesButton;
        private System.Windows.Forms.ListView categoryListView;
    }
}