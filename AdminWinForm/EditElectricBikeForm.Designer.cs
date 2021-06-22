
namespace AdminWinForm
{
    partial class EditElectricBikeForm
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
            this.label6 = new System.Windows.Forms.Label();
            this.motorTextBox = new System.Windows.Forms.TextBox();
            this.saveElectricBikeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(99, 375);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Motor:";
            // 
            // motorTextBox
            // 
            this.motorTextBox.Location = new System.Drawing.Point(155, 372);
            this.motorTextBox.Name = "motorTextBox";
            this.motorTextBox.Size = new System.Drawing.Size(125, 27);
            this.motorTextBox.TabIndex = 18;
            // 
            // saveElectricBikeButton
            // 
            this.saveElectricBikeButton.Location = new System.Drawing.Point(28, 476);
            this.saveElectricBikeButton.Name = "saveElectricBikeButton";
            this.saveElectricBikeButton.Size = new System.Drawing.Size(171, 42);
            this.saveElectricBikeButton.TabIndex = 19;
            this.saveElectricBikeButton.Text = "Save";
            this.saveElectricBikeButton.UseVisualStyleBackColor = true;
            this.saveElectricBikeButton.Click += new System.EventHandler(this.saveElectricBikeButton_Click);
            // 
            // EditElectricBikeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 587);
            this.Controls.Add(this.saveElectricBikeButton);
            this.Controls.Add(this.motorTextBox);
            this.Controls.Add(this.label6);
            this.Name = "EditElectricBikeForm";
            this.Text = "EditElectricBikeForm";
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.motorTextBox, 0);
            this.Controls.SetChildIndex(this.saveElectricBikeButton, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox motorTextBox;
        private System.Windows.Forms.Button saveElectricBikeButton;
    }
}