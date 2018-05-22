using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace graphicApp
{
    public class Circle : Ellipse
    {
        public Circle(Point first, Point last) : base(first, last)
        {
        }

        public Circle()
        {
        }

        public override void Draw(Color paintcolor, Graphics g)
        {

            g.FillEllipse(new SolidBrush(paintcolor), Math.Min(startPoint.X, FinalPoint.X), Math.Min(startPoint.Y, FinalPoint.Y), Math.Abs(FinalPoint.Y - startPoint.Y), Math.Abs(FinalPoint.Y - startPoint.Y));

        }
    }
}
