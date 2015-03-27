using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace lab1_oop
{
    class Quadrilateral : Triangle
    {
        public int x4,y4;
        public Quadrilateral(PaintEventArgs e, int point1_x, int point1_y, int point2_x, int point2_y, int point3_x, int point3_y, int point4_x, int point4_y)
            : base(e, point1_x, point1_y, point2_x, point2_y, point3_x, point3_y)
        {
            x4 = point4_x;
            y4 = point4_y;
        }


    }
}
