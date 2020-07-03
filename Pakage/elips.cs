using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pakage
{
    public partial class elips : Form
    {
        public elips()
        {
            InitializeComponent();
        }

        void ellipseMidpoint(int xCenter, int yCenter, int Rx, int Ry)
        {
            int Rx2 = Rx * Rx;
            int Ry2 = Ry * Ry;
            int twoRx2 = 2 * Rx2;
            int twoRy2 = 2 * Ry2;
            double p;
            int x = 0;
            int y = Ry;
            int px = 0;
            int py = twoRx2 * y;
            ellipsePlotPoints(xCenter, yCenter, x, y);
            p = Math.Round(Ry2 - (Rx2 * Ry) + (0.25 * Rx2));
            while (px < py)
            {
                x++;
                px += twoRy2;
                if (p < 0)
                    p += Ry2 + px;
                else
                {
                    y--;
                    py -= twoRx2;
                    p += Ry2 + px - py;
                }
                ellipsePlotPoints(xCenter, yCenter, x, y);
            }
            p = Math.Round(Ry2 * (x + 0.5) * (x + 0.5) + Rx2 * (y - 1) * (y - 1) - Rx2 * Ry2);
            while (y > 0)
            {
                y--;
                py -= twoRx2;
                if (p > 0)
                    p += Rx2 - py;
                else
                {
                    x++;
                    px += twoRy2;
                    p += Rx2 - py + px;
                }
                ellipsePlotPoints(xCenter, yCenter, x, y);
            }
        }

        void ellipsePlotPoints(int xcntr, int ycntr, int x, int y)
        {
            var g = elips1.CreateGraphics();
            var aBrash = Brushes.Red;
            g.FillRectangle(aBrash, xcntr + x, ycntr + y, 2, 2);
            g.FillRectangle(aBrash, xcntr - x, ycntr + y, 2, 2);
            g.FillRectangle(aBrash, xcntr + x, ycntr - y, 2, 2);
            g.FillRectangle(aBrash, xcntr - x, ycntr - y, 2, 2);


        }

        private void Draw_Click(object sender, EventArgs e)
        {
            int x = int.Parse(xCenter.Text);
            int y = int.Parse(yCenter.Text);
            int r1 = int.Parse(radius1.Text);
            int r2 = int.Parse(radius2.Text);
            ellipseMidpoint(x, y, r1, r2);
        }
    }
}
