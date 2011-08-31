using SupplyDispense.Model.SubModel;

namespace SupplyDispense.View.Control
{
    partial class ShiftableRow
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.bsData = new System.Windows.Forms.BindingSource(this.components);
            this.DecrementBtn = new System.Windows.Forms.Button();
            this.IncrementBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bsData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsData, "Description", true));
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // bsData
            // 
            this.bsData.DataSource = typeof(SupplyDispense.Model.SubModel.ShiftableItem);
            // 
            // DecrementBtn
            // 
            this.DecrementBtn.BackColor = System.Drawing.Color.Transparent;
            this.DecrementBtn.Location = new System.Drawing.Point(92, 16);
            this.DecrementBtn.Name = "DecrementBtn";
            this.DecrementBtn.Size = new System.Drawing.Size(25, 23);
            this.DecrementBtn.TabIndex = 1;
            this.DecrementBtn.Text = "-";
            this.DecrementBtn.UseVisualStyleBackColor = false;
            // 
            // IncrementBtn
            // 
            this.IncrementBtn.BackColor = System.Drawing.Color.Transparent;
            this.IncrementBtn.Location = new System.Drawing.Point(175, 16);
            this.IncrementBtn.Name = "IncrementBtn";
            this.IncrementBtn.Size = new System.Drawing.Size(26, 23);
            this.IncrementBtn.TabIndex = 2;
            this.IncrementBtn.Text = "+";
            this.IncrementBtn.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsData, "AmountToAdjust", true));
            this.label2.Location = new System.Drawing.Point(124, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // ShiftableRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IncrementBtn);
            this.Controls.Add(this.DecrementBtn);
            this.Controls.Add(this.label1);
            this.Name = "ShiftableRow";
            this.Size = new System.Drawing.Size(220, 44);
            ((System.ComponentModel.ISupportInitialize)(this.bsData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DecrementBtn;
        private System.Windows.Forms.Button IncrementBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource bsData;
    }
}
