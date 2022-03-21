using FirstTask1_1;

namespace FirstTask1_1
{
    public class Program
    {
        enum Flag
        {
            ToCenter,
            ToBorder
        }
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
                    int[,] array = new int[rows, columns];
                    int toBorder = 0;
                    int toCenter = rows * columns - 1;
                    starter.GetStartToCenter(rows, columns, toBorder, array);
                    starter.GetStartToBorder(rows, columns, toCenter, array);
                }
                catch
                {
                    Console.WriteLine("Error");
                }
            }
        }
    }
}