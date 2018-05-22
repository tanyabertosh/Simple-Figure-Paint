using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace graphicApp
{
    public class Square : Rectangle
    {
        public Square(Point first, Point last) : base(first, last)
        {
        }

        public Square()
        {
        }

        public override void Draw(Color paintcolor, Graphics g)
        {

            //(new SolidBrush(paintcolor), Math.Min(startPoint.X, FinalPoint.X), Math.Min(startPoint.Y, FinalPoint.Y), Math.Min(Math.Abs(FinalPoint.Y - startPoint.Y),FinalPoint.Y), Math.Min(Math.Abs(FinalPoint.Y - startPoint.Y), FinalPoint.Y));
            g.FillRectangle(new SolidBrush(paintcolor), Math.Min(startPoint.X, FinalPoint.X), Math.Min(startPoint.Y, FinalPoint.Y), Math.Abs(startPoint.Y-FinalPoint.Y), Math.Abs(startPoint.Y - FinalPoint.Y));

        }
    }
}
