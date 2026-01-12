
using CheraasjeEpp.UI.Widgets;

namespace CheraasjeEpp.UI.Pages
{
    partial class Login
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
            backgroundPictureBox = new PictureBox();
            userIdTextBox = new RoundedTextBox();
            passwordTextBox = new RoundedTextBox();
            loginButton = new RoundedButton();
            ((System.ComponentModel.ISupportInitialize)backgroundPictureBox).BeginInit();
            SuspendLayout();
            // 
            // backgroundPictureBox
            // 
            backgroundPictureBox.Image = Properties.Resources.LoginPageBackground;
            backgroundPictureBox.Location = new Point(0, 0);
            backgroundPictureBox.Name = "backgroundPictureBox";
            backgroundPictureBox.Size = new Size(924, 532);
            backgroundPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            backgroundPictureBox.TabIndex = 2;
            backgroundPictureBox.TabStop = false;
            // 
            // userIdTextBox
            // 
            userIdTextBox.BackColor = Color.White;
            userIdTextBox.BorderColor = Color.Red;
            userIdTextBox.BorderRadius = 15;
            userIdTextBox.BorderSize = 2;
            userIdTextBox.FillColor = SystemColors.Window;
            userIdTextBox.ForeColor = Color.Black;
            userIdTextBox.Location = new Point(300, 180);
            userIdTextBox.Name = "userIdTextBox";
            userIdTextBox.Padding = new Padding(10, 6, 10, 6);
            userIdTextBox.PlaceholderText = "User ID...";
            userIdTextBox.Size = new Size(250, 35);
            userIdTextBox.TabIndex = 0;
            userIdTextBox.TextAlign = HorizontalAlignment.Left;
            userIdTextBox.UseSystemPasswordChar = false;
            // 
            // passwordTextBox
            // 
            passwordTextBox.BackColor = Color.White;
            passwordTextBox.BorderColor = Color.Red;
            passwordTextBox.BorderRadius = 15;
            passwordTextBox.BorderSize = 2;
            passwordTextBox.FillColor = SystemColors.Window;
            passwordTextBox.ForeColor = Color.Black;
            passwordTextBox.Location = new Point(300, 230);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Padding = new Padding(10, 6, 10, 6);
            passwordTextBox.PlaceholderText = "Password...";
            passwordTextBox.Size = new Size(250, 35);
            passwordTextBox.TabIndex = 1;
            passwordTextBox.TextAlign = HorizontalAlignment.Left;
            passwordTextBox.UseSystemPasswordChar = true;
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.Red;
            loginButton.Cursor = Cursors.Hand;
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.ForeColor = Color.White;
            loginButton.Location = new Point(300, 284);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(160, 23);
            loginButton.TabIndex = 3;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // Login
            // 
            Controls.Add(loginButton);
            Controls.Add(userIdTextBox);
            Controls.Add(passwordTextBox);
            Controls.Add(backgroundPictureBox);
            Name = "Login";
            Size = new Size(923, 531);
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)backgroundPictureBox).EndInit();
            ResumeLayout(false);
        }


        #endregion
        private PictureBox backgroundPictureBox;
        private RoundedTextBox userIdTextBox;
        private RoundedTextBox passwordTextBox;
        private RoundedButton loginButton;
    }
}