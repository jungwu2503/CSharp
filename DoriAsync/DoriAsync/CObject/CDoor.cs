using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoriAsync
{
    class CDoor : CBase
    {
        public Rectangle _rtDoorSide;
        public Rectangle _rtDoor;

        public CDoor(string sName)
        {
            strName = sName;
            _pen = new Pen(Color.WhiteSmoke, 3);
            _brush = new SolidBrush(Color.WhiteSmoke);

            _rtDoorSide = new Rectangle(10, 70, 20, 60);
            _rtDoor = new Rectangle(10, 70, 20, 60);
        }

        public Pen fPenInfo()
        {
            return _pen;
        }

        public SolidBrush fBrushInfo()
        {
            return _brush;
        }

        public void fMove(int iMove)
        {
            fSquareMove(iMove);
        }

        protected void fSquareMove(int iMove)
        {
            Point oPoint = _rtDoor.Location;
            oPoint.Y = oPoint.Y + iMove;
            _rtDoor.Location = oPoint;
        }

    }
}
