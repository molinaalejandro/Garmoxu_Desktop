using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Garmoxu_Desktop
{
    class MyCheckBox : Control
    {
        public Color Background { get; set; }

        public Color BorderColor { get; set; }

        public int BorderHeight { get; set; }

        public int BorderWidth { get; set; }

        public bool Checked { get; set; }

        public Color EnterColor { get; set; }

        public Color LeaveColor { get; set; }

        public Padding PaddingCheck { get; set; }

        public MyCheckBox(bool @checked)
        {
            DoubleBuffered = true;
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);

            this.BackColor = Color.Transparent;
            this.Background = Color.White;
            this.BorderColor = Color.Black;
            this.BorderWidth = 15;
            this.BorderHeight = 15;
            this.Checked = @checked;
            this.EnterColor = BorderColor;
            this.LeaveColor = BorderColor;
            this.PaddingCheck = new Padding(0, 0, 0, 0);
        }

        public MyCheckBox() : this(false) { }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            float borderSize = 4;
            float radius = 4;

            float width = BorderWidth;
            float height = BorderHeight;

            //float X = (this.ClientSize.Width / 2) - width / 2;
            //float Y = (this.ClientSize.Height / 2) - height / 2;            

            float X = borderSize/2;
            float Y = borderSize/2;

            Graphics g = e.Graphics;
            GraphicsPath gp = new GraphicsPath();

            gp.AddArc(X, Y, radius, radius, 180, 90);
            gp.AddArc(X + width, Y, radius, radius, 270, 90);
            gp.AddArc(X + width, Y + height, radius, radius, 0, 90);
            gp.AddArc(X, Y + height, radius, radius, 90, 90);

            gp.CloseFigure();
            g.FillPath(new SolidBrush(Background), gp);
            g.DrawPath(new Pen(this.BorderColor, borderSize), gp);
            gp.Dispose();

            if (Checked)
            {
                //StringFormat sf = new StringFormat();
                //sf.Alignment = StringAlignment.Center;
                //sf.LineAlignment = StringAlignment.Center;
                //Font f = new Font("Arial", (float)rc.Height * 0.5f, FontStyle.Bold, GraphicsUnit.Pixel);

                g.DrawString(
                    "\u2713", this.Font,
                    new SolidBrush(this.ForeColor),
                    (this.ClientSize.Width/2) - (g.MeasureString("\u2713", this.Font).Width/2),
                    (this.ClientSize.Height / 2) - (g.MeasureString("\u2713", this.Font).Height / 2)
                    );
            }
        }

        protected override void OnClick(EventArgs e)
        {
            //base.OnClick(e);
            Checked = !Checked;
            Invalidate();
        }
    }
}
