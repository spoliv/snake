using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLine
    {
        List<Point> pvList;

        public VerticalLine(int x, int yUp, int yDown, char sym)
        {
            pvList = new List<Point>();
            for (int y = yUp; y <= yDown; y++)
            {
                Point pv = new Point(x, y, sym);
                pvList.Add(pv);
            }
        }

        public void Drow()
        {
            foreach (Point pv in pvList)
            {
                pv.Draw();
            }
        }
    }
}
