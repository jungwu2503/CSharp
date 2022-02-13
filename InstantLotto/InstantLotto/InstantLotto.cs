using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace InstantLotto
{
    public partial class InstantLotto : Form
    {
        Bitmap backImage;
        bool dragging;
        Bitmap canvasShot;

        public InstantLotto()
        {
            InitializeComponent();
            dragging = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            backImage = new Bitmap("instantLotto.gif");
            //canvas.Image = backImage;
            SetBounds(0, 0, backImage.Width+10, backImage.Height+30);
        }

        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging == false) return;

            Graphics g = canvas.CreateGraphics();

            g.CompositingMode = CompositingMode.SourceOver;
            TextureBrush brush = new TextureBrush(backImage);

            g.FillEllipse(brush, e.X, e.Y, 20, 20);

            brush.Dispose();
            g.Dispose();
        }

        private void canvas_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
        }

        [System.Runtime.InteropServices.DllImportAttribute("gdi32.dll")]
        private static extern bool BitBlt(
            IntPtr a, int b, int c, int d, int e, IntPtr f, int g, int h, System.Int32 i);

        private void canvas_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;

            Rectangle r = canvas.ClientRectangle;
            canvasShot = new Bitmap(r.Width, r.Height);

            Graphics g1 = canvas.CreateGraphics();
            Graphics g2 = Graphics.FromImage(canvasShot);

            IntPtr dc1 = g1.GetHdc();
            IntPtr dc2 = g2.GetHdc();

            BitBlt(dc2, 0, 0, r.Width, r.Height, dc1, 0, 0, 0x00CC0020);

            g1.ReleaseHdc(dc1);
            g2.ReleaseHdc(dc2);
            g1.Dispose();
            g2.Dispose();
        }

        private void canvas_Paint(object sender, PaintEventArgs e)
        {            
            if (canvasShot == null) return;
            e.Graphics.DrawImage(canvasShot, 0, 0);
            //canvas.Image = canvasShot;
        }

        private void canvas_Click(object sender, EventArgs e)
        {
            Graphics g = canvas.CreateGraphics();
            Pen pen = new Pen(Color.Black);
            g.DrawLine(pen, backImage.Width / 2 - 7, 0, backImage.Width / 2 - 7, backImage.Height);
            g.DrawLine(pen, 0, backImage.Height/4 - 7, backImage.Width, backImage.Height/4 - 7);
            g.DrawLine(pen, 0, backImage.Height / 2 - 12, backImage.Width, backImage.Height / 2 - 12);
            g.DrawLine(pen, 0, backImage.Height / 4 * 3 - 5, backImage.Width, backImage.Height / 4 * 3 - 5);
            
            pen.Dispose();
            g.Dispose();
        }

    }
}
