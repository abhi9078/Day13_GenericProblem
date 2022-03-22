using System;
using System.Collections.Generic;

namespace Day13GenericProblem
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to program ");
            Console.WriteLine("Enter Length of Array");
            int len = int.Parse(Console.ReadLine());
            int[] arr = new int[len];
            Console.WriteLine("Enter elements of array");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            UC_5_MaxUsingGeneric<int> gen = new UC_5_MaxUsingGeneric<int>(arr);
            gen.MaxValue();
        }
    }
}
