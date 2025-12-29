using cheraasje_epp.Data;
using cheraasje_epp.Models;

namespace cheraasje_epp.UI.Account
{
    partial class Account
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
            pictureBox1 = new PictureBox();
            userNameLabel = new Label();
            UserNameTitleLabel = new Label();
            UserIdTitleLabel = new Label();
            UserIdLabel = new Label();
            ChangePasswordButton = new cheraasje_epp.UI.Controls.RoundedButton();
            LogOutButton = new cheraasje_epp.UI.Controls.RoundedButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.UserInfoPageBackground;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(923, 532);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // userNameLabel
            // 
            userNameLabel.BackColor = Color.White;
            userNameLabel.Font = new Font("Sans Serif Collection", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            userNameLabel.Location = new Point(42, 150);
            userNameLabel.Margin = new Padding(0);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new Size(203, 48);
            userNameLabel.TabIndex = 1;
            userNameLabel.Text = "{USERNAME}";
            // 
            // UserNameTitleLabel
            // 
            UserNameTitleLabel.BackColor = Color.White;
            UserNameTitleLabel.Font = new Font("Sans Serif Collection", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UserNameTitleLabel.Location = new Point(41, 115);
            UserNameTitleLabel.Margin = new Padding(0);
            UserNameTitleLabel.Name = "UserNameTitleLabel";
            UserNameTitleLabel.Size = new Size(203, 48);
            UserNameTitleLabel.TabIndex = 2;
            UserNameTitleLabel.Text = "Name:";
            // 
            // UserIdTitleLabel
            // 
            UserIdTitleLabel.BackColor = Color.White;
            UserIdTitleLabel.Font = new Font("Sans Serif Collection", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UserIdTitleLabel.Location = new Point(41, 185);
            UserIdTitleLabel.Margin = new Padding(0);
            UserIdTitleLabel.Name = "UserIdTitleLabel";
            UserIdTitleLabel.Size = new Size(203, 48);
            UserIdTitleLabel.TabIndex = 3;
            UserIdTitleLabel.Text = "Employee id:";
            // 
            // UserIdLabel
            // 
            UserIdLabel.BackColor = Color.White;
            UserIdLabel.Font = new Font("Sans Serif Collection", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UserIdLabel.Location = new Point(42, 220);
            UserIdLabel.Margin = new Padding(0);
            UserIdLabel.Name = "UserIdLabel";
            UserIdLabel.Size = new Size(203, 48);
            UserIdLabel.TabIndex = 4;
            UserIdLabel.Text = "{USERID}";
            // 
            // ChangePasswordButton
            // 
            ChangePasswordButton.BaseBackColor = Color.Empty;
            ChangePasswordButton.FlatAppearance.BorderSize = 0;
            ChangePasswordButton.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ChangePasswordButton.Location = new Point(43, 362);
            ChangePasswordButton.Name = "ChangePasswordButton";
            ChangePasswordButton.Size = new Size(401, 35);
            ChangePasswordButton.TabIndex = 5;
            ChangePasswordButton.Text = "change password";
            ChangePasswordButton.UseVisualStyleBackColor = false;
            ChangePasswordButton.BackColor = Color.FromArgb(255, 87, 87);
            ChangePasswordButton.ForeColor = Color.White;
            // 
            // LogOutButton
            // 
            LogOutButton.BaseBackColor = Color.Empty;
            LogOutButton.FlatAppearance.BorderSize = 0;
            LogOutButton.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LogOutButton.Location = new Point(43, 407);
            LogOutButton.Name = "LogOutButton";
            LogOutButton.Size = new Size(401, 35);
            LogOutButton.TabIndex = 6;
            LogOutButton.Text = "Log out";
            LogOutButton.UseVisualStyleBackColor = false;
            LogOutButton.BackColor = Color.FromArgb(204, 0, 0);
            LogOutButton.ForeColor = Color.White;
            // 
            // Account
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(LogOutButton);
            Controls.Add(ChangePasswordButton);
            Controls.Add(UserNameTitleLabel);
            Controls.Add(userNameLabel);
            Controls.Add(UserIdTitleLabel);
            Controls.Add(UserIdLabel);
            Controls.Add(pictureBox1);
            Name = "Account";
            Size = new Size(923, 532);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label userNameLabel;
        private Label UserNameTitleLabel;
        private Label UserIdTitleLabel;
        private Label UserIdLabel;
        private Controls.RoundedButton ChangePasswordButton;
        private Controls.RoundedButton LogOutButton;
    }
}
