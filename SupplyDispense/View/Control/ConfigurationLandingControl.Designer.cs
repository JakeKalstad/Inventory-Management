namespace SupplyDispense.View.Control
{
    partial class ConfigurationLandingControl
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
            this.userControlButton = new System.Windows.Forms.Button();
            this.addUserButton = new System.Windows.Forms.Button();
            this.SystemSettingsButton = new System.Windows.Forms.Button();
            this.PrinterButton = new System.Windows.Forms.Button();
            this.rebootButton = new System.Windows.Forms.Button();
            this.DeleteUserButton = new System.Windows.Forms.Button();
            this.ExitAppButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userControlButton
            // 
            this.userControlButton.Location = new System.Drawing.Point(243, 0);
            this.userControlButton.Name = "userControlButton";
            this.userControlButton.Size = new System.Drawing.Size(150, 140);
            this.userControlButton.TabIndex = 2;
            this.userControlButton.Text = "User Control Panel";
            this.userControlButton.UseVisualStyleBackColor = true;
            // 
            // addUserButton
            // 
            this.addUserButton.Location = new System.Drawing.Point(42, 0);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(150, 140);
            this.addUserButton.TabIndex = 1;
            this.addUserButton.Text = "Add User";
            this.addUserButton.UseVisualStyleBackColor = true;
            // 
            // SystemSettingsButton
            // 
            this.SystemSettingsButton.Location = new System.Drawing.Point(655, 169);
            this.SystemSettingsButton.Name = "SystemSettingsButton";
            this.SystemSettingsButton.Size = new System.Drawing.Size(150, 140);
            this.SystemSettingsButton.TabIndex = 7;
            this.SystemSettingsButton.Text = "System Settings";
            this.SystemSettingsButton.UseVisualStyleBackColor = true;
            // 
            // PrinterButton
            // 
            this.PrinterButton.Location = new System.Drawing.Point(446, 0);
            this.PrinterButton.Name = "PrinterButton";
            this.PrinterButton.Size = new System.Drawing.Size(150, 140);
            this.PrinterButton.TabIndex = 3;
            this.PrinterButton.Text = "Printer Setup";
            this.PrinterButton.UseVisualStyleBackColor = true;
            // 
            // rebootButton
            // 
            this.rebootButton.Location = new System.Drawing.Point(243, 169);
            this.rebootButton.Name = "rebootButton";
            this.rebootButton.Size = new System.Drawing.Size(150, 140);
            this.rebootButton.TabIndex = 5;
            this.rebootButton.Text = "Restart System";
            this.rebootButton.UseVisualStyleBackColor = true;
            // 
            // DeleteUserButton
            // 
            this.DeleteUserButton.Location = new System.Drawing.Point(42, 169);
            this.DeleteUserButton.Name = "DeleteUserButton";
            this.DeleteUserButton.Size = new System.Drawing.Size(150, 140);
            this.DeleteUserButton.TabIndex = 4;
            this.DeleteUserButton.Text = "Delete User";
            this.DeleteUserButton.UseVisualStyleBackColor = true;
            // 
            // ExitAppButton
            // 
            this.ExitAppButton.Location = new System.Drawing.Point(446, 169);
            this.ExitAppButton.Name = "ExitAppButton";
            this.ExitAppButton.Size = new System.Drawing.Size(150, 140);
            this.ExitAppButton.TabIndex = 6;
            this.ExitAppButton.Text = "Exit Application";
            this.ExitAppButton.UseVisualStyleBackColor = true;
            // 
            // ConfigurationLandingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.rebootButton);
            this.Controls.Add(this.DeleteUserButton);
            this.Controls.Add(this.ExitAppButton);
            this.Controls.Add(this.userControlButton);
            this.Controls.Add(this.addUserButton);
            this.Controls.Add(this.SystemSettingsButton);
            this.Controls.Add(this.PrinterButton);
            this.Name = "ConfigurationLandingControl";
            this.Size = new System.Drawing.Size(843, 313);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button userControlButton;
        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.Button SystemSettingsButton;
        private System.Windows.Forms.Button PrinterButton;
        private System.Windows.Forms.Button rebootButton;
        private System.Windows.Forms.Button DeleteUserButton;
        private System.Windows.Forms.Button ExitAppButton;
    }
}
