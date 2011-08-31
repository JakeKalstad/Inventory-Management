namespace SupplyDispense.View.Control
{
    partial class ZoomableItemRow
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
            this.actionBtn = new System.Windows.Forms.Button();
            this.itemRow1 = new SupplyDispense.View.Control.ItemRow();
            this.SuspendLayout();
            // 
            // actionBtn
            // 
            this.actionBtn.Location = new System.Drawing.Point(486, 0);
            this.actionBtn.Name = "actionBtn";
            this.actionBtn.Size = new System.Drawing.Size(210, 59);
            this.actionBtn.TabIndex = 1;
            this.actionBtn.Text = "actionButton";
            this.actionBtn.UseVisualStyleBackColor = true;
            // 
            // itemRow1
            // 
            this.itemRow1.Location = new System.Drawing.Point(3, 3);
            this.itemRow1.Name = "itemRow1";
            this.itemRow1.Size = new System.Drawing.Size(476, 56);
            this.itemRow1.TabIndex = 0;
            // 
            // ZoomableItemRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.actionBtn);
            this.Controls.Add(this.itemRow1);
            this.Name = "ZoomableItemRow";
            this.Size = new System.Drawing.Size(695, 61);
            this.ResumeLayout(false);

        }

        #endregion

        private ItemRow itemRow1;
        private System.Windows.Forms.Button actionBtn;
    }
}
