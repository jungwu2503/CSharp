using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XDrawer2
{
    class FigureItem : ListViewItem
    {
        Figure figure;
        public FigureItem(String s, Figure figure)
            : base(s)
        {
            this.figure = figure;
        }
        public Figure getFigure() {
            return figure;
        }
    }
}
