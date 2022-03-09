using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CopyAndPaste
{
    public partial class Form1 : Form
    {
        CGlobalKeyboardHook _kbdHook = new CGlobalKeyboardHook();


        public Form1()
        {
            InitializeComponent();
        }

        void Form1_Load(object sender, System.EventArgs e)
        {
            Version oVersion = Assembly.GetEntryAssembly().GetName().Version;
            this.Text = string.Format("{0} Ver.{1}.{2} / Build Time ({3})", "Copy&Paste", oVersion.Major, oVersion.Minor, GetBuildDateTime(oVersion));

            _kbdHook.hook();
            _kbdHook.KeyDown += _kbdHook_keyDown;
        }

        // Build Time을 변환
        public DateTime GetBuildDateTime(Version oVersion)
        {
            string strVersion = oVersion.ToString();

            // 날짜 등록
            int iDays = Convert.ToInt32(strVersion.Split('.')[2]);
            DateTime refData = new DateTime(2000, 1, 1);
            DateTime dtBuildDate = refData.AddDays(iDays);

            // 초 등록
            int iSeconds = Convert.ToInt32(strVersion.Split('.')[3]);
            iSeconds = iSeconds * 2;
            dtBuildDate = dtBuildDate.AddSeconds(iSeconds);

            // 시차 조정
            DaylightTime daylighttime = TimeZone.CurrentTimeZone.GetDaylightChanges(dtBuildDate.Year);

            if (TimeZone.IsDaylightSavingTime(dtBuildDate, daylighttime)) {
                dtBuildDate = dtBuildDate.Add(daylighttime.Delta);
            }

            return dtBuildDate;
        }

        private void _kbdHook_keyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.C && cboxActivation.Checked)
            {
                Thread.Sleep(400);

                lboxTextSave.Items.Add(Clipboard.GetData(System.Windows.Forms.DataFormats.UnicodeText).ToString());
            }
        }
        
        void lboxTestSave_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (lboxTextSave.SelectedIndex != -1)
            {
                Clipboard.SetData(System.Windows.Forms.DataFormats.UnicodeText, lboxTextSave.SelectedItem.ToString());
            }
        }

        private void tBar_Scroll_Change(object sender, EventArgs e)
        {
            this.Opacity = tBar.Value / 10.0;
        }

        private void btnAdd(object sender, EventArgs e)
        {
            DataSave();            
        }

        private void tbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DataSave();
            }
        }

        private void DataSave()
        {
            string strText = txtlbtextadd.Text;

            if (!string.IsNullOrEmpty(strText) && !lboxTextSave.Items.Contains(strText))
            {
                lboxTextSave.Items.Add(strText);
                txtlbtextadd.Text = "";
            }
        }

        private void cbox_Change(object sender, EventArgs e)
        {
            if (cboxActivation.Checked)
            {
                lblActivation.Text = "활성화 상태(Ctrl + C 가능)";
                lblActivation.Enabled = true;

                txtlbtextadd.Enabled = true;
                btnlbtextadd.Enabled = true;
            }
            else
            {
                lblActivation.Text = "비활성화 상태(붙여넣기만 가능)";
                lblActivation.Enabled = false;

                txtlbtextadd.Enabled = false;
                btnlbtextadd.Enabled = false;
            }
        }

        private void lbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (lboxTextSave.SelectedItems.Count > 0)
                    lboxTextSave.Items.RemoveAt(lboxTextSave.SelectedIndex);
            }
        }

    }
}
