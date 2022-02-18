using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoriThread
{
    public partial class Form1 : Form
    {
        private enum enumPlayer
        {
            손흥민,
            김덕배,
            최앙리,
            박무리뉴,
            오메시,
        }

        int _locationX = 0;
        int _locationY = 0;

        public Form1()
        {
            InitializeComponent();

            _locationX = Location.X;
            _locationY = Location.Y;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            _locationX = Location.X + Size.Width;
            _locationY = Location.Y;

            for (int i = 0; i < numPlayerCount.Value; i++)
            {
                Play pl = new Play(((enumPlayer)i).ToString());
                pl.Location = new Point(_locationX, _locationY + pl.Height * i);

                pl.eventdelMessage += pl_eventdelMessage;

                pl.Show();
                pl.fThreadStart();
            }

            
        }

        int pl_eventdelMessage(object sender, string strResult)
        {

            if (InvokeRequired) // 요청한 Thread가 현재 Main Thread에 있는 Control을 엑세스할수 있는지 확인
            {
                Invoke(new Action(delegate()
                {

                    Play oPlayerForm = sender as Play;

                    lboxResult.Items.Add(string.Format("Player : {0}, Text : {1}", oPlayerForm.StrPlayerName, strResult));
                }));
            }
            return 0;
        }

    }
}
