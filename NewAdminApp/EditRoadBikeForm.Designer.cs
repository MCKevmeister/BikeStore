
namespace NewAdminApp
{
    partial class EditRoadBikeForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.saveRoadBikeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(94, 372);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Brakes:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(155, 369);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 27);
            this.textBox1.TabIndex = 17;
            // 
            // saveRoadBikeButton
            // 
            this.saveRoadBikeButton.Location = new System.Drawing.Point(28, 476);
            this.saveRoadBikeButton.Name = "saveRoadBikeButton";
            this.saveRoadBikeButton.Size = new System.Drawing.Size(171, 42);
            this.saveRoadBikeButton.TabIndex = 18;
            this.saveRoadBikeButton.Text = "Save";
            this.saveRoadBikeButton.UseVisualStyleBackColor = true;
            this.saveRoadBikeButton.Click += new System.EventHandler(this.saveRoadBikeButton_Click);
            // 
            // EditRoadBikeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 592);
            this.Controls.Add(this.saveRoadBikeButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Name = "EditRoadBikeForm";
            this.Text = "Edit Road Bike Form";
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.textBox1, 0);
            this.Controls.SetChildIndex(this.saveRoadBikeButton, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button saveRoadBikeButton;
    }
}