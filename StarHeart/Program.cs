using System;

namespace StarHeart
{
    internal class Program
    {
        private static void Main(string[] args)

        {
            int size = 6;
            for (int x = 0; x < size; x++)
            {
                for (int y = 0; y <= 4 * size; y++)
                {
                    double dist1 = Math.Sqrt(Math.Pow(x - size, 2) + Math.Pow(y - size, 2));
                    double dist2 = Math.Sqrt(Math.Pow(x - size, 2) + Math.Pow(y - 3 * size, 2));

                    if (dist1 < size + 0.5 || dist2 < size + 0.5)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
            for (int x = 1; x < 2 * size; x++)
            {
                for (int y = 0; y < x; y++)
                    Console.Write(" ");

                for (int y = 0; y < 4 * size + 1 - 2 * x; y++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}