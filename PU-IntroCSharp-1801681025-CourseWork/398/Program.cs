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
            Console.WriteLine("Enter the number of days for the month (<=31): ");

            string inputDays = Console.ReadLine();
            int days;

            while (!(Int32.TryParse(inputDays, out days))
                  || (days < 1 || days > 32))
            {
                Console.WriteLine("Not a valid ammount, higher than 1, lower than 32! ");
                Console.WriteLine("Please re-enter the days: ");
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

            //PrintAboveAvg(A);
            //PrintAboveAvg(B);
            //PrintAboveAvg(C);

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
            double average;

            //Please use double of "s" variable
            foreach (double s in arr)

                total += s;

            if (arr.Length > 0)
            {
                average = total / arr.Length;
                double geometricMean = average;
                Console.WriteLine("Srednoto kolichestvo na valeji v stanciite (A), (B), i (C) e: " + geometricMean);
            }
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] > total)
                    Console.WriteLine($"Valejite nad srednoto nivo sa: {arr[i]}");

        }
        //public static void PrintAboveAvg(int[] arr)
        //{
        //    // Find average 
        //    double avg = 0;
        //    foreach (double s in arr)
        //       if (arr.Length > 0)
        //    {
        //        avg = avg / arr.Length;
        //        double geometricMean = avg;
        //        Console.WriteLine("Srednoto kolichestvo na valeji v stanciite (A), (B), i (C) e: " + geometricMean);
        //    }
        //    // Print elements greater than average 
        //    for (int i = 0; i < arr.Length; i++)
        //        if (arr[i] > avg)
        //            Console.WriteLine(arr[i] + " ");
        //}
        
    }

}
