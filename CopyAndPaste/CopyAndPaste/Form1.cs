using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
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
            try
            {
                if (e.Control && e.KeyCode == Keys.C && cboxActivation.Checked)
                {
                    Thread.Sleep(400);

                    lboxTextSave.Items.Add(Clipboard.GetData(System.Windows.Forms.DataFormats.UnicodeText).ToString());
                }
            }
            catch (Exception)
            {

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

        #region MStrip

        private void 저장하기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fFileSave();
        }
        
        private void 불러오기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fFileLoad();
        }

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 공백제거ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fEmptyDelete();
        }

        private void 모두삭제ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAllDelete();
        }

        private void 프로그램정보ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fProgramInfo();
        }

        #endregion

        #region CMStrip

        private void 공백제거ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fEmptyDelete();
        }

        private void 저장하기ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fFileSave();
        }

        private void 불러오기ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fFileLoad();
        }

        private void 모두삭제ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fAllDelete();
        }

        private void 프로그램정보ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fProgramInfo();
        }

        #endregion

        #region Event Function

        /// <summary>
        /// 공백 제거용 함수
        /// </summary>
        private void fEmptyDelete()
        {
            int iCount = lboxTextSave.Items.Count;

            for (int i = 0; i < iCount; i++)
            {
                lboxTextSave.Items[i] = lboxTextSave.Items[i].ToString().Trim();
            }

        }

        /// <summary>
        /// 모두 삭제용 함수
        /// </summary>
        private void fAllDelete()
        {
            if (DialogResult.Yes == MessageBox.Show("등록되어있는 Data를 초기화 하시겠습니까?", "ListBox Item Clear", MessageBoxButtons.YesNo))
            {
                lboxTextSave.Items.Clear();
            }
        }

        /// <summary>
        /// 저장하기용 함수
        /// </summary>
        private void fFileSave()
        {
            SaveFileDialog SFDialog = new SaveFileDialog();

            int libCount = lboxTextSave.Items.Count;
            string strFilePath = string.Empty;

            SFDialog.InitialDirectory = Application.StartupPath;
            SFDialog.FileName = "*.txt";
            SFDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            try
            {
                if (SFDialog.ShowDialog() == DialogResult.OK)
                {
                    strFilePath = SFDialog.FileName;
                    StreamWriter swSFDialog = new StreamWriter(strFilePath);

                    for (int i = 0; i < libCount; i++)
                    {
                        swSFDialog.WriteLine(lboxTextSave.Items[i].ToString());
                    }
                    swSFDialog.Close(); 
                    MessageBox.Show("저장이 완료 되었습니다.");
                }
            }
            catch
            {

            }

        }

        /// <summary>
        /// 불러오기용 함수
        /// </summary>
        private void fFileLoad()
        {

        }

        /// <summary>
        /// 프로그램 정보 함수
        /// </summary>
        private void fProgramInfo()
        {
            string strProgramInfo = "반복작업을 조금이나마 수월하게~! CNP~(Copy N Paste)";
            MessageBox.Show(strProgramInfo);
        }

        #endregion

    }
}
