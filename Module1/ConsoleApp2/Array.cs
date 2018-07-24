using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Array
    {
        public void ArrayOutput()
        {
            const int x = 5;
            const int y = 5;

            int[,] arrayOut
                = new int[x, y] {
                    { 1, 2, 3, 4, 5 },
                    { 6, 7, 8, 9, 10 },
                    { 11, 12, 13, 14, 15 },
                    { 0, 1, 2, 3, 4 },
                    { 10, 11, 12, 13, 14 }
                };
            for (int i = 0; i < x; i++)
            {
                System.Console.Write("({0}):", i);
                for (int j = 0; j < y; j++)
                {
                    System.Console.Write(arrayOut[i, j]);
                    System.Console.Write(" ");
                }

                System.Console.WriteLine();
            }

        }
        public void RowNumber()
        {
            const int x = 5;
            const int y = 5;


            int[,] arrayOut
                = new int[x, y] {
                    { 1, 2, 3, 4, 5 },
                    { 6, 7, 8, 9, 10 },
                    { 11, 12, 13, 14, 15 },
                    { 0, 1, 2, 3, 4 },
                    { 10, 11, 12, 13, 14 }
                };
            int allcount = arrayOut.Length;
            int maxRowSum = 0;
            int rowIndex = 0;

            for (int i = 0; i < x; i++)
            {
                int rowSum = 0;

                for (int j = 0; j < y; j++)
                {
                    rowSum += arrayOut[i, j];
                }

                if (maxRowSum < rowSum)
                {
                    maxRowSum = rowSum;
                    rowIndex = i;
                }
            }
            System.Console.WriteLine("Max Row index {0} with max sum in row {1}", rowIndex, maxRowSum);
        }

        public void CoulmnNumber()
        {
            const int x = 5;
            const int y = 5;


            int[,] arrayOut
                = new int[x, y] {
                    { 1, 2, 3, 4, 5 },
                    { 6, 7, 8, 9, 10 },
                    { 11, 12, 13, 14, 15 },
                    { 0, 1, 2, 3, 4 },
                    { 10, 11, 12, 13, 14 }
                };
            int allcount = arrayOut.Length;
            int maxColumnSum = 0;
            int columnIndex = 0;

            for (int j = 0; j < y; j++)
            {
                int columnSum = 0;

                for (int i = 0; i < x; i++)
                {
                    columnSum += arrayOut[i, j];
                }

                if (maxColumnSum < columnSum)
                {
                    maxColumnSum = columnSum;
                    columnIndex = j;
                }
            }
            System.Console.WriteLine("Max column index {0} with max sum in column {1}", columnIndex, maxColumnSum);
        }

        /*public void CoulmnNumberDouble()
        {
            const int x = 5;
            const int y = 5;


            int[,] arrayOut
                = new int[x, y] {
                    { 1, 2, 3, 4, 5 },
                    { 6, 7, 8, 9, 10 },
                    { 11, 12, 13, 14, 15 },
                    { 20, 1, 2, 3, 4 },
                    { 10, 11, 12, 13, 14 }
                };
            int allcount = arrayOut.Length;

            int maxColumnSum = 0;
            List<int> indexes = new List<int>();

            for (int j = 0; j < y; j++)
            {
                int columnSum = 0;

                for (int i = 0; i < x; i++)
                {
                    columnSum += arrayOut[i, j];
                }

                if (maxColumnSum < columnSum)
                {
                    maxColumnSum = columnSum;
                }
                else
                {
                    indexes.Add(j);
                }
            }
            System.Console.WriteLine("Max column index {0} with max sum in column {1}", columnIndex, maxColumnSum);
        }*/


        public void SortArray()
        {
            int n;
            Console.WriteLine("Dlina massiva=");
            n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("A[{0}]=", i);
                string value = Console.ReadLine();
                a[i] = int.Parse(value);
            }

            for (int i = 0; i < n; i++)
                Console.Write("{0}; ", a[i]);
            Console.WriteLine();


            for (int k = n - 1; k > 0; k--)
                for (int i = 0; i < k; i++)
                    if (a[i] > a[i + 1])
                    {
                        int buf = a[i];
                        a[i] = a[i + 1];
                        a[i + 1] = buf;
                    }

            for (int i = 0; i < n; i++)
                Console.Write("{0}; ", a[i]);
        }
    }
}
