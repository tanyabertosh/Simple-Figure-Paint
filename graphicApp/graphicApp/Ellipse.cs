using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace graphicApp
{
    public class Ellipse : Figure
    {
        public Ellipse(Point first, Point last) : base(first,last)
        {
        }

        public Ellipse()
        {
        }

        public override void Draw(Color paintcolor, Graphics g)
        {

            g.FillEllipse(new SolidBrush(paintcolor), Math.Min(startPoint.X, FinalPoint.X), Math.Min(startPoint.Y, FinalPoint.Y), Math.Abs(startPoint.X - FinalPoint.X), Math.Abs(startPoint.Y - FinalPoint.Y));

        }
    }
}
