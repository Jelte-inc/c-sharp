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
            idBox.BackColor = Color.White;
            idBox.BorderColor = Color.Red;
            idBox.BorderRadius = 15;
            idBox.BorderSize = 2;
            idBox.Location = new Point(300, 180);
            idBox.Name = "idBox";
            idBox.Padding = new Padding(10, 5, 10, 5);
            idBox.Size = new Size(250, 35);
            idBox.TabIndex = 0;
            idBox.UseSystemPasswordChar = false;

            idBox.Enter += (s, e) =>
            {
                if (idBox.Text == "Employee ID...")
                {
                    idBox.Text = "";
                    idBox.ForeColor = Color.Black;
                }
            };

            idBox.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(idBox.Text))
                {
                    idBox.Text = "Employee ID...";
                    idBox.ForeColor = Color.Gray;
                }
            };
            // 
            // passwordBox
            // 
            passwordBox.BackColor = Color.White;
            passwordBox.BorderColor = Color.Red;
            passwordBox.BorderRadius = 15;
            passwordBox.BorderSize = 2;
            passwordBox.Location = new Point(300, 230);
            passwordBox.Name = "passwordBox";
            passwordBox.Padding = new Padding(10, 5, 10, 5);
            passwordBox.Size = new Size(250, 35);
            passwordBox.TabIndex = 1;
            passwordBox.UseSystemPasswordChar = false;
            passwordBox.Text = "Password...";
            passwordBox.Enter += (s, e) =>
            {
                if (passwordBox.Text == "Password...")
                {
                    passwordBox.Text = "";
                    passwordBox.ForeColor = Color.Black;
                    passwordBox.UseSystemPasswordChar = true;
                }
            };

            passwordBox.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(passwordBox.Text))
                {
                    passwordBox.Text = "Password...";
                    passwordBox.ForeColor = Color.Gray;
                    passwordBox.UseSystemPasswordChar = false;
                }
            };
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