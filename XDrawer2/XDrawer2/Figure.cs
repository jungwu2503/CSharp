using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace XDrawer2
{
    public abstract class Figure
    {
        protected Region _region;
        protected Popup _popup;
        protected bool _fillFlag;
        protected Color _color;

        public abstract void move(int dx, int dy);
        public abstract Figure clone();
        public abstract void draw(Graphics g);
        public abstract void draw(IntPtr hdc);
        public abstract void draw(Graphics g, Pen pen);
        public abstract void setXY2(int x2, int y2);
        public abstract void makeRegion();
        public abstract void setXY12(int x1, int y1, int x2, int y2);

        public Figure()
        {
            _color = Color.Black;
        }

        public Figure(Color color)
        {
            _color = color;
        }

        public void drawing(IntPtr hdc, int x, int y)
        {
            draw(hdc);
            setXY2(x, y);
            draw(hdc);
        }

        public void moving(IntPtr hdc, int dx, int dy)
        {
            draw(hdc);
            move(dx, dy);
            draw(hdc);
        }

        public virtual void setColor(Color c)
        {
            _color = c;
        }

        public virtual void fillFigure()
        {
            _fillFlag = !_fillFlag;
        }

        public void setPopup(Popup popup)
        {
            _popup = popup;
            _fillFlag = false;
        }

        public void popup(System.Drawing.Point point)
        {
            _popup.popup(point);
        }

        public bool ptInRegion(int x, int y)
        {
            if (_region != null)
            {
                return _region.IsVisible(x, y);
            }
            else
            {
                return false;
            }
        }

        /*protected Color _color;

        public Figure()
        {
            _color = Color.Black;
        }

        public virtual void setColor(Color color)
        {
            _color = color;
        }

        public bool ptlnRegion(int x, int y)
        {
            if (_region != null)
            {
                return _region.IsVisible(x, y);
            }
            else
            {
                return false;
            }
        }

        public virtual void setFill()
        {
        }

        public virtual int getX1()
        {
            return -1;
        }

        public virtual int getY1()
        {
            return -1;
        }

        public virtual int getX2()
        {
            return -1;
        }

        public virtual int getY2()
        {
            return -1;
        }

        public virtual void setXY12(int x1, int y1, int x2, int y2)
        {
        }

        public virtual String getClassName()
        {
            return "Figure";
        }

        public virtual void drawing(IntPtr hdc, int newX, int newY)
        {
            draw(hdc);
            setXY2(newX, newY);
            draw(hdc);
        }

        public abstract void draw(Graphics g, Pen pen);
        public abstract void draw(IntPtr hdc);
        public abstract Figure clone();
        public abstract void setXY2(int newX, int newY);
        public abstract void makeRegion();
        public abstract void move(int dx, int dy);
        */
    }
}
