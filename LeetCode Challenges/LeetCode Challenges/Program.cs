using LeetCode_Challenges.CodeWars;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode_Challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            //Day10Binary(10);

            IQTest("2 1 1");
            Console.WriteLine();

        }
        

        public static int IQTest(string numbers)
        {
            string[] split = numbers.Split(' ');
            List<int> arr = new List<int>();

            #region For Loop
            //for (int i = 0 ; i < split.Length; i++)
            //{
            //    if (Convert.ToInt32(split[i]) % 2 == 0 && split[i] == split[i + 1])
            //    {
            //        arr.Add(0);

            //    }
            //    else
            //        arr.Add(1);
            //}
            #endregion For Loop


            foreach (var item in split)
            {
                if (Convert.ToInt32(item) % 2 == 0)
                {
                    arr.Add(0);
                }
                else
                    arr.Add(1);
            }

            var myQuarry = split.Where(c => c.Contains(Convert.ToChar(arr[0])));

            foreach (var item in myQuarry)
            {
                Console.WriteLine(item + "From my Quarry");
            }
            if (arr[0] != arr[1] && arr[0] != arr[2])
            {
                Console.WriteLine(0);
                return 0;
            }
            else if (arr[1] != arr[0] && arr[1] != arr[2])
            {
                Console.WriteLine(1);
                return 1;
            }
            else if (arr[2] != arr[0] && arr[2] != arr[1])
            {
                Console.WriteLine(2);
                return 2;
            }
            else   
            Console.WriteLine(-1);
            return -1;

            //Reference: https://www.codewars.com/kata/552c028c030765286c00007d/train/csharp
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
