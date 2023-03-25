using System;

namespace _1._BackToPast
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            double year = double.Parse(Console.ReadLine());
            double moneySpend = 0;
            double age = 17;

            for (int i = 1800; i <=year; i++) 
            {
                age += 1;
                
                if ((i % 2 == 0)) { moneySpend += 12000; }
                else moneySpend += 12000 + age * 50;
                //Console.WriteLine(i + " : " + age);
                //Console.WriteLine(moneySpend);
                
            }

            if (money > moneySpend)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {(money - moneySpend):f2} dollars left.");
            }
            else Console.WriteLine($"He will need {(moneySpend - money):f2} dollars to survive.");
        }
    }
}
