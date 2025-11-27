using cheraasje_epp.Data;
using cheraasje_epp.Models;

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
            var dataManager = new DataManager();
            pictureBox1 = new PictureBox();
            branchButton = new Label();
            fleetButton = new Label();
            accountButton = new Label();
            shortUserInfoLabel = new Label();
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
            branchButton.Cursor = Cursors.Hand;
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
            // 
            // fleetButton
            // 
            fleetButton.AutoSize = true;
            fleetButton.BackColor = Color.White;
            fleetButton.Font = new Font("Consolas", 27F, FontStyle.Underline, GraphicsUnit.Point, 0);
            fleetButton.Location = new Point(39, 123);
            fleetButton.Margin = new Padding(2, 0, 2, 0);
            fleetButton.Name = "fleetButton";
            fleetButton.Size = new Size(218, 42);
            fleetButton.TabIndex = 3;
            fleetButton.Text = "Your Fleet";
            // 
            // accountButton
            // 
            accountButton.AutoSize = true;
            accountButton.BackColor = Color.White;
            accountButton.Font = new Font("Consolas", 27F, FontStyle.Underline, GraphicsUnit.Point, 0);
            accountButton.Location = new Point(39, 196);
            accountButton.Margin = new Padding(2, 0, 2, 0);
            accountButton.Name = "accountButton";
            accountButton.Size = new Size(258, 42);
            accountButton.TabIndex = 4;
            accountButton.Text = "Your Account";
            // 
            // shortUserInfoLabel
            // 
            int userId = Session.UserId;
            User user = dataManager.GetUser(userId);
            string branchName = dataManager.GetBranchById(user.BranchId).Name;
            string shortUserInfo = user.Name + " at " + branchName;
            shortUserInfoLabel.AutoSize = true;
            shortUserInfoLabel.Location = new Point(824, 22);
            shortUserInfoLabel.Name = "shortUserInfoLabel";
            shortUserInfoLabel.Size = new Size(38, 15);
            shortUserInfoLabel.TabIndex = 5;
            shortUserInfoLabel.Text = shortUserInfo;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(shortUserInfoLabel);
            Controls.Add(accountButton);
            Controls.Add(fleetButton);
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
        private Label fleetButton;
        private Label accountButton;
        private Label shortUserInfoLabel;
    }
}
