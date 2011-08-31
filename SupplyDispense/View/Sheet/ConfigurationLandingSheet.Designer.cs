using SupplyDispense.View.Control;

namespace SupplyDispense.View.Sheet
{
    partial class ConfigurationLandingSheet
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
            this.MainLandingControl = new SupplyDispense.View.Control.ConfigurationLandingControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // MainLandingControl
            // 
            this.MainLandingControl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MainLandingControl.Location = new System.Drawing.Point(-24, 156);
            this.MainLandingControl.Name = "MainLandingControl";
            this.MainLandingControl.Size = new System.Drawing.Size(821, 317);
            this.MainLandingControl.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 490);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 110);
            this.panel2.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 465);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 68);
            this.panel1.TabIndex = 9;
            // 
            // ConfigurationLandingSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MainLandingControl);
            this.Name = "ConfigurationLandingSheet";
            this.Controls.SetChildIndex(this.MainLandingControl, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.Options, 0);
            this.Controls.SetChildIndex(this.PrintScreenOnly, 0);
            this.Controls.SetChildIndex(this.ConnectionInfo, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private Control.ConfigurationLandingControl MainLandingControl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}
