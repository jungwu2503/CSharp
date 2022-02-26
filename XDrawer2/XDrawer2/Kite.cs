using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XDrawer2
{
    public class Kite : Box
    {
        Circle center;
        Line l1;
        Line l2;
        Line l3;
        Line l4;

        public Kite(int x, int y)
            : base(x,y)
        {
            center = new Circle(x, y);
            l1 = new Line(x, y);
            l2 = new Line(x, y);
            l3 = new Line(x, y);
            l4 = new Line(x, y);
        }

        public Kite(int x1, int y1, int x2, int y2)
            : base (x1,y1,x2,y2)
        {
            int w = x2 - x1;
            int h = y2 - y1;

            center = new Circle(x1 + w / 4, y1 + h / 4, x1 + w * 3 / 4, y1 + h * 3 / 4);
            l1 = new Line(x1, y1, x2, y2);
            l2 = new Line(x1+w/2, y1, x1+w/2, y2);
            l3 = new Line(x2, y1, x1, y2);
            l4 = new Line(x1, y1+h/2, x2, y1+h/2);
        }

        public override void setColor(Color c)
        {
            base.setColor(c);
            center.setColor(c);
            l1.setColor(c);
            l2.setColor(c);
            l3.setColor(c);
            l4.setColor(c);
        }

        public override void fillFigure()
        {
            center.fillFigure();
        }

        public override void draw(Graphics g)
        {
            base.draw(g);
            center.draw(g);
            l1.draw(g);
            l2.draw(g);
            l3.draw(g);
            l4.draw(g);
        }

        public override void draw(IntPtr hdc)
        {
            base.draw(hdc);
            center.draw(hdc);
            l1.draw(hdc);
            l2.draw(hdc);
            l3.draw(hdc);
            l4.draw(hdc);
        }

        public override void move(int dx, int dy)
        {
            base.move(dx, dy);
            center.move(dx, dy);
            l1.move(dx, dy);
            l2.move(dx, dy);
            l3.move(dx, dy);
            l4.move(dx, dy);
        }

        public override void setXY2(int x2, int y2)
        {
            int w = x2 - _x1;
            int h = y2 - _y1;
            base.setXY2(x2, y2);
            center.setXY12(_x1 + w / 4, _y1 + h / 4, _x1 + w * 3 / 4, _y1 + h * 3 / 4);
            l1.setXY2(x2, y2);
            l2.setXY12(_x1+w/2,_y1,_x1+w/2,_y2);
            l3.setXY12(x2, _y1, _x1, y2);
            l4.setXY12(_x1, _y1 + h / 2, x2, _y1 + h / 2);
        }

    }
}
