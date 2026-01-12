namespace cheraasje_epp.UI.Admin.Widgets
{
    partial class UserItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserItem));
            roundedRectangle1 = new CheraasjeApp.UI.Controls.RoundedRectangle();
            editButton = new Button();
            binButton = new Button();
            nameLabel = new Label();
            SuspendLayout();
            // 
            // roundedRectangle1
            // 
            roundedRectangle1.BackColor = Color.Transparent;
            roundedRectangle1.CornerRadius = 20;
            roundedRectangle1.FillColor = Color.Red;
            roundedRectangle1.Location = new Point(0, 0);
            roundedRectangle1.Name = "roundedRectangle1";
            roundedRectangle1.Size = new Size(304, 60);
            roundedRectangle1.TabIndex = 0;
            roundedRectangle1.Text = "roundedRectangle1";
            // 
            // editButton
            // 
            editButton.BackColor = Color.Red;
            editButton.BackgroundImage = (Image)resources.GetObject("editButton.BackgroundImage");
            editButton.BackgroundImageLayout = ImageLayout.Zoom;
            editButton.FlatAppearance.BorderSize = 0;
            editButton.FlatStyle = FlatStyle.Flat;
            editButton.Location = new Point(201, 3);
            editButton.Name = "editButton";
            editButton.Size = new Size(49, 49);
            editButton.TabIndex = 1;
            editButton.UseVisualStyleBackColor = false;
            editButton.Click += editButton_Click;
            // 
            // binButton
            // 
            binButton.BackColor = Color.Red;
            binButton.BackgroundImage = (Image)resources.GetObject("binButton.BackgroundImage");
            binButton.BackgroundImageLayout = ImageLayout.Zoom;
            binButton.FlatAppearance.BorderSize = 0;
            binButton.FlatStyle = FlatStyle.Flat;
            binButton.Location = new Point(245, 3);
            binButton.Name = "binButton";
            binButton.Size = new Size(49, 49);
            binButton.TabIndex = 2;
            binButton.UseVisualStyleBackColor = false;
            binButton.Click += binButton_Click;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.BackColor = Color.Red;
            nameLabel.Font = new Font("Segoe UI", 10F);
            nameLabel.ForeColor = Color.White;
            nameLabel.Location = new Point(18, 18);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(75, 19);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "nameLabel";
            // 
            // UserItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(nameLabel);
            Controls.Add(binButton);
            Controls.Add(editButton);
            Controls.Add(roundedRectangle1);
            Name = "UserItem";
            Size = new Size(305, 59);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheraasjeApp.UI.Controls.RoundedRectangle roundedRectangle1;
        private Button editButton;
        private Button binButton;
        private Label nameLabel;
    }
}
