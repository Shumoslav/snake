using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    internal class HorizontalLine
    {

        List<Point> pList;

        public HorizontalLine(int xLeft, int xRight, int y, char sym)
        {
            pList = new List<Point>();
            for (int i = xLeft; i <= xRight; i++)
            {
                Point pnt = new Point(i, y, sym);
                pList.Add(pnt);
            }

        }

        public void Drow()
        {
            foreach(Point p in pList)
            {
                p.Draw();
            }   
        }


    }
}
