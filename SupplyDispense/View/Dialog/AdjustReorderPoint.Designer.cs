using SupplyDispense.Model.SubModel;

namespace SupplyDispense.View.Dialog
{
    partial class AdjustReorderPoint
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
            this.txdNewPoint = new System.Windows.Forms.TextBox();
            this.bsdata = new System.Windows.Forms.BindingSource(this.components);
            this.IdSpot = new System.Windows.Forms.Label();
            this.bsData2 = new System.Windows.Forms.BindingSource(this.components);
            this.nameSpot = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bsdata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsData2)).BeginInit();
            this.SuspendLayout();
            // 
            // errorLbl
            // 
            this.errorLbl.AutoSize = true;
            this.errorLbl.Location = new System.Drawing.Point(230, 86);
            this.errorLbl.Name = "errorLbl";
            this.errorLbl.Size = new System.Drawing.Size(0, 17);
            this.errorLbl.TabIndex = 17;
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(183, 202);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(131, 41);
            this.cancelBtn.TabIndex = 3;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // saveBtn
            // 
            this.saveBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.saveBtn.Location = new System.Drawing.Point(39, 202);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(124, 41);
            this.saveBtn.TabIndex = 2;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            // 
            // txdNewPoint
            // 
            this.txdNewPoint.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsdata, "Newpoint", true));
            this.txdNewPoint.Location = new System.Drawing.Point(192, 160);
            this.txdNewPoint.Name = "txdNewPoint";
            this.txdNewPoint.Size = new System.Drawing.Size(131, 22);
            this.txdNewPoint.TabIndex = 1;
            // 
            // bsdata
            // 
            this.bsdata.DataSource = typeof(SupplyDispense.View.Dialog.AdjustModel);
            // 
            // IdSpot
            // 
            this.IdSpot.AutoSize = true;
            this.IdSpot.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsData2, "Id", true));
            this.IdSpot.Location = new System.Drawing.Point(189, 69);
            this.IdSpot.Name = "IdSpot";
            this.IdSpot.Size = new System.Drawing.Size(46, 17);
            this.IdSpot.TabIndex = 13;
            this.IdSpot.Text = "label5";
            // 
            // bsData2
            // 
            this.bsData2.DataSource = typeof(SupplyDispense.Model.SubModel.DisplayableItem);
            // 
            // nameSpot
            // 
            this.nameSpot.AutoSize = true;
            this.nameSpot.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsData2, "ItemDescription", true));
            this.nameSpot.Location = new System.Drawing.Point(189, 23);
            this.nameSpot.Name = "nameSpot";
            this.nameSpot.Size = new System.Drawing.Size(46, 17);
            this.nameSpot.TabIndex = 12;
            this.nameSpot.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "New Reorder Point";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Item Id:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Item Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(230, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsData2, "ReorderPoint", true));
            this.label5.Location = new System.Drawing.Point(189, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Current Reorder Point:";
            // 
            // AdjustReorderPoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 261);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.errorLbl);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.txdNewPoint);
            this.Controls.Add(this.IdSpot);
            this.Controls.Add(this.nameSpot);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AdjustReorderPoint";
            this.Text = "AdjustReorderPoint";
            ((System.ComponentModel.ISupportInitialize)(this.bsdata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsData2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label errorLbl;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.TextBox txdNewPoint;
        private System.Windows.Forms.Label IdSpot;
        private System.Windows.Forms.Label nameSpot;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource bsdata;
        private System.Windows.Forms.BindingSource bsData2;
    }
}