using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode_Challenges
{
    class TS
    {
        //To find the targeted value between the index values in an array.
        public static int[] TwoSum(int[] nums, int target)
        {
            //Pull the first index value in the array and compare it to the following index values.
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    //put the index values in the array
                    int[] arr = { i, j };
                    //if the index value's sum equal the target return the index.
                    if (nums[i] + nums[j] == target)
                    {
                        return arr;
                    }
                }

            }
            //return null if it does not equate to the target number.
            return null;
        }
        //The first attempt to find the targeted value between the index values in an array.
        //Does Not Work All The Time!
        public static int[] TwoSum0(int[] nums, int target)
        {
            //initialize a count and incriment it through the loop until the values match.
            int count = 0;
            while (true)
            {
                int[] arr = { count, count + 1 };
                if (nums[count] + nums[count + 1] != target)
                {
                    count++;
                }
                if (nums[count] + nums[count + 1] == target)
                {
                    return arr;
                }

            }
        }
        //Very unclear instructions to solve needs work
        public static string GenerateTheString(int n)
        {
            string test = "";
            Random a = new Random();
            string c = "c";
            string b = "b";
            for (int i = 0; i < n; i++)
            {
                if (n % 2 == 0)
                {
                    test = test + c;
                }
                if (a.Next(2) == 1 && n % 2 == 1)
                {
                    test = test + b;
                }
                else if (a.Next(3) == 2 && n % 2 == 1)
                {
                    test = test + c;
                }

                //if (a.Next(2) == 1)
                //{
                //    test = test + c;
                //}
                //else
                //    test = test + b;
            }
            return test;
            //https://leetcode.com/contest/weekly-contest-179/problems/generate-a-string-with-characters-that-have-odd-counts/ 
        }

        //Reverse integers
        //Keep in mind negative numbers from -2^32 -> 2^32
        //Do some math

        public static int Reverseint(int x)
        {
            List<int> arr = new List<int> { };
            while (x>0)
            {
                int temp = x % 10;
                arr.Add(temp);
                x = x / 10;
            }
            x = 0;
            for (int i = 0; i < arr.Count; i++)
            {


            }
            return x;


            //https://leetcode.com/problems/reverse-integer/
        }

    }
}
