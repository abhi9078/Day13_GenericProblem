using System;
using System.Collections.Generic;

namespace Day13GenericProblem
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to program ");
            
            Refactor1<int> refactorint = new Refactor1<int>();
            int max1 = refactorint.MaxValue(10, 20, 30);
            Console.WriteLine("Maximum value of int is: "+max1);

            Refactor1<double> refactorfloat = new Refactor1<double>();
            double max2 = refactorfloat.MaxValue(10.10, 20.20, 30.30);
            Console.WriteLine("Maximum value of float is: " + max2);

            Refactor1<string> refactorstring = new Refactor1<string>();
            string max3 = refactorstring.MaxValue("Abhi", "avi", "lol");
            Console.WriteLine("Maximum value of string is: " + max3);
        }
    }
}
