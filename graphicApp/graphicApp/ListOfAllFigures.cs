using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace graphicApp
{
    public class ListOfAllFigures
    {

        private List<Figure> list = new List<Figure>(); 

        public void Add(Figure item)
        {
            list.Add(item);
        }

        public void DrawfromList(Color paintcolor, Graphics g)
        {
            for (int i = 0; i < list.Count; i++)
            {
                list[i].Draw(paintcolor, g);
            }
        }
        public void DrawfromList1(List<Color> paintcolor, Graphics g)
        {
            for (int i = 0; i < list.Count; i++)
            {
                list[i].Draw(paintcolor[i], g);
            }
        }
    }
}
