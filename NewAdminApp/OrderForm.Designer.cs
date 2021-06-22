
namespace NewAdminApp
{
    partial class OrderForm
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
            this.mainMenuButton = new System.Windows.Forms.Button();
            this.totalValueLabel = new System.Windows.Forms.Label();
            this.deleteOrderButton = new System.Windows.Forms.Button();
            this.ordersDataGridView = new System.Windows.Forms.DataGridView();
            this.Invoice_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bike_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // MainLabel
            // 
            this.MainLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MainLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.MainLabel.Location = new System.Drawing.Point(0, 0);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(1238, 73);
            this.MainLabel.TabIndex = 17;
            this.MainLabel.Text = "Orders";
            this.MainLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 62);
            this.label1.TabIndex = 18;
            // 
            // mainMenuButton
            // 
            this.mainMenuButton.Location = new System.Drawing.Point(25, 302);
            this.mainMenuButton.Name = "mainMenuButton";
            this.mainMenuButton.Size = new System.Drawing.Size(171, 43);
            this.mainMenuButton.TabIndex = 16;
            this.mainMenuButton.Text = "Main Menu";
            this.mainMenuButton.UseVisualStyleBackColor = true;
            this.mainMenuButton.Click += new System.EventHandler(this.mainMenuButton_Click);
            // 
            // totalValueLabel
            // 
            this.totalValueLabel.AutoSize = true;
            this.totalValueLabel.Location = new System.Drawing.Point(773, 302);
            this.totalValueLabel.Name = "totalValueLabel";
            this.totalValueLabel.Size = new System.Drawing.Size(210, 20);
            this.totalValueLabel.TabIndex = 20;
            this.totalValueLabel.Text = "Total Value of Orders:  $19,049";
            // 
            // deleteOrderButton
            // 
            this.deleteOrderButton.Location = new System.Drawing.Point(236, 302);
            this.deleteOrderButton.Name = "deleteOrderButton";
            this.deleteOrderButton.Size = new System.Drawing.Size(171, 43);
            this.deleteOrderButton.TabIndex = 19;
            this.deleteOrderButton.Text = "Delete Order";
            this.deleteOrderButton.UseVisualStyleBackColor = true;
            this.deleteOrderButton.Click += new System.EventHandler(this.deleteOrderButton_Click);
            // 
            // ordersDataGridView
            // 
            this.ordersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Invoice_Id,
            this.Date,
            this.Customer,
            this.Email,
            this.Bike_Id,
            this.Amount,
            this.Total_Amount});
            this.ordersDataGridView.Location = new System.Drawing.Point(25, 76);
            this.ordersDataGridView.Name = "ordersDataGridView";
            this.ordersDataGridView.RowHeadersWidth = 51;
            this.ordersDataGridView.RowTemplate.Height = 29;
            this.ordersDataGridView.Size = new System.Drawing.Size(1201, 188);
            this.ordersDataGridView.TabIndex = 21;
            // 
            // Invoice_Id
            // 
            this.Invoice_Id.HeaderText = "Invoice Id";
            this.Invoice_Id.MinimumWidth = 6;
            this.Invoice_Id.Name = "Invoice_Id";
            this.Invoice_Id.Width = 125;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.Width = 125;
            // 
            // Customer
            // 
            this.Customer.HeaderText = "Customer";
            this.Customer.MinimumWidth = 6;
            this.Customer.Name = "Customer";
            this.Customer.Width = 125;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.Width = 125;
            // 
            // Bike_Id
            // 
            this.Bike_Id.HeaderText = "Bike Id";
            this.Bike_Id.MinimumWidth = 6;
            this.Bike_Id.Name = "Bike_Id";
            this.Bike_Id.Width = 125;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.MinimumWidth = 6;
            this.Amount.Name = "Amount";
            this.Amount.Width = 125;
            // 
            // Total_Amount
            // 
            this.Total_Amount.HeaderText = "Total Amount";
            this.Total_Amount.MinimumWidth = 6;
            this.Total_Amount.Name = "Total_Amount";
            this.Total_Amount.Width = 125;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 450);
            this.Controls.Add(this.ordersDataGridView);
            this.Controls.Add(this.totalValueLabel);
            this.Controls.Add(this.deleteOrderButton);
            this.Controls.Add(this.MainLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mainMenuButton);
            this.Name = "OrderForm";
            this.Text = "Bike Store Admin";
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label MainLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button mainMenuButton;
        private System.Windows.Forms.Label totalValueLabel;
        private System.Windows.Forms.Button deleteOrderButton;
        private System.Windows.Forms.DataGridView ordersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Invoice_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bike_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Amount;
    }
}