using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XDrawer2
{
    class MainPopup : Popup
    {
        
        public MainPopup(XDrawer form)
            : base(form, "Figure")
        {
            MenuItem pointItem = new MenuItem("Point");
            popupPtr.MenuItems.Add(pointItem);
            pointItem.Click += new EventHandler(form.pointToolStripMenuItem_Click);

            MenuItem boxItem = new MenuItem("Box");
            popupPtr.MenuItems.Add(boxItem);
            boxItem.Click += new EventHandler(form.boxToolStripMenuItem_Click);

            MenuItem lineItem = new MenuItem("Line");
            popupPtr.MenuItems.Add(lineItem);
            lineItem.Click += new EventHandler(form.lineToolStripMenuItem_Click);

            MenuItem circleItem = new MenuItem("Circle");
            popupPtr.MenuItems.Add(circleItem);
            circleItem.Click += new EventHandler(form.circleToolStripMenuItem_Click);

            MenuItem kiteItem = new MenuItem("Kite");
            popupPtr.MenuItems.Add(kiteItem);
            kiteItem.Click += new EventHandler(form.kiteToolStripMenuItem_Click);
            
            MenuItem tvItem = new MenuItem("TV");
            popupPtr.MenuItems.Add(tvItem);

        }

    }
}
