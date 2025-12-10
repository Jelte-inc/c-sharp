using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class RoundedButton : Button
{
    private Color _baseBackColor;
    public Color BaseBackColor
    {
        get { return _baseBackColor; }
        set
        {
            _baseBackColor = value;
            this.BackColor = _baseBackColor; // Stelt de Button.BackColor in
            this.Invalidate();
        }
    }

    public RoundedButton()
    {
        // Standaard kleur
        this.BackColor = _baseBackColor;

        // Geen standaard WinForms border
        this.FlatStyle = FlatStyle.Flat;
        this.FlatAppearance.BorderSize = 0;

        // Hover events
        this.MouseEnter += (s, e) =>
        {
            // Gebruik de private field _baseBackColor om de lichtere kleur te berekenen
            this.BackColor = ControlPaint.Light(_baseBackColor);
            this.Invalidate();
        };
        this.MouseLeave += (s, e) =>
        {
            // Ga terug naar de ingestelde basiskleur
            this.BackColor = _baseBackColor;
            this.Invalidate();
        };
    }

    protected override void OnPaint(PaintEventArgs pevent)
    {
        pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

        int radius = 20;

        // Afgeronde rechthoek
        GraphicsPath path = new GraphicsPath();
        path.AddArc(0, 0, radius, radius, 180, 90);
        path.AddArc(this.Width - radius, 0, radius, radius, 270, 90);
        path.AddArc(this.Width - radius, this.Height - radius, radius, radius, 0, 90);
        path.AddArc(0, this.Height - radius, radius, radius, 90, 90);
        path.CloseAllFigures();

        this.Region = new Region(path);

        // Achtergrond
        using (SolidBrush brush = new SolidBrush(this.BackColor))
        {
            pevent.Graphics.FillPath(brush, path);
        }

        // Tekst
        TextRenderer.DrawText(
            pevent.Graphics,
            this.Text,
            this.Font,
            this.ClientRectangle,
            this.ForeColor,
            TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
        );

    }

}
