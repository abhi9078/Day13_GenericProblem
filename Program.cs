using System;
using System.Collections.Generic;

namespace Day13GenericProblem
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to program ");
            
            Refactor2<int> refactorint = new Refactor2<int>(10,20,30);
            int max1 = refactorint.MaxValueOf(10, 20, 30);
            Console.WriteLine("Maximum value of int is: "+max1);

            Refactor2<double> refactorfloat = new Refactor2<double>(10.10, 20.20, 30.30);
            double max2 = refactorfloat.MaxValueOf(10.10, 20.20, 30.30);
            Console.WriteLine("Maximum value of float is: " + max2);

            Refactor2<string> refactorstring = new Refactor2<string>("Abhi", "avi", "lol");
            string max3 = refactorstring.MaxValueOf("Abhi", "avi", "lol");
            Console.WriteLine("Maximum value of string is: " + max3);
        }
    }
}
