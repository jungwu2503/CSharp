using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XDrawer2
{
    public partial class FigureDialog : Form
    {
        XDrawer mainForm;
        static String[] figureTypes = {"Point", "Box", "Line", "Circle", "Kite", "TV"};

        public FigureDialog(XDrawer form)
        {
            mainForm = form;
            InitializeComponent();

            textX1.Text = "0";
            textY1.Text = "0";
            textX2.Text = "0";
            textY2.Text = "0";

            for (int i = 0; i < figureTypes.Length; i++)
            {
                selectBox.Items.Add(figureTypes[i]);
            }

            selectBox.SelectedIndex = 1;

            redButton.ForeColor = Color.Red;

        }
    }
}
