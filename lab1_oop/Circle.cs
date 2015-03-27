using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace lab1_oop
{
    class Circle : Shape
    {
        public int eccentricity1, x1, y1;

        public Circle(PaintEventArgs e, int point1_x, int point1_y, int radius)
            :base(e)
        {
            eccentricity1 = radius;
            x1 = point1_x;
            y1 = point1_y;
        }


    }
}
