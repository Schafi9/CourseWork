using System;
using System.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace _372ab
{
    class Program
    {
        static string[] x = {"Бургас","Варна","Силистра","Търговище","Ловеч",
             "Кърджали","Пловдив","Благоевград","Пазарджик","Асеновград","Ботевград","Велико Търново","Габрово",
            "Димитровград","Копривщица",  "Крумовград",  "Кърджали",
            "Кюстендил","Момчилград", "Панагюрище", "Симеоновград",
             "Бургас",  "Варна",   "Силистра","Търговище",
             "Ловеч",  "Кърджали",  "Пловдив", "Благоевград",
             "Пазарджик", "Асеновград",  "Ботевград",  "Велико Търново",
            "Габрово",  "Димитровград", "Копривщица",  "Крумовград",
             "Кърджали",  "Кюстендил",  "Момчилград",  "Панагюрище","Симеоновград", "Градешница"};
        

        static void Print(string[] a)
        {
            

            for (int i = 0; i < a.Length; i++)
            {
                string element = a[i];
                Console.WriteLine(i+1+": "+a[i]);
            }

        }

        public static void SolveB(string[] a)
        {

            string part = "град";
            string bigLetter = "Град";
            foreach(string x in a)
            {
                if(x.Contains(part))
                {
                    Console.WriteLine(x);
                }
                if (x.Contains(bigLetter))
                {
                    Console.WriteLine(x);
                }
            }

        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Thats all the cities: "); Print(x);
            Console.WriteLine("The cities which has Град in their names are: "); SolveB(x);
        }
    }
}
