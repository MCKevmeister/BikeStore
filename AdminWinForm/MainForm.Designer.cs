
namespace AdminWinForm
{
    partial class Form1
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
            this.MainLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.manufacturerButton = new System.Windows.Forms.Button();
            this.categoryButton = new System.Windows.Forms.Button();
            this.categoryListView = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MainLabel
            // 
            this.MainLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MainLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.MainLabel.Location = new System.Drawing.Point(0, 0);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(800, 55);
            this.MainLabel.TabIndex = 9;
            this.MainLabel.Text = "Select a Category";
            this.MainLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 10;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(25, 390);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(171, 43);
            this.closeButton.TabIndex = 6;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            // 
            // manufacturerButton
            // 
            this.manufacturerButton.Location = new System.Drawing.Point(25, 341);
            this.manufacturerButton.Name = "manufacturerButton";
            this.manufacturerButton.Size = new System.Drawing.Size(171, 43);
            this.manufacturerButton.TabIndex = 7;
            this.manufacturerButton.Text = "View Manufacturers";
            this.manufacturerButton.UseVisualStyleBackColor = true;
            // 
            // categoryButton
            // 
            this.categoryButton.Location = new System.Drawing.Point(25, 292);
            this.categoryButton.Name = "categoryButton";
            this.categoryButton.Size = new System.Drawing.Size(171, 43);
            this.categoryButton.TabIndex = 8;
            this.categoryButton.Text = "Open Category";
            this.categoryButton.UseVisualStyleBackColor = true;
            // 
            // categoryListView
            // 
            this.categoryListView.HideSelection = false;
            this.categoryListView.Location = new System.Drawing.Point(12, 76);
            this.categoryListView.Name = "categoryListView";
            this.categoryListView.Size = new System.Drawing.Size(730, 210);
            this.categoryListView.TabIndex = 5;
            this.categoryListView.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(202, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 43);
            this.button1.TabIndex = 8;
            this.button1.Text = "View Orders";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(202, 341);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(171, 43);
            this.button2.TabIndex = 11;
            this.button2.Text = "Add Item";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.MainLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.manufacturerButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.categoryButton);
            this.Controls.Add(this.categoryListView);
            this.Name = "Form1";
            this.Text = "Bike Store Admin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label MainLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button manufacturerButton;
        private System.Windows.Forms.Button categoryButton;
        private System.Windows.Forms.ListView categoryListView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

