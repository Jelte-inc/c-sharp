namespace CheraasjeEpp.UI.Widgets;

using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class RoundedButton : Button
{
    private Color _baseBackColor;
    private bool _hover;
    private bool _internalColorChange;

    public RoundedButton()
    {
        SetStyle(
            ControlStyles.AllPaintingInWmPaint |
            ControlStyles.OptimizedDoubleBuffer |
            ControlStyles.UserPaint,
            true);

        UseVisualStyleBackColor = false;
        FlatStyle = FlatStyle.Flat;
        FlatAppearance.BorderSize = 0;
        ForeColor = Color.White;
        Cursor = Cursors.Hand;
    }

    protected override void OnCreateControl()
    {
        base.OnCreateControl();
        _baseBackColor = BackColor;
    }

    protected override void OnBackColorChanged(EventArgs e)
    {
        if (!_internalColorChange)
            _baseBackColor = BackColor;

        base.OnBackColorChanged(e);
        Invalidate();
    }

    protected override void OnMouseEnter(EventArgs e)
    {
        _hover = true;
        _internalColorChange = true;
        BackColor = ControlPaint.Light(_baseBackColor, 0.2f);
        _internalColorChange = false;
        base.OnMouseEnter(e);
    }

    protected override void OnMouseLeave(EventArgs e)
    {
        _hover = false;
        _internalColorChange = true;
        BackColor = _baseBackColor;
        _internalColorChange = false;
        base.OnMouseLeave(e);
    }

    protected override void OnClick(EventArgs e)
    {
        base.OnClick(e);
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

        int radius = 20;
        using GraphicsPath path = new GraphicsPath();
        path.AddArc(0, 0, radius, radius, 180, 90);
        path.AddArc(Width - radius, 0, radius, radius, 270, 90);
        path.AddArc(Width - radius, Height - radius, radius, radius, 0, 90);
        path.AddArc(0, Height - radius, radius, radius, 90, 90);
        path.CloseAllFigures();

        Region = new Region(path);

        using var brush = new SolidBrush(BackColor);
        e.Graphics.FillPath(brush, path);

        TextRenderer.DrawText(
            e.Graphics,
            Text,
            Font,
            ClientRectangle,
            ForeColor,
            TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
    }
}
