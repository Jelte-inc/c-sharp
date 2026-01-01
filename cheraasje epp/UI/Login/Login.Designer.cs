using Cheraasje.Epp.UI.Controls;
using cheraasje_epp.UI.Controls;

namespace cheraasje_epp
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
            pictureBox1 = new PictureBox();
            idBox = new RoundedTextBox();
            passwordBox = new RoundedTextBox();
            loginButton = new RoundedButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.LoginPageBackground;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(924, 532);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // idBox
            // 
            idBox.Location = new Point(300, 180);
            idBox.Name = "idBox";
            idBox.Size = new Size(250, 35);
            idBox.TabIndex = 0;
            idBox.UseSystemPasswordChar = false;
            idBox.BackColor = Color.White;
            idBox.Enter += (s, e) =>
            idBox.ForeColor = Color.Black;
            idBox.PlaceholderText = "User ID...";
            passwordBox.usePasswordMasking = true;
            // 
            // passwordBox
            // 
            passwordBox.Location = new Point(300, 230);
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(250, 35);
            passwordBox.TabIndex = 1;
            passwordBox.BackColor = Color.White;
            passwordBox.UseSystemPasswordChar = false;
            passwordBox.PlaceholderText = "Password...";
            passwordBox.Enter += (s, e) =>
            passwordBox.ForeColor = Color.Black;
            // 
            // loginButton
            // 
            loginButton.Cursor = Cursors.Hand;
            loginButton.Location = new Point(300, 284);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(160, 23);
            loginButton.TabIndex = 3;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.BaseBackColor = Color.Red;
            loginButton.ForeColor = Color.White;
            loginButton.Click += loginButton_Click;
            // 
            // Login
            // 
            Controls.Add(loginButton);
            Controls.Add(idBox);
            Controls.Add(passwordBox);
            Controls.Add(pictureBox1);
            Name = "Login";
            Size = new Size(923, 531);
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }


        #endregion
        private PictureBox pictureBox1;
        private RoundedTextBox idBox;
        private RoundedTextBox passwordBox;
        private RoundedButton loginButton;
    }
}