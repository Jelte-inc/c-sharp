namespace cheraasje_epp.UI.Pages.AddUser
{
    partial class UserEditor
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
            nameInputField = new cheraasje_epp.UI.Controls.RoundedTextBox();
            passwordInputField = new cheraasje_epp.UI.Controls.RoundedTextBox();
            passwordCheckInputField = new cheraasje_epp.UI.Controls.RoundedTextBox();
            confirmButton = new Cheraasje.Epp.UI.Controls.RoundedButton();
            cancelButton = new Cheraasje.Epp.UI.Controls.RoundedButton();
            adminCheckBox = new CheckBox();
            branchDropdown = new ComboBox();
            nameLabel = new Label();
            passwordLabel1 = new Label();
            passwordLabel2 = new Label();
            branchLabel = new Label();
            SuspendLayout();
            // 
            // nameInputField
            // 
            nameInputField.BorderColor = Color.Red;
            nameInputField.BorderRadius = 15;
            nameInputField.BorderSize = 2;
            nameInputField.FillColor = SystemColors.Window;
            nameInputField.Location = new Point(31, 38);
            nameInputField.Name = "nameInputField";
            nameInputField.Padding = new Padding(10, 6, 10, 6);
            nameInputField.PlaceholderText = "Enter name";
            nameInputField.Size = new Size(280, 49);
            nameInputField.TabIndex = 0;
            nameInputField.TextAlign = HorizontalAlignment.Left;
            nameInputField.UseSystemPasswordChar = false;
            // 
            // passwordInputField
            // 
            passwordInputField.BorderColor = Color.Red;
            passwordInputField.BorderRadius = 15;
            passwordInputField.BorderSize = 2;
            passwordInputField.FillColor = SystemColors.Window;
            passwordInputField.Location = new Point(31, 103);
            passwordInputField.Name = "passwordInputField";
            passwordInputField.Padding = new Padding(10, 6, 10, 6);
            passwordInputField.PlaceholderText = "Enter password";
            passwordInputField.Size = new Size(280, 49);
            passwordInputField.TabIndex = 1;
            passwordInputField.TextAlign = HorizontalAlignment.Left;
            passwordInputField.UseSystemPasswordChar = true;
            // 
            // passwordCheckInputField
            // 
            passwordCheckInputField.BorderColor = Color.Red;
            passwordCheckInputField.BorderRadius = 15;
            passwordCheckInputField.BorderSize = 2;
            passwordCheckInputField.FillColor = SystemColors.Window;
            passwordCheckInputField.Location = new Point(31, 168);
            passwordCheckInputField.Name = "passwordCheckInputField";
            passwordCheckInputField.Padding = new Padding(10, 6, 10, 6);
            passwordCheckInputField.PlaceholderText = "Re-enter password";
            passwordCheckInputField.Size = new Size(280, 49);
            passwordCheckInputField.TabIndex = 2;
            passwordCheckInputField.TextAlign = HorizontalAlignment.Left;
            passwordCheckInputField.UseSystemPasswordChar = true;
            // 
            // confirmButton
            // 
            confirmButton.BackColor = Color.Red;
            confirmButton.FlatAppearance.BorderSize = 0;
            confirmButton.FlatStyle = FlatStyle.Flat;
            confirmButton.ForeColor = Color.White;
            confirmButton.Location = new Point(180, 305);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new Size(131, 46);
            confirmButton.TabIndex = 3;
            confirmButton.Text = "Confirm";
            confirmButton.UseVisualStyleBackColor = false;
            confirmButton.Click += confirmButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.BackColor = Color.Red;
            cancelButton.FlatAppearance.BorderSize = 0;
            cancelButton.FlatStyle = FlatStyle.Flat;
            cancelButton.ForeColor = Color.White;
            cancelButton.Location = new Point(31, 305);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(131, 46);
            cancelButton.TabIndex = 4;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += cancelButton_Click;
            // 
            // adminCheckBox
            // 
            adminCheckBox.AutoSize = true;
            adminCheckBox.Font = new Font("Segoe UI", 12F);
            adminCheckBox.Location = new Point(41, 265);
            adminCheckBox.Name = "adminCheckBox";
            adminCheckBox.Size = new Size(75, 25);
            adminCheckBox.TabIndex = 6;
            adminCheckBox.Text = "Admin";
            adminCheckBox.UseVisualStyleBackColor = true;
            // 
            // branchDropdown
            // 
            branchDropdown.FormattingEnabled = true;
            branchDropdown.Location = new Point(31, 236);
            branchDropdown.Name = "branchDropdown";
            branchDropdown.Size = new Size(280, 23);
            branchDropdown.TabIndex = 7;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(50, 31);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(39, 15);
            nameLabel.TabIndex = 8;
            nameLabel.Text = "Name";
            nameLabel.Click += nameLabel_Click;
            // 
            // passwordLabel1
            // 
            passwordLabel1.AutoSize = true;
            passwordLabel1.Location = new Point(50, 96);
            passwordLabel1.Name = "passwordLabel1";
            passwordLabel1.Size = new Size(57, 15);
            passwordLabel1.TabIndex = 9;
            passwordLabel1.Text = "Password";
            // 
            // passwordLabel2
            // 
            passwordLabel2.AutoSize = true;
            passwordLabel2.Location = new Point(50, 161);
            passwordLabel2.Name = "passwordLabel2";
            passwordLabel2.Size = new Size(57, 15);
            passwordLabel2.TabIndex = 10;
            passwordLabel2.Text = "Password";
            // 
            // branchLabel
            // 
            branchLabel.AutoSize = true;
            branchLabel.Location = new Point(31, 220);
            branchLabel.Name = "branchLabel";
            branchLabel.Size = new Size(44, 15);
            branchLabel.TabIndex = 11;
            branchLabel.Text = "Branch";
            // 
            // UserEditor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(333, 450);
            Controls.Add(branchLabel);
            Controls.Add(passwordLabel2);
            Controls.Add(passwordLabel1);
            Controls.Add(nameLabel);
            Controls.Add(branchDropdown);
            Controls.Add(adminCheckBox);
            Controls.Add(cancelButton);
            Controls.Add(confirmButton);
            Controls.Add(passwordCheckInputField);
            Controls.Add(passwordInputField);
            Controls.Add(nameInputField);
            Name = "UserEditor";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Controls.RoundedTextBox nameInputField;
        private Controls.RoundedTextBox passwordInputField;
        private Controls.RoundedTextBox passwordCheckInputField;
        private Cheraasje.Epp.UI.Controls.RoundedButton confirmButton;
        private Cheraasje.Epp.UI.Controls.RoundedButton cancelButton;
        private CheckBox adminCheckBox;
        private ComboBox branchDropdown;
        private Label nameLabel;
        private Label passwordLabel1;
        private Label passwordLabel2;
        private Label branchLabel;
    }
}