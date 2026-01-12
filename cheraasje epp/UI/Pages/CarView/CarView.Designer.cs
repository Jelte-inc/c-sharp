namespace cheraasje_epp.UI.Pages
{
    partial class CarView
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
        /// 
        private void InitializeComponent()
        {
            carNameLabel = new Label();
            currentCarPicture = new PictureBox();
            backLabel = new Label();
            carImages = new FlowLayoutPanel();
            buildYearLabel = new Label();
            mileageLabel = new Label();
            askingPriceLabel = new Label();
            licensePlateLabel = new Label();
            transmissionLabel = new Label();
            cycleBackButton = new Button();
            cycleForwardButton = new Button();
            labelTable = new TableLayoutPanel();
            buildYearTextLabel = new Label();
            mileageTextLabel = new Label();
            askingPriceTextLabel = new Label();
            licensePlateTextLabel = new Label();
            transmissionTextLabel = new Label();
            titleLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)currentCarPicture).BeginInit();
            labelTable.SuspendLayout();
            SuspendLayout();
            // 
            // carNameLabel
            // 
            carNameLabel.AutoSize = true;
            carNameLabel.BackColor = Color.White;
            carNameLabel.Font = new Font("Segoe UI", 38F, FontStyle.Bold);
            carNameLabel.Location = new Point(11, 117);
            carNameLabel.Name = "carNameLabel";
            carNameLabel.Size = new Size(288, 68);
            carNameLabel.TabIndex = 1;
            carNameLabel.Text = "{CarName}";
            // 
            // currentCarPicture
            // 
            currentCarPicture.Location = new Point(636, 117);
            currentCarPicture.Name = "currentCarPicture";
            currentCarPicture.Size = new Size(250, 250);
            currentCarPicture.TabIndex = 2;
            currentCarPicture.TabStop = false;
            // 
            // backLabel
            // 
            backLabel.AutoSize = true;
            backLabel.BackColor = Color.White;
            backLabel.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            backLabel.Location = new Point(776, 19);
            backLabel.Name = "backLabel";
            backLabel.Size = new Size(110, 40);
            backLabel.TabIndex = 3;
            backLabel.Text = "< back";
            backLabel.Click += backLabel_Click;
            // 
            // carImages
            // 
            carImages.Location = new Point(636, 383);
            carImages.Name = "carImages";
            carImages.Size = new Size(250, 74);
            carImages.TabIndex = 4;
            // 
            // buildYearLabel
            // 
            buildYearLabel.AutoSize = true;
            buildYearLabel.BackColor = Color.White;
            buildYearLabel.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buildYearLabel.Location = new Point(224, 6);
            buildYearLabel.Margin = new Padding(0, 6, 0, 6);
            buildYearLabel.Name = "buildYearLabel";
            buildYearLabel.Size = new Size(169, 40);
            buildYearLabel.TabIndex = 5;
            buildYearLabel.Text = "{BuildYear}";
            // 
            // mileageLabel
            // 
            mileageLabel.AutoSize = true;
            mileageLabel.BackColor = Color.White;
            mileageLabel.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mileageLabel.Location = new Point(224, 58);
            mileageLabel.Margin = new Padding(0, 6, 0, 6);
            mileageLabel.Name = "mileageLabel";
            mileageLabel.Size = new Size(149, 40);
            mileageLabel.TabIndex = 6;
            mileageLabel.Text = "{Mileage}";
            // 
            // askingPriceLabel
            // 
            askingPriceLabel.AutoSize = true;
            askingPriceLabel.BackColor = Color.White;
            askingPriceLabel.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            askingPriceLabel.Location = new Point(224, 110);
            askingPriceLabel.Margin = new Padding(0, 6, 0, 6);
            askingPriceLabel.Name = "askingPriceLabel";
            askingPriceLabel.Size = new Size(200, 40);
            askingPriceLabel.TabIndex = 7;
            askingPriceLabel.Text = "{AskingPrice}";
            // 
            // licensePlateLabel
            // 
            licensePlateLabel.AutoSize = true;
            licensePlateLabel.BackColor = Color.White;
            licensePlateLabel.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            licensePlateLabel.Location = new Point(224, 162);
            licensePlateLabel.Margin = new Padding(0, 6, 0, 6);
            licensePlateLabel.Name = "licensePlateLabel";
            licensePlateLabel.Size = new Size(208, 40);
            licensePlateLabel.TabIndex = 8;
            licensePlateLabel.Text = "{LicensePlate}";
            // 
            // transmissionLabel
            // 
            transmissionLabel.AutoSize = true;
            transmissionLabel.BackColor = Color.White;
            transmissionLabel.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            transmissionLabel.Location = new Point(224, 214);
            transmissionLabel.Margin = new Padding(0, 6, 0, 6);
            transmissionLabel.Name = "transmissionLabel";
            transmissionLabel.Size = new Size(218, 40);
            transmissionLabel.TabIndex = 9;
            transmissionLabel.Text = "{Transmission}";
            // 
            // cycleBackButton
            // 
            cycleBackButton.Location = new Point(638, 231);
            cycleBackButton.Name = "cycleBackButton";
            cycleBackButton.Size = new Size(23, 23);
            cycleBackButton.TabIndex = 11;
            cycleBackButton.Text = "<";
            cycleBackButton.UseVisualStyleBackColor = true;
            cycleBackButton.Click += cycleBackButton_Click;
            // 
            // cycleForwardButton
            // 
            cycleForwardButton.Location = new Point(861, 231);
            cycleForwardButton.Name = "cycleForwardButton";
            cycleForwardButton.Size = new Size(23, 23);
            cycleForwardButton.TabIndex = 12;
            cycleForwardButton.Text = ">";
            cycleForwardButton.UseVisualStyleBackColor = true;
            cycleForwardButton.Click += cycleForwardButton_Click;
            // 
            // labelTable
            // 
            labelTable.AutoSize = true;
            labelTable.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            labelTable.BackColor = Color.White;
            labelTable.ColumnCount = 2;
            labelTable.ColumnStyles.Add(new ColumnStyle());
            labelTable.ColumnStyles.Add(new ColumnStyle());
            labelTable.Controls.Add(buildYearTextLabel, 0, 0);
            labelTable.Controls.Add(buildYearLabel, 1, 0);
            labelTable.Controls.Add(mileageTextLabel, 0, 1);
            labelTable.Controls.Add(mileageLabel, 1, 1);
            labelTable.Controls.Add(askingPriceTextLabel, 0, 2);
            labelTable.Controls.Add(askingPriceLabel, 1, 2);
            labelTable.Controls.Add(licensePlateTextLabel, 0, 3);
            labelTable.Controls.Add(licensePlateLabel, 1, 3);
            labelTable.Controls.Add(transmissionTextLabel, 0, 4);
            labelTable.Controls.Add(transmissionLabel, 1, 4);
            labelTable.Location = new Point(23, 196);
            labelTable.Name = "labelTable";
            labelTable.RowCount = 5;
            labelTable.RowStyles.Add(new RowStyle());
            labelTable.RowStyles.Add(new RowStyle());
            labelTable.RowStyles.Add(new RowStyle());
            labelTable.RowStyles.Add(new RowStyle());
            labelTable.RowStyles.Add(new RowStyle());
            labelTable.Size = new Size(442, 260);
            labelTable.TabIndex = 0;
            // 
            // buildYearTextLabel
            // 
            buildYearTextLabel.AutoSize = true;
            buildYearTextLabel.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold);
            buildYearTextLabel.Location = new Point(0, 6);
            buildYearTextLabel.Margin = new Padding(0, 6, 20, 6);
            buildYearTextLabel.Name = "buildYearTextLabel";
            buildYearTextLabel.Size = new Size(165, 40);
            buildYearTextLabel.TabIndex = 0;
            buildYearTextLabel.Text = "Build year:";
            // 
            // mileageTextLabel
            // 
            mileageTextLabel.AutoSize = true;
            mileageTextLabel.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold);
            mileageTextLabel.Location = new Point(0, 58);
            mileageTextLabel.Margin = new Padding(0, 6, 20, 6);
            mileageTextLabel.Name = "mileageTextLabel";
            mileageTextLabel.Size = new Size(135, 40);
            mileageTextLabel.TabIndex = 6;
            mileageTextLabel.Text = "Mileage:";
            // 
            // askingPriceTextLabel
            // 
            askingPriceTextLabel.AutoSize = true;
            askingPriceTextLabel.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold);
            askingPriceTextLabel.Location = new Point(0, 110);
            askingPriceTextLabel.Margin = new Padding(0, 6, 20, 6);
            askingPriceTextLabel.Name = "askingPriceTextLabel";
            askingPriceTextLabel.Size = new Size(194, 40);
            askingPriceTextLabel.TabIndex = 7;
            askingPriceTextLabel.Text = "Asking price:";
            // 
            // licensePlateTextLabel
            // 
            licensePlateTextLabel.AutoSize = true;
            licensePlateTextLabel.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold);
            licensePlateTextLabel.Location = new Point(0, 162);
            licensePlateTextLabel.Margin = new Padding(0, 6, 20, 6);
            licensePlateTextLabel.Name = "licensePlateTextLabel";
            licensePlateTextLabel.Size = new Size(203, 40);
            licensePlateTextLabel.TabIndex = 8;
            licensePlateTextLabel.Text = "Licence plate:";
            // 
            // transmissionTextLabel
            // 
            transmissionTextLabel.AutoSize = true;
            transmissionTextLabel.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold);
            transmissionTextLabel.Location = new Point(0, 214);
            transmissionTextLabel.Margin = new Padding(0, 6, 20, 6);
            transmissionTextLabel.Name = "transmissionTextLabel";
            transmissionTextLabel.Size = new Size(204, 40);
            transmissionTextLabel.TabIndex = 9;
            transmissionTextLabel.Text = "Transmission:";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 32.75F);
            titleLabel.Location = new Point(36, 19);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(226, 60);
            titleLabel.TabIndex = 13;
            titleLabel.Text = "Car viewer";
            // 
            // CarView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(titleLabel);
            Controls.Add(labelTable);
            Controls.Add(cycleForwardButton);
            Controls.Add(cycleBackButton);
            Controls.Add(carImages);
            Controls.Add(backLabel);
            Controls.Add(currentCarPicture);
            Controls.Add(carNameLabel);
            Name = "CarView";
            Size = new Size(923, 532);
            ((System.ComponentModel.ISupportInitialize)currentCarPicture).EndInit();
            labelTable.ResumeLayout(false);
            labelTable.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label carNameLabel;
        private PictureBox currentCarPicture;
        private Label backLabel;
        private FlowLayoutPanel carImages;
        private Label buildYearLabel;
        private Label mileageLabel;
        private Label askingPriceLabel;
        private Label licensePlateLabel;
        private Label transmissionLabel;
        private Button cycleBackButton;
        private Button cycleForwardButton;
        private TableLayoutPanel labelTable;
        private Label titleLabel;
        private Label buildYearTextLabel;
        private Label mileageTextLabel;
        private Label askingPriceTextLabel;
        private Label licensePlateTextLabel;
        private Label transmissionTextLabel;
    }
}
