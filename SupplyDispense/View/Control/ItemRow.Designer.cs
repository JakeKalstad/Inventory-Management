using SupplyDispense.Model;
using SupplyDispense.Model.SubModel;

namespace SupplyDispense.View.Control
{
    partial class ItemRow
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
            this.LabelItemId = new System.Windows.Forms.Label();
            this.bsSource = new System.Windows.Forms.BindingSource(this.components);
            this.LblQuantity = new System.Windows.Forms.Label();
            this.LblItemNumber = new System.Windows.Forms.Label();
            this.LblLocation = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            ((System.ComponentModel.ISupportInitialize)(this.bsSource)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelItemId
            // 
            this.LabelItemId.AutoSize = true;
            this.LabelItemId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsSource, "Id", true));
            this.LabelItemId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelItemId.Location = new System.Drawing.Point(189, 0);
            this.LabelItemId.Name = "LabelItemId";
            this.LabelItemId.Size = new System.Drawing.Size(53, 20);
            this.LabelItemId.TabIndex = 1;
            this.LabelItemId.Text = "label2";
            // 
            // bsSource
            // 
            this.bsSource.DataSource = typeof(SupplyDispense.Model.SubModel.DisplayableItem);
            // 
            // LblQuantity
            // 
            this.LblQuantity.AutoSize = true;
            this.LblQuantity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsSource, "Quantity", true));
            this.LblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblQuantity.Location = new System.Drawing.Point(363, 11);
            this.LblQuantity.Name = "LblQuantity";
            this.LblQuantity.Size = new System.Drawing.Size(79, 29);
            this.LblQuantity.TabIndex = 2;
            this.LblQuantity.Text = "label3";
            // 
            // LblItemNumber
            // 
            this.LblItemNumber.AutoSize = true;
            this.LblItemNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsSource, "ItemNumber", true));
            this.LblItemNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblItemNumber.Location = new System.Drawing.Point(23, 0);
            this.LblItemNumber.Name = "LblItemNumber";
            this.LblItemNumber.Size = new System.Drawing.Size(116, 20);
            this.LblItemNumber.TabIndex = 3;
            this.LblItemNumber.Text = "supplyNumber";
            // 
            // LblLocation
            // 
            this.LblLocation.AutoSize = true;
            this.LblLocation.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsSource, "Location", true));
            this.LblLocation.Location = new System.Drawing.Point(61, 30);
            this.LblLocation.Name = "LblLocation";
            this.LblLocation.Size = new System.Drawing.Size(46, 17);
            this.LblLocation.TabIndex = 4;
            this.LblLocation.Text = "label3";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(472, 52);
            this.shapeContainer1.TabIndex = 5;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 7;
            this.lineShape1.X2 = 460;
            this.lineShape1.Y1 = 50;
            this.lineShape1.Y2 = 50;
            // 
            // ItemRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.LblLocation);
            this.Controls.Add(this.LblItemNumber);
            this.Controls.Add(this.LblQuantity);
            this.Controls.Add(this.LabelItemId);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "ItemRow";
            this.Size = new System.Drawing.Size(472, 52);
            ((System.ComponentModel.ISupportInitialize)(this.bsSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelItemId;
        private System.Windows.Forms.Label LblQuantity;
        private System.Windows.Forms.Label LblItemNumber;
        private System.Windows.Forms.Label LblLocation;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.BindingSource bsSource;
    }
}
