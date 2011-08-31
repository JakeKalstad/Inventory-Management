using SupplyDispense.View.Control;

namespace SupplyDispense.View.Sheet
{
    partial class LoginSheet
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.TopLogo = new System.Windows.Forms.PictureBox();
            this.bottomLogo = new System.Windows.Forms.PictureBox();
            this.LoginControl = new SupplyDispense.View.Control.LoginControl();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 324);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(579, 118);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(3, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(579, 142);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // TopLogo
            // 
            this.TopLogo.Location = new System.Drawing.Point(4, 5);
            this.TopLogo.Name = "TopLogo";
            this.TopLogo.Size = new System.Drawing.Size(793, 166);
            this.TopLogo.TabIndex = 2;
            this.TopLogo.TabStop = false;
            // 
            // bottomLogo
            // 
            this.bottomLogo.Location = new System.Drawing.Point(4, 406);
            this.bottomLogo.Name = "bottomLogo";
            this.bottomLogo.Size = new System.Drawing.Size(796, 191);
            this.bottomLogo.TabIndex = 4;
            this.bottomLogo.TabStop = false;
            // 
            // LoginControl
            // 
            this.LoginControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LoginControl.Location = new System.Drawing.Point(194, 184);
            this.LoginControl.Name = "LoginControl";
            this.LoginControl.Size = new System.Drawing.Size(386, 171);
            this.LoginControl.TabIndex = 0;
            // 
            // LoginSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TopLogo);
            this.Controls.Add(this.LoginControl);
            this.Controls.Add(this.bottomLogo);
            this.Name = "LoginSheet";
            this.Controls.SetChildIndex(this.bottomLogo, 0);
            this.Controls.SetChildIndex(this.LoginControl, 0);
            this.Controls.SetChildIndex(this.TopLogo, 0);
            this.Controls.SetChildIndex(this.Options, 0);
            this.Controls.SetChildIndex(this.PrintScreenOnly, 0);
            this.Controls.SetChildIndex(this.ConnectionInfo, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox TopLogo;
        private LoginControl LoginControl;
        private System.Windows.Forms.PictureBox bottomLogo;
    }
}
