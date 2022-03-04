using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoriCoding
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            // 1.
            /*
            string R1 = tboxBefore.Text.Replace("개똥", "사탕");
            tboxAfter.Text = R1;

            string R2 = tboxBefore.Text.Replace("닭", "과자");
            tboxAfter.Text = R2;

            string R3 = tboxBefore.Text.Replace("꿩", "아이스크림");
            tboxAfter.Text = R3;

            string R4 = tboxBefore.Text.Replace("생선", "우유");
            tboxAfter.Text = R4;

            string R5 = tboxBefore.Text.Replace("알", "돈");
            tboxAfter.Text = R5;
            */
            // 2.
            /*
            StringBuilder sb = new StringBuilder();
            string[] strList = tboxBefore.Text.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries );

            string R1 = strList[0].Replace("개똥", "사탕");
            sb.Append(R1 + "\r\n");

            string R2 = strList[1].Replace("닭", "과자");
            sb.Append(R2 + "\r\n");

            string R3 = strList[2].Replace("꿩", "아이스크림");
            sb.Append(R3 + "\r\n");

            string R4 = strList[3].Replace("생선", "우유");
            sb.Append(R4 + "\r\n");

            string R5 = strList[4].Replace("알", "돈");
            sb.Append(R5 + "\r\n");

            tboxAfter.Text = sb.ToString();
            */
            // 3.
            /*
            StringBuilder sb = new StringBuilder();
            string[] strList = tboxBefore.Text.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            
            string R1 = strList[0].Replace(dgChangeData["cBefore", 0].Value.ToString(), dgChangeData["cAfter", 0].Value.ToString());
            sb.Append(R1 + "\r\n");

            string R2 = strList[1].Replace(dgChangeData["cBefore", 1].Value.ToString(), dgChangeData["cAfter", 1].Value.ToString());
            sb.Append(R2 + "\r\n");

            string R3 = strList[2].Replace(dgChangeData["cBefore", 2].Value.ToString(), dgChangeData["cAfter", 2].Value.ToString());
            sb.Append(R3 + "\r\n");

            string R4 = strList[3].Replace(dgChangeData["cBefore", 3].Value.ToString(), dgChangeData["cAfter", 3].Value.ToString());
            sb.Append(R4 + "\r\n");

            string R5 = strList[4].Replace(dgChangeData["cBefore", 4].Value.ToString(), dgChangeData["cAfter", 4].Value.ToString());
            sb.Append(R5 + "\r\n");

            tboxAfter.Text = sb.ToString();
            */
            // 4.
            StringBuilder sb = new StringBuilder();
            string[] strList = tboxBefore.Text.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

            for (int iListRow = 0; iListRow < strList.Length; iListRow++)
            {
                sb.Append(fReplaceResult(strList[0], 0));
            }

            tboxAfter.Text = sb.ToString();
        }

        private string fReplaceResult(string strBeforeText, int idgRow)
        {
            string strAfterText = string.Empty;

            strAfterText = strBeforeText.Replace(dgChangeData["cBefore", idgRow].Value.ToString(), dgChangeData["cAfter", idgRow].Value.ToString() + "\r\n");

            return strAfterText;
        }

    }
}
