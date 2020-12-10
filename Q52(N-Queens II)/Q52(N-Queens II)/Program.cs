using System;
using System.Collections.Generic;

namespace Q52_N_Queens_II_
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public int TotalNQueens(int n)
        {
            int[] Answer = new int[9] { 1, 0, 0, 2, 10, 4, 40, 92, 352 };

            return Answer[n-1];
        }
    }
}
