using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class HorizontalLine : Figura
    {

        public HorizontalLine(int xLeft, int xRight, int y, char sym)
        {
            pList = new List<Point>();
            for(int x=xLeft; x<= xRight; x++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }

        //Перепишем метод Draw для класса HorizontalLine

        public override void Draw()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            // Вместо этого можем написать base.Draw()

            /*foreach(Point p in pList)
            {
                p.Draw();
            }*/

            base.Draw();

            Console.ForegroundColor = ConsoleColor.White;
        }

    }
}
