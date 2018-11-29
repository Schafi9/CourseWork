using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha4
{
    class Program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Zadacha 4.");
            Console.Write("Vuvedi broyat na dnite v meseca (<=31): ");

            string inputDays = Console.ReadLine();
            int days;

            while (!(Int32.TryParse(inputDays, out days))
                  || (days < 1 || days > 32))
            {
                Console.WriteLine("Nevalidna stoinost, trqbva da sa ot 1 do 31! ");
                Console.WriteLine("Vuvedi dnite otnovo: ");
                inputDays = Console.ReadLine();
            }
            int n = days;
            int[] A = new int[n];
            int[] B = new int[n];
            int[] C = new int[n];

            FillArray(A);
            FillArray(B);
            FillArray(C);

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Stanciya A");
            Console.ForegroundColor = ConsoleColor.Gray;
            PrintArray(A);

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Stanciya B");
            Console.ForegroundColor = ConsoleColor.Gray;
            PrintArray(B);

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Stanciya C");
            Console.ForegroundColor = ConsoleColor.Gray;
            PrintArray(C);

            Console.WriteLine();

            GeometricMean(A);
            GeometricMean(B);
            GeometricMean(C);

            Console.ReadKey(true);
        }

        //Метод за въвеждане в масив
        public static void FillArray(int[] arr)
        {

            for (int i = 0; i < arr.Length; i++)
            {
                int x = i + 1;
                Console.Write("Vuvedi Valejite za [" + x + "] den: ");
                arr[i] = int.Parse(Console.ReadLine());
            }
        }

        //Метод за изваждане на данните от масив
        static void PrintArray(int[] arr)
        {


            for (int i = 0; i < arr.Length; i++)
            {
                int x = i + 1;
                Console.WriteLine("Den [" + x + "] - Valeji: " + arr[i] + " -litra na kv.m. ");
            }
            Console.WriteLine();

        }
        //Метод за пресмятане на средно на един масив
        public static void GeometricMean(int[] arr)
        {
            double total = 0;
            double average=0;

            //Please use double of "s" variable
            foreach (double s in arr)

                total += s;

            if (arr.Length > 0)
            {
                average = total / arr.Length;
                double geometricMean = average;
                Console.WriteLine("Srednoto kolichestvo na valeji v stanciite (A), (B), i (C) e: " + geometricMean);  
            }
            Console.WriteLine($"Valejite nad srednoto nivo sa: ");
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] > average)
                {
                    Console.WriteLine(arr[i]);
                }
        }        
    }
}
