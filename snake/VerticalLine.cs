﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    internal class VerticalLine : Figure
    {
        public VerticalLine(int yTop, int yBottom, int x, char sym)
        {
            pList = new List<Point>();
            for (int j = yTop; j <= yBottom; j++)
            {
                Point pnt = new Point(x, j, sym);
                pList.Add(pnt);
            }
        }
    }
}
