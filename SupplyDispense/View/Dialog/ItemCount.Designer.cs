using SupplyDispense.Model.SubModel;

namespace SupplyDispense.View.Dialog
{
    partial class ItemCount
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.errorLbl = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.bsRestQty = new System.Windows.Forms.BindingSource(this.components);
            this.IdSpot = new System.Windows.Forms.Label();
            this.nameSpot = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bsRestQty)).BeginInit();
            this.SuspendLayout();
            // 
            // errorLbl
            // 
            this.errorLbl.AutoSize = true;
            this.errorLbl.Location = new System.Drawing.Point(208, 82);
            this.errorLbl.Name = "errorLbl";
            this.errorLbl.Size = new System.Drawing.Size(0, 17);
            this.errorLbl.TabIndex = 17;
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(170, 153);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(131, 41);
            this.cancelBtn.TabIndex = 3;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // saveBtn
            // 
            this.saveBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.saveBtn.Location = new System.Drawing.Point(26, 153);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(124, 41);
            this.saveBtn.TabIndex = 2;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            // 
            // txtQty
            // 
            this.txtQty.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsRestQty, "Quantity", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtQty.Location = new System.Drawing.Point(170, 107);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(131, 22);
            this.txtQty.TabIndex = 1;
            // 
            // bsRestQty
            // 
            this.bsRestQty.DataSource = typeof(SupplyDispense.Model.SubModel.DisplayableItem);
            // 
            // IdSpot
            // 
            this.IdSpot.AutoSize = true;
            this.IdSpot.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsRestQty, "Id", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.IdSpot.Location = new System.Drawing.Point(167, 65);
            this.IdSpot.Name = "IdSpot";
            this.IdSpot.Size = new System.Drawing.Size(46, 17);
            this.IdSpot.TabIndex = 13;
            this.IdSpot.Text = "label5";
            // 
            // nameSpot
            // 
            this.nameSpot.AutoSize = true;
            this.nameSpot.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsRestQty, "ItemDescription", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.nameSpot.Location = new System.Drawing.Point(167, 19);
            this.nameSpot.Name = "nameSpot";
            this.nameSpot.Size = new System.Drawing.Size(46, 17);
            this.nameSpot.TabIndex = 12;
            this.nameSpot.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Amount Counted:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Item Id:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Item Name:";
            // 
            // ItemCount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 211);
            this.Controls.Add(this.errorLbl);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.IdSpot);
            this.Controls.Add(this.nameSpot);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ItemCount";
            this.Text = "ItemCount";
            ((System.ComponentModel.ISupportInitialize)(this.bsRestQty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label errorLbl;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label IdSpot;
        private System.Windows.Forms.Label nameSpot;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bsRestQty;
    }
}