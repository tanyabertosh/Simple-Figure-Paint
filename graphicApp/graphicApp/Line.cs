using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace graphicApp
{
    public class Line : Figure
    {
        public Line(Point first, Point last) : base(first, last)
        {
        }

        public Line()
        {
        }

        public override void Draw(Color paintcolor, Graphics g)
        {
            g.DrawLine(new Pen(paintcolor), startPoint, FinalPoint);


        }

    }
}
