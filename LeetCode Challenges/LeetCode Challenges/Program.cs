using System;
using System.Collections;
using System.Collections.Generic;

namespace LeetCode_Challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            Day10Binary(10);
        }
        public static int Day10Binary(int n)
        {
            ArrayList bin = new ArrayList();
            for (int i = 0; i < n/10 + 1; i++)
            {
                Console.WriteLine(Math.Pow(2, i));
                if (n / (Math.Pow(2,i)) > 0)
                {
                    n = Convert.ToInt32(n / Math.Pow(2, i));
                    bin.Add(1);
                    Console.WriteLine("Input");
                }
            }
            for (int i = 0, j = bin.Count; i < bin.Count-1; i++, j--)
            {

            }
            return 0;
        }

    }
}
