using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class OutStarsTriangle
    {
        public void OutStars()
        {
            int maxlent = 13;
            int x = 1;
            int y = 1;
            int n = (maxlent / 2) + 1;
            for (y = 0; y < n; y++)
            {
                int min = n - y;
                int max = n + y;
                for (x = 1; x <= maxlent; x++)
                {

                     if (min < x && max > x && y < n - 1)
                            Console.Write(" ");
                        else
                            Console.Write("*");
                   
                        Console.Write(" ");
                }
                Console.WriteLine();
            }


        }
    }
}
