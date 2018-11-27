using System;

namespace _398
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadacha 4.");
            Console.Write("Ednomeren masiv: "); int n = 1;
            int[] A = new int[n];
            //int[] B = new int[n];
            //int[] C = new int[n];

            //RndArray(A);
            //RndArray(B);
            //RndArray(C);

            FillArray(A);
            //FillArray(B);
            //FillArray(C);

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Masiv A");
            Console.ForegroundColor = ConsoleColor.Gray;
            PrintArray(A);

            //Console.ForegroundColor = ConsoleColor.DarkGreen;
            //Console.WriteLine("Masiv B");
            //Console.ForegroundColor = ConsoleColor.Gray;
            //PrintArray(B);

            //Console.ForegroundColor = ConsoleColor.DarkGreen;
            //Console.WriteLine("Masiv C");
            //Console.ForegroundColor = ConsoleColor.Gray;
            //PrintArray(C);

            Check5(A);
            //Check5(B);
            //Check5(C);

            Console.WriteLine();

            GeometricMean(A);
            //GeometricMean(B);
            //GeometricMean(C);

            Console.WriteLine();
            //TransformC(A, B, C);
            //Console.WriteLine("Transformiraniq masiv C");
            //PrintArray(C);


            Console.ReadKey(true);
        }


        //static void RndArray(int[] arr)
        //{

        //    Random rng = new Random(1000);
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        arr[i] = rng.Next(0, 100);
        //    }

        //}

        //Метод за въвеждане в масив
        static void FillArray(int[] arr)
        {

            for (int i = 0; i < arr.Length; i++)
            {
                int x = i + 1;
                Console.Write("Vuvedi element [" + x + "] v masiva: ");
                arr[i] = int.Parse(Console.ReadLine());
            }
        }

        //Метод за проверка на тези числа, които се делят на 5 без остатък
        //и да се намират на нечетна позиция в масива
        static void Check5(int[] arr)
        {
            int counter = 0;

            for (int i = 1; i < arr.Length; i = i + 2)
            {
                if (arr[i] % 5 == 0)
                {
                    counter++;
                }
            }

            Console.WriteLine("V masiva ima: " + counter + " chisla koito se delqt na 5 bez ostatuk, koito da se namirat v nechetna poziciq v masiva.");
        }

        //Метод за изваждане на данните от масив
        static void PrintArray(int[] arr)
        {


            for (int i = 0; i < arr.Length; i++)
            {
                int x = i + 1;
                Console.WriteLine("Element [" + x + "] na masiva e: " + arr[i] + " ");
            }
            Console.WriteLine();

        }


        //Метод за пресмятане на средно геометричното на един масив
        static void GeometricMean(int[] arr)
        {
            double proizv = 1;

            //Произведението на всички елементи на масива
            foreach (var item in arr)
            {
                proizv *= item;
            }

            //Цялото произзведение повдигнато на степен 1/n, където n е броя на елементите
            double geometricMean = Math.Pow(proizv, 1.0 / arr.Length);

            Console.WriteLine("Sredno geometrichnoto na masiva e :" + geometricMean);
        }

        //Метод за преизчисление на масив C
        static void TransformC(int[] A, int[] B, int[] C)
        {

            int y = C.Length - 1;
            int z, c;
            for (int i = 0; i < C.Length; i++)
            {

                //Променлива Z, която да помни разликата на елемните на масива отзад - напред
                z = A[y] - B[y];
                //Променлива С, която да помни разликата на елемните на масива отпред - назад
                c = A[i] - B[i];

                y--;

                //Записване на произведението в масива С
                C[i] = z * c;
            }
        }
    }
}
