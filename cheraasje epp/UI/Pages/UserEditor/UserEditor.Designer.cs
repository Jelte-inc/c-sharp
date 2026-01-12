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
            SuspendLayout();
            // 
            // nameInputField
            // 
            nameInputField.BorderColor = Color.Red;
            nameInputField.BorderRadius = 15;
            nameInputField.BorderSize = 2;
            nameInputField.FillColor = SystemColors.Window;
            nameInputField.Location = new Point(31, 63);
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
            passwordInputField.Location = new Point(31, 118);
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
            passwordCheckInputField.Location = new Point(31, 173);
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
            cancelButton.Click += this.cancelButton_Click;
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
            // AddUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(333, 450);
            Controls.Add(branchDropdown);
            Controls.Add(adminCheckBox);
            Controls.Add(cancelButton);
            Controls.Add(confirmButton);
            Controls.Add(passwordCheckInputField);
            Controls.Add(passwordInputField);
            Controls.Add(nameInputField);
            Name = "AddUser";
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
    }
}