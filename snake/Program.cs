using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);

            //Drawing frame
            HorizontalLine Topline = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine Bottomline = new HorizontalLine(0, 78, 24, '+');
            VerticalLine LeftLine = new VerticalLine(0, 24, 0, '+'); 
            VerticalLine RightLine = new VerticalLine(0, 24, 78, '+');

            Topline.Drow();
            Bottomline.Drow();
            LeftLine.Drow();    
            RightLine.Drow();

            Point p = new Point(3, 3, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Drow();

            Console.ReadLine();
        }
    }
}
