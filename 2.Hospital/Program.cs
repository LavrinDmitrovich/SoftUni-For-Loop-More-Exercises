﻿using System;

namespace _2.Hospital
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int patient = 0;
            int treated = 0;
            int untreated = 0;
            int doctors = 7;
            

            for (int i = 1; i <= days; i++) 
            {
            patient = int.Parse(Console.ReadLine());
              
                if (i % 3 == 0) { if (untreated > treated) { doctors++; } }
                if (patient <= doctors) { treated += patient; }
                    else { untreated += patient - doctors; treated += doctors; }
               
            }
            Console.WriteLine($"Treated patients: {treated}.");
            Console.WriteLine($"Untreated patients: {untreated}.");
        }
    }
}
