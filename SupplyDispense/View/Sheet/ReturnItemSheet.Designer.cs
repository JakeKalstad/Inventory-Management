namespace SupplyDispense.View.Sheet
{
    partial class ReturnItemSheet
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
            this.dataShifter1 = new SupplyDispense.View.Control.DataShifter();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // dataShifter1
            // 
            this.dataShifter1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataShifter1.Location = new System.Drawing.Point(514, 162);
            this.dataShifter1.Name = "dataShifter1";
            this.dataShifter1.Size = new System.Drawing.Size(267, 375);
            this.dataShifter1.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 166);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(499, 355);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // ReturnItemSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dataShifter1);
            this.Name = "ReturnItemSheet";
            this.Controls.SetChildIndex(this.dataShifter1, 0);
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            this.Controls.SetChildIndex(this.Options, 0);
            this.Controls.SetChildIndex(this.PrintScreenOnly, 0);
            this.Controls.SetChildIndex(this.ConnectionInfo, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private Control.DataShifter dataShifter1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
