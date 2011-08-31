using SupplyDispense.View.Control;

namespace SupplyDispense.View.Sheet
{
    partial class InventoryLandingSheet
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
            this.bottomLogo = new System.Windows.Forms.PictureBox();
            this.TopLogo = new System.Windows.Forms.PictureBox();
            this.InventoryControl = new InventoryControl();
            ((System.ComponentModel.ISupportInitialize)(this.bottomLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // bottomLogo
            // 
            this.bottomLogo.Location = new System.Drawing.Point(0, 488);
            this.bottomLogo.Name = "bottomLogo";
            this.bottomLogo.Size = new System.Drawing.Size(799, 109);
            this.bottomLogo.TabIndex = 7;
            this.bottomLogo.TabStop = false;
            // 
            // TopLogo
            // 
            this.TopLogo.Location = new System.Drawing.Point(7, 5);
            this.TopLogo.Name = "TopLogo";
            this.TopLogo.Size = new System.Drawing.Size(790, 143);
            this.TopLogo.TabIndex = 6;
            this.TopLogo.TabStop = false;
            // 
            // InventoryControl
            // 
            this.InventoryControl.Location = new System.Drawing.Point(29, 144);
            this.InventoryControl.Name = "InventoryControl";
            this.InventoryControl.Size = new System.Drawing.Size(768, 340);
            this.InventoryControl.TabIndex = 9;
            // 
            // InventoryLandingSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.InventoryControl);
            this.Controls.Add(this.bottomLogo);
            this.Controls.Add(this.TopLogo);
            this.Name = "InventoryLandingSheet";
            this.Size = new System.Drawing.Size(800, 600);
            ((System.ComponentModel.ISupportInitialize)(this.bottomLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox bottomLogo;
        private System.Windows.Forms.PictureBox TopLogo;
        private Control.InventoryControl InventoryControl;

    }
}
