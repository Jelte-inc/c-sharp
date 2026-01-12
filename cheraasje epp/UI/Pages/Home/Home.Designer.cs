using CheraasjeEpp.Data;
using CheraasjeEpp.Models;

namespace CheraasjeEpp.UI.Pages
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
            backgroundPictureBox = new PictureBox();
            branchButton = new Label();
            fleetButton = new Label();
            accountButton = new Label();
            shortUserInfoLabel = new Label();
            adminButton = new Label();
            ((System.ComponentModel.ISupportInitialize)backgroundPictureBox).BeginInit();
            SuspendLayout();
            // 
            // backgroundPictureBox
            // 
            backgroundPictureBox.AccessibleName = "HomePageBackground";
            backgroundPictureBox.Image = Properties.Resources.HomepageBackground;
            backgroundPictureBox.Location = new Point(-1, -1);
            backgroundPictureBox.Margin = new Padding(2);
            backgroundPictureBox.Name = "backgroundPictureBox";
            backgroundPictureBox.Size = new Size(923, 532);
            backgroundPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            backgroundPictureBox.TabIndex = 0;
            backgroundPictureBox.TabStop = false;
            // 
            // branchButton
            // 
            branchButton.AutoSize = true;
            branchButton.BackColor = Color.White;
            branchButton.Cursor = Cursors.Hand;
            branchButton.Font = new Font("Consolas", 27.75F, FontStyle.Underline, GraphicsUnit.Point, 0);
            branchButton.Location = new Point(39, 49);
            branchButton.Margin = new Padding(2, 0, 2, 0);
            branchButton.Name = "branchButton";
            branchButton.Size = new Size(239, 43);
            branchButton.TabIndex = 2;
            branchButton.Text = "Your Branch";
            branchButton.Click += branchButton_Click;
            branchButton.MouseEnter += LabelMouseEnter;
            branchButton.MouseLeave += LabelMouseLeave;
            // 
            // fleetButton
            // 
            fleetButton.AutoSize = true;
            fleetButton.BackColor = Color.White;
            fleetButton.Cursor = Cursors.Hand;
            fleetButton.Font = new Font("Consolas", 27F, FontStyle.Underline, GraphicsUnit.Point, 0);
            fleetButton.Location = new Point(39, 102);
            fleetButton.Margin = new Padding(2, 0, 2, 0);
            fleetButton.Name = "fleetButton";
            fleetButton.Size = new Size(218, 42);
            fleetButton.TabIndex = 3;
            fleetButton.Text = "Your Fleet";
            fleetButton.Click += fleetButton_Click;
            fleetButton.MouseEnter += LabelMouseEnter;
            fleetButton.MouseLeave += LabelMouseLeave;
            // 
            // accountButton
            // 
            accountButton.AutoSize = true;
            accountButton.BackColor = Color.White;
            accountButton.Cursor = Cursors.Hand;
            accountButton.Font = new Font("Consolas", 27F, FontStyle.Underline, GraphicsUnit.Point, 0);
            accountButton.Location = new Point(39, 154);
            accountButton.Margin = new Padding(2, 0, 2, 0);
            accountButton.Name = "accountButton";
            accountButton.Size = new Size(258, 42);
            accountButton.TabIndex = 4;
            accountButton.Text = "Your Account";
            accountButton.Click += accountButton_Click;
            accountButton.MouseEnter += LabelMouseEnter;
            accountButton.MouseLeave += LabelMouseLeave;
            // 
            // shortUserInfoLabel
            // 
            shortUserInfoLabel.AutoSize = true;
            shortUserInfoLabel.BackColor = Color.White;
            shortUserInfoLabel.Font = new Font("Consolas", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            shortUserInfoLabel.Location = new Point(636, 18);
            shortUserInfoLabel.Name = "shortUserInfoLabel";
            shortUserInfoLabel.Size = new Size(120, 23);
            shortUserInfoLabel.TabIndex = 5;
            shortUserInfoLabel.Text = "{USERINFO}";
            // 
            // adminButton
            // 
            adminButton.AutoSize = true;
            adminButton.BackColor = Color.White;
            adminButton.Cursor = Cursors.Hand;
            adminButton.Font = new Font("Consolas", 27F, FontStyle.Underline, GraphicsUnit.Point, 0);
            adminButton.Location = new Point(39, 206);
            adminButton.Margin = new Padding(2, 0, 2, 0);
            adminButton.Name = "adminButton";
            adminButton.Size = new Size(258, 42);
            adminButton.TabIndex = 6;
            adminButton.Text = "Admin Center";
            adminButton.Click += adminButton_Click;
            adminButton.MouseEnter += LabelMouseEnter;
            adminButton.MouseLeave += LabelMouseLeave;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(adminButton);
            Controls.Add(shortUserInfoLabel);
            Controls.Add(accountButton);
            Controls.Add(fleetButton);
            Controls.Add(branchButton);
            Controls.Add(backgroundPictureBox);
            Margin = new Padding(2);
            Name = "Home";
            Size = new Size(923, 531);
            ((System.ComponentModel.ISupportInitialize)backgroundPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox backgroundPictureBox;
        private Label branchButton;
        private Label fleetButton;
        private Label accountButton;
        private Label shortUserInfoLabel;
        private Label adminButton;
    }
}
