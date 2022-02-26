﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace XDrawer2
{
    public class Line : BoxFigure
    {
        public Line(int x, int y)
            : base(x,y)
        {            
        }

        public Line(int x1, int y1, int x2, int y2)
            : base(x1, y1, x2, y2)
        {
        }

        public override void draw(Graphics g)
        {
            Pen pen = new Pen(_color);
            g.DrawLine(pen, _x1, _y1, _x2, _y2);
        }

        public override void draw(Graphics g, Pen pen)
        {
            g.DrawLine(pen, _x1, _y1, _x2, _y2);
        }

        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        internal static extern bool MoveToEx(IntPtr hdc, 
            int x1, int y1, int pos);
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        internal static extern bool LineTo(IntPtr hdc,
            int x1, int y1);
        public override void draw(IntPtr hdc)
        {
            MoveToEx(hdc, _x1, _y1, 0);
            LineTo(hdc, _x2, _y2);
        }

        public override void makeRegion()
        {
            int regionWidth = 20;
            int x = _x1;
            int y = _y1;
            int w = _x2 - _x1;
            int h = _y2 - _y1;
            int sign_h = 1;
            if (h < 0) sign_h = -1;
            double angle;
            double theta = (w != 0) ? Math.Atan((double)(h) / (double)(w)) : sign_h * Math.PI / 2.0;
            if (theta < 0) theta = theta + 2 * Math.PI;
            angle = (theta + Math.PI / 2.0);
            int dx = (int)(regionWidth * Math.Cos(angle));
            int dy = (int)(regionWidth * Math.Sin(angle));
            System.Drawing.Point[] pt = new System.Drawing.Point[4];
            pt[0].X = x + dx; pt[0].Y = y + dy;
            pt[1].X = x - dx; pt[1].Y = y - dy;
            pt[2].X = x + w - dx; pt[2].Y = y + h - dy;
            pt[3].X = x + w + dx; pt[3].Y = y + h + dy;
            byte[] type = new byte[4];
            type[0] = (byte)PathPointType.Line;
            type[1] = (byte)PathPointType.Line;
            type[2] = (byte)PathPointType.Line;
            type[3] = (byte)PathPointType.Line;
            GraphicsPath gp = new GraphicsPath(pt, type);
            _region = new Region(gp);
        }

        public override Figure clone()
        {
            Line newFigure = new Line(_x1, _y1, _x2, _y2);
            newFigure._color = _color;
            newFigure._popup = _popup;
            newFigure.move(20, 20);
            return newFigure;
        }
        
//      private bool _fillFlag;
/*      public Box()
        {
            _fillFlag = false;
        }
        
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        internal static extern bool Rectangle(
            IntPtr hdc,
            int ulCornerX, int ulCornerY,
            int lrCornerX, int lrCornerY);

        public override void draw(Graphics g, Pen pen)
        {
            if (_fillFlag == true)
            {
                Brush br = new SolidBrush(_color);
                g.FillRectangle(br, Math.Min(_x1,_x2), Math.Min(_y1, _y2), Math.Abs(_x2 - _x1), Math.Abs(_y2 - _y1));
                br.Dispose();
            }
            Color oldColor = pen.Color;
            pen.Color = _color;
            g.DrawRectangle(pen, Math.Min(_x1,_x2), Math.Min(_y1, _y2), Math.Abs(_x2 - _x1), Math.Abs(_y2 - _y1));
            pen.Color = oldColor;
        }

        public override void draw(IntPtr hdc)
        {
            Rectangle(hdc, _x1, _y1, _x2, _y2);
        }

        public override Figure clone()
        {
            //Box newFigure = new Box(_popup, _x1, _y1, _x2, _y2);
            //newFigure._color = _color;
            //newFigure._fillFlag = _fillFlag;
            //return newFigure;
            return null;
        }
*/
    }
}
