using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask1_2
{
    internal class Starter
    {
        public void GetStart(int rows, int columns, int firstValue, int[,] array, int flag, int increment)
        {
            if (flag == (int)Flag.ToCenter)
            {
                int a = 1;
                int b = 1;
                int index = 1;
                int first = firstValue;
                Console.WriteLine("To Center");
                for (int i = 0; i < columns; i++)
                {
                    array[0, i] = firstValue;
                    firstValue += increment;
                    index++;
                }
                for (int j = 1; j < rows; j++)
                {
                    array[j, columns - 1] = firstValue;
                    firstValue += increment;
                    index++;

                }
                for (int k = columns - 2; k >= 0; k--)
                {
                    array[rows - 1, k] = firstValue;
                    firstValue += increment;
                    index++;
                }
                for (int l = rows - 2; l > 0; l--)
                {
                    array[l, 0] = firstValue;
                    firstValue += increment;
                    index++;
                }

                while (index < rows * columns)
                {

                    while (array[a, b + 1] == 0)
                    {
                        array[a, b] = firstValue;
                        b++;
                        firstValue += increment;
                        index++;
                    }
                    while (array[a + 1, b] == 0)
                    {
                        array[a, b] = firstValue;
                        a++;
                        firstValue += increment;
                        index++;
                    }

                    while (array[a, b - 1] == 0)
                    {
                        array[a, b] = firstValue;
                        b--;
                        firstValue += increment;
                        index++;
                    }
                    while (array[a - 1, b] == 0)
                    {
                        array[a, b] = firstValue;
                        a--;
                        firstValue += increment;
                        index++;
                    }
                }

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        if (array[i, j] == 0)
                        {
                            array[i, j] = firstValue;
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
                int index = (rows * columns - 1 ) * increment + firstValue;
                firstValue = rows * columns;
                for (int i = 0; i < columns; i++)
                {
                    array[0, i] = index;
                    firstValue--;
                    index-= increment;
                }
                for (int j = 1; j < rows; j++)
                {
                    array[j, columns - 1] = index;
                    firstValue--;
                    index -= increment;
                }
                for (int k = columns - 2; k >= 0; k--)
                {
                    array[rows - 1, k] = index;
                    firstValue--;
                    index -= increment;
                }
                for (int l = rows - 2; l > 0; l--)
                {
                    array[l, 0] = index;
                    firstValue--;
                    index -= increment;
                }
                while (firstValue > 1)
                {

                    while (array[a, b + 1] == 0)
                    {
                        array[a, b] = index;
                        b++;
                        firstValue--;
                        index -= increment;
                    }
                    while (array[a + 1, b] == 0)
                    {
                        array[a, b] = index;
                        a++;
                        firstValue--;
                        index -= increment; 
                    }

                    while (array[a, b - 1] == 0)
                    {
                        array[a, b] = index;
                        b--;
                        firstValue--;
                        index -= increment;
                    }
                    while (array[a - 1, b] == 0)
                    {
                        array[a, b] = index;
                        a--;
                        firstValue--;
                        index -= increment;
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

