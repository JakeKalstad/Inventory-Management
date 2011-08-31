namespace SupplyDispense.View.Control
{
    partial class InventoryControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DeleteItemButton = new System.Windows.Forms.Button();
            this.RestockButton = new System.Windows.Forms.Button();
            this.inventoryCountButton = new System.Windows.Forms.Button();
            this.AssignItemButton = new System.Windows.Forms.Button();
            this.AdjustReorderButton = new System.Windows.Forms.Button();
            this.TransactionReportButton = new System.Windows.Forms.Button();
            this.RestockHistoryButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DeleteItemButton
            // 
            this.DeleteItemButton.Location = new System.Drawing.Point(396, 187);
            this.DeleteItemButton.Name = "DeleteItemButton";
            this.DeleteItemButton.Size = new System.Drawing.Size(150, 140);
            this.DeleteItemButton.TabIndex = 6;
            this.DeleteItemButton.Text = "Delete Item";
            this.DeleteItemButton.UseVisualStyleBackColor = true;
            // 
            // RestockButton
            // 
            this.RestockButton.Location = new System.Drawing.Point(200, 14);
            this.RestockButton.Name = "RestockButton";
            this.RestockButton.Size = new System.Drawing.Size(150, 140);
            this.RestockButton.TabIndex = 2;
            this.RestockButton.Text = "Restock";
            this.RestockButton.UseVisualStyleBackColor = true;
            // 
            // inventoryCountButton
            // 
            this.inventoryCountButton.Location = new System.Drawing.Point(3, 14);
            this.inventoryCountButton.Name = "inventoryCountButton";
            this.inventoryCountButton.Size = new System.Drawing.Size(150, 140);
            this.inventoryCountButton.TabIndex = 1;
            this.inventoryCountButton.Text = "Inventory Count";
            this.inventoryCountButton.UseVisualStyleBackColor = true;
            // 
            // AssignItemButton
            // 
            this.AssignItemButton.Location = new System.Drawing.Point(585, 187);
            this.AssignItemButton.Name = "AssignItemButton";
            this.AssignItemButton.Size = new System.Drawing.Size(150, 140);
            this.AssignItemButton.TabIndex = 7;
            this.AssignItemButton.Text = "Assign Item";
            this.AssignItemButton.UseVisualStyleBackColor = true;
            // 
            // AdjustReorderButton
            // 
            this.AdjustReorderButton.Location = new System.Drawing.Point(396, 14);
            this.AdjustReorderButton.Name = "AdjustReorderButton";
            this.AdjustReorderButton.Size = new System.Drawing.Size(150, 140);
            this.AdjustReorderButton.TabIndex = 3;
            this.AdjustReorderButton.Text = "Adjust Reorder Point";
            this.AdjustReorderButton.UseVisualStyleBackColor = true;
            // 
            // TransactionReportButton
            // 
            this.TransactionReportButton.Location = new System.Drawing.Point(3, 187);
            this.TransactionReportButton.Name = "TransactionReportButton";
            this.TransactionReportButton.Size = new System.Drawing.Size(150, 140);
            this.TransactionReportButton.TabIndex = 4;
            this.TransactionReportButton.Text = "Transaction Report";
            this.TransactionReportButton.UseVisualStyleBackColor = true;
            // 
            // RestockHistoryButton
            // 
            this.RestockHistoryButton.Location = new System.Drawing.Point(200, 187);
            this.RestockHistoryButton.Name = "RestockHistoryButton";
            this.RestockHistoryButton.Size = new System.Drawing.Size(150, 140);
            this.RestockHistoryButton.TabIndex = 5;
            this.RestockHistoryButton.Text = "Restock History";
            this.RestockHistoryButton.UseVisualStyleBackColor = true;
            // 
            // InventoryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.RestockHistoryButton);
            this.Controls.Add(this.TransactionReportButton);
            this.Controls.Add(this.DeleteItemButton);
            this.Controls.Add(this.RestockButton);
            this.Controls.Add(this.inventoryCountButton);
            this.Controls.Add(this.AssignItemButton);
            this.Controls.Add(this.AdjustReorderButton);
            this.Name = "InventoryControl";
            this.Size = new System.Drawing.Size(746, 342);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DeleteItemButton;
        private System.Windows.Forms.Button RestockButton;
        private System.Windows.Forms.Button inventoryCountButton;
        private System.Windows.Forms.Button AssignItemButton;
        private System.Windows.Forms.Button AdjustReorderButton;
        private System.Windows.Forms.Button TransactionReportButton;
        private System.Windows.Forms.Button RestockHistoryButton;
    }
}
