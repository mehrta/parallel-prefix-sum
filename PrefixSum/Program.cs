using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrefixSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string newline = System.Environment.NewLine;
            PrefixSum ps = new PrefixSum();
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 }; // Input array

            System.Console.WriteLine("Input array:");
            foreach (int i in arr)
                System.Console.Write(i.ToString() + " ");
            
            ///////
            ps.Input = arr;
            ps.Calculate(); // Calculate Prefix sum
            ///////

            System.Console.WriteLine(newline + newline + "Prefix Sum:");
            foreach (int i in ps.Output)
                System.Console.Write(i.ToString() + " ");

            System.Console.Read();
        }
    }
}
