using SupplyDispense.Model.SubModel;

namespace SupplyDispense.View.Control
{
    partial class DataShifter
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TitleLable = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.actionBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(261, 288);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // TitleLable
            // 
            this.TitleLable.AutoSize = true;
            this.TitleLable.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "Title", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TitleLable.Location = new System.Drawing.Point(3, 8);
            this.TitleLable.Name = "TitleLable";
            this.TitleLable.Size = new System.Drawing.Size(51, 17);
            this.TitleLable.TabIndex = 1;
            this.TitleLable.Text = "default";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(SupplyDispense.Model.SubModel.ShifterModel);
            // 
            // actionBtn
            // 
            this.actionBtn.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "ActionDescription", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.actionBtn.Location = new System.Drawing.Point(3, 318);
            this.actionBtn.Name = "actionBtn";
            this.actionBtn.Size = new System.Drawing.Size(261, 50);
            this.actionBtn.TabIndex = 1;
            this.actionBtn.Text = "default";
            this.actionBtn.UseVisualStyleBackColor = true;
            // 
            // DataShifter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.actionBtn);
            this.Controls.Add(this.TitleLable);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "DataShifter";
            this.Size = new System.Drawing.Size(263, 371);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label TitleLable;
        private System.Windows.Forms.Button actionBtn;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}
