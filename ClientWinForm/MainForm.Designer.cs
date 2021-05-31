
namespace ClientWinForm
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.categoryListView = new System.Windows.Forms.ListView();
            this.categoryButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.MainLabel = new System.Windows.Forms.Label();
            this.manufacturerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // categoryListView
            // 
            this.categoryListView.HideSelection = false;
            this.categoryListView.Location = new System.Drawing.Point(12, 46);
            this.categoryListView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.categoryListView.Name = "categoryListView";
            this.categoryListView.Size = new System.Drawing.Size(730, 169);
            this.categoryListView.TabIndex = 0;
            this.categoryListView.UseCompatibleStateImageBehavior = false;
            // 
            // categoryButton
            // 
            this.categoryButton.Location = new System.Drawing.Point(25, 219);
            this.categoryButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.categoryButton.Name = "categoryButton";
            this.categoryButton.Size = new System.Drawing.Size(171, 34);
            this.categoryButton.TabIndex = 1;
            this.categoryButton.Text = "Open Category";
            this.categoryButton.UseVisualStyleBackColor = true;
            this.categoryButton.Click += new System.EventHandler(this.categoryButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(25, 298);
            this.closeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(171, 34);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // MainLabel
            // 
            this.MainLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold);
            this.MainLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.MainLabel.Location = new System.Drawing.Point(0, 0);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(754, 44);
            this.MainLabel.TabIndex = 3;
            this.MainLabel.Text = "Select a Category";
            this.MainLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // manufacturerButton
            // 
            this.manufacturerButton.Location = new System.Drawing.Point(25, 258);
            this.manufacturerButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.manufacturerButton.Name = "manufacturerButton";
            this.manufacturerButton.Size = new System.Drawing.Size(171, 34);
            this.manufacturerButton.TabIndex = 1;
            this.manufacturerButton.Text = "View Manufacturers";
            this.manufacturerButton.UseVisualStyleBackColor = true;
            this.manufacturerButton.Click += new System.EventHandler(this.manufacturerButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 346);
            this.Controls.Add(this.MainLabel);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.manufacturerButton);
            this.Controls.Add(this.categoryButton);
            this.Controls.Add(this.categoryListView);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Bike Store";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ListView categoryListView;
        private System.Windows.Forms.Button categoryButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label MainLabel;
        private System.Windows.Forms.Button manufacturerButton;
    }
}

