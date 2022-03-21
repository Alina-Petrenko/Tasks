using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask1_2
{
    internal class Starter
    {
        public void GetStart(int rows, int columns, int p, int[,] array, int flag, int increment)
        {
            if (flag == (int)Flag.ToCenter)
            {
                int a = 1;
                int b = 1;
                int index = 1;
                int first = p;
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
                            if (first == 0)
                                array[0, 0] = 0;
                        }
                        Console.Write($"{array[i, j]} \t");
                    }
                    Console.WriteLine("");
                }
            }
            else if (flag == (int)Flag.ToBorder)
            {
                Console.WriteLine("To Border");
                int a = 1;
                int b = 1;
                int index = rows * columns - 1 + p;
                p = rows * columns;
                for (int i = 0; i < columns; i++)
                {
                    array[0, i] = index;
                    p--;
                    index--;
                }
                for (int j = 1; j < rows; j++)
                {
                    array[j, columns - 1] = index;
                    p--;
                    index--;
                }
                for (int k = columns - 2; k >= 0; k--)
                {
                    array[rows - 1, k] = index;
                    p--;
                    index--;
                }
                for (int l = rows - 2; l > 0; l--)
                {
                    array[l, 0] = index;
                    p--;
                    index--;
                }
                while (p > 1)
                {

                    while (array[a, b + 1] == 0)
                    {
                        array[a, b] = index;
                        b++;
                        p--;
                        index--;
                    }
                    while (array[a + 1, b] == 0)
                    {
                        array[a, b] = index;
                        a++;
                        p--;
                        index--;
                    }

                    while (array[a, b - 1] == 0)
                    {
                        array[a, b] = index;
                        b--;
                        p--;
                        index--;
                    }
                    while (array[a - 1, b] == 0)
                    {
                        array[a, b] = index;
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
                            array[i, j] = index;
                        Console.Write($"{array[i, j]} \t");
                    }
                    Console.WriteLine("");
                }
            }
            else
            {
                Console.WriteLine("Wrong flag number, try again");

            }
        }
    }
}

