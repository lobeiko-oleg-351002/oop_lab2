using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace lab1_oop
{
    class Line : Shape
    {
        public int x1,y1,x2,y2;

        public Line(PaintEventArgs e,int point1_x, int point1_y, int point2_x, int point2_y)
            : base (e)
        {
            this.x1 = point1_x;
            this.y1 = point1_y;
            this.x2 = point2_x;          
            this.y2 = point2_y;
        }

    }
}
