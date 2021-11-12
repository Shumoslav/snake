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

            HorizontalLine Hline = new HorizontalLine(5,8,7,'#');
            Hline.Drow();

            VerticalLine Vline = new VerticalLine(8, 7, 11, '#');
            Vline.Drew();


            Console.ReadLine();
        }
    }
}
