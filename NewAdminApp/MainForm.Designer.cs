
namespace NewAdminApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.closeButton = new System.Windows.Forms.Button();
            this.viewElectricBikeStock = new System.Windows.Forms.Button();
            this.viewRoadBikeStock = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.MainLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(25, 390);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(171, 43);
            this.closeButton.TabIndex = 6;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // viewElectricBikeStock
            // 
            this.viewElectricBikeStock.Location = new System.Drawing.Point(25, 125);
            this.viewElectricBikeStock.Name = "viewElectricBikeStock";
            this.viewElectricBikeStock.Size = new System.Drawing.Size(171, 43);
            this.viewElectricBikeStock.TabIndex = 8;
            this.viewElectricBikeStock.Text = "Electric Bike Stock";
            this.viewElectricBikeStock.UseVisualStyleBackColor = true;
            this.viewElectricBikeStock.Click += new System.EventHandler(this.viewElectricBikeStock_Click);
            // 
            // viewRoadBikeStock
            // 
            this.viewRoadBikeStock.Location = new System.Drawing.Point(25, 206);
            this.viewRoadBikeStock.Name = "viewRoadBikeStock";
            this.viewRoadBikeStock.Size = new System.Drawing.Size(171, 43);
            this.viewRoadBikeStock.TabIndex = 8;
            this.viewRoadBikeStock.Text = "Road Bike Stock";
            this.viewRoadBikeStock.UseVisualStyleBackColor = true;
            this.viewRoadBikeStock.Click += new System.EventHandler(this.viewRoadBikeStock_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 62);
            this.label1.TabIndex = 10;
            // 
            // MainLabel
            // 
            this.MainLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MainLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.MainLabel.Location = new System.Drawing.Point(0, 0);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(800, 73);
            this.MainLabel.TabIndex = 9;
            this.MainLabel.Text = "Bike Store Administration";
            this.MainLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 43);
            this.button1.TabIndex = 8;
            this.button1.Text = "View Orders";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.viewOrdersButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.viewRoadBikeStock);
            this.Controls.Add(this.viewElectricBikeStock);
            this.Name = "MainForm";
            this.Text = "Bike Store Admin";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button viewElectricBikeStock;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label MainLabel;
        private System.Windows.Forms.Button viewRoadBikeStock;
    }
}

