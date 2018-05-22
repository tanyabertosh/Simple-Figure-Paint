using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace graphicApp
{
    public abstract class Figure
    {
        public Point startPoint { get; protected set; }
        public Point FinalPoint { get; protected set; }

        public Figure(Point first, Point last)
        {
            startPoint = first;
            FinalPoint = last;
        }

        public Figure()
        {
           
        }

        public virtual void SetCoordinates(Point first, Point last)
        {
            startPoint = first;
            FinalPoint = last;
            
        }

        public abstract void Draw(Color paintcolor, Graphics g);

    }
}
