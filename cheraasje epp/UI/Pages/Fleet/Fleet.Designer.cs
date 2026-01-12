using CheraasjeEpp.UI.Widgets;

namespace CheraasjeEpp.UI.Pages
{
    partial class Fleet
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
            backgroundPictureBox = new PictureBox();
            branchLabel = new Label();
            searchBox = new RoundedTextBox();
            addNewCarButton = new RoundedButton();
            brandFilterButton = new RoundedButton();
            priceFilterButton = new RoundedButton();
            colorFilterButton = new RoundedButton();
            doorFilterButton = new RoundedButton();
            removeFiltersButton = new RoundedButton();
            carList = new FlowLayoutPanel();
            menuButton = new Button();
            ((System.ComponentModel.ISupportInitialize)backgroundPictureBox).BeginInit();
            SuspendLayout();
            // 
            // backgroundPictureBox
            // 
            backgroundPictureBox.BackColor = Color.White;
            backgroundPictureBox.Image = Properties.Resources.FleetPageBackground;
            backgroundPictureBox.Location = new Point(0, 0);
            backgroundPictureBox.Name = "backgroundPictureBox";
            backgroundPictureBox.Size = new Size(923, 531);
            backgroundPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            backgroundPictureBox.TabIndex = 0;
            backgroundPictureBox.TabStop = false;
            // 
            // branchLabel
            // 
            branchLabel.AutoSize = true;
            branchLabel.BackColor = Color.White;
            branchLabel.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            branchLabel.Location = new Point(78, 62);
            branchLabel.Name = "branchLabel";
            branchLabel.Size = new Size(264, 45);
            branchLabel.TabIndex = 1;
            branchLabel.Text = "{BRANCH NAME}";
            // 
            // searchBox
            // 
            searchBox.BackColor = Color.White;
            searchBox.BorderColor = Color.Red;
            searchBox.BorderRadius = 15;
            searchBox.BorderSize = 2;
            searchBox.FillColor = Color.White;
            searchBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchBox.ForeColor = Color.Black;
            searchBox.Location = new Point(420, 39);
            searchBox.Name = "searchBox";
            searchBox.Padding = new Padding(10, 5, 10, 5);
            searchBox.PlaceholderText = "🔎 Type to search...";
            searchBox.Size = new Size(307, 68);
            searchBox.TabIndex = 2;
            searchBox.TextAlign = HorizontalAlignment.Left;
            searchBox.UseSystemPasswordChar = false;
            // 
            // addNewCarButton
            // 
            addNewCarButton.BackColor = Color.FromArgb(255, 87, 87);
            addNewCarButton.FlatAppearance.BorderSize = 0;
            addNewCarButton.FlatStyle = FlatStyle.Flat;
            addNewCarButton.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addNewCarButton.ForeColor = Color.White;
            addNewCarButton.Location = new Point(745, 39);
            addNewCarButton.Name = "addNewCarButton";
            addNewCarButton.Size = new Size(156, 68);
            addNewCarButton.TabIndex = 3;
            addNewCarButton.Text = "+ Add new car";
            addNewCarButton.UseVisualStyleBackColor = false;
            addNewCarButton.Click += addNewCarButton_Click;
            // 
            // brandFilterButton
            // 
            brandFilterButton.BackColor = Color.FromArgb(255, 87, 87);
            brandFilterButton.FlatAppearance.BorderSize = 0;
            brandFilterButton.FlatStyle = FlatStyle.Flat;
            brandFilterButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            brandFilterButton.ForeColor = Color.White;
            brandFilterButton.Location = new Point(22, 134);
            brandFilterButton.Name = "brandFilterButton";
            brandFilterButton.Size = new Size(168, 41);
            brandFilterButton.TabIndex = 4;
            brandFilterButton.Text = "Brand";
            brandFilterButton.UseVisualStyleBackColor = false;
            brandFilterButton.Click += BrandFilterButton_Click;
            // 
            // priceFilterButton
            // 
            priceFilterButton.BackColor = Color.FromArgb(255, 87, 87);
            priceFilterButton.FlatAppearance.BorderSize = 0;
            priceFilterButton.FlatStyle = FlatStyle.Flat;
            priceFilterButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            priceFilterButton.ForeColor = Color.White;
            priceFilterButton.Location = new Point(198, 134);
            priceFilterButton.Name = "priceFilterButton";
            priceFilterButton.Size = new Size(168, 41);
            priceFilterButton.TabIndex = 5;
            priceFilterButton.Text = "Price";
            priceFilterButton.UseVisualStyleBackColor = false;
            priceFilterButton.Click += priceFilterButton_Click;
            // 
            // colorFilterButton
            // 
            colorFilterButton.BackColor = Color.FromArgb(255, 87, 87);
            colorFilterButton.FlatAppearance.BorderSize = 0;
            colorFilterButton.FlatStyle = FlatStyle.Flat;
            colorFilterButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            colorFilterButton.ForeColor = Color.White;
            colorFilterButton.Location = new Point(375, 134);
            colorFilterButton.Name = "colorFilterButton";
            colorFilterButton.Size = new Size(168, 41);
            colorFilterButton.TabIndex = 6;
            colorFilterButton.Text = "Color";
            colorFilterButton.UseVisualStyleBackColor = false;
            colorFilterButton.Click += colorFilterButton_Click;
            // 
            // doorFilterButton
            // 
            doorFilterButton.BackColor = Color.FromArgb(255, 87, 87);
            doorFilterButton.FlatAppearance.BorderSize = 0;
            doorFilterButton.FlatStyle = FlatStyle.Flat;
            doorFilterButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            doorFilterButton.ForeColor = Color.White;
            doorFilterButton.Location = new Point(551, 134);
            doorFilterButton.Name = "doorFilterButton";
            doorFilterButton.Size = new Size(168, 41);
            doorFilterButton.TabIndex = 7;
            doorFilterButton.Text = "Doors";
            doorFilterButton.UseVisualStyleBackColor = false;
            doorFilterButton.Click += doorFilterButton_Click;
            // 
            // removeFiltersButton
            // 
            removeFiltersButton.BackColor = Color.Silver;
            removeFiltersButton.FlatAppearance.BorderSize = 0;
            removeFiltersButton.FlatStyle = FlatStyle.Flat;
            removeFiltersButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            removeFiltersButton.ForeColor = Color.White;
            removeFiltersButton.Location = new Point(728, 134);
            removeFiltersButton.Name = "removeFiltersButton";
            removeFiltersButton.Size = new Size(173, 41);
            removeFiltersButton.TabIndex = 8;
            removeFiltersButton.Text = "X Remove filters";
            removeFiltersButton.UseVisualStyleBackColor = false;
            removeFiltersButton.Click += removeFiltersButton_Click;
            // 
            // carList
            // 
            carList.AutoScroll = true;
            carList.FlowDirection = FlowDirection.TopDown;
            carList.Location = new Point(78, 197);
            carList.Name = "carList";
            carList.Size = new Size(751, 331);
            carList.TabIndex = 9;
            carList.WrapContents = false;
            // 
            // menuButton
            // 
            menuButton.BackColor = Color.White;
            menuButton.Cursor = Cursors.Hand;
            menuButton.FlatAppearance.BorderSize = 0;
            menuButton.FlatStyle = FlatStyle.Flat;
            menuButton.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            menuButton.Location = new Point(12, 16);
            menuButton.Name = "menuButton";
            menuButton.Size = new Size(36, 46);
            menuButton.TabIndex = 10;
            menuButton.Text = "☰";
            menuButton.UseVisualStyleBackColor = false;
            menuButton.Click += menuButton_Click;
            // 
            // Fleet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(menuButton);
            Controls.Add(carList);
            Controls.Add(removeFiltersButton);
            Controls.Add(doorFilterButton);
            Controls.Add(colorFilterButton);
            Controls.Add(priceFilterButton);
            Controls.Add(brandFilterButton);
            Controls.Add(addNewCarButton);
            Controls.Add(searchBox);
            Controls.Add(branchLabel);
            Controls.Add(backgroundPictureBox);
            Name = "Fleet";
            Size = new Size(923, 531);
            ((System.ComponentModel.ISupportInitialize)backgroundPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox backgroundPictureBox;
        private Label branchLabel;
        private RoundedTextBox searchBox;
        private RoundedButton addNewCarButton;
        private RoundedButton brandFilterButton;
        private RoundedButton priceFilterButton;
        private RoundedButton colorFilterButton;
        private RoundedButton doorFilterButton;
        private RoundedButton removeFiltersButton;
        private FlowLayoutPanel carList;
        private Button menuButton;
    }
}
