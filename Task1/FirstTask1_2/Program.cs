using FirstTask1_2;
using System;
// TODO: Always remove unused usings
using System.Diagnostics;

namespace FirstTask1_2
{
    // TODO: Name Bypass is better
    [Flags]
    enum Flag
    {
        // TODO: FromBorderToCenter - better
        ToCenter = 1,
        // TODO: Better to identify all values in enum, if you start to do it.
        ToBorder = 2
    }
    public class Program
    {
        // TODO: if we don`t use arguments we can mark them as "_" or just remove them
        public static void Main()
        {
            // TODO: Name of class does not fit the purpose of class
            // Better to name Filler, ArrayFiller for example
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
                        int[,] array = new int[rows, columns];

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
                        // TODO: Square is a subclass of rectangle.
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