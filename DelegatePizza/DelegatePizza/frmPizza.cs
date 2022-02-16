using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelegatePizza
{
    public partial class frmPizza : Form
    {
        public delegate int delPizzaComplete(string strResult, int iTime);
        public event delPizzaComplete eventdelPizzaComplete; // delegate event 선언
        //private Dictionary<string, int> dPizzaOrder;

        private bool bOrderComplete = false; // 제작 완료 확인 flag

        public bool BOrderComplete
        {
            get { return bOrderComplete; }
            set { bOrderComplete = value; }
        }

        public frmPizza()
        {
            InitializeComponent();
        }

        //public frmPizza(Dictionary<string, int> dPizzaOrder)
        //{
        //    this.dPizzaOrder = dPizzaOrder;
        //}

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        internal void fpizzrCheck(Dictionary<string, int> dPizzaOrder)
        {
            int iTotalTime = 0;
            bOrderComplete = false;

            foreach (KeyValuePair<string,int> oOrder in dPizzaOrder)
            {
                int iNowTime = 0;
                string strType = string.Empty;
                int iTime = 0;
                int iCount = oOrder.Value;

                switch (oOrder.Key)
                {
                    case "오리지널":
                        iNowTime = 3000;
                        strType = "도우";                        
                        break;
                    case "씬":
                        iNowTime = 3500;
                        strType = "도우";
                        break;
                    case "리치골드":
                        iNowTime = 500;
                        strType = "엣지";
                        break;
                    case "치즈크러스트":
                        iNowTime = 400;
                        strType = "엣지";
                        break;
                    case "소세지":
                        iNowTime = 32;
                        strType = "토핑";
                        break;
                    case "감자":
                        iNowTime = 17;
                        strType = "토핑";
                        break;
                    case "치즈":
                        iNowTime = 48;
                        strType = "토핑";
                        break;
                }

                iTime = iNowTime * iCount;
                iTotalTime += iTime;
                lboxMake.Items.Add(string.Format("{0}) {1} : {2}초 ({3}초, {4}개)", strType, oOrder.Key, iTime, iNowTime, iCount));

                Refresh(); // 시스템 부하때문에 잘안씀
                Thread.Sleep(1000);
            }

            int iRet = eventdelPizzaComplete("Pizza가 완성되었습니다.", iTotalTime);

            bOrderComplete = true;

            lboxMake.Items.Add("===================");
            if (iRet == 0)
            {
                lboxMake.Items.Add("주문 완료 확인!!");
            }
            else
            {
                lboxMake.Items.Add("제작 시간 초과. 주문 취소!!");
            }

        }

    }
}
