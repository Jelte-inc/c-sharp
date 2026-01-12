using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace CheraasjeEpp.UI.Widgets
{
    public class RoundedRectangle : Control
    {
        public Color FillColor { get; set; } = Color.Red;
        public int CornerRadius { get; set; } = 20;

        public RoundedRectangle()
        {
            this.SetStyle(ControlStyles.UserPaint |
                          ControlStyles.OptimizedDoubleBuffer |
                          ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
            this.Size = new Size(200, 60);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            // Make the work area slightly smaller than the control for a sharp edge
            Rectangle rect = new Rectangle(0, 0, this.Width - 1, this.Height - 1);

            // 1. Create the path for the rounded corners
            using (GraphicsPath path = GetRoundedPath(rect, CornerRadius))
            {
                // 2. Fill the inside
                using (SolidBrush brush = new SolidBrush(FillColor))
                {
                    g.FillPath(brush, path);
                }
            }
        }

        private GraphicsPath GetRoundedPath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int d = radius * 2;

            // Prevent radius from being larger than half of the height/width
            if (d > rect.Width) d = rect.Width;
            if (d > rect.Height) d = rect.Height;

            path.AddArc(rect.X, rect.Y, d, d, 180, 90);
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
            path.CloseFigure();
            return path;
        }
    }
}
