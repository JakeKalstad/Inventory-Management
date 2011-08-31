namespace SupplyDispense.View.Control
{
    partial class PrintScreenOnly
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
            this.ExitButon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // printScreenButton
            // 
            this.printScreenButton.Location = new System.Drawing.Point(4, 4);
            this.printScreenButton.Name = "printScreenButton";
            this.printScreenButton.Size = new System.Drawing.Size(143, 40);
            this.printScreenButton.TabIndex = 0;
            this.printScreenButton.Text = "Print Screen";
            this.printScreenButton.UseVisualStyleBackColor = true;
            // 
            // ExitButon
            // 
            this.ExitButon.Location = new System.Drawing.Point(4, 55);
            this.ExitButon.Name = "ExitButon";
            this.ExitButon.Size = new System.Drawing.Size(143, 40);
            this.ExitButon.TabIndex = 1;
            this.ExitButon.Text = "Exit";
            this.ExitButon.UseVisualStyleBackColor = true;
            // 
            // PrintScreenOnly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ExitButon);
            this.Controls.Add(this.printScreenButton);
            this.Name = "PrintScreenOnly";
            this.Size = new System.Drawing.Size(150, 102);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button printScreenButton;
        private System.Windows.Forms.Button ExitButon;
    }
}
