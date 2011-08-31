namespace SupplyDispense.View.Control
{
    partial class TransactionControl
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
            this.TransactionbyUserButton = new System.Windows.Forms.Button();
            this.TransactionByItemButton = new System.Windows.Forms.Button();
            this.TransactionByDateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TransactionbyUserButton
            // 
            this.TransactionbyUserButton.Location = new System.Drawing.Point(220, 12);
            this.TransactionbyUserButton.Name = "TransactionbyUserButton";
            this.TransactionbyUserButton.Size = new System.Drawing.Size(155, 139);
            this.TransactionbyUserButton.TabIndex = 2;
            this.TransactionbyUserButton.Text = "Transaction by User";
            this.TransactionbyUserButton.UseVisualStyleBackColor = true;
            // 
            // TransactionByItemButton
            // 
            this.TransactionByItemButton.Location = new System.Drawing.Point(19, 12);
            this.TransactionByItemButton.Name = "TransactionByItemButton";
            this.TransactionByItemButton.Size = new System.Drawing.Size(155, 139);
            this.TransactionByItemButton.TabIndex = 1;
            this.TransactionByItemButton.Text = "Transaction by Item";
            this.TransactionByItemButton.UseVisualStyleBackColor = true;
            // 
            // TransactionByDateButton
            // 
            this.TransactionByDateButton.Location = new System.Drawing.Point(423, 12);
            this.TransactionByDateButton.Name = "TransactionByDateButton";
            this.TransactionByDateButton.Size = new System.Drawing.Size(155, 139);
            this.TransactionByDateButton.TabIndex = 3;
            this.TransactionByDateButton.Text = "Transaction by Date";
            this.TransactionByDateButton.UseVisualStyleBackColor = true;
            // 
            // TransactionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.TransactionbyUserButton);
            this.Controls.Add(this.TransactionByItemButton);
            this.Controls.Add(this.TransactionByDateButton);
            this.Name = "TransactionControl";
            this.Size = new System.Drawing.Size(594, 161);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button TransactionbyUserButton;
        private System.Windows.Forms.Button TransactionByItemButton;
        private System.Windows.Forms.Button TransactionByDateButton;
    }
}
