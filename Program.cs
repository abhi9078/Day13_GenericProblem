using System;
using System.Collections.Generic;

namespace Day13GenericProblem
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Greater between 3 integer program ");
            Console.WriteLine("Enter 3 Integer Value");
            int fst=int.Parse(Console.ReadLine());
            int snd=int.Parse(Console.ReadLine());
            int trd=int.Parse(Console.ReadLine());
            UC_1_MaxInteger.MaxInteger(fst, snd, trd);
        }
    }
}
