using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lab1_oop;

namespace lab1_oop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int[,] coords = new int[4,2];
        public int numOfClick, finalClick;
        DrawManager drawManager = new DrawManager();
      
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
            if (radioButton1.Checked == true)
            {
                Line shape = new Line(e, coords[0, 0], coords[0, 1], coords[1, 0], coords[1, 1]);
                drawManager.Draw(shape, e);
            }
            if (radioButton2.Checked == true)
            {
                Rectangle_class shape = new Rectangle_class(e, coords[0, 0], coords[0, 1], coords[1, 0], coords[1, 1]);
                drawManager.Draw(shape, e);
            }
            if (radioButton3.Checked == true)
            {
                Triangle shape = new Triangle(e, coords[0, 0], coords[0, 1], coords[1, 0], coords[1, 1], coords[2, 0], coords[2, 1]);
                drawManager.Draw(shape, e);
            }
            if (radioButton4.Checked == true)
            {
                Quadrilateral shape = new Quadrilateral(e, coords[0, 0], coords[0, 1], coords[1, 0], coords[1, 1], coords[2, 0], coords[2, 1], coords[3, 0], coords[3, 1]);
                drawManager.Draw(shape, e);
            }
            if (radioButton5.Checked == true)
            {
                Circle shape = new Circle(e, coords[0, 0], coords[0, 1], Math.Abs(coords[1, 0] - coords[0, 0]));
                drawManager.Draw(shape, e);
            }
            if (radioButton6.Checked == true)
            {
                Ellipse shape = new Ellipse(e, coords[0, 0], coords[0, 1], Math.Abs(coords[1, 0] - coords[0, 0]), Math.Abs(coords[2, 0] - coords[0, 0]));
                drawManager.Draw(shape, e);
            }
           
        }
        private void refreshCoords()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    coords[i,j] = 0;
                }
            }
            numOfClick = 0;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            refreshCoords();
            finalClick = 2;
        }    

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            refreshCoords();
            finalClick = 2;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            refreshCoords();
            finalClick = 3;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            refreshCoords();
            finalClick = 4;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            refreshCoords();
            finalClick = 2;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            refreshCoords();
            finalClick = 3;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (numOfClick < finalClick)
            {
              coords[numOfClick,0] = e.X;
              coords[numOfClick,1] = e.Y;
              numOfClick++;
            }
            if (numOfClick == finalClick)
            {
                Form1_Paint(this, new PaintEventArgs(this.CreateGraphics(), this.Bounds));

                refreshCoords();
            }

            
        }

        
        


    }
}
