using CheraasjeEpp.UI.Widgets;

namespace CheraasjeEpp.UI.Pages.AddUser
{
    partial class BranchEditor
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
            nameInputField = new RoundedTextBox();
            locationInputField = new RoundedTextBox();
            adressInputField = new RoundedTextBox();
            confirmButton = new RoundedButton();
            cancelButton = new RoundedButton();
            phoneInputField = new RoundedTextBox();
            postalCodeInputField = new RoundedTextBox();
            ownerDropdown = new ComboBox();
            nameLabel = new Label();
            locationLabel = new Label();
            adressLabel = new Label();
            ownerLabel = new Label();
            postalCodeLabel = new Label();
            phoneNumberLabel = new Label();
            SuspendLayout();
            // 
            // nameInputField
            // 
            nameInputField.BorderColor = Color.Red;
            nameInputField.BorderRadius = 15;
            nameInputField.BorderSize = 2;
            nameInputField.FillColor = SystemColors.Window;
            nameInputField.Location = new Point(31, 17);
            nameInputField.Name = "nameInputField";
            nameInputField.Padding = new Padding(10, 6, 10, 6);
            nameInputField.PlaceholderText = "Enter name";
            nameInputField.Size = new Size(280, 49);
            nameInputField.TabIndex = 0;
            nameInputField.TextAlign = HorizontalAlignment.Left;
            nameInputField.UseSystemPasswordChar = false;
            // 
            // locationInputField
            // 
            locationInputField.BorderColor = Color.Red;
            locationInputField.BorderRadius = 15;
            locationInputField.BorderSize = 2;
            locationInputField.FillColor = SystemColors.Window;
            locationInputField.Location = new Point(31, 82);
            locationInputField.Name = "locationInputField";
            locationInputField.Padding = new Padding(10, 6, 10, 6);
            locationInputField.PlaceholderText = "Enter location";
            locationInputField.Size = new Size(280, 49);
            locationInputField.TabIndex = 1;
            locationInputField.TextAlign = HorizontalAlignment.Left;
            locationInputField.UseSystemPasswordChar = false;
            // 
            // adressInputField
            // 
            adressInputField.BorderColor = Color.Red;
            adressInputField.BorderRadius = 15;
            adressInputField.BorderSize = 2;
            adressInputField.FillColor = SystemColors.Window;
            adressInputField.Location = new Point(31, 147);
            adressInputField.Name = "adressInputField";
            adressInputField.Padding = new Padding(10, 6, 10, 6);
            adressInputField.PlaceholderText = "Enter adress";
            adressInputField.Size = new Size(280, 49);
            adressInputField.TabIndex = 2;
            adressInputField.TextAlign = HorizontalAlignment.Left;
            adressInputField.UseSystemPasswordChar = false;
            // 
            // confirmButton
            // 
            confirmButton.BackColor = Color.Red;
            confirmButton.FlatAppearance.BorderSize = 0;
            confirmButton.FlatStyle = FlatStyle.Flat;
            confirmButton.ForeColor = Color.White;
            confirmButton.Location = new Point(180, 397);
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
            cancelButton.Location = new Point(31, 397);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(131, 46);
            cancelButton.TabIndex = 4;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += cancelButton_Click;
            // 
            // phoneInputField
            // 
            phoneInputField.BorderColor = Color.Red;
            phoneInputField.BorderRadius = 15;
            phoneInputField.BorderSize = 2;
            phoneInputField.FillColor = SystemColors.Window;
            phoneInputField.Location = new Point(31, 321);
            phoneInputField.Name = "phoneInputField";
            phoneInputField.Padding = new Padding(10, 6, 10, 6);
            phoneInputField.PlaceholderText = "Enter phone number";
            phoneInputField.Size = new Size(280, 49);
            phoneInputField.TabIndex = 9;
            phoneInputField.TextAlign = HorizontalAlignment.Left;
            phoneInputField.UseSystemPasswordChar = false;
            // 
            // postalCodeInputField
            // 
            postalCodeInputField.BorderColor = Color.Red;
            postalCodeInputField.BorderRadius = 15;
            postalCodeInputField.BorderSize = 2;
            postalCodeInputField.FillColor = SystemColors.Window;
            postalCodeInputField.Location = new Point(31, 256);
            postalCodeInputField.Name = "postalCodeInputField";
            postalCodeInputField.Padding = new Padding(10, 6, 10, 6);
            postalCodeInputField.PlaceholderText = "Enter postal code";
            postalCodeInputField.Size = new Size(280, 49);
            postalCodeInputField.TabIndex = 10;
            postalCodeInputField.TextAlign = HorizontalAlignment.Left;
            postalCodeInputField.UseSystemPasswordChar = false;
            // 
            // ownerDropdown
            // 
            ownerDropdown.FormattingEnabled = true;
            ownerDropdown.Location = new Point(31, 217);
            ownerDropdown.Name = "ownerDropdown";
            ownerDropdown.Size = new Size(280, 23);
            ownerDropdown.TabIndex = 11;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.BackColor = Color.Transparent;
            nameLabel.Location = new Point(48, 9);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(39, 15);
            nameLabel.TabIndex = 12;
            nameLabel.Text = "Name";
            // 
            // locationLabel
            // 
            locationLabel.AutoSize = true;
            locationLabel.BackColor = Color.Transparent;
            locationLabel.Location = new Point(48, 74);
            locationLabel.Name = "locationLabel";
            locationLabel.Size = new Size(53, 15);
            locationLabel.TabIndex = 13;
            locationLabel.Text = "Location";
            // 
            // adressLabel
            // 
            adressLabel.AutoSize = true;
            adressLabel.BackColor = Color.Transparent;
            adressLabel.Location = new Point(48, 139);
            adressLabel.Name = "adressLabel";
            adressLabel.Size = new Size(42, 15);
            adressLabel.TabIndex = 14;
            adressLabel.Text = "Adress";
            // 
            // ownerLabel
            // 
            ownerLabel.AutoSize = true;
            ownerLabel.Location = new Point(34, 201);
            ownerLabel.Name = "ownerLabel";
            ownerLabel.Size = new Size(42, 15);
            ownerLabel.TabIndex = 15;
            ownerLabel.Text = "Owner";
            // 
            // postalCodeLabel
            // 
            postalCodeLabel.AutoSize = true;
            postalCodeLabel.BackColor = Color.Transparent;
            postalCodeLabel.Location = new Point(48, 248);
            postalCodeLabel.Name = "postalCodeLabel";
            postalCodeLabel.Size = new Size(68, 15);
            postalCodeLabel.TabIndex = 16;
            postalCodeLabel.Text = "Postal code";
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new Point(48, 313);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new Size(86, 15);
            phoneNumberLabel.TabIndex = 17;
            phoneNumberLabel.Text = "Phone number";
            // 
            // BranchEditor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(333, 450);
            Controls.Add(phoneNumberLabel);
            Controls.Add(postalCodeLabel);
            Controls.Add(ownerLabel);
            Controls.Add(adressLabel);
            Controls.Add(locationLabel);
            Controls.Add(nameLabel);
            Controls.Add(ownerDropdown);
            Controls.Add(postalCodeInputField);
            Controls.Add(phoneInputField);
            Controls.Add(cancelButton);
            Controls.Add(confirmButton);
            Controls.Add(adressInputField);
            Controls.Add(locationInputField);
            Controls.Add(nameInputField);
            Name = "BranchEditor";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private RoundedTextBox nameInputField;
        private RoundedTextBox locationInputField;
        private RoundedTextBox adressInputField;
        private RoundedButton confirmButton;
        private RoundedButton cancelButton;
        private RoundedTextBox phoneInputField;
        private RoundedTextBox postalCodeInputField;
        private ComboBox ownerDropdown;
        private Label nameLabel;
        private Label locationLabel;
        private Label adressLabel;
        private Label ownerLabel;
        private Label postalCodeLabel;
        private Label phoneNumberLabel;
    }
}