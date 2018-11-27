using System;

namespace _63
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose between 1, 2 or 3 to find y:");
            Console.Write("k= ");
            double k = int.Parse(Console.ReadLine());
            double y = 0;
            switch (k)
            {
                
                case 1:
                    {
                        y = 6.7;
                        Console.WriteLine($"y={y}");
                        break;
                    }
                case 2:
                    {                       
                        y = 6.7 + (9 * k);
                        Console.WriteLine($"y={y}");
                        break;
                    }
                case 3:
                    {
                        y = 6.7 + (9 * k) + (7 * (k * k));
                        Console.WriteLine($"y={y}");
                        break;
                    }
                default:
                    Console.WriteLine("Wrong input, type 1, 2 or 3!");
                    break;
            }
        }
    }
}
