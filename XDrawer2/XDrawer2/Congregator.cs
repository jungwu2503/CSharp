using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace XDrawer2
{
    class Congregator : BoxFigure
    {
        protected LinkedList<Figure> children;

        public Congregator()
            : base()
        {
            children = new LinkedList<Figure>();
        }

        public Congregator(int x1, int y1, int x2, int y2)
            : base(x1,y1,x2,y2)
        {
            children = new LinkedList<Figure>();
        }

        public override void draw(Graphics g)
        {
            IEnumerator<Figure> i = children.GetEnumerator();
            while (i.MoveNext())
            {
                Figure fig = i.Current;

                fig.draw(g);
            }

        }

        public override void setColor(Color c)
        {
            base.setColor(c);
            foreach (Figure fig in children)
            {
                fig.setColor(c);
            }
        }

        public override void draw(Graphics g, Pen pen)
        {
            base.move(20, 20);
            foreach (Figure fig in children)
            {
                fig.draw(g, pen);
            }
        }

        public override void move(int dx, int dy)
        {
            foreach (Figure fig in children)
            {
                fig.move(dx, dy);
            }
        }

        public override void draw(IntPtr hdc)
        {
            foreach (Figure fig in children)
            {
                fig.draw(hdc);
            }
        }

        public override Figure clone()
        {
            Congregator newFigure = new Congregator();
            newFigure.copy(this);
            foreach (Figure fig in children)
            {
                newFigure.children.AddLast(fig.clone());
            }
            newFigure.move(20, 20);
            return newFigure;
           
        }
    }
}
