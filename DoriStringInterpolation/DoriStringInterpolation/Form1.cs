using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoriStringInterpolation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            string s1 = tbox1Value1.Text;
            string s2 = tbox1Value2.Text;

            string strValue0 = s1 + " is " + s2; // 속도 : strValue0 > strValue1 = strValue2

            // He is a teacher
            string strValue1 = String.Format("{0} is {1}", s1, s2);
            lboxStringFormat.Items.Add(strValue1);

            // 문자열 보간 .. 버전 낮아서 안되는듯 함
            /*string strValue2 = $"{s1} is {s2}";
            lboxStringInterpolation.Items.Add(strValue2);*/
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            DateTime dt = dtPicker.Value;

            lboxStringFormat.Items.Add(string.Format("오늘은 {0:yyyy-MM-dd} 입니다.", dt));
            //lboxStringInterpolation.Items.Add($"오늘은 {dt:yyyy-MM-dd} 입니다.");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            int i1 = (int)num1.Value;
            int i2 = (int)num2.Value;

            int iBigCount = (i1 > i2) ? i1 : i2;

            lboxStringFormat.Items.Add(string.Format("{0}, {1} 중 큰 수는 {2} 이다.", i1, i2, iBigCount));
            //lboxStringInterpolation.Items.Add($"{i1}, {i2} 중 큰 수는 {((i1 > i2) ? i1 : i2)} 이다.");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            string strValue = "Value";

            lboxStringFormat.Items.Add(string.Format("{{{0}}}", strValue));
            //lboxStringInterpolation.Items.Add($"{{{strValue}}}");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            string strValue = tbox5Value.Text.ToUpper();

            lboxStringFormat.Items.Add(string.Format("대문자 변환 : {0}", strValue));
            //lboxStringInterpolation.Items.Add($"대문자 변환 : {strValue.ToUpper()}");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            string strValue1 = "S1) C:\\Users\\jungw\\Documents\\Visual Studio 2012\\Projects\\DoriStringInterpolation \r\n Test";

            string strValue2 = @"S2) C:\Users\jungw\Documents\Visual Studio 2012\Projects\DoriStringInterpolation 
Test";
            // @ = escape sequence를 무시하겠다!

            tbox6Value.Text = strValue1 + "\r\n \r\n" + strValue2;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            string strR1 = "Test1";
            string strR2 = "Test2";

            /* 이렇게 No
            string strQuery = "Select " + 
                              "ROW_1, " +
                              "ROW_2, " +
            */ 

           /* string strQuery = $@"Select 
                                    Row_1,
                                    Row_2
                                 From
                                    TB_Table
                                 Where
                                    Row_1 = {strR1}
                                    AND Row_2 = {strR2}"; 

            tbox7Value.Text = strQuery;*/

        }
    }
}
