﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Garmoxu_Desktop
{
    public class MyGroupBox : GroupBox
    {
        private Color _background = Color.Transparent;
        private Color _borderColor = Color.Silver;
        private int _borderSize = 3;
        private bool _textActivated = true;

        public Color Background
        {
            get { return this._background; }
            set { this._background = value; }
        }

        public Color BorderColor
        {
            get { return this._borderColor; }
            set { this._borderColor = value; }
        }

        public int BorderSize
        {
            get { return this._borderSize; }
            set { this._borderSize = value; }
        }

        public bool TextActivated
        {
            get { return this._textActivated; }
            set { this._textActivated = value; }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            //get the text size in groupbox
            Size tSize = TextRenderer.MeasureText(this.Text, this.Font);

            Rectangle borderRect = e.ClipRectangle;
            borderRect.X = (borderRect.X + (tSize.Width / 50));
            borderRect.Y = (borderRect.Y + (tSize.Height / 2));
            borderRect.Width = (borderRect.Width - (tSize.Width / 15));
            borderRect.Height = (borderRect.Height - (tSize.Height / 1) - (tSize.Height / 350));

            float X = borderRect.X;
            float Y = borderRect.Y; 
            float width = borderRect.Width;
            float height = borderRect.Height;
            float radius = 10;

            GraphicsPath gp = new GraphicsPath();
            gp.AddArc(X + width - (radius * 2), Y, radius * 2, radius * 2, 270, 90);
            gp.AddArc(X + width - (radius * 2), Y + height - (radius * 2), radius * 2, radius * 2, 0, 90);
            gp.AddArc(X, Y + height - (radius * 2), radius * 2, radius * 2, 90, 90);
            gp.AddArc(X, Y, radius * 2, radius * 2, 180, 90);
            gp.CloseFigure();
            e.Graphics.FillPath(new SolidBrush(this._background), gp);
            e.Graphics.DrawPath(new Pen(this._borderColor, this._borderSize), gp);
            gp.Dispose();

            //ControlPaint.DrawBorder(e.Graphics, borderRect, this._borderColor, ButtonBorderStyle.Solid);

            if (this._textActivated)
            {
                Rectangle textRect = e.ClipRectangle;
                textRect.X = (textRect.X + 20);
                textRect.Width = tSize.Width-(tSize.Width / 5);
                textRect.Height = tSize.Height;
                e.Graphics.FillRectangle(new SolidBrush(this.BackColor), textRect);
                e.Graphics.DrawString(this.Text, this.Font, new SolidBrush(this.ForeColor), textRect);
            }
        }

    }
}

