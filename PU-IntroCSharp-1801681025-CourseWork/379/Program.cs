using System;
using System.Linq; // put with other using directives

namespace _379
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Generate(args);
            Square(args);
            Sss(rand);
            Console.Write("Input a=");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Input b=");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Input c=");
            int c = int.Parse(Console.ReadLine());
            int res = 0;
            res = (Math.Abs(c - b)) * (a + c);
            Console.WriteLine($"|c-b|*(a+c)= {res}");
        }


        static void Generate(string[] args)
        {
            Random rand = new Random();

            //void Main(string[] args)
            {
                // Declare and initialize an integer array, which will store 100 numbers
                int[] intArray = new int[132];

                // Generate 132 random numbers and store them in the array
                Console.WriteLine("Here are 132 randomly generated numbers in the interval between 0 and 150.");
                for (int i = 0; i < intArray.Length; i++)
                {
                    intArray[i] = rand.Next(150);
                    Console.WriteLine(intArray[i]);
                }
                Console.WriteLine("Display the numbers that are odd.");
                for (int i = 0; i < intArray.Length; i++)
                {
                    if ((intArray[i] % 2) != 0)//&& (i % 2 != 0))
                        Console.WriteLine($"{intArray[i]} is odd.");
                }
                Console.WriteLine("----------------------------------------------------------");
                Console.WriteLine("----------------------------------------------------------");
            }
        }
        static void Square(string[] args)
        {


            Console.WriteLine("Write 5 positive numbers: ");

            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());
            int number4 = int.Parse(Console.ReadLine());
            int number5 = int.Parse(Console.ReadLine());
            if (number1 < 0 || number2 < 0 || number3 < 0 || number4 < 0 || number5 < 0)
            {
                Console.WriteLine("One or more of the numbers is not positive, please write only positive numbers!");
            }
            double result = number1 * number2 * number3 * number4 * number5;

            double squareRoot = Math.Sqrt(result);
            System.Console.WriteLine("Square root is: " + squareRoot);

            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("----------------------------------------------------------");
        }
        private static void Sss(Random rand)
        {

            Console.Write("Input k= ");
            int k = int.Parse(Console.ReadLine());
            int[] intArray2 = new int[k];
            int sum = 0;

            Console.WriteLine("Here are the K randomly generated numbers.");
            for (int j = 0; j < intArray2.Length; j++)

            {
                intArray2[j] = rand.Next(k);
                Console.WriteLine(intArray2[j]);
            }
            Console.WriteLine("The two-digit numbers which are ending at 5 are: ");
            for (int i = 0; i < intArray2.Length; i++)
            {
                if (intArray2[i] >= 10 && intArray2[i] <= 99 && intArray2[i] % 5 == 0 && intArray2[i] % 2 == 1)
                {
                    Console.WriteLine(intArray2[i]);
                    sum += intArray2[i];

                }

            }
            Console.WriteLine($"The summary of the two-digit numbers which ends at 5 is: {sum}");
           
        }
    }
}
    

