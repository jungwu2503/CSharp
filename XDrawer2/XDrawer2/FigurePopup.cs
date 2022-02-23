using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XDrawer2
{
    class FigurePopup : Popup
    {
        public FigurePopup(XDrawer form, String title, bool fillFlag)
            : base(form, title)
        {            
            MenuItem deleteItem = new MenuItem("Delete");
            popupPtr.MenuItems.Add(deleteItem);
            deleteItem.Click += new EventHandler(form.deleteSelectedFigure);

            MenuItem copyItem = new MenuItem("Copy");
            popupPtr.MenuItems.Add(copyItem);
            copyItem.Click += new EventHandler(form.copySelectedFigure);

            MenuItem[] colorPopup = new MenuItem[4];
            colorPopup[0] = new MenuItem("Black");
            colorPopup[0].Click += new EventHandler(form.setBlackColorFigure);
            colorPopup[1] = new MenuItem("Red");
            colorPopup[1].Click += new EventHandler(form.setRedColorFigure);
            colorPopup[2] = new MenuItem("Green");
            colorPopup[2].Click += new EventHandler(form.setGreenColorFigure);
            colorPopup[3] = new MenuItem("Blue");
            colorPopup[3].Click += new EventHandler(form.setBlueColorFigure);
            popupPtr.MenuItems.Add("Select Color", colorPopup);

            if (fillFlag)
            {
                MenuItem fillItem = new MenuItem("Fill");
                popupPtr.MenuItems.Add(fillItem);
                fillItem.Click += new EventHandler(form.fillSelectedFigure);
            }
        }
    }
}
