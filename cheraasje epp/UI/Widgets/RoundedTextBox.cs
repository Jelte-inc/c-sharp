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

    public RoundedTextBox()
    {
        this.Padding = new Padding(10, 5, 10, 5);
        this.BackColor = Color.White;

        textBox.BorderStyle = BorderStyle.None;
        textBox.Location = new Point(10, 8);
        textBox.Width = this.Width - 20;
        textBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

        Controls.Add(textBox);
        this.Height = 35;
    }

    protected override void OnResize(EventArgs e)
    {
        base.OnResize(e);
        textBox.Location = new Point(10, (this.Height - textBox.Height) / 2);
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        Graphics g = e.Graphics;
        g.SmoothingMode = SmoothingMode.AntiAlias;

        Rectangle rect = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
        using (GraphicsPath path = GetRoundPath(rect, BorderRadius))
        using (Pen pen = new Pen(BorderColor, BorderSize))
        {
            g.DrawPath(pen, path);
        }
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
    public bool UseSystemPasswordChar { get => textBox.UseSystemPasswordChar; set => textBox.UseSystemPasswordChar = value; }
    public TextBox InnerTextBox => textBox;
}
