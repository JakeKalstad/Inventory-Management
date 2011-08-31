using System.Windows.Forms;

namespace SupplyDispense.View.Control
{
    partial class ConnectionInfoControl
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
            this.ConnectionInformation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ConnectionInformation
            // 
            this.ConnectionInformation.Location = new System.Drawing.Point(3, 1);
            this.ConnectionInformation.Name = "ConnectionInformation";
            this.ConnectionInformation.Size = new System.Drawing.Size(140, 57);
            this.ConnectionInformation.TabIndex = 3;
            this.ConnectionInformation.Text = "Connection Information";
            this.ConnectionInformation.Dock = DockStyle.Bottom | DockStyle.Left;
            this.ConnectionInformation.UseVisualStyleBackColor = true;
            // 
            // ConnectionInfoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.ConnectionInformation);
            this.Name = "ConnectionInfoControl";
            this.Size = new System.Drawing.Size(150, 61);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ConnectionInformation;
    }
}
