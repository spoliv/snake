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
            Console.SetBufferSize(80, 25);

            HorizontalLine upLine = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine downLine = new HorizontalLine(0, 78, 24, '+');
            VerticalLine leftLine = new VerticalLine(0, 0, 24, '+');
            VerticalLine rightLine = new VerticalLine(78, 0, 24, '+');
            /*Draw(upLine);
            Draw(downLine);
            Draw(leftLine);
            Draw(rightLine);*/

            //Просто горизонтальная линия

            HorizontalLine h1 = new HorizontalLine(0, 5, 6, '&');

            // Отрисовка точек

            Point p = new Point(4, 5, '*');
            Figura fSnake = new Snake(p, 6, Direction.RIGHT);
            /*Draw(fSnake);*/
            Snake snake = (Snake)fSnake;

            List<Figura> figures = new List<Figura>();
            figures.Add(upLine);
            figures.Add(downLine);
            figures.Add(leftLine);
            figures.Add(rightLine);
            figures.Add(fSnake);
            figures.Add(h1);

            foreach(var f in figures)
            {
                f.Draw();
            }

            FoodCreator foodCreator = new FoodCreator(80, 25, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();

            while (true)
            {
                if(snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }

                else
                {
                    snake.Move();
                }

                System.Threading.Thread.Sleep(300);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }

            }
          
            /*Console.ReadLine();*/
        }

        /*static void Draw(Figura figura)
        {
            figura.Draw();
        }*/
    }
}
