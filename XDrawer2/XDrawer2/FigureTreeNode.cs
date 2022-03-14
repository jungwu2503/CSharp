using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XDrawer2
{
    public class FigureTreeNode : TreeNode
    {
        Figure figure;
        public FigureTreeNode(String name, Figure figure)
            : base(name)
        {
            this.figure = figure;
        }
        public Figure getFigure()
        {
            return figure;
        }
    }
}
