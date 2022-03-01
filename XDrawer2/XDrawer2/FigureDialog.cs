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
        String selectedText;
        Color selectedColor;
        static String[] figureTypes = {"Box", "Circle", "Point", "Line", "Kite", "TV", "TV2", "TV3", "Speaker", "TVSet"};

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
            selectedText = figureTypes[selectBox.SelectedIndex];

            redButton.ForeColor = Color.Red;
            greenButton.ForeColor = Color.Green;
            blueButton.ForeColor = Color.Blue;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (textX1.Text.Length == 0) return;
            if (textY1.Text.Length == 0) return;
            if (textX2.Text.Length == 0) return;
            if (textY2.Text.Length == 0) return;

            int x1 = int.Parse(textX1.Text);
            int y1 = int.Parse(textY1.Text);
            int x2 = int.Parse(textX2.Text);
            int y2 = int.Parse(textY2.Text);

            Figure newFigure = null;

            MessageBox.Show(selectedText);
            if (selectedText.Equals("Box"))
            {
                newFigure = new Box(x1, y1, x2, y2);
                newFigure.setPopup(mainForm.getBoxPopup());
            }
            else if (selectedText.Equals("Circle"))
            {
                newFigure = new Circle(x1, y1, x2, y2);
                newFigure.setPopup(mainForm.getCirclePopup());
            }
            else if (selectedText.Equals("Point"))
            {
                newFigure = new Point(x1, y1);
                newFigure.setPopup(mainForm.getPointPopup());
            }
            else if (selectedText.Equals("Line"))
            {
                newFigure = new Line(x1, y1,x2,y2);
                newFigure.setPopup(mainForm.getLinePopup());
            }

            else if (selectedText.Equals("Kite"))
            {
                newFigure = new Kite(x1, y1, x2, y2);
                newFigure.setPopup(mainForm.getKitePopup());
            }

            else if (selectedText.Equals("TV"))
            {
                newFigure = new TV(x1, y1);
                newFigure.setPopup(mainForm.getTVPopup());
            }

            else if (selectedText.Equals("TV2"))
            {
                newFigure = new TV2(x1, y1);
                newFigure.setPopup(mainForm.getTV2Popup());
            }

            else if (selectedText.Equals("TV3"))
            {
                newFigure = new TV3(x1, y1);
                newFigure.setPopup(mainForm.getTV3Popup());
            }

            else if (selectedText.Equals("Speaker"))
            {
                newFigure = new Speaker(x1, y1);
                newFigure.setPopup(mainForm.getSpeakerPopup());
            }

            else if (selectedText.Equals("TVSet"))
            {
                newFigure = new TVSet(x1, y1);
                newFigure.setPopup(mainForm.getTVSetPopup());
            }

            newFigure.setColor(selectedColor);
            newFigure.makeRegion();
            mainForm.Figures.AddLast(newFigure);
            mainForm.Canvas.Invalidate();
        }

        private void selectBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedText = figureTypes[selectBox.SelectedIndex];
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void blackButton_Click(object sender, EventArgs e)
        {
            selectedColor = Color.Black;
        }

        private void redButton_CheckedChanged(object sender, EventArgs e)
        {
            selectedColor = Color.Red;
        }

        private void greenButton_CheckedChanged(object sender, EventArgs e)
        {
            selectedColor = Color.Green;
        }

        private void blueButton_CheckedChanged(object sender, EventArgs e)
        {
            selectedColor = Color.Blue;
        }

        private void selectColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                selectedColor = dialog.Color;
                
            }
        }

    }
}
