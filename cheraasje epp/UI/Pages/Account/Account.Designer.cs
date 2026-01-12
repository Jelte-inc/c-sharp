using cheraasje_epp.Data;
using cheraasje_epp.Models;
using cheraasje_epp.UI.Widgets;

namespace cheraasje_epp.UI.Pages
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
            LogOutButton = new RoundedButton();
            menuButton = new Button();
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
            // LogOutButton
            // 
            LogOutButton.BackColor = Color.FromArgb(204, 0, 0);
            LogOutButton.FlatAppearance.BorderSize = 0;
            LogOutButton.FlatStyle = FlatStyle.Flat;
            LogOutButton.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LogOutButton.ForeColor = Color.White;
            LogOutButton.Location = new Point(43, 407);
            LogOutButton.Name = "LogOutButton";
            LogOutButton.Size = new Size(401, 35);
            LogOutButton.TabIndex = 6;
            LogOutButton.Text = "Log out";
            LogOutButton.UseVisualStyleBackColor = false;
            LogOutButton.Click += LogOutButton_Click;
            // 
            // menuButton
            // 
            menuButton.BackColor = Color.White;
            menuButton.Cursor = Cursors.Hand;
            menuButton.FlatAppearance.BorderSize = 0;
            menuButton.FlatStyle = FlatStyle.Flat;
            menuButton.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            menuButton.Location = new Point(12, 21);
            menuButton.Name = "menuButton";
            menuButton.Size = new Size(36, 46);
            menuButton.TabIndex = 22;
            menuButton.Text = "☰";
            menuButton.UseVisualStyleBackColor = false;
            menuButton.Click += menuButton_Click;
            // 
            // Account
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(menuButton);
            Controls.Add(LogOutButton);
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
        private RoundedButton LogOutButton;
        private Button menuButton;
    }
}
