using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoriAsync
{
    class CRobot : CBase
    {
        public Rectangle _rtCircle_Robot;
        public Rectangle _rtSquare_Arm;
        public Rectangle _rtSquare_Object;

        public CRobot(string sName)
        {
            strName = sName;
            _pen = new Pen(Color.WhiteSmoke, 3);
            _brush = new SolidBrush(Color.WhiteSmoke);

            _rtCircle_Robot = new Rectangle(50, 50, 100, 100);
            _rtSquare_Arm = new Rectangle(40, 90, 80, 20);
            _rtSquare_Object = new Rectangle(20, 80, 20, 40);
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
            Point oPoint = _rtSquare_Arm.Location;
            oPoint.X = oPoint.X + iMove;
            _rtSquare_Arm.Location = oPoint;

            oPoint = _rtSquare_Object.Location;
            oPoint.X = oPoint.X + iMove;
            _rtSquare_Object.Location = oPoint;
        }

    }
}
