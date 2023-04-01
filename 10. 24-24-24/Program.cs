using System;

namespace _10._24_24_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 24; i++)
            {
                for (int j = 0; j <= 59; j++)
                { 
                for (int k = 0; k <=59; k++) { Console.WriteLine(i + " : " + j + " : " +k); }
                }
            }
        }
    }
}
