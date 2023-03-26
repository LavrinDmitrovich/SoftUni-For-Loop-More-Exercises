using System;

namespace _7._Stadion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double seats = double.Parse(Console.ReadLine());

            double fans = double.Parse(Console.ReadLine());

            string team = string.Empty;

            double tmA = 0;

            double tmB = 0;

            double tmV = 0;

            double tmG = 0;



            for (int i = 0; i < fans; i++)

            {

                team = Console.ReadLine();



                if (team == "A") { tmA++; }

                if (team == "B") { tmB++; }

                if (team == "V") { tmV++; }

                if (team == "G") { tmG++; }



            }



            Console.WriteLine($"{(tmA * 100 / fans):f2}%");

            Console.WriteLine($"{(tmB * 100 / fans):f2}%");

            Console.WriteLine($"{(tmV * 100 / fans):f2}%");

            Console.WriteLine($"{(tmG * 100 / fans):f2}%");

            Console.WriteLine($"{(fans * 100 / seats):f2}%");
        }
    }
}
