namespace cheraasje_epp.UI.Controls;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class RoundedTextBox : UserControl
{
    private TextBox textBox = new TextBox();

    public Color BorderColor { get; set; } = Color.Red;
    public int BorderRadius { get; set; } = 15;
    public int BorderSize { get; set; } = 2;

    private Color fillColor = Color.White;

    public bool usePasswordMasking { get; set; } = false;

    public HorizontalAlignment TextAlign
    {
        get => textBox.TextAlign;
        set => textBox.TextAlign = value;
    }

    public Color FillColor
    {
        get => fillColor;
        set
        {
            fillColor = value;
            textBox.BackColor = value;
            Invalidate();
        }
    }

    private string placeholderText = "";
    public Color placeholderColor { get; set; } = Color.Gray;

    public string PlaceholderText
    {
        get => placeholderText;
        set
        {
            placeholderText = value;
            SetPlaceholder();
        }
    }

    private void SetPlaceholder()
    {
        if (!DesignMode && string.IsNullOrEmpty(textBox.Text))
        {
            textBox.Text = placeholderText;
            textBox.ForeColor = placeholderColor;
        }
    }

    public RoundedTextBox()
    {
        this.SetStyle(ControlStyles.UserPaint |
                      ControlStyles.AllPaintingInWmPaint |
                      ControlStyles.OptimizedDoubleBuffer, true);

        textBox.BackColor = FillColor;
        this.Padding = new Padding(10, 5, 10, 5);
        textBox.ForeColor = ForeColor;
        textBox.BorderStyle = BorderStyle.None;
        textBox.Location = new Point(10, 8);
        textBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        Controls.Add(textBox);
        this.Height = 35;
        textBox.GotFocus += TextBox_GotFocus;
        textBox.LostFocus += TextBox_LostFocus;
        textBox.TextChanged += TextBox_TextChanged;
        SetPlaceholder();
    }


    protected override void OnResize(EventArgs e)
    {
        base.OnResize(e);

        textBox.Location = new Point(
            Padding.Left,
            (Height - textBox.PreferredHeight) / 2
        );

        textBox.Width = Width - Padding.Horizontal;
    }


    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        Graphics g = e.Graphics;
        g.SmoothingMode = SmoothingMode.AntiAlias;

        Rectangle rect = new Rectangle(0, 0, Width - 1, Height - 1);

        using (GraphicsPath path = GetRoundPath(rect, BorderRadius))
        using (SolidBrush brush = new SolidBrush(FillColor))
        using (Pen pen = new Pen(BorderColor, BorderSize))
        {
            // Achtergrond vullen
            g.FillPath(brush, path);

            // Rand tekenen
            g.DrawPath(pen, path);
        }
    }

    private void TextBox_GotFocus(object sender, EventArgs e)
    {
        if (!DesignMode && textBox.Text == placeholderText)
        {
            textBox.Text = "";
            textBox.ForeColor = ForeColor;
        }
    }

    private void TextBox_LostFocus(object sender, EventArgs e)
    {
        if (!DesignMode && string.IsNullOrEmpty(textBox.Text))
        {
            textBox.Text = placeholderText;
            textBox.ForeColor = placeholderColor;
        }
    }

    private void TextBox_TextChanged(object sender, EventArgs e)
    {
        if (DesignMode)
            return;

        // Masker alleen aan bij echte invoer
        textBox.UseSystemPasswordChar =
            usePasswordMasking &&
            !string.IsNullOrEmpty(textBox.Text) &&
            textBox.Text != placeholderText;
    }


    private GraphicsPath GetRoundPath(Rectangle rect, int radius)
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

    public override string Text { get => textBox.Text; set => textBox.Text = value; }

    public override Color ForeColor
    {
        get => textBox.ForeColor;
        set
        {
            textBox.ForeColor = value;
            base.ForeColor = value;
        }
    }

    public override Font Font
    {
        get => textBox.Font;
        set
        {
            textBox.Font = value;
            base.Font = value;
            Invalidate();
        }
    }

    public bool UseSystemPasswordChar { get => textBox.UseSystemPasswordChar; set => textBox.UseSystemPasswordChar = value; }
    public TextBox InnerTextBox => textBox;
}
