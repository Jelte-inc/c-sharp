namespace cheraasje_epp.UI.Controls
{
    using System;
    using System.Drawing;
    using System.Drawing.Drawing2D;
    using System.Windows.Forms;

    public class RoundedTextBox : UserControl
    {
        private readonly TextBox textBox;

        public RoundedTextBox()
        {
            SetStyle(
                ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.ResizeRedraw,
                true);

            textBox = new TextBox
            {
                BorderStyle = BorderStyle.None,
                Multiline = false,
                Location = new Point(Padding.Left, Padding.Top),
                Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right
            };

            textBox.TextChanged += (s, e) => TextChanged?.Invoke(this, e);

            Padding = new Padding(10, 6, 10, 6);
            Height = 36;

            Controls.Add(textBox);
            UpdateTextBoxLayout();
        }

        // -----------------------
        // Properties
        // -----------------------

        public override string Text
        {
            get => textBox.Text;
            set => textBox.Text = value;
        }

        public override Font Font
        {
            get => textBox.Font;
            set
            {
                textBox.Font = value;
                base.Font = value;
                UpdateTextBoxLayout();
            }
        }

        public override Color ForeColor
        {
            get => textBox.ForeColor;
            set
            {
                textBox.ForeColor = value;
                base.ForeColor = value;
            }
        }

        public Color FillColor
        {
            get => textBox.BackColor;
            set
            {
                textBox.BackColor = value;
                Invalidate();
            }
        }

        public Color BorderColor { get; set; } = Color.Red;

        public int BorderRadius { get; set; } = 15;

        public int BorderSize { get; set; } = 2;

        public HorizontalAlignment TextAlign
        {
            get => textBox.TextAlign;
            set => textBox.TextAlign = value;
        }

        public bool UseSystemPasswordChar
        {
            get => textBox.UseSystemPasswordChar;
            set => textBox.UseSystemPasswordChar = value;
        }

        public string PlaceholderText
        {
            get => textBox.PlaceholderText;
            set => textBox.PlaceholderText = value;
        }

        public TextBox InnerTextBox => textBox;

        public new event EventHandler TextChanged;

        // -----------------------
        // Layout & Painting
        // -----------------------

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            UpdateTextBoxLayout();
        }

        private void UpdateTextBoxLayout()
        {
            if (textBox == null)
                return;

            textBox.Width = Width - Padding.Horizontal;
            textBox.Location = new Point(
                Padding.Left,
                (Height - textBox.PreferredHeight) / 2
            );
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = ClientRectangle;
            rect.Width -= 1;
            rect.Height -= 1;

            using GraphicsPath path = GetRoundedPath(rect, BorderRadius);
            using SolidBrush backgroundBrush = new SolidBrush(FillColor);
            using Pen borderPen = new Pen(BorderColor, BorderSize);

            e.Graphics.FillPath(backgroundBrush, path);
            e.Graphics.DrawPath(borderPen, path);
        }

        private static GraphicsPath GetRoundedPath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int diameter = radius * 2;

            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);
            path.CloseFigure();

            return path;
        }
    }
}
