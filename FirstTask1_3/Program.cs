using System;

namespace FirstTask1_3
{
    enum Flag
    {
        ToCenter = 1,
        ToBorder
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Starter starter = new Starter();
            while (true)
            {
                try
                {
                    Console.WriteLine("Write rows number");
                    int rows = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("Write columns number");
                    int columns = Int32.Parse(Console.ReadLine());
                    if (columns != rows)
                    {
                        int[][] array = new int[rows][];
                        for (int i = 0; i < rows; i++)
                        {
                            array[i] = new int[columns];
                        }

                        Console.WriteLine("Write first number");
                        int firstValue = Int32.Parse(Console.ReadLine());

                        Console.WriteLine("Write increment number");
                        int increment = Int32.Parse(Console.ReadLine());

                        Console.WriteLine("Set flag: 1 - To Center, 2 - To Border");
                        int flag = Int32.Parse(Console.ReadLine());

                        string elapsedTime = starter.GetStart(rows, columns, firstValue, array, flag, increment);
                        Console.WriteLine($"Elapsed time: {elapsedTime}\n");
                    }
                    else
                    {
                        Console.WriteLine("It should be a rectangle, not a square!");
                    }
                }
                catch
                {
                    Console.WriteLine("Oops! It's seems like you wrote incorrect value! Try again");
                }

            }
        }
    }
}
