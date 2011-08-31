using SupplyDispense.Model.SubModel;

namespace SupplyDispense.View.Control
{
    partial class UserRow
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
            this.bsUser = new System.Windows.Forms.BindingSource(this.components);
            this.resetPassBtn = new System.Windows.Forms.Button();
            this.chgAccsBtn = new System.Windows.Forms.Button();
            this.trsctRptBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bsUser)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUser, "UserName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // bsUser
            // 
            this.bsUser.DataSource = typeof(SupplyDispense.Model.SubModel.UserRowModel);
            // 
            // resetPassBtn
            // 
            this.resetPassBtn.Location = new System.Drawing.Point(227, 14);
            this.resetPassBtn.Name = "resetPassBtn";
            this.resetPassBtn.Size = new System.Drawing.Size(134, 50);
            this.resetPassBtn.TabIndex = 1;
            this.resetPassBtn.Text = "Reset Password";
            this.resetPassBtn.UseVisualStyleBackColor = true;
            // 
            // chgAccsBtn
            // 
            this.chgAccsBtn.Location = new System.Drawing.Point(389, 14);
            this.chgAccsBtn.Name = "chgAccsBtn";
            this.chgAccsBtn.Size = new System.Drawing.Size(134, 50);
            this.chgAccsBtn.TabIndex = 2;
            this.chgAccsBtn.Text = "Change Access";
            this.chgAccsBtn.UseVisualStyleBackColor = true;
            // 
            // trsctRptBtn
            // 
            this.trsctRptBtn.Location = new System.Drawing.Point(548, 14);
            this.trsctRptBtn.Name = "trsctRptBtn";
            this.trsctRptBtn.Size = new System.Drawing.Size(134, 50);
            this.trsctRptBtn.TabIndex = 3;
            this.trsctRptBtn.Text = "Run Transaction Report";
            this.trsctRptBtn.UseVisualStyleBackColor = true;
            // 
            // UserRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.trsctRptBtn);
            this.Controls.Add(this.chgAccsBtn);
            this.Controls.Add(this.resetPassBtn);
            this.Controls.Add(this.label1);
            this.Name = "UserRow";
            this.Size = new System.Drawing.Size(681, 71);
            ((System.ComponentModel.ISupportInitialize)(this.bsUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button resetPassBtn;
        private System.Windows.Forms.Button chgAccsBtn;
        private System.Windows.Forms.Button trsctRptBtn;
        private System.Windows.Forms.BindingSource bsUser;
    }
}
