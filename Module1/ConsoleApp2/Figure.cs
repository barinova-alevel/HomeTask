using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2

{
    class Figure
    {
        public void FigureSquare()
        {
            int n = 0;
            while (n < 4)
            {
                Console.WriteLine("****");
                n++;
            }
            Console.WriteLine();
        }
        public void FigureTriangle()
        {
            int x = 1;
            int y = 1;
            int max = 4;
            do
            {
                do
                {
                    Console.Write("*");
                    x++;
                }
                while (x <= y);
                Console.WriteLine();
                y++;
                x = 1;
            }
            while (y <= max);
            Console.WriteLine();
        }

        public void FigureRectangle()
        {
            int edge = 3;
            for (int i = 0; i < edge;)
            {
                //int j = 0;
                for (int j = 0; j <= edge;)
                {
                    Console.Write("*");
                    j++;
                }
                Console.WriteLine();
                i++;
            }
            Console.WriteLine();
        }
        public void SpaceTriangle()
        {
            int maxlen = 13;
            int x = 1;
            int y = 1;
            int n = (maxlen / 2) + 1;
            for (y = 0; y < n; y++)
            {
                for (x = 1; x <= maxlen; x++)
                {
                    int min = n - y;
                    int max = n + y;
                    if (min <= x && max >= x)
                    {
                        Console.Write("*");
                    }
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
        public void InSpaceTriangle()
        {
            int maxlen = 13;
            int x = 1;
            int y = 1;
            int n = (maxlen / 2) + 1;
            for (y = 0; y < n; y++)
            {
                int min = n - y;
                int max = n + y;
                for (x = 1; x <= maxlen; x++)
                {

                    if (min <= x && max >= x)
                    {
                        if (min < x && max > x && y < n - 1)
                            Console.Write(" ");
                        else
                            Console.Write("*");
                    }
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
              

         }
     }
}
