using SupplyDispense.Model.SubModel;

namespace SupplyDispense.View.Dialog
{
    partial class AddUser
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
            this.createBtn = new System.Windows.Forms.Button();
            this.userNameTxt = new System.Windows.Forms.TextBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.userIdTxt = new System.Windows.Forms.TextBox();
            this.userTypeLue = new System.Windows.Forms.ComboBox();
            this.unameLbl = new System.Windows.Forms.Label();
            this.UIdlbl = new System.Windows.Forms.Label();
            this.uTypelbl = new System.Windows.Forms.Label();
            this.bsUser = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bsUser)).BeginInit();
            this.SuspendLayout();
            // 
            // createBtn
            // 
            this.createBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.createBtn.Location = new System.Drawing.Point(43, 203);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(130, 75);
            this.createBtn.TabIndex = 4;
            this.createBtn.Text = "Create";
            this.createBtn.UseVisualStyleBackColor = true;
            // 
            // userNameTxt
            // 
            this.userNameTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUser, "Name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.userNameTxt.Location = new System.Drawing.Point(176, 23);
            this.userNameTxt.Name = "userNameTxt";
            this.userNameTxt.Size = new System.Drawing.Size(178, 22);
            this.userNameTxt.TabIndex = 1;
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(224, 203);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(130, 75);
            this.cancelBtn.TabIndex = 5;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // userIdTxt
            // 
            this.userIdTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUser, "Id", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.userIdTxt.Location = new System.Drawing.Point(176, 68);
            this.userIdTxt.Name = "userIdTxt";
            this.userIdTxt.Size = new System.Drawing.Size(178, 22);
            this.userIdTxt.TabIndex = 2;
            // 
            // userTypeLue
            // 
            this.userTypeLue.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUser, "Type", true));
            this.userTypeLue.FormattingEnabled = true;
            this.userTypeLue.Location = new System.Drawing.Point(176, 117);
            this.userTypeLue.Name = "userTypeLue";
            this.userTypeLue.Size = new System.Drawing.Size(178, 24);
            this.userTypeLue.TabIndex = 3;
            // 
            // unameLbl
            // 
            this.unameLbl.AutoSize = true;
            this.unameLbl.Location = new System.Drawing.Point(23, 27);
            this.unameLbl.Name = "unameLbl";
            this.unameLbl.Size = new System.Drawing.Size(83, 17);
            this.unameLbl.TabIndex = 8;
            this.unameLbl.Text = "User Name:";
            // 
            // UIdlbl
            // 
            this.UIdlbl.AutoSize = true;
            this.UIdlbl.Location = new System.Drawing.Point(23, 73);
            this.UIdlbl.Name = "UIdlbl";
            this.UIdlbl.Size = new System.Drawing.Size(57, 17);
            this.UIdlbl.TabIndex = 9;
            this.UIdlbl.Text = "User Id:";
            // 
            // uTypelbl
            // 
            this.uTypelbl.AutoSize = true;
            this.uTypelbl.Location = new System.Drawing.Point(23, 117);
            this.uTypelbl.Name = "uTypelbl";
            this.uTypelbl.Size = new System.Drawing.Size(78, 17);
            this.uTypelbl.TabIndex = 10;
            this.uTypelbl.Text = "User Type:";
            // 
            // bsUser
            // 
            this.bsUser.DataSource = typeof(DisplayUser);
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 290);
            this.Controls.Add(this.uTypelbl);
            this.Controls.Add(this.UIdlbl);
            this.Controls.Add(this.unameLbl);
            this.Controls.Add(this.userTypeLue);
            this.Controls.Add(this.userIdTxt);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.userNameTxt);
            this.Controls.Add(this.createBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddUser";
            this.Text = "AddUser";
            ((System.ComponentModel.ISupportInitialize)(this.bsUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.TextBox userNameTxt;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.TextBox userIdTxt;
        private System.Windows.Forms.ComboBox userTypeLue;
        private System.Windows.Forms.Label unameLbl;
        private System.Windows.Forms.Label UIdlbl;
        private System.Windows.Forms.Label uTypelbl;
        private System.Windows.Forms.BindingSource bsUser;
    }
}