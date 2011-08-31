namespace SupplyDispense.View.Control
{
    partial class MainMenuControl
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
            this.InventoryButton = new System.Windows.Forms.Button();
            this.configButton = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InventoryButton
            // 
            this.InventoryButton.Location = new System.Drawing.Point(428, 14);
            this.InventoryButton.Name = "InventoryButton";
            this.InventoryButton.Size = new System.Drawing.Size(155, 139);
            this.InventoryButton.TabIndex = 3;
            this.InventoryButton.Text = "Inventory";
            this.InventoryButton.UseVisualStyleBackColor = true;
            // 
            // configButton
            // 
            this.configButton.Location = new System.Drawing.Point(629, 14);
            this.configButton.Name = "configButton";
            this.configButton.Size = new System.Drawing.Size(155, 139);
            this.configButton.TabIndex = 4;
            this.configButton.Text = "Configuration";
            this.configButton.UseVisualStyleBackColor = true;
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(225, 14);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(155, 139);
            this.returnButton.TabIndex = 2;
            this.returnButton.Text = "Return Item";
            this.returnButton.UseVisualStyleBackColor = true;
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(24, 14);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(155, 139);
            this.removeButton.TabIndex = 1;
            this.removeButton.Text = "Remove Item";
            this.removeButton.UseVisualStyleBackColor = true;
            // 
            // MainMenuControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.configButton);
            this.Controls.Add(this.InventoryButton);
            this.Name = "MainMenuControl";
            this.Size = new System.Drawing.Size(796, 171);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button InventoryButton;
        private System.Windows.Forms.Button configButton;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Button removeButton;
    }
}
