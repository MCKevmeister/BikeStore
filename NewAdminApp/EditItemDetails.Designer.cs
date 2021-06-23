using System.ComponentModel;

namespace NewAdminApp
{
    partial class EditItemDetails
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
            this.label1 = new System.Windows.Forms.Label();
            this.itemNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.MainLabel = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.stockTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.manufacturerTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item Name:";
            // 
            // itemNameTextBox
            // 
            this.itemNameTextBox.Location = new System.Drawing.Point(156, 67);
            this.itemNameTextBox.Name = "itemNameTextBox";
            this.itemNameTextBox.Size = new System.Drawing.Size(586, 27);
            this.itemNameTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Item Description:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(156, 100);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(586, 163);
            this.descriptionTextBox.TabIndex = 3;
            this.descriptionTextBox.Text = "";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(248, 2);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(125, 27);
            this.maskedTextBox1.TabIndex = 4;
            // 
            // MainLabel
            // 
            this.MainLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MainLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.MainLabel.Location = new System.Drawing.Point(0, 0);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(800, 55);
            this.MainLabel.TabIndex = 5;
            this.MainLabel.Text = "Edit Item Detials";
            this.MainLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(156, 269);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(233, 27);
            this.priceTextBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Price:";
            // 
            // stockTextBox
            // 
            this.stockTextBox.Location = new System.Drawing.Point(156, 302);
            this.stockTextBox.Name = "stockTextBox";
            this.stockTextBox.Size = new System.Drawing.Size(233, 27);
            this.stockTextBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(102, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Stock:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 338);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Manufacturer:";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(28, 523);
            this.exitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(171, 42);
            this.exitButton.TabIndex = 15;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // manufacturerTextBox
            // 
            this.manufacturerTextBox.Location = new System.Drawing.Point(156, 335);
            this.manufacturerTextBox.Name = "manufacturerTextBox";
            this.manufacturerTextBox.Size = new System.Drawing.Size(233, 27);
            this.manufacturerTextBox.TabIndex = 16;
            // 
            // EditItemDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 574);
            this.Controls.Add(this.manufacturerTextBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.stockTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MainLabel);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.itemNameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "EditItemDetails";
            this.Text = "NewItemForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        protected System.Windows.Forms.TextBox itemNameTextBox;
        private System.Windows.Forms.Label label2;
        protected System.Windows.Forms.RichTextBox descriptionTextBox;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label MainLabel;
        protected System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label label3;
        protected System.Windows.Forms.TextBox stockTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox manufacturerTextBox;
    }
}