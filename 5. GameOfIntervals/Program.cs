using System;

namespace _5._GameOfIntervals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double steps = double.Parse(Console.ReadLine());
            double num = 0;

            double x = 0;

            double one = 0;
            double two = 0;
            double three = 0;
            double four = 0;
            double five = 0;
            double six = 0;

            double sum = 0;


            for (int i = 0; i < steps; i++)


            {
                num = double.Parse(Console.ReadLine());
                if (num >= 0 && num <= 9) { x = num * 0.2; one++; sum += x; }
                if (num >= 10 && num <= 19) { x = num * 0.3; two++; sum += x; }
                if (num >= 20 && num <= 29) { x = num * 0.4; three++; sum += x; }
                if (num >= 30 && num <= 39) { x = 50; four++; sum += x; }
                if (num >= 40 && num <= 50) { x = 100; five++; sum += x; }
                if (num < 0 || num > 50) { x = 0; six++; sum = sum / 2; }

                
                //Console.WriteLine($"x={x:f2} , sum={sum:f2}");

            }
            Console.WriteLine("{0:f2}", sum);
            Console.WriteLine($"From 0 to 9: {(one * 100 / steps):f2}%");
            Console.WriteLine($"From 10 to 19: {(two * 100 / steps):f2}%");
            Console.WriteLine($"From 20 to 29: {(three * 100 / steps):f2}%");
            Console.WriteLine($"From 30 to 39: {(four * 100 / steps):f2}%");
            Console.WriteLine($"From 40 to 50: {(five * 100 / steps):f2}%");
            Console.WriteLine($"Invalid numbers: {(six * 100 / steps):f2}%");


        }
    }
}
