namespace cheraasje_epp.UI.Pages.FleetWidgets
{
    partial class PopUp
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
            comboBox1 = new ComboBox();
            chooseLabel = new Label();
            confirmButton = new Button();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(57, 102);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(273, 23);
            comboBox1.TabIndex = 0;
            // 
            // chooseLabel
            // 
            chooseLabel.AutoSize = true;
            chooseLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chooseLabel.Location = new Point(57, 65);
            chooseLabel.Name = "chooseLabel";
            chooseLabel.Size = new Size(126, 21);
            chooseLabel.TabIndex = 1;
            chooseLabel.Text = "Choose a {VAR}";
            // 
            // confirmButton
            // 
            confirmButton.Location = new Point(57, 149);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new Size(96, 28);
            confirmButton.TabIndex = 2;
            confirmButton.Text = "Confirm";
            confirmButton.UseVisualStyleBackColor = true;
            confirmButton.Click += confirmButton_Click;
            // 
            // PopUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(385, 204);
            Controls.Add(confirmButton);
            Controls.Add(chooseLabel);
            Controls.Add(comboBox1);
            Name = "PopUp";
            Text = "Ok";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label chooseLabel;
        private Button confirmButton;
    }
}