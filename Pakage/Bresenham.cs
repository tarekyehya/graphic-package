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
    public partial class Bresenham : Form
    {
        public Bresenham()
        {
            InitializeComponent();
        }

        void lineBres(int x0, int y0, int xEnd, int yEnd)
        {
            var g = line2.CreateGraphics();
            var b = Brushes.Black;
            int dx = Math.Abs(xEnd - x0), dy = Math.Abs(yEnd - y0);
            int x, y, p = 2 * dy - dx;
            int twoDy = 2 * dy, twoDyMinusDx = 2 * (dy - dx);

            /* Determine which endpoint to use as start position.  */
            if (x0 > xEnd)
            {
                x = xEnd; y = yEnd; xEnd = x0;
            }
            else
            {
                x = x0; y = y0;
            }
            g.FillRectangle(b, x, y, 2, 2);

            while (x < xEnd)
            {
                x++;
                if (p < 0)
                    p += twoDy;
                else
                {
                    y++;
                    p += twoDyMinusDx;
                }
                g.FillRectangle(b, x, y, 2, 2);
            }
        }


        private void Draw_Click(object sender, EventArgs e)
        {

            int x = int.Parse(x1.Text); ;
            int y = int.Parse(y1.Text); ;
            int m = int.Parse(x2.Text); ;
            int p = int.Parse(y2.Text); ;
            lineBres(x, y, m, p);
        }
    }
}
