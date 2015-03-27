using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace lab1_oop
{
    class DrawManager
    {
        public void Draw(Line line, PaintEventArgs e)
        {    
            line.g.DrawLine(line.pen, line.x1, line.y1, line.x2,line.y2);   
        }
        public void Draw(Triangle temp, PaintEventArgs e)
        {
            temp.g.DrawLine(temp.pen, temp.x1, temp.y1, temp.x2, temp.y2);
            temp.g.DrawLine(temp.pen, temp.x1, temp.y1, temp.x3, temp.y3);
            temp.g.DrawLine(temp.pen, temp.x3, temp.y3, temp.x2, temp.y2);
        }
        public void Draw(Rectangle_class temp, PaintEventArgs e)
        {
            Rectangle rect = new Rectangle();
            rect.X = temp.x1;
            rect.Y = temp.y1;
            rect.Width = temp.x2 - temp.x1;
            rect.Height = temp.y2 - temp.y1;
            temp.g.DrawRectangle(temp.pen, rect);
        }
        public void Draw(Circle temp, PaintEventArgs e)
        {
            Rectangle rect = new Rectangle();
            rect.X = temp.x1;
            rect.Y = temp.y1;
            rect.Width = 2 * temp.eccentricity1;
            rect.Height = 2 * temp.eccentricity1;
            temp.g.DrawEllipse(temp.pen, rect);
        }
        public void Draw(Ellipse temp, PaintEventArgs e)
        {
            Rectangle rect = new Rectangle();
            rect.X = temp.x1;
            rect.Y = temp.y1;
            rect.Width = 2 * temp.eccentricity1;
            rect.Height = 2 * temp.eccentricity2;
            temp.g.DrawEllipse(temp.pen, rect);
        }
        public void Draw(Quadrilateral temp, PaintEventArgs e)
        {
            temp.g.DrawLine(temp.pen, temp.x1, temp.y1, temp.x2, temp.y2);
            temp.g.DrawLine(temp.pen, temp.x2, temp.y2, temp.x3, temp.y3);
            temp.g.DrawLine(temp.pen, temp.x3, temp.y3, temp.x4, temp.y4);
            temp.g.DrawLine(temp.pen, temp.x1, temp.y1, temp.x4, temp.y4);
        }
    }
}
