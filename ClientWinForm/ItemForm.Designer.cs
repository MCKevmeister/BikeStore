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
            this.specificationsLabel = new System.Windows.Forms.Label();
            this.weightLabel = new System.Windows.Forms.Label();
            this.viewCategoriesButton = new System.Windows.Forms.Button();
            this.viewManufacturersButton = new System.Windows.Forms.Button();
            this.orderButton = new System.Windows.Forms.Button();
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
            this.itemNameLabel.Size = new System.Drawing.Size(754, 702);
            this.itemNameLabel.TabIndex = 0;
            this.itemNameLabel.Text = "Merida eSpresso 500 EQ";
            this.itemNameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(320, 632);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manufacturer:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(400, 416);
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
            this.label6.Size = new System.Drawing.Size(58, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Motor:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(577, 441);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Stock:";
            // 
            // itemPicture
            // 
            this.itemPicture.Location = new System.Drawing.Point(18, 62);
            this.itemPicture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.itemPicture.Name = "itemPicture";
            this.itemPicture.Size = new System.Drawing.Size(300, 300);
            this.itemPicture.TabIndex = 2;
            this.itemPicture.TabStop = false;
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.Location = new System.Drawing.Point(453, 474);
            this.customerNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(255, 27);
            this.customerNameTextBox.TabIndex = 4;
            this.customerNameTextBox.Text = "Mark";
            // 
            // quantity
            // 
            this.quantity.Location = new System.Drawing.Point(453, 441);
            this.quantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(73, 27);
            this.quantity.TabIndex = 5;
            this.quantity.Text = "1";
            // 
            // customerEmailTextBox
            // 
            this.customerEmailTextBox.Location = new System.Drawing.Point(453, 506);
            this.customerEmailTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.customerEmailTextBox.Name = "customerEmailTextBox";
            this.customerEmailTextBox.Size = new System.Drawing.Size(255, 27);
            this.customerEmailTextBox.TabIndex = 6;
            this.customerEmailTextBox.Text = "markchristison@gmail.com";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(324, 62);
            this.descriptionLabel.MaximumSize = new System.Drawing.Size(400, 0);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(399, 340);
            this.descriptionLabel.TabIndex = 7;
            this.descriptionLabel.Text = resources.GetString("descriptionLabel.Text");
            // 
            // manufacturerLabel
            // 
            this.manufacturerLabel.AutoSize = true;
            this.manufacturerLabel.Location = new System.Drawing.Point(436, 632);
            this.manufacturerLabel.Name = "manufacturerLabel";
            this.manufacturerLabel.Size = new System.Drawing.Size(56, 20);
            this.manufacturerLabel.TabIndex = 8;
            this.manufacturerLabel.Text = "Merida";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(453, 418);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(52, 20);
            this.priceLabel.TabIndex = 8;
            this.priceLabel.Text = "$4,900";
            // 
            // stockLabel
            // 
            this.stockLabel.AutoSize = true;
            this.stockLabel.Location = new System.Drawing.Point(635, 441);
            this.stockLabel.Name = "stockLabel";
            this.stockLabel.Size = new System.Drawing.Size(17, 20);
            this.stockLabel.TabIndex = 8;
            this.stockLabel.Text = "3";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.quantityLabel.Location = new System.Drawing.Point(377, 441);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(74, 20);
            this.quantityLabel.TabIndex = 9;
            this.quantityLabel.Text = "Quantity:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(396, 476);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 20);
            this.label13.TabIndex = 10;
            this.label13.Text = "Name:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(400, 506);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 20);
            this.label14.TabIndex = 11;
            this.label14.Text = "Email:";
            // 
            // specificationsLabel
            // 
            this.specificationsLabel.AutoSize = true;
            this.specificationsLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.specificationsLabel.Location = new System.Drawing.Point(383, 585);
            this.specificationsLabel.Name = "specificationsLabel";
            this.specificationsLabel.Size = new System.Drawing.Size(198, 38);
            this.specificationsLabel.TabIndex = 12;
            this.specificationsLabel.Text = "Specifications";
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Location = new System.Drawing.Point(436, 658);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(155, 20);
            this.weightLabel.TabIndex = 13;
            this.weightLabel.Text = "Shimano E6100 60Nm";
            // 
            // viewCategoriesButton
            // 
            this.viewCategoriesButton.Location = new System.Drawing.Point(18, 392);
            this.viewCategoriesButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.viewCategoriesButton.Name = "viewCategoriesButton";
            this.viewCategoriesButton.Size = new System.Drawing.Size(171, 42);
            this.viewCategoriesButton.TabIndex = 14;
            this.viewCategoriesButton.Text = "View Categories";
            this.viewCategoriesButton.UseVisualStyleBackColor = true;
            // 
            // viewManufacturersButton
            // 
            this.viewManufacturersButton.Location = new System.Drawing.Point(18, 442);
            this.viewManufacturersButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.viewManufacturersButton.Name = "viewManufacturersButton";
            this.viewManufacturersButton.Size = new System.Drawing.Size(171, 42);
            this.viewManufacturersButton.TabIndex = 15;
            this.viewManufacturersButton.Text = "View Manufacturers";
            this.viewManufacturersButton.UseVisualStyleBackColor = true;
            // 
            // orderButton
            // 
            this.orderButton.Location = new System.Drawing.Point(453, 540);
            this.orderButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(171, 42);
            this.orderButton.TabIndex = 16;
            this.orderButton.Text = "Order";
            this.orderButton.UseVisualStyleBackColor = true;
            // 
            // ItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 702);
            this.Controls.Add(this.orderButton);
            this.Controls.Add(this.viewManufacturersButton);
            this.Controls.Add(this.viewCategoriesButton);
            this.Controls.Add(this.weightLabel);
            this.Controls.Add(this.specificationsLabel);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ItemForm";
            this.Text = "Merida eSpresso 500 EQ";
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
        private System.Windows.Forms.Label specificationsLabel;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.Button viewCategoriesButton;
        private System.Windows.Forms.Button viewManufacturersButton;
        private System.Windows.Forms.Button orderButton;
    }
}