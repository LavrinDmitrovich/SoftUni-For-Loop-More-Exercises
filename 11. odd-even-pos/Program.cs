using System;
using System.Linq;

namespace _11._odd_even_pos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            

            int evenMassiveLength = 0;
            int oddMassiveLength = 0;

            if (count%2 == 0) { evenMassiveLength = count / 2; oddMassiveLength = count / 2;}
            else { oddMassiveLength = (count+1) / 2; evenMassiveLength = (count-1) / 2; }

            double[] basicmassive = new double[count];
            double[] even  = new double[evenMassiveLength];
            double[] odd = new double[oddMassiveLength];

            double num = 0;
            double evenElent = 0;
            double oddElent = 0;

            for (int i = 0; i < count; i++)
            {
                num = double.Parse(Console.ReadLine());
                basicmassive[i] = num;

                if (i%2 == 0) { odd[(i)/ 2] = num; }
                else { even[(i-1)/2] = num; }
            }

            double sumeven = even.Sum();
            double sumodd = odd.Sum();

            double mineven = 0;
            double maxeven = 0;
            double minodd = 0;
            double maxodd = 0;
            bool evnmslng = true;
            bool oddmslng = true;

            if (even.Length > 0 ) { mineven = even.Min(); maxeven = even.Max(); }  else evnmslng = false;
            if (odd.Length > 0 ) { minodd = odd.Min(); maxodd = odd.Max(); } else oddmslng = false;

            Console.WriteLine($"OddSum={sumodd:f2},");
            if (oddmslng == false)
            {
                Console.WriteLine("OddMin=No,");
                Console.WriteLine("OddMax=No,");
            }
            else
            {
                Console.WriteLine($"OddMin={minodd:f2},");
                Console.WriteLine($"OddMax={maxodd:f2},");
            }
            Console.WriteLine($"EvenSum={sumeven:f2},");
            if (evnmslng == false)
            {
                Console.WriteLine("EvenMin=No,");
                Console.WriteLine("EvenMax=No");
            }
            else
            {
                Console.WriteLine($"EvenMin={mineven:f2},");
                Console.WriteLine($"EvenMax={maxeven:f2}");
            }
        }
    }
}
