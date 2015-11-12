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
            Point p1 = new Point(1, 3, '*');
            /*p1.x = 1;
            p1.y = 3;
            p1.sym = '*';*/

            p1.Draw(p1.x, p1.y, p1.sym);

            Point p2 = new Point(4, 5, '#');
            /*p2.x = 4;
            p2.y = 5;
            p2.sym = '#';*/

            p2.Draw(p2.x, p2.y, p2.sym);

            Point p3 = new Point(6, 8, '&');
            Point p4 = new Point(9, 10, '@');


            List<char> numList = new List<char>();
            numList.Add('*');
            numList.Add('#');
            numList.Add('&');
            numList.Add('@');

            foreach(char i in numList)
            {
                Console.WriteLine(i);
            }

            List<Point> pList = new List<Point>();
            pList.Add(p1);
            pList.Add(p2);
            pList.Add(p3);
            pList.Add(p4);

            Console.ReadLine();
        }

    }
}
