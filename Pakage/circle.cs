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
    public partial class circle : Form
    {
        public circle()
        {
            InitializeComponent();
        }


        void circelplotpoints(int xCenter, int yCenter, int x, int y)

        {
            var abrush = Brushes.Black;
            var g = circle1.CreateGraphics();
            g.FillRectangle(abrush, xCenter + x, yCenter + y, 2, 2);
            g.FillRectangle(abrush, xCenter - x, yCenter + y, 2, 2);
            g.FillRectangle(abrush, xCenter + x, yCenter - y, 2, 2);
            g.FillRectangle(abrush, xCenter - x, yCenter - y, 2, 2);
            g.FillRectangle(abrush, xCenter + y, yCenter + x, 2, 2);
            g.FillRectangle(abrush, xCenter - y, yCenter + x, 2, 2);
            g.FillRectangle(abrush, xCenter + y, yCenter - x, 2, 2);
            g.FillRectangle(abrush, xCenter - y, yCenter - x, 2, 2);
        }


        public void Circelmidpoint(int xCenter, int yCenter, int radius)
        {
            int x = 0;
            int y = radius;
            int p = 1 - radius;


            circelplotpoints(xCenter, yCenter, x, y);

            while (x < y)
            {
                x++;
                if (p < 0)
                    p += 2 * x + 1;
                else
                {
                    y--;
                    p += 2 * (x - y) + 1;
                }
                circelplotpoints(xCenter, yCenter, x, y);

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Draw_Click(object sender, EventArgs e)
        {
            int x = int.Parse(x1.Text); ;
            int y = int.Parse(y1.Text); ;
            int r = int.Parse(radius.Text); ;
            Circelmidpoint(x, y, r);
        }
    }
}
