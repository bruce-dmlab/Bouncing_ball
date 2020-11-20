using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bouncingball
{
    public partial class Form1 : Form
    {
        private int ballposx = 0;
        private int ballposy = 0;
        private int ballwidth = 30;
        private int ballheight = 30;
        private int moveposx = 5;
        private int moveposy = 7;

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.Clear(this.BackColor);
            e.Graphics.FillEllipse(Brushes.Red, ballposx, ballposy, ballwidth, ballheight);
            e.Graphics.DrawEllipse(Pens.Black, ballposx, ballposy, ballwidth, ballheight);

        }

        private void MoveBall(object sender, EventArgs e)
        {
            ballposx = ballposx + moveposx;
            ballposy = ballposy + moveposy;
            if (ballposx < 0)
            {
                ballposx = 0;
                moveposx = -1 * moveposx;
            }

            if (ballposx > this.ClientSize.Width)
            {
                ballposx = this.ClientSize.Width;
                moveposx = -1 * moveposx;
            }

            if (ballposy < 0)
            {
                ballposy = 0;
                moveposy = -1 * moveposy;
            }

            if (ballposy > this.ClientSize.Height)
            {
                ballposy = this.ClientSize.Height;
                moveposy = -1 * moveposy;
            }


            /*if (ballposx < 0 || ballposx > this.ClientSize.Width)
            {
                moveposx = -1 * moveposx;
            }*/

            /*if (ballposy < 0 || ballposy > this.ClientSize.Height)
            {
                moveposy = -1 * moveposy;
            }*/

            this.Refresh();
        }
    }
}
