using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoriRecursionFunction
{
    public partial class Form1 : Form
    {
        enum enControlType {
            Unknown,
            Label,
            Textbox,
            Button,
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnExe_Click(object sender, EventArgs e)
        {
            // Control Level, Control Type, Control Text
            int iLevel = (int)numLevel.Value;

            enControlType eControlType = enControlType.Unknown;
            if (rdoLabel.Checked) eControlType = enControlType.Label;
            else if (rdoTextBox.Checked) eControlType = enControlType.Textbox;
            else if (rdoButton.Checked) eControlType = enControlType.Button;

            string strChangeText = tboxChangeText.Text;

            ControlSearch(gboxCheckList, iLevel, eControlType, strChangeText);
        }

        private void ControlSearch(GroupBox checkList, int iLevel, enControlType eType, string strChangeText)
        {
            foreach (var item in checkList.Controls)
            {
                if (checkList.Text.Equals("Level " + iLevel))
                {
                    switch (eType)
                    {
                        case enControlType.Label:
                            if (item is Label) {
                                ((Label)item).Text = strChangeText;
                                lboxResult.Items.Add(string.Format("현재 GroupBox : {0}, Label Text : {1}로 변경", checkList.Text, strChangeText));
                            }
                            break;
                        case enControlType.Textbox:
                            if (item is TextBox) {
                                ((TextBox)item).Text = strChangeText;
                                lboxResult.Items.Add(string.Format("현재 GroupBox : {0}, Textbox Text : {1}로 변경", checkList.Text, strChangeText));
                            }
                            break;
                        case enControlType.Button:
                            if (item is Button) {
                                ((Button)item).Text = strChangeText;
                                lboxResult.Items.Add(string.Format("현재 GroupBox : {0}, Button Text : {1}로 변경", checkList.Text, strChangeText));
                            }
                            break;
                    }
                }

                if (item is GroupBox)
                {
                    lboxResult.Items.Add(string.Format("현재 GroupBox : {0}, 다음 GroupBox : {1}로 이동", checkList.Text, ((GroupBox)item).Text));
                    ControlSearch((GroupBox)item, iLevel, eType, strChangeText);
                }
            }

            if (checkList == gboxCheckList) {
                lboxResult.Items.Add("END");
            }

        }

    }
}
