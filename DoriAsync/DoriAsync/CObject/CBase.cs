using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoriAsync
{
    class CBase
    {
        public string strName;
        protected Pen _pen;
        protected SolidBrush _brush;

        public CBase()
        {
            _pen = new Pen(Color.Aqua);
        }


    }
}
