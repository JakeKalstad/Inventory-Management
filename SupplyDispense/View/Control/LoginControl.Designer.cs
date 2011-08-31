using SupplyDispense.Model;
using SupplyDispense.Model.SheetModel;

namespace SupplyDispense.View.Control
{
    partial class LoginControl
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
            this.PassWordLabel = new System.Windows.Forms.Label();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.PasswordInput = new System.Windows.Forms.TextBox();
            this.loginBs = new System.Windows.Forms.BindingSource(this.components);
            this.UserNameInput = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.loginBs)).BeginInit();
            this.SuspendLayout();
            // 
            // PassWordLabel
            // 
            this.PassWordLabel.AutoSize = true;
            this.PassWordLabel.Location = new System.Drawing.Point(22, 71);
            this.PassWordLabel.Name = "PassWordLabel";
            this.PassWordLabel.Size = new System.Drawing.Size(73, 17);
            this.PassWordLabel.TabIndex = 12;
            this.PassWordLabel.Text = "Password:";
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Location = new System.Drawing.Point(48, 29);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(47, 17);
            this.LoginLabel.TabIndex = 11;
            this.LoginLabel.Text = "Login:";
            // 
            // PasswordInput
            // 
            this.PasswordInput.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loginBs, "PassWord", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.PasswordInput.Location = new System.Drawing.Point(123, 71);
            this.PasswordInput.Name = "PasswordInput";
            this.PasswordInput.PasswordChar = '#';
            this.PasswordInput.Size = new System.Drawing.Size(231, 22);
            this.PasswordInput.TabIndex = 2;
            // 
            // loginBs
            // 
            this.loginBs.DataSource = typeof(LoginModel);
            // 
            // UserNameInput
            // 
            this.UserNameInput.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loginBs, "Login", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.UserNameInput.Location = new System.Drawing.Point(123, 29);
            this.UserNameInput.Name = "UserNameInput";
            this.UserNameInput.Size = new System.Drawing.Size(231, 22);
            this.UserNameInput.TabIndex = 1;
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(166, 113);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LoginButton.Size = new System.Drawing.Size(122, 38);
            this.LoginButton.TabIndex = 8;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loginBs, "ErrorMessage", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label1.Location = new System.Drawing.Point(120, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 13;
            // 
            // LoginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PassWordLabel);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.PasswordInput);
            this.Controls.Add(this.UserNameInput);
            this.Controls.Add(this.LoginButton);
            this.Name = "LoginControl";
            this.Size = new System.Drawing.Size(386, 171);
            ((System.ComponentModel.ISupportInitialize)(this.loginBs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PassWordLabel;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.TextBox PasswordInput;
        private System.Windows.Forms.TextBox UserNameInput;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.BindingSource loginBs;
        private System.Windows.Forms.Label label1;
    }
}
