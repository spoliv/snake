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
            int x1 = 1;
            int y1 = 3;
            char sim1 = '*';

            Console.SetCursorPosition(x1, y1);
            Console.Write(sim1);

            int x2 = 4;
            int y2 = 5;
            char sim2 = '#';

            Console.SetCursorPosition(x2, y2);
            Console.Write(sim2);

            Console.ReadLine();
        }

    }
}
