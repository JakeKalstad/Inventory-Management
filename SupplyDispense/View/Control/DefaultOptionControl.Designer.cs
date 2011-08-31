namespace SupplyDispense.View.Control
{
    partial class DefaultOptionControl
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
            this.printScreenButton = new System.Windows.Forms.Button();
            this.prevScreen = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // printScreenButton
            // 
            this.printScreenButton.Location = new System.Drawing.Point(0, 3);
            this.printScreenButton.Name = "printScreenButton";
            this.printScreenButton.Size = new System.Drawing.Size(143, 40);
            this.printScreenButton.TabIndex = 1;
            this.printScreenButton.Text = "Print Screen";
            this.printScreenButton.UseVisualStyleBackColor = true;
            // 
            // prevScreen
            // 
            this.prevScreen.Location = new System.Drawing.Point(0, 49);
            this.prevScreen.Name = "prevScreen";
            this.prevScreen.Size = new System.Drawing.Size(143, 40);
            this.prevScreen.TabIndex = 2;
            this.prevScreen.Text = "Previous Screen";
            this.prevScreen.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(0, 95);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(143, 40);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // DefaultOptionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.prevScreen);
            this.Controls.Add(this.printScreenButton);
            this.Name = "DefaultOptionControl";
            this.Size = new System.Drawing.Size(148, 143);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button printScreenButton;
        private System.Windows.Forms.Button prevScreen;
        private System.Windows.Forms.Button exitButton;

    }
}
