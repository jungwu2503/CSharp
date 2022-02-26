using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace XDrawer2
{
    public class Box : BoxFigure
    {
        public Box(int x, int y)
            : base(x,y)
        {            
        }

        public Box(int x1, int y1, int x2, int y2)
            : base(x1, y1, x2, y2)
        {

        }

        public override void draw(Graphics g)
        {
            if (_fillFlag == false)
            {
                Pen pen = new Pen(_color);
                g.DrawRectangle(pen, _x1, _y1, _x2 - _x1, _y2 - _y1);
            }
            else
            {
                Brush brush = new SolidBrush(_color);
                g.FillRectangle(brush, _x1, _y1, _x2 - _x1, _y2 - _y1);
            }
        }

        public override void draw(Graphics g, Pen pen)
        {
            g.DrawRectangle(pen, _x1, _y1, _x2 - _x1, _y2 - _y1);
        }

        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        internal static extern bool Rectangle(IntPtr hdc, 
            int x1, int y1, int x2, int y2);
        public override void draw(IntPtr hdc)
        {
            Rectangle(hdc, _x1, _y1, _x2, _y2);
        }

        public override Figure clone()
        {
            Box newFigure = new Box(_x1,_y1,_x2,_y2);
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
