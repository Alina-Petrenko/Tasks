using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask1_2
{
    internal class Starter
    {
        public string GetStart(int rows, int columns, int firstValue, int[,] array, int flag, int increment)
        {
            Stopwatch time = new Stopwatch();
            time.Start();
            int internalRows = 1;
            int internalColumns = 1;
            if (flag == (int)Flag.ToCenter)
            {             
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

                    while (array[internalRows, internalColumns + 1] == 0)
                    {
                        array[internalRows, internalColumns] = firstValue;
                        internalColumns++;
                        firstValue += increment;
                        index++;
                    }
                    while (array[internalRows + 1, internalColumns] == 0)
                    {
                        array[internalRows, internalColumns] = firstValue;
                        internalRows++;
                        firstValue += increment;
                        index++;
                    }

                    while (array[internalRows, internalColumns - 1] == 0)
                    {
                        array[internalRows, internalColumns] = firstValue;
                        internalColumns--;
                        firstValue += increment;
                        index++;
                    }
                    while (array[internalRows - 1, internalColumns] == 0)
                    {
                        array[internalRows, internalColumns] = firstValue;
                        internalRows--;
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

                    while (array[internalRows, internalColumns + 1] == 0)
                    {
                        array[internalRows, internalColumns] = index;
                        internalColumns++;
                        firstValue--;
                        index -= increment;
                    }
                    while (array[internalRows + 1, internalColumns] == 0)
                    {
                        array[internalRows, internalColumns] = index;
                        internalRows++;
                        firstValue--;
                        index -= increment; 
                    }

                    while (array[internalRows, internalColumns - 1] == 0)
                    {
                        array[internalRows, internalColumns] = index;
                        internalColumns--;
                        firstValue--;
                        index -= increment;
                    }
                    while (array[internalRows - 1, internalColumns] == 0)
                    {
                        array[internalRows, internalColumns] = index;
                        internalRows--;
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

            time.Stop();
            TimeSpan timeSpan = time.Elapsed;
            string elapsedTime = timeSpan.ToString(@"mm\:ss\.FFFFFF");
            return elapsedTime;
        }
    }
}

