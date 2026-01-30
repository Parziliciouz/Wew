using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ACUsageTracker
{
    public class SoftButton : Button
    {
        private int _borderRadius = 20;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int BorderRadius 
        { 
            get => _borderRadius; 
            set { _borderRadius = value; UpdateRegion(); } 
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color HoverColor { get; set; }

        public SoftButton()
        {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | 
                          ControlStyles.OptimizedDoubleBuffer | 
                          ControlStyles.ResizeRedraw | 
                          ControlStyles.UserPaint, true);
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            UpdateRegion();
        }

        private void UpdateRegion()
        {
            Rectangle rect = new Rectangle(0, 0, Width, Height);
            if (rect.Width > 0 && rect.Height > 0)
            {
                using (GraphicsPath path = GetRoundedPath(rect, BorderRadius))
                {
                    this.Region = new Region(path);
                }
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            // Fill background
            using (var brush = new SolidBrush(this.BackColor))
            {
                g.Clear(this.Parent?.BackColor ?? this.BackColor); // Clear with parent color
                g.FillRectangle(brush, ClientRectangle); // Only fill the region (clipped by control region)
            }

            // Draw Text
            using (var brush = new SolidBrush(this.ForeColor))
            {
                using (var sf = new StringFormat())
                {
                    sf.Alignment = StringAlignment.Center;
                    sf.LineAlignment = StringAlignment.Center;
                    g.DrawString(this.Text, this.Font, brush, ClientRectangle, sf);
                }
            }
        }

        private GraphicsPath GetRoundedPath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;
            if (curveSize <= 0) curveSize = 1;
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }
    }

    public class SoftPanel : Panel
    {
        private int _borderRadius = 20;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int BorderRadius 
        { 
            get => _borderRadius; 
            set { _borderRadius = value; UpdateRegion(); } 
        }

        public SoftPanel()
        {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | 
                          ControlStyles.OptimizedDoubleBuffer | 
                          ControlStyles.ResizeRedraw | 
                          ControlStyles.UserPaint, true);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            UpdateRegion();
        }

        private void UpdateRegion()
        {
            Rectangle rect = new Rectangle(0, 0, Width, Height);
            if (rect.Width > 0 && rect.Height > 0)
            {
                using (GraphicsPath path = GetRoundedPath(rect, BorderRadius))
                {
                    this.Region = new Region(path);
                }
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            using (var brush = new SolidBrush(this.BackColor))
            {
                g.Clear(this.Parent?.BackColor ?? this.BackColor);
                g.FillRectangle(brush, ClientRectangle);
            }
        }

        private GraphicsPath GetRoundedPath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;
            if (curveSize <= 0) curveSize = 1;
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }
    }
}
