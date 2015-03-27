using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace lab1_oop
{
    class Ellipse : Circle
    {
        public int eccentricity2;

        public Ellipse(PaintEventArgs e,int point1_x, int point1_y, int eccentricity1,int eccentr2)
            : base (e, point1_x,point1_y,eccentricity1)
        {
            eccentricity2 = eccentr2;
        }


    }
}
