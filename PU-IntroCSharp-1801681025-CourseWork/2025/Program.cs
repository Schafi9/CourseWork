using System;

namespace _2025
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 2025;
            string binary = Convert.ToString(number, 2);
            string binary2 = Convert.ToString(number, 8);
            string binary3 = Convert.ToString(number, 16);
            Console.WriteLine($"Binary system: { binary}");
            Console.WriteLine($"8 number system: { binary2}");
            Console.WriteLine($"16 number system: { binary3}");
        }
    }
}
