using Cheraasje.Epp.UI.Controls;
using cheraasje_epp.UI.Controls;

namespace cheraasje_epp.UI.Admin
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            pictureBox2 = new PictureBox();
            branchList = new FlowLayoutPanel();
            userList = new FlowLayoutPanel();
            branchInputField = new RoundedTextBox();
            branchButton = new RoundedButton();
            userInputField = new RoundedTextBox();
            userButton = new RoundedButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(923, 532);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // branchList
            // 
            branchList.AutoScroll = true;
            branchList.BackColor = Color.White;
            branchList.Location = new Point(76, 148);
            branchList.Name = "branchList";
            branchList.Size = new Size(332, 197);
            branchList.TabIndex = 0;
            // 
            // userList
            // 
            userList.AutoScroll = true;
            userList.BackColor = Color.White;
            userList.Location = new Point(506, 148);
            userList.Name = "userList";
            userList.Size = new Size(332, 197);
            userList.TabIndex = 1;
            // 
            // branchInputField
            // 
            branchInputField.BackColor = Color.White;
            branchInputField.BorderColor = Color.Red;
            branchInputField.BorderRadius = 15;
            branchInputField.BorderSize = 2;
            branchInputField.FillColor = SystemColors.Window;
            branchInputField.Location = new Point(76, 411);
            branchInputField.Name = "branchInputField";
            branchInputField.Padding = new Padding(10, 6, 10, 6);
            branchInputField.PlaceholderText = "Type branch name...";
            branchInputField.Size = new Size(196, 36);
            branchInputField.TabIndex = 2;
            branchInputField.TextAlign = HorizontalAlignment.Left;
            branchInputField.UseSystemPasswordChar = false;
            // 
            // branchButton
            // 
            branchButton.BackColor = Color.Red;
            branchButton.FlatAppearance.BorderSize = 0;
            branchButton.FlatStyle = FlatStyle.Flat;
            branchButton.ForeColor = Color.White;
            branchButton.Location = new Point(295, 411);
            branchButton.Name = "branchButton";
            branchButton.Size = new Size(96, 36);
            branchButton.TabIndex = 3;
            branchButton.Text = "Add";
            branchButton.UseVisualStyleBackColor = false;
            // 
            // userInputField
            // 
            userInputField.BackColor = Color.White;
            userInputField.BorderColor = Color.Red;
            userInputField.BorderRadius = 15;
            userInputField.BorderSize = 2;
            userInputField.FillColor = SystemColors.Window;
            userInputField.Location = new Point(506, 411);
            userInputField.Name = "userInputField";
            userInputField.Padding = new Padding(10, 6, 10, 6);
            userInputField.PlaceholderText = "Type user name...";
            userInputField.Size = new Size(196, 36);
            userInputField.TabIndex = 4;
            userInputField.TextAlign = HorizontalAlignment.Left;
            userInputField.UseSystemPasswordChar = false;
            // 
            // userButton
            // 
            userButton.BackColor = Color.Red;
            userButton.FlatAppearance.BorderSize = 0;
            userButton.FlatStyle = FlatStyle.Flat;
            userButton.ForeColor = Color.White;
            userButton.Location = new Point(742, 411);
            userButton.Name = "userButton";
            userButton.Size = new Size(96, 36);
            userButton.TabIndex = 5;
            userButton.Text = "Add";
            userButton.UseVisualStyleBackColor = false;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(userButton);
            Controls.Add(userInputField);
            Controls.Add(branchButton);
            Controls.Add(branchInputField);
            Controls.Add(userList);
            Controls.Add(branchList);
            Controls.Add(pictureBox2);
            Name = "Admin";
            Size = new Size(923, 532);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox2;
        private FlowLayoutPanel branchList;
        private FlowLayoutPanel userList;
        private RoundedTextBox branchInputField;
        private RoundedButton branchButton;
        private RoundedTextBox userInputField;
        private RoundedButton userButton;
    }
}
