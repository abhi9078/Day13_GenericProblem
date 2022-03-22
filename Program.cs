using System;
using System.Collections.Generic;

namespace Day13GenericProblem
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Greater between 3 Strings program ");
            Console.WriteLine("Enter 3 String");
            string fst=Console.ReadLine();
            string snd=Console.ReadLine();
            string trd=Console.ReadLine();
            UC_3_MaxString.MaxString(fst, snd, trd);
        }
    }
}
