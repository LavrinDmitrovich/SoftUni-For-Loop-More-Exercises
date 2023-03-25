using System;

namespace _3.Logistics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double count = double.Parse(Console.ReadLine());
            
            double bus =0;
            double track = 0;
            double train = 0;

            for (int i = 0; i < count; i++)
            {  double weight = double.Parse(Console.ReadLine());

                if (weight <= 3) { bus +=weight;}
                if (weight > 3 && weight <=11) { track += weight; }
                if (weight > 12) { train += weight; }

            }

            double aver = (bus*200+track*175+train*120)/(bus+track+train);

            
            Console.WriteLine("{0:F2}", aver);
            Console.WriteLine($"{bus*100/(bus+track+train):f2}%");
            Console.WriteLine($"{track * 100 / (bus + track + train):f2}%");
            Console.WriteLine($"{train * 100 / (bus + track + train):f2}%");

        }
    }
}
