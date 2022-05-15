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

            float borderSize = 3;
            float radius = 5;

            float X = this.Padding.Left - this.Padding.Right;
            float Y = this.Padding.Top - this.Padding.Bottom;
            float width = BorderWidth;
            float height = BorderHeight;

            Graphics g = e.Graphics;
            GraphicsPath gp = new GraphicsPath();
            gp.AddArc(X + width, Y, radius, radius, 270, 90);
            gp.AddArc(X + width, Y + height, radius, radius, 0, 90);
            gp.AddArc(X, Y + height, radius, radius, 90, 90);
            gp.AddArc(X, Y, radius, radius, 180, 90);
            gp.CloseFigure();
            g.FillPath(new SolidBrush(Background), gp);
            g.DrawPath(new Pen(this.BorderColor, borderSize), gp);
            gp.Dispose();

            if (Checked)
            {
                StringFormat stringFormat = new StringFormat();
                stringFormat.Alignment = StringAlignment.Center;
                stringFormat.LineAlignment = StringAlignment.Center;
                //Font f = new Font("Arial", (float)rc.Height * 0.5f, FontStyle.Bold, GraphicsUnit.Pixel);
                g.DrawString(
                    "\u2713", this.Font, 
                    new SolidBrush(this.ForeColor), 
                    X-1, 
                    Y-5.5f);
            }
        }

        protected override void OnClick(EventArgs e)
        {
            //base.OnClick(e);
            Checked = !Checked;
            Invalidate();
        }

        //protected override void OnMouseEnter(EventArgs e)
        //{
        //    base.OnMouseEnter(e);
        //    this.BorderColor = EnterColor;
        //    this.ForeColor = EnterColor;
        //    Invalidate();
        //}

        //protected override void OnMouseLeave(EventArgs e)
        //{
        //    base.OnMouseEnter(e);
        //    this.BorderColor = LeaveColor;
        //    this.ForeColor = LeaveColor;
        //    Invalidate();
        //}
    }
}
