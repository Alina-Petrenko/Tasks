using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask1_1
{
    internal class Starter
    {
        public void GetStartToCenter(int rows, int columns, int p, int[,] array)
        {
            int a = 1;
            int b = 1;
            int index = 1;
            Console.WriteLine("To Center");

            for (int i = 0; i < columns; i++)
            {
                array[0, i] = p;
                p++;
                index++;
            }
            for (int j = 1; j < rows; j++)
            {
                array[j, columns - 1] = p;
                p++;
                index++;
            }
            for (int k = columns - 2; k >= 0; k--)
            {
                array[rows - 1, k] = p;
                p++;
                index++;
            }
            for (int l = rows - 2; l > 0; l--)
            {
                array[l, 0] = p;
                p++;
                index++;
            }

            while (index < rows * columns)
            {

                while (array[a, b + 1] == 0)
                {
                    array[a, b] = p;
                    b++;
                    p++;
                    index++;
                }
                while (array[a + 1, b] == 0)
                {
                    array[a, b] = p;
                    a++;
                    p++;
                    index++;
                }

                while (array[a, b - 1] == 0)
                {
                    array[a, b] = p;
                    b--;
                    p++;
                    index++;
                }
                while (array[a - 1, b] == 0)
                {
                    array[a, b] = p;
                    a--;
                    p++;
                    index++;
                }
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (array[i, j] == 0)
                    {
                        array[i, j] = p;
                        array[0, 0] = 0;
                    }
                    Console.Write($"{array[i, j]} \t");
                }
                Console.WriteLine("");
            }
        }
        public void GetStartToBorder(int rows, int columns, int p, int[,] array)
        {
            Console.WriteLine("To Border");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = 0;
                }
            }
            int a = 1;
            int b = 1;
            int index = rows * columns;
            for (int i = 0; i < columns; i++)
            {
                array[0, i] = p;
                p--;
                index--;
            }
            for (int j = 1; j < rows; j++)
            {
                array[j, columns - 1] = p;
                p--;
                index--;
            }
            for (int k = columns - 2; k >= 0; k--)
            {
                array[rows - 1, k] = p;
                p--;
                index--;
            }
            for (int l = rows - 2; l > 0; l--)
            {
                array[l, 0] = p;
                p--;
                index--;
            }

            while (index > 1)
            {

                while (array[a, b + 1] == 0)
                {
                    array[a, b] = p;
                    b++;
                    p--;
                    index--;
                }
                while (array[a + 1, b] == 0)
                {
                    array[a, b] = p;
                    a++;
                    p--;
                    index--;
                }

                while (array[a, b - 1] == 0)
                {
                    array[a, b] = p;
                    b--;
                    p--;
                    index--;
                }
                while (array[a - 1, b] == 0)
                {
                    array[a, b] = p;
                    a--;
                    p--;
                    index--;
                }
            }


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (array[i, j] == 0)
                        array[i, j] = p;
                    Console.Write($"{array[i, j]} \t");
                }
                Console.WriteLine("");
            }
        }
    }
}