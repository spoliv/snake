using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            

            HorizontalLine lineg = new HorizontalLine(5, 10, 8, '*');
            lineg.Drow();

            VerticalLine linev = new VerticalLine(10, 9, 15, '#');
            linev.Drow();

            Console.ReadLine();
        }

    }
}
