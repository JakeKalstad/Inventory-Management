using SupplyDispense.View.Control;

namespace SupplyDispense.View.Sheet
{
    partial class AssignItemSheet
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
            this.assignItemControl1 = new AssignItemControl();
            this.SuspendLayout();
            // 
            // assignItemControl1
            // 
            this.assignItemControl1.Location = new System.Drawing.Point(207, 186);
            this.assignItemControl1.Name = "assignItemControl1";
            this.assignItemControl1.Size = new System.Drawing.Size(388, 263);
            this.assignItemControl1.TabIndex = 3;
            // 
            // AssignItemSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.assignItemControl1);
            this.Name = "AssignItemSheet";
            this.Controls.SetChildIndex(this.assignItemControl1, 0);
            this.Controls.SetChildIndex(this.Options, 0);
            this.Controls.SetChildIndex(this.PrintScreenOnly, 0);
            this.Controls.SetChildIndex(this.ConnectionInfo, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private Control.AssignItemControl assignItemControl1;

    }
}
