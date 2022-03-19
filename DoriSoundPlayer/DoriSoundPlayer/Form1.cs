using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using SM = System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoriSoundPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _tm = new Timer();
        }


        #region SystemSound
        private void btnBeep_Click(object sender, EventArgs e)
        {
            if (rdoBeep1.Checked)
            {
                SM.SystemSounds.Asterisk.Play();
            }
            else if (rdoBeep2.Checked)
            {
                SM.SystemSounds.Beep.Play();
            }
            else if (rdoBeep3.Checked)
            {
                SM.SystemSounds.Exclamation.Play();
            }
            else if (rdoBeep4.Checked)
            {
                SM.SystemSounds.Hand.Play();                
            }
            else if (rdoBeep5.Checked)
            {
                SM.SystemSounds.Question.Play();
            }
        }
        #endregion


        #region WAV

        SM.SoundPlayer _soundPlay;

        private void btnWAV_Click(object sender, EventArgs e)
        {
            string strFilePath = string.Empty;

            OFDialog.InitialDirectory = Application.StartupPath; // 프로그램 실행 파일 위치
            OFDialog.FileName = "*.wav";
            OFDialog.Filter = "wav files (*.wav)|*.wav|All files (*.*)|*.*";

            if (OFDialog.ShowDialog() == DialogResult.OK)
            {
                PlayWaveFile(OFDialog.FileName, false);
            }

        }

        private void PlayWaveFile(string filePath, bool playLooping)
        {
            if (_soundPlay != null)
            {
                _soundPlay.Stop();
                _soundPlay.Dispose();
                _soundPlay = null;
            }

            if (string.IsNullOrWhiteSpace(filePath))
            {
                return;
            }

            _soundPlay = new SM.SoundPlayer(filePath);

            if (playLooping)
            {
                _soundPlay.PlayLooping();
            }
            else
            {
                _soundPlay.Play();
            }
        }

        #endregion

        #region MP3

        Timer _tm;
        MediaPlayer.MediaPlayerClass _mediaPlayer;

        enum EnumStatus
        {
            Play,
            Stop,
            Pause,
        }

        private void btnMP3_Click(object sender, EventArgs e)
        {
            string strFilePath = string.Empty;

            OFDialog.InitialDirectory = Application.StartupPath; // 프로그램 실행 파일 위치
            OFDialog.FileName = "*.mp3";
            OFDialog.Filter = "mp3 files (*.mp3)|*.mp3|All files (*.*)|*.*";

            if (OFDialog.ShowDialog() == DialogResult.OK)
            {
                if (_mediaPlayer == null)
                {
                    _mediaPlayer = new MediaPlayer.MediaPlayerClass();
                }

                _mediaPlayer.FileName = OFDialog.FileName;
                _mediaPlayer.Stop();
                changeStatus(EnumStatus.Stop);
                tboxFileName.Text = OFDialog.FileName;

                tbarVolume.Value = TrackbarToVolume(-1200, 0, _mediaPlayer.Volume);
                lblVolume.Text = tbarVolume.Value.ToString();

                _tm.Interval = 500;
                _tm.Tick += _tm_Tick;
            }
        }

        void _tm_Tick(object sender, EventArgs e)
        {
            tbarMain.Minimum = 0;
            tbarMain.Maximum = (int)_mediaPlayer.Duration; // MP3 파일의 전체 재생 시간 (int)
            tbarMain.Value = (int)_mediaPlayer.CurrentPosition; // MP3 파일의 현재 재생 위치

            string strCurrentTime = TimeSpan.FromSeconds(_mediaPlayer.CurrentPosition).ToString(@"hh\:mm\:ss");
            string strFullTime = TimeSpan.FromSeconds(_mediaPlayer.Duration).ToString(@"hh\:mm\:ss");

            lblTime.Text = string.Format("{0} / {1}", strCurrentTime, strFullTime);

            //tbarVolume.Value = TrackbarToVolume(-1200, 0, _mediaPlayer.Volume);
            //lblVolume.Text = tbarVolume.Value.ToString();
        }
        
        private void btnPlay_Click(object sender, EventArgs e)
        {
            _mediaPlayer.Play();
            _tm.Start();
            changeStatus(EnumStatus.Play);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            _mediaPlayer.Stop();
            _tm.Stop();
            changeStatus(EnumStatus.Stop);
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            _mediaPlayer.Pause();
            changeStatus(EnumStatus.Pause);
        }

        private void changeStatus(EnumStatus eStatus)
        {
            tboxStatus.Text = eStatus.ToString();
        }

        private void tbarVolume_Scroll(object sender, EventArgs e)
        {
            lblVolume.Text = tbarVolume.Value.ToString();

            int iVolume = VolumeToTrackbar(-1200, 0, tbarVolume.Value);

            if (tbarVolume.Value == 0)
            {
                _mediaPlayer.Mute = true;
            }
            else
            {
                _mediaPlayer.Mute = false;
                _mediaPlayer.Volume = iVolume;
            }
            //tbarVolume.Value = _mediaPlayer.Volume;

            //_mediaPlayer.Volume = tbarVolume.Value;


        }

        /// <summary>
        /// 1 : 100 = -1200 : 0 => 50 : ?
        /// </summary>
        /// <param name="Min"></param>
        /// <param name="Max"></param>
        /// <param name="Value"></param>
        /// <returns></returns>
        private int TrackbarToVolume(int Min, int Max, int Value)
        {
            double iRange = Max - Min;
            double iTarget = Value - Min;
            return (int)(iTarget / iRange * 100);
        }

        /// <summary>
        /// -600 : ?
        /// </summary>
        /// <param name="Min"></param>
        /// <param name="Max"></param>
        /// <param name="Per"></param>
        /// <returns></returns>
        private int VolumeToTrackbar(int Min, int Max, int Per)
        {
            double iRange = Max - Min;
            double iTarget = iRange * Per / 100;
            return (int)(iTarget + Min);
        }

        #endregion
    }
}
