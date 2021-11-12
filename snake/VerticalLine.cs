using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    internal class VerticalLine
    {

        List<Point> pList;

        public VerticalLine(int x, int yTop, int yBottom, char sym)
        {
            pList = new List<Point>();
            for (int j = yTop; j <= yBottom; j++)
            {
                Point pnt = new Point(x, j, sym);
                pList.Add(pnt);
            }
        }

        public void Drew()
        {
            foreach(Point p in pList)
            {
                p.Draw();
            }
        }

    }
}
