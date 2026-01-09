namespace cheraasje_epp.UI.Pages.FleetWidgets
{
    partial class CarResultItem
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
            titleLabel = new Label();
            pictureBox1 = new PictureBox();
            priceLabel = new Label();
            mileageLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLabel.Location = new Point(142, 22);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(74, 25);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "{TITLE}";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(8, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(103, 103);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            priceLabel.Location = new Point(142, 53);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(61, 21);
            priceLabel.TabIndex = 2;
            priceLabel.Text = "{PRICE}";
            // 
            // mileageLabel
            // 
            mileageLabel.AutoSize = true;
            mileageLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mileageLabel.Location = new Point(279, 53);
            mileageLabel.Name = "mileageLabel";
            mileageLabel.Size = new Size(83, 21);
            mileageLabel.TabIndex = 3;
            mileageLabel.Text = "{MILEAGE}";
            // 
            // CarResultItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(mileageLabel);
            Controls.Add(priceLabel);
            Controls.Add(pictureBox1);
            Controls.Add(titleLabel);
            Name = "CarResultItem";
            Size = new Size(634, 121);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLabel;
        private PictureBox pictureBox1;
        private Label priceLabel;
        private Label mileageLabel;
    }
}
