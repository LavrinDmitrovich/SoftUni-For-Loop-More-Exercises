using System;

namespace _4.Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double count = double.Parse(Console.ReadLine());

            double top = 0;
            double midtop = 0;
            double midlow = 0;
            double low = 0;
            double sum = 0;
            double aver = 0;

            for (int i = 0; i < count; i++)
            {
                double grade = double.Parse(Console.ReadLine());
                sum += grade;
                if (grade >=5) { top++; }
                if (grade >= 4 && grade <= 4.99) { midtop++; }
                if (grade >= 3 && grade <= 3.99) { midlow++; }
                if (grade < 3) { low++; }

            }

            aver = sum/count;


            Console.WriteLine($"Top students: {top * 100 / count:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {midtop * 100 / count:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {midlow * 100 / count:f2}%");
            Console.WriteLine($"Fail: {low * 100 / count:f2}%");
            Console.WriteLine($"Average: {aver:f2}");
        }
    }
}
