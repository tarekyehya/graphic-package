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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        void lineDDA(int x1, int y1, int x2, int y2)
        {
            var g = line1.CreateGraphics();
            int dx = x2 - x1, dy = y2 - y1, steps, k;
            float xIncrement, yIncrement, x = x1, y = y1;
            if (Math.Abs(dx) > Math.Abs(dy))
                steps = Math.Abs(dx);
            else
                steps = Math.Abs(dy);
            xIncrement = (float)dx / (float)steps;
            yIncrement = (float)dy / (float)steps;

            var a = Brushes.Red;

            for (k = 0; k < steps; k++)
            {
                x += xIncrement;
                y += yIncrement;
                g.FillRectangle(a, x, y, 2, 2);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = int.Parse(x1.Text); ;
            int y = int.Parse(y1.Text); ;
            int m = int.Parse(x2.Text); ;
            int p = int.Parse(y2.Text); ;
            lineDDA(x, y, m, p);
        }
    }
}
