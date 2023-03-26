using System;
using System.Data;
using System.Linq;

namespace _6._Bills
{
    internal class Program
    {
        static void Main(string[] args)
        {
           double month = double.Parse(Console.ReadLine());

            double elec = 0;

            double elecsum = 0;



            for (int i = 0; i < month; i++)



            {

                elec = double.Parse(Console.ReadLine());

                elecsum += elec;

            }



            double watersum = 20 * month;

            double internetsum = 15 * month;

            double extras = (elecsum + watersum + internetsum) * 1.2;

            double aver = (elecsum + watersum + internetsum + extras) / month;



            Console.WriteLine($"Electricity: {elecsum:f2} lv");

            Console.WriteLine($"Water: {watersum:f2} lv");

            Console.WriteLine($"Internet: {internetsum:f2} lv");

            Console.WriteLine($"Other: {extras:f2} lv");

            Console.WriteLine($"Average: {aver:f2} lv");

        }
    }
}
