
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
            this.manufacturerButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bikeListView
            // 
            this.bikeListView.HideSelection = false;
            this.bikeListView.Location = new System.Drawing.Point(12, 58);
            this.bikeListView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bikeListView.Name = "bikeListView";
            this.bikeListView.Size = new System.Drawing.Size(730, 210);
            this.bikeListView.TabIndex = 0;
            this.bikeListView.UseCompatibleStateImageBehavior = false;
            // 
            // currentStockLabel
            // 
            this.currentStockLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.currentStockLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.currentStockLabel.Location = new System.Drawing.Point(0, 0);
            this.currentStockLabel.Name = "currentStockLabel";
            this.currentStockLabel.Size = new System.Drawing.Size(754, 51);
            this.currentStockLabel.TabIndex = 1;
            this.currentStockLabel.Text = "Current Stock";
            this.currentStockLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // manufacturerButton
            // 
            this.manufacturerButton.Location = new System.Drawing.Point(25, 323);
            this.manufacturerButton.Name = "manufacturerButton";
            this.manufacturerButton.Size = new System.Drawing.Size(171, 43);
            this.manufacturerButton.TabIndex = 4;
            this.manufacturerButton.Text = "View Manufacturers";
            this.manufacturerButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 43);
            this.button1.TabIndex = 5;
            this.button1.Text = "View Item";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(25, 372);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(171, 43);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "View Categories";
            this.closeButton.UseVisualStyleBackColor = true;
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 433);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.manufacturerButton);
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
        private System.Windows.Forms.Button manufacturerButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button closeButton;
    }
}