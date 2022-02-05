using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstForm
{
    public partial class Frame : Form
    {
        public Frame()
        {
            InitializeComponent();
        }

        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            g.DrawRectangle(new Pen(Color.Black), 100, 100, 500, 500);
        }

        private void 열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListForm form = new ListForm();

            form.Show();
        }

        private void modalMenuItem_Click(object sender, EventArgs e)
        {
            ModalForm form = new ModalForm();

            form.Show();
        }

        private void modealessMenuItem_Click(object sender, EventArgs e)
        {
            ModalForm form = new ModalForm();

            form.Show();
        }
    }
}
