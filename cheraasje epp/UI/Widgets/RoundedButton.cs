using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class RoundedButton : Button
{
   
    public RoundedButton(Color backColor, Color foreColor)
    {
        // Standaard kleur
        this.BackColor = backColor;
        this.ForeColor = foreColor;

        // Geen standaard WinForms border
        this.FlatStyle = FlatStyle.Flat;
        this.FlatAppearance.BorderSize = 0;

        // Hover events
        this.MouseEnter += (s, e) =>
        {
            this.BackColor = ControlPaint.Light(backColor); // Lichter rood bij hover
            this.Invalidate();
        };
        this.MouseLeave += (s, e) =>
        {
            this.BackColor = backColor;
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
