using cheraasje_epp.UI.Controls;

namespace cheraasje_epp.UI.Pages
{
    partial class AddCar
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
            pictureBox1 = new PictureBox();
            branchLabel = new Label();
            brandInputField = new RoundedTextBox();
            modelInputField = new RoundedTextBox();
            buildYearInputField = new RoundedTextBox();
            uploadedImagesView = new FlowLayoutPanel();
            addCarButton = new Cheraasje.Epp.UI.Controls.RoundedButton();
            mileageInputField = new RoundedTextBox();
            priceInputField = new RoundedTextBox();
            licencePlateInputField = new RoundedTextBox();
            selectManualButton = new Cheraasje.Epp.UI.Controls.RoundedButton();
            selectAutomaticButton = new Cheraasje.Epp.UI.Controls.RoundedButton();
            amountOfDoorInputField = new RoundedTextBox();
            colorInputField = new RoundedTextBox();
            addImagesButton = new Cheraasje.Epp.UI.Controls.RoundedButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.AddCarPageBackground;
            pictureBox1.Location = new Point(0, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(923, 531);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // branchLabel
            // 
            branchLabel.AutoSize = true;
            branchLabel.BackColor = Color.White;
            branchLabel.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            branchLabel.Location = new Point(75, 65);
            branchLabel.Name = "branchLabel";
            branchLabel.Size = new Size(239, 40);
            branchLabel.TabIndex = 1;
            branchLabel.Text = "{BRANCH NAME}";
            // 
            // brandInputField
            // 
            brandInputField.BackColor = Color.White;
            brandInputField.BorderColor = Color.Red;
            brandInputField.BorderRadius = 18;
            brandInputField.BorderSize = 2;
            brandInputField.FillColor = Color.White;
            brandInputField.Location = new Point(36, 138);
            brandInputField.Name = "brandInputField";
            brandInputField.Padding = new Padding(10, 5, 10, 5);
            brandInputField.PlaceholderText = "Brand...";
            brandInputField.Size = new Size(361, 37);
            brandInputField.TabIndex = 2;
            brandInputField.TextAlign = HorizontalAlignment.Left;
            brandInputField.UseSystemPasswordChar = false;
            // 
            // modelInputField
            // 
            modelInputField.BackColor = Color.White;
            modelInputField.BorderColor = Color.Red;
            modelInputField.BorderRadius = 18;
            modelInputField.BorderSize = 2;
            modelInputField.FillColor = Color.White;
            modelInputField.Location = new Point(36, 193);
            modelInputField.Name = "modelInputField";
            modelInputField.Padding = new Padding(10, 5, 10, 5);
            modelInputField.PlaceholderText = "Model...";
            modelInputField.Size = new Size(361, 37);
            modelInputField.TabIndex = 3;
            modelInputField.TextAlign = HorizontalAlignment.Left;
            modelInputField.UseSystemPasswordChar = false;
            // 
            // buildYearInputField
            // 
            buildYearInputField.BackColor = Color.White;
            buildYearInputField.BorderColor = Color.Red;
            buildYearInputField.BorderRadius = 18;
            buildYearInputField.BorderSize = 2;
            buildYearInputField.FillColor = Color.White;
            buildYearInputField.Location = new Point(36, 248);
            buildYearInputField.Name = "buildYearInputField";
            buildYearInputField.Padding = new Padding(10, 5, 10, 5);
            buildYearInputField.PlaceholderText = "Build year...";
            buildYearInputField.Size = new Size(361, 37);
            buildYearInputField.TabIndex = 4;
            buildYearInputField.TextAlign = HorizontalAlignment.Left;
            buildYearInputField.UseSystemPasswordChar = false;
            // 
            // uploadedImagesView
            // 
            uploadedImagesView.BackColor = Color.White;
            uploadedImagesView.Location = new Point(118, 352);
            uploadedImagesView.Name = "uploadedImagesView";
            uploadedImagesView.Size = new Size(279, 77);
            uploadedImagesView.TabIndex = 6;
            // 
            // addCarButton
            // 
            addCarButton.BackColor = Color.FromArgb(255, 87, 87);
            addCarButton.FlatAppearance.BorderSize = 0;
            addCarButton.FlatStyle = FlatStyle.Flat;
            addCarButton.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addCarButton.ForeColor = Color.White;
            addCarButton.Location = new Point(36, 445);
            addCarButton.Name = "addCarButton";
            addCarButton.Size = new Size(361, 38);
            addCarButton.TabIndex = 7;
            addCarButton.Text = "Add";
            addCarButton.UseVisualStyleBackColor = false;
            addCarButton.Click += addCarButton_Click;
            // 
            // mileageInputField
            // 
            mileageInputField.BackColor = Color.White;
            mileageInputField.BorderColor = Color.Red;
            mileageInputField.BorderRadius = 18;
            mileageInputField.BorderSize = 2;
            mileageInputField.FillColor = Color.White;
            mileageInputField.Location = new Point(511, 248);
            mileageInputField.Name = "mileageInputField";
            mileageInputField.Padding = new Padding(10, 5, 10, 5);
            mileageInputField.PlaceholderText = "Mileage...";
            mileageInputField.Size = new Size(361, 37);
            mileageInputField.TabIndex = 10;
            mileageInputField.TextAlign = HorizontalAlignment.Left;
            mileageInputField.UseSystemPasswordChar = false;
            // 
            // priceInputField
            // 
            priceInputField.BackColor = Color.White;
            priceInputField.BorderColor = Color.Red;
            priceInputField.BorderRadius = 18;
            priceInputField.BorderSize = 2;
            priceInputField.FillColor = Color.White;
            priceInputField.Location = new Point(511, 193);
            priceInputField.Name = "priceInputField";
            priceInputField.Padding = new Padding(10, 5, 10, 5);
            priceInputField.PlaceholderText = "Price...";
            priceInputField.Size = new Size(361, 37);
            priceInputField.TabIndex = 11;
            priceInputField.TextAlign = HorizontalAlignment.Left;
            priceInputField.UseSystemPasswordChar = false;
            // 
            // licencePlateInputField
            // 
            licencePlateInputField.BackColor = Color.White;
            licencePlateInputField.BorderColor = Color.Red;
            licencePlateInputField.BorderRadius = 18;
            licencePlateInputField.BorderSize = 2;
            licencePlateInputField.FillColor = Color.White;
            licencePlateInputField.Location = new Point(511, 138);
            licencePlateInputField.Name = "licencePlateInputField";
            licencePlateInputField.Padding = new Padding(10, 5, 10, 5);
            licencePlateInputField.PlaceholderText = "Licence plate...";
            licencePlateInputField.Size = new Size(361, 37);
            licencePlateInputField.TabIndex = 12;
            licencePlateInputField.TextAlign = HorizontalAlignment.Left;
            licencePlateInputField.UseSystemPasswordChar = false;
            // 
            // selectManualButton
            // 
            selectManualButton.BackColor = Color.FromArgb(255, 87, 87);
            selectManualButton.FlatAppearance.BorderSize = 0;
            selectManualButton.FlatStyle = FlatStyle.Flat;
            selectManualButton.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            selectManualButton.ForeColor = Color.White;
            selectManualButton.Location = new Point(511, 353);
            selectManualButton.Name = "selectManualButton";
            selectManualButton.Size = new Size(174, 38);
            selectManualButton.TabIndex = 13;
            selectManualButton.Text = "Manual";
            selectManualButton.UseVisualStyleBackColor = false;
            selectManualButton.Click += selectManualButton_Click;
            // 
            // selectAutomaticButton
            // 
            selectAutomaticButton.BackColor = Color.Silver;
            selectAutomaticButton.FlatAppearance.BorderSize = 0;
            selectAutomaticButton.FlatStyle = FlatStyle.Flat;
            selectAutomaticButton.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            selectAutomaticButton.ForeColor = Color.White;
            selectAutomaticButton.Location = new Point(710, 353);
            selectAutomaticButton.Name = "selectAutomaticButton";
            selectAutomaticButton.Size = new Size(162, 38);
            selectAutomaticButton.TabIndex = 14;
            selectAutomaticButton.Text = "Automatic";
            selectAutomaticButton.UseVisualStyleBackColor = false;
            selectAutomaticButton.Click += selectAutomaticButton_Click;
            // 
            // amountOfDoorInputField
            // 
            amountOfDoorInputField.BackColor = Color.White;
            amountOfDoorInputField.BorderColor = Color.Red;
            amountOfDoorInputField.BorderRadius = 18;
            amountOfDoorInputField.BorderSize = 2;
            amountOfDoorInputField.FillColor = Color.White;
            amountOfDoorInputField.Location = new Point(36, 303);
            amountOfDoorInputField.Name = "amountOfDoorInputField";
            amountOfDoorInputField.Padding = new Padding(10, 5, 10, 5);
            amountOfDoorInputField.PlaceholderText = "Amount of doors...";
            amountOfDoorInputField.Size = new Size(361, 37);
            amountOfDoorInputField.TabIndex = 15;
            amountOfDoorInputField.TextAlign = HorizontalAlignment.Left;
            amountOfDoorInputField.UseSystemPasswordChar = false;
            // 
            // colorInputField
            // 
            colorInputField.BackColor = Color.White;
            colorInputField.BorderColor = Color.Red;
            colorInputField.BorderRadius = 18;
            colorInputField.BorderSize = 2;
            colorInputField.FillColor = Color.White;
            colorInputField.Location = new Point(511, 303);
            colorInputField.Name = "colorInputField";
            colorInputField.Padding = new Padding(10, 5, 10, 5);
            colorInputField.PlaceholderText = "Color...";
            colorInputField.Size = new Size(361, 37);
            colorInputField.TabIndex = 16;
            colorInputField.TextAlign = HorizontalAlignment.Left;
            colorInputField.UseSystemPasswordChar = false;
            // 
            // addImagesButton
            // 
            addImagesButton.BackColor = Color.FromArgb(255, 87, 87);
            addImagesButton.FlatAppearance.BorderSize = 0;
            addImagesButton.FlatStyle = FlatStyle.Flat;
            addImagesButton.ForeColor = Color.White;
            addImagesButton.Location = new Point(36, 353);
            addImagesButton.Name = "addImagesButton";
            addImagesButton.Size = new Size(76, 76);
            addImagesButton.TabIndex = 0;
            addImagesButton.Text = "Add Images";
            addImagesButton.UseVisualStyleBackColor = false;
            addImagesButton.Click += addImagesButton_Click;
            // 
            // AddCar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(addImagesButton);
            Controls.Add(colorInputField);
            Controls.Add(amountOfDoorInputField);
            Controls.Add(selectAutomaticButton);
            Controls.Add(selectManualButton);
            Controls.Add(licencePlateInputField);
            Controls.Add(priceInputField);
            Controls.Add(mileageInputField);
            Controls.Add(addCarButton);
            Controls.Add(uploadedImagesView);
            Controls.Add(buildYearInputField);
            Controls.Add(modelInputField);
            Controls.Add(brandInputField);
            Controls.Add(branchLabel);
            Controls.Add(pictureBox1);
            Name = "AddCar";
            Size = new Size(923, 531);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label branchLabel;
        private Controls.RoundedTextBox brandInputField;
        private Controls.RoundedTextBox modelInputField;
        private Controls.RoundedTextBox buildYearInputField;
        private Controls.RoundedTextBox roundedTextBox4;
        private FlowLayoutPanel uploadedImagesView;
        private Cheraasje.Epp.UI.Controls.RoundedButton addCarButton;
        private Controls.RoundedTextBox mileageInputField;
        private Controls.RoundedTextBox priceInputField;
        private Controls.RoundedTextBox licencePlateInputField;
        private Cheraasje.Epp.UI.Controls.RoundedButton selectManualButton;
        private Cheraasje.Epp.UI.Controls.RoundedButton selectAutomaticButton;
        private Controls.RoundedTextBox amountOfDoorInputField;
        private Controls.RoundedTextBox colorInputField;
        private Cheraasje.Epp.UI.Controls.RoundedButton addImagesButton;
    }
}
