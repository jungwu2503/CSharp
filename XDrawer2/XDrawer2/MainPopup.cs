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
            tvItem.Click += new EventHandler(form.tVToolStripMenuItem_Click);

            MenuItem tv2Item = new MenuItem("TV2");
            popupPtr.MenuItems.Add(tv2Item);
            tv2Item.Click += new EventHandler(form.tV2ToolStripMenuItem_Click);

            MenuItem tv3Item = new MenuItem("TV3");
            popupPtr.MenuItems.Add(tv3Item);
            tv3Item.Click += new EventHandler(form.tV3ToolStripMenuItem_Click);

            MenuItem speakerItem = new MenuItem("Speaker");
            popupPtr.MenuItems.Add(speakerItem);
            speakerItem.Click += new EventHandler(form.speakerToolStripMenuItem_Click);

            MenuItem tvsetItem = new MenuItem("TV Set");
            popupPtr.MenuItems.Add(tvsetItem);
            tvsetItem.Click += new EventHandler(form.tVSetToolStripMenuItem_Click);

        }

    }
}
