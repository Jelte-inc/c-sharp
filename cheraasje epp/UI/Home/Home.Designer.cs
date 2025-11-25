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
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1897, 1012);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // branchButton
            // 
            branchButton.AutoSize = true;
            branchButton.BackColor = Color.White;
            branchButton.Font = new Font("Segoe UI", 54.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            branchButton.Location = new Point(98, 126);
            branchButton.Margin = new Padding(2, 0, 2, 0);
            branchButton.Name = "branchButton";
            branchButton.Size = new Size(455, 98);
            branchButton.TabIndex = 2;
            branchButton.Text = "Your Branch";
            branchButton.Click += branchButton_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1896, 981);
            Controls.Add(branchButton);
            Controls.Add(pictureBox1);
            Margin = new Padding(2);
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
