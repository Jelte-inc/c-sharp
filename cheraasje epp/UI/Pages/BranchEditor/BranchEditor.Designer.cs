namespace cheraasje_epp.UI.Pages.AddUser
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
            nameInputField = new cheraasje_epp.UI.Controls.RoundedTextBox();
            locationInputField = new cheraasje_epp.UI.Controls.RoundedTextBox();
            adressInputField = new cheraasje_epp.UI.Controls.RoundedTextBox();
            confirmButton = new Cheraasje.Epp.UI.Controls.RoundedButton();
            cancelButton = new Cheraasje.Epp.UI.Controls.RoundedButton();
            phoneInputField = new cheraasje_epp.UI.Controls.RoundedTextBox();
            postalCodeInputField = new cheraasje_epp.UI.Controls.RoundedTextBox();
            ownerDropdown = new ComboBox();
            SuspendLayout();
            // 
            // nameInputField
            // 
            nameInputField.BorderColor = Color.Red;
            nameInputField.BorderRadius = 15;
            nameInputField.BorderSize = 2;
            nameInputField.FillColor = SystemColors.Window;
            nameInputField.Location = new Point(31, 12);
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
            locationInputField.Location = new Point(31, 67);
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
            adressInputField.Location = new Point(31, 122);
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
            phoneInputField.Location = new Point(31, 261);
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
            postalCodeInputField.Location = new Point(31, 206);
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
            ownerDropdown.Location = new Point(31, 177);
            ownerDropdown.Name = "ownerDropdown";
            ownerDropdown.Size = new Size(280, 23);
            ownerDropdown.TabIndex = 11;
            // 
            // BranchEditor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(333, 450);
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
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Controls.RoundedTextBox nameInputField;
        private Controls.RoundedTextBox locationInputField;
        private Controls.RoundedTextBox adressInputField;
        private Cheraasje.Epp.UI.Controls.RoundedButton confirmButton;
        private Cheraasje.Epp.UI.Controls.RoundedButton cancelButton;
        private Controls.RoundedTextBox phoneInputField;
        private Controls.RoundedTextBox postalCodeInputField;
        private ComboBox ownerDropdown;
    }
}