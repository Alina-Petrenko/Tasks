using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask1_1
{
    // TODO: always need summary. What is the purpose of this class.
    internal class Starter
    {
        // TODO: always need summary
        /// <summary>
        /// Fills <paramref name="array"/> by elements starting from <paramref name="firstValue"/>.  
        /// </summary>
        /// <param name="rows">Count of rows in array.</param>
        /// <param name="columns">SECOND</param>
        /// <param name="firstValue">THIRD</param>
        /// <param name="array"></param>
        public void GetStartToCenter(int rows, int columns, int firstValue, int[,] array)
        {
            //TODO:  We don`t need rows and columns
            array.GetLength(0);
            array.GetLength(1);


            int internalRows = 1;
            int internalColumns = 1;
            int index = 1;
            Console.WriteLine("To Center");

            for (int i = 0; i < columns; i++)
            {
                array[0, i] = firstValue;
                firstValue++;
                index++;
            }
            for (int j = 1; j < rows; j++)
            {
                array[j, columns - 1] = firstValue;
                firstValue++;
                index++;
            }
            for (int k = columns - 2; k >= 0; k--)
            {
                array[rows - 1, k] = firstValue;
                firstValue++;
                index++;
            }
            for (int l = rows - 2; l > 0; l--)
            {
                array[l, 0] = firstValue;
                firstValue++;
                index++;
            }

            // TODO: Why we cannot use it for external rows and columns?
            while (index < rows * columns)
            {

                while (array[internalRows, internalColumns + 1] == 0)
                {
                    array[internalRows, internalColumns] = firstValue;
                    internalColumns++;
                    firstValue++;
                    index++;
                }
                while (array[internalRows + 1, internalColumns] == 0)
                {
                    array[internalRows, internalColumns] = firstValue;
                    internalRows++;
                    firstValue++;
                    index++;
                }

                while (array[internalRows, internalColumns - 1] == 0)
                {
                    array[internalRows, internalColumns] = firstValue;
                    internalColumns--;
                    firstValue++;
                    index++;
                }
                while (array[internalRows - 1, internalColumns] == 0)
                {
                    array[internalRows, internalColumns] = firstValue;
                    internalRows--;
                    firstValue++;
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
                        array[0, 0] = 0;
                    }
                    Console.Write($"{array[i, j]} \t");
                }
                Console.WriteLine("");
            }
        }
        public void GetStartToBorder(int rows, int columns, int firstValue, int[,] array)
        {
            Console.WriteLine("To Border");
            
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = 0;
                }
            }
            int internalRows = 1;
            int internalColumns = 1;
            int index = rows * columns;
            for (int i = 0; i < columns; i++)
            {
                array[0, i] = firstValue;
                firstValue--;
                index--;
            }
            for (int j = 1; j < rows; j++)
            {
                array[j, columns - 1] = firstValue;
                firstValue--;
                index--;
            }
            for (int k = columns - 2; k >= 0; k--)
            {
                array[rows - 1, k] = firstValue;
                firstValue--;
                index--;
            }
            for (int l = rows - 2; l > 0; l--)
            {
                array[l, 0] = firstValue;
                firstValue--;
                index--;
            }

            while (index > 1)
            {

                while (array[internalRows, internalColumns + 1] == 0)
                {
                    array[internalRows, internalColumns] = firstValue;
                    internalColumns++;
                    firstValue--;
                    index--;
                }
                while (array[internalRows + 1, internalColumns] == 0)
                {
                    array[internalRows, internalColumns] = firstValue;
                    internalRows++;
                    firstValue--;
                    index--;
                }

                while (array[internalRows, internalColumns - 1] == 0)
                {
                    array[internalRows, internalColumns] = firstValue;
                    internalColumns--;
                    firstValue--;
                    index--;
                }
                while (array[internalRows - 1, internalColumns] == 0)
                {
                    array[internalRows, internalColumns] = firstValue;
                    internalRows--;
                    firstValue--;
                    index--;
                }
            }


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (array[i, j] == 0)
                        array[i, j] = firstValue;
                    Console.Write($"{array[i, j]} \t");
                }
                Console.WriteLine("");
            }
        }
    }
}