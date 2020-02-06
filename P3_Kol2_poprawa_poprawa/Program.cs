using System;
using System.Collections.Generic;

namespace P3_Kol2_poprawa_poprawa
{
    class Program
    {
        static void Main(string[] args)

        {
            Random a = new Random();
            Console.WriteLine("Zadanie.1");

            var skladniki = new List<Skladnik>();

            for (int i = 0; i < 10; i++)
            {
                skladniki.Add(new Skladnik(
                    a.Next(0,10),
                    a.Next(5,15),
                    a.Next(10,20)
                    ));
            }

            foreach (var item in skladniki)
            {
                Console.WriteLine(skladniki);
            }

            var produkty = new List<int>();

            



            Console.WriteLine("Zadanie.2");
            Console.WriteLine("pisz coś");
            string tekst = Console.ReadLine();
            int x = 20;
            Console.WriteLine(tekst.licz(x));

            Console.WriteLine("Zadanie.3");

            var tak = new Hex("FF,AA,BB");
            //var(R, G, B) = tak;

            //Console.WriteLine($"");

            Console.WriteLine("Zadanie.4");
            Console.WriteLine("Zadanie.5");
        }
    }
}
