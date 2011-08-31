using SupplyDispense.Model;
using SupplyDispense.Model.SheetModel;

namespace SupplyDispense.View.Control
{
    partial class AssignItemControl
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
            this.assignmentButton = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.bsAssign = new System.Windows.Forms.BindingSource(this.components);
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtRestock = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblRestock = new System.Windows.Forms.Label();
            this.LocationCombo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.bsAssign)).BeginInit();
            this.SuspendLayout();
            // 
            // assignmentButton
            // 
            this.assignmentButton.Location = new System.Drawing.Point(98, 195);
            this.assignmentButton.Name = "assignmentButton";
            this.assignmentButton.Size = new System.Drawing.Size(238, 49);
            this.assignmentButton.TabIndex = 5;
            this.assignmentButton.Text = "Assign Item";
            this.assignmentButton.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsAssign, "Name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtName.Location = new System.Drawing.Point(98, 27);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(238, 22);
            this.txtName.TabIndex = 1;
            // 
            // bsAssign
            // 
            this.bsAssign.DataSource = typeof(AssignItemModel);
            // 
            // txtId
            // 
            this.txtId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsAssign, "Id", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtId.Location = new System.Drawing.Point(98, 68);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(238, 22);
            this.txtId.TabIndex = 2;
            // 
            // txtRestock
            // 
            this.txtRestock.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsAssign, "RestockPoint", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtRestock.Location = new System.Drawing.Point(98, 151);
            this.txtRestock.Name = "txtRestock";
            this.txtRestock.Size = new System.Drawing.Size(238, 22);
            this.txtRestock.TabIndex = 4;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(0, 30);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(79, 17);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Item Name:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(0, 71);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(53, 17);
            this.lblId.TabIndex = 6;
            this.lblId.Text = "Item Id:";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(0, 113);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(96, 17);
            this.lblLocation.TabIndex = 7;
            this.lblLocation.Text = "Item Location:";
            // 
            // lblRestock
            // 
            this.lblRestock.AutoSize = true;
            this.lblRestock.Location = new System.Drawing.Point(0, 154);
            this.lblRestock.Name = "lblRestock";
            this.lblRestock.Size = new System.Drawing.Size(99, 17);
            this.lblRestock.TabIndex = 8;
            this.lblRestock.Text = "Restock Point:";
            // 
            // LocationCombo
            // 
            this.LocationCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.LocationCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.LocationCombo.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.bsAssign, "Location", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.LocationCombo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsAssign, "Location", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.LocationCombo.FormattingEnabled = true;
            this.LocationCombo.Location = new System.Drawing.Point(98, 110);
            this.LocationCombo.Name = "LocationCombo";
            this.LocationCombo.Size = new System.Drawing.Size(238, 24);
            this.LocationCombo.TabIndex = 3;
            // 
            // AssignItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.LocationCombo);
            this.Controls.Add(this.lblRestock);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtRestock);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.assignmentButton);
            this.Name = "AssignItemControl";
            this.Size = new System.Drawing.Size(335, 259);
            ((System.ComponentModel.ISupportInitialize)(this.bsAssign)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button assignmentButton;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtRestock;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblRestock;
        private System.Windows.Forms.BindingSource bsAssign;
        private System.Windows.Forms.ComboBox LocationCombo;
    }
}
