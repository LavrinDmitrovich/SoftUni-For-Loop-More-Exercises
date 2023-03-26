using System;
using System.Linq;

namespace _7.Couples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int couples = int.Parse(Console.ReadLine());
            double num1 = 0;
            double num2 = 0;
            double sum = 0;
            int[] sort = new int[couples];
            int[] sort2 = new int[sort.Length];
            int equals = 0;


            for (int i = 0; i < couples; i++)

            {
                num1 = double.Parse(Console.ReadLine());
                num2 = double.Parse(Console.ReadLine());
                sum = num1 + num2;
                sort[i] = (int)sum;
            }

            for (int i = 0; i <= couples - 2; i++)
            {
                if (sort[i] == sort[i + 1]) { equals++; }
            }

            for (int i = 0; i < sort.Length - 1; i++)
            {
                sort2[i] = Math.Abs(sort[i] - sort[i + 1]);
            }

            int s = sort2.Max();

            if (equals == couples - 1) { Console.WriteLine($"Yes, value={sort[0]}"); }
            else { Console.WriteLine($"No, maxdiff={s}"); }
        }
    }
}
