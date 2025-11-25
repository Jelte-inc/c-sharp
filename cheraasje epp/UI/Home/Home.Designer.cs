namespace cheraasje_epp
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            branchButton = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.AccessibleName = "HomePageBackground";
            pictureBox1.Image = Properties.Resources.Homepage_Background;
            pictureBox1.Location = new Point(-1, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1898, 1027);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // branchButton
            // 
            branchButton.AutoSize = true;
            branchButton.Location = new Point(180, 179);
            branchButton.Name = "branchButton";
            branchButton.Size = new Size(59, 25);
            branchButton.TabIndex = 2;
            branchButton.Text = "Your Branch";
            branchButton.Click += branchButton_Click;
            branchButton.BackColor = Color.White;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1898, 1024);
            Controls.Add(branchButton);
            Controls.Add(pictureBox1);
            Name = "Home";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label branchButton;
    }
}
