using System.ComponentModel;

namespace ClientWinForm
{
    partial class ItemForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemForm));
            this.itemNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.itemPicture = new System.Windows.Forms.PictureBox();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.quantity = new System.Windows.Forms.DomainUpDown();
            this.customerEmailTextBox = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.manufacturerLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.stockLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.weightLabel = new System.Windows.Forms.Label();
            this.manufacturerButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.itemPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // itemNameLabel
            // 
            this.itemNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemNameLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.itemNameLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.itemNameLabel.Location = new System.Drawing.Point(0, 0);
            this.itemNameLabel.Name = "itemNameLabel";
            this.itemNameLabel.Size = new System.Drawing.Size(754, 703);
            this.itemNameLabel.TabIndex = 0;
            this.itemNameLabel.Text = "Merida eSpresso 500 EQ";
            this.itemNameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(320, 618);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manufacturer:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(383, 638);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Price:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(366, 658);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Weight:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(577, 427);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Stock:";
            // 
            // itemPicture
            // 
            this.itemPicture.Location = new System.Drawing.Point(18, 63);
            this.itemPicture.Name = "itemPicture";
            this.itemPicture.Size = new System.Drawing.Size(300, 300);
            this.itemPicture.TabIndex = 2;
            this.itemPicture.TabStop = false;
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.Location = new System.Drawing.Point(453, 458);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(255, 27);
            this.customerNameTextBox.TabIndex = 4;
            // 
            // quantity
            // 
            this.quantity.Location = new System.Drawing.Point(453, 425);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(73, 27);
            this.quantity.TabIndex = 5;
            this.quantity.Text = "domainUpDown1";
            // 
            // customerEmailTextBox
            // 
            this.customerEmailTextBox.Location = new System.Drawing.Point(453, 491);
            this.customerEmailTextBox.Name = "customerEmailTextBox";
            this.customerEmailTextBox.Size = new System.Drawing.Size(255, 27);
            this.customerEmailTextBox.TabIndex = 6;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(324, 63);
            this.descriptionLabel.MaximumSize = new System.Drawing.Size(400, 0);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(399, 340);
            this.descriptionLabel.TabIndex = 7;
            this.descriptionLabel.Text = resources.GetString("descriptionLabel.Text");
            // 
            // manufacturerLabel
            // 
            this.manufacturerLabel.AutoSize = true;
            this.manufacturerLabel.Location = new System.Drawing.Point(436, 618);
            this.manufacturerLabel.Name = "manufacturerLabel";
            this.manufacturerLabel.Size = new System.Drawing.Size(133, 20);
            this.manufacturerLabel.TabIndex = 8;
            this.manufacturerLabel.Text = "manufacturerLabel";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(436, 638);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(42, 20);
            this.priceLabel.TabIndex = 8;
            this.priceLabel.Text = "price";
            // 
            // stockLabel
            // 
            this.stockLabel.AutoSize = true;
            this.stockLabel.Location = new System.Drawing.Point(635, 427);
            this.stockLabel.Name = "stockLabel";
            this.stockLabel.Size = new System.Drawing.Size(17, 20);
            this.stockLabel.TabIndex = 8;
            this.stockLabel.Text = "3";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.quantityLabel.Location = new System.Drawing.Point(373, 427);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(74, 20);
            this.quantityLabel.TabIndex = 9;
            this.quantityLabel.Text = "Quantity:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(392, 461);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 20);
            this.label13.TabIndex = 10;
            this.label13.Text = "Name:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(396, 494);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 20);
            this.label14.TabIndex = 11;
            this.label14.Text = "Email:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(383, 570);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(198, 38);
            this.label15.TabIndex = 12;
            this.label15.Text = "Specifications";
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Location = new System.Drawing.Point(436, 658);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(56, 20);
            this.weightLabel.TabIndex = 13;
            this.weightLabel.Text = "Weight";
            // 
            // manufacturerButton
            // 
            this.manufacturerButton.Location = new System.Drawing.Point(18, 393);
            this.manufacturerButton.Name = "manufacturerButton";
            this.manufacturerButton.Size = new System.Drawing.Size(171, 43);
            this.manufacturerButton.TabIndex = 14;
            this.manufacturerButton.Text = "View Categories";
            this.manufacturerButton.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(18, 442);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(171, 43);
            this.button3.TabIndex = 15;
            this.button3.Text = "View Manufacturers";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(453, 524);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(171, 43);
            this.button4.TabIndex = 16;
            this.button4.Text = "Order";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(18, 491);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(171, 43);
            this.closeButton.TabIndex = 18;
            this.closeButton.Text = "Main Menu";
            this.closeButton.UseVisualStyleBackColor = true;
            // 
            // ItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 703);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.manufacturerButton);
            this.Controls.Add(this.weightLabel);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.stockLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.manufacturerLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.customerEmailTextBox);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.customerNameTextBox);
            this.Controls.Add(this.itemPicture);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.itemNameLabel);
            this.Name = "ItemForm";
            this.Text = "Merida eSpresso 500 EQ";
            this.Load += new System.EventHandler(this.ItemForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label itemNameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox itemPicture;
        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.DomainUpDown quantity;
        private System.Windows.Forms.TextBox customerEmailTextBox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label manufacturerLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label stockLabel;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.Button manufacturerButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button closeButton;
    }
}