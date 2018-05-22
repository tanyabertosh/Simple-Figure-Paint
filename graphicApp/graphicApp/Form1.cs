using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace graphicApp
{
    public partial class Form1 : Form
    {
        Color paintcolor;
        bool choose = false;
        bool draw = false;
        bool workingOnImage = false;
        Point FirstPoint, LastPoint;
        Figure figure;
        ListOfAllFigures list1 = new ListOfAllFigures();
        List<Color> color = new List<Color>();

        public Form1()
        {
            InitializeComponent();
            drawingField.Cursor = Cursors.Cross;
           

        }

        private void buttonClear_Click_1(object sender, EventArgs e)
        {
            Graphics g = drawingField.CreateGraphics();
            g.Clear(drawingField.BackColor);
        }

        private void drawingField_Paint(object sender, PaintEventArgs e)
        {
            
            if (workingOnImage)
            {
                
                try
                {
                    figure.SetCoordinates(FirstPoint, LastPoint);
                    figure.Draw(paintcolor, e.Graphics);
                }
                catch (Exception exp) { }
                list1.Add(figure);
                color.Add(paintcolor);
                list1.DrawfromList1(color, e.Graphics);
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            choose = false;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (choose)
            {
                Bitmap bmp = (Bitmap)pictureBox1.Image.Clone();
                paintcolor = bmp.GetPixel(e.X, e.Y);


                pictureBox2.BackColor = paintcolor;
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            choose = true;
        }

        private void drawingField_MouseMove(object sender, MouseEventArgs e)
        {
            if (draw)
            {
                LastPoint.X = e.X;
                LastPoint.Y = e.Y;
                
                drawingField.Invalidate();
            }
        }

        private void drawingField_MouseUp(object sender, MouseEventArgs e)
        {
            draw = false; 

        }

        private void drawingField_MouseDown(object sender, MouseEventArgs e)
        {
            draw = true;
            FirstPoint.X = e.X;
            FirstPoint.Y = e.Y;
            if (workingOnImage == false)
            {
                workingOnImage = true;
            }
        }

        private void buttonAllFigures_Click(object sender, EventArgs e)
        {
            Graphics g = drawingField.CreateGraphics();
            g.Clear(Color.White);
            ListOfAllFigures list = new ListOfAllFigures();
            Line line = new Line();
            line.SetCoordinates(new Point(10, 70), new Point(100, 100));
            Rectangle rectangle = new Rectangle();
            rectangle.SetCoordinates(new Point(10, 110), new Point(120, 150));
            Ellipse ellipse = new Ellipse();
            ellipse.SetCoordinates(new Point(10, 10), new Point(100, 50));
            Square square = new Square();
            square.SetCoordinates(new Point(10, 210), new Point(40, 250));
            Circle circle = new Circle();
            circle.SetCoordinates(new Point(10, 150), new Point(50, 200));

            list.Add(ellipse);
            list.Add(line);
            list.Add(rectangle);
            list.Add(circle);
            list.Add(square);

            list.DrawfromList(paintcolor, g);
        }

        private void buttonLine_Click(object sender, EventArgs e)
        {
            figure = new Line();   
        }

        private void buttonRectangle_Click(object sender, EventArgs e)
        {
            figure = new Rectangle();  
        }

        private void buttonCircle_Click(object sender, EventArgs e)
        {
            figure = new Circle();   
        }

        private void buttonSquare_Click(object sender, EventArgs e)
        {
            figure = new Square();  
        }

        private void buttonEllipse_Click(object sender, EventArgs e)
        {
            figure = new Ellipse();
        }

    }
}
