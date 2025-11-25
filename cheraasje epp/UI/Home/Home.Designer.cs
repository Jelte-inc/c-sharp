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
            label1 = new Label();
            label2 = new Label();
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
            pictureBox1.Size = new Size(923, 532);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // branchButton
            // 
            branchButton.AutoSize = true;
            branchButton.BackColor = Color.White;
            branchButton.Font = new Font("Consolas", 27.75F, FontStyle.Underline, GraphicsUnit.Point, 0);
            branchButton.Location = new Point(39, 53);
            branchButton.Margin = new Padding(2, 0, 2, 0);
            branchButton.Name = "branchButton";
            branchButton.Size = new Size(239, 43);
            branchButton.TabIndex = 2;
            branchButton.Text = "Your Branch";
            branchButton.Click += branchButton_Click;
            branchButton.MouseEnter += branchButton_Mouse_Enter;
            branchButton.MouseLeave += branchButton_Mouse_Leave;
            branchButton.Cursor = Cursors.Hand;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Consolas", 27F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(39, 123);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(218, 42);
            label1.TabIndex = 3;
            label1.Text = "Your Fleet";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Consolas", 27F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.Location = new Point(39, 196);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(218, 42);
            label2.TabIndex = 4;
            label2.Text = "Your Fleet";
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(branchButton);
            Controls.Add(pictureBox1);
            Margin = new Padding(2);
            Name = "Home";
            Size = new Size(923, 531);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label branchButton;
        private Label label1;
        private Label label2;
    }
}
