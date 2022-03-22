using System;
using System.Collections.Generic;

namespace Day13GenericProblem
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Greater between 3 Floats program ");
            Console.WriteLine("Enter 3 Floats Value");
            double fst=double.Parse(Console.ReadLine());
            double snd=double.Parse(Console.ReadLine());
            double trd=double.Parse(Console.ReadLine());
            UC_2_MaxFloat.MaxFloat(fst, snd, trd);
        }
    }
}
