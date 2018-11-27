using System;

namespace _213j
{
    class Program
    {
        static void Main(string[] args)
        {
            double result = 0.0;
            
            for (int i = 1; i <= 100; i++)
            {
                double tan = Math.Tan(i);
                result += tan;
            }

            Console.WriteLine("{0}", result);
        }
    
    }
}
