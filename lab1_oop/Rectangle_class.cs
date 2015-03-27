using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace lab1_oop
{
    class Rectangle_class : Line
    {
        public Rectangle_class(PaintEventArgs e, int point1_x, int point1_y, int point2_x, int point2_y)
            : base (e, point1_x, point1_y, point2_x, point2_y)
        {
        }

    }
}
