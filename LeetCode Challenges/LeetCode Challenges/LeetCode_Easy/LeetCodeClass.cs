using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode_Challenges
{
    class Leet
    {
        // Roman numeral Convertion

        public static int RomanToInt(string s)
        {
            /*Symbol       Value
            I             1
            V             5
            X             10
            L             50
            C             100
            D             500
            M             1000*/
            int output = 0;
            int valueR = 0;
            int temp = 0;
            #region For Loop
            for (int i = (s.Length - 1); i >= 0 ; i--)
            {
                #region Logic 2
                if (s[i] == 'I')
                    valueR = 1;
                else if (s[i] == 'V')
                    valueR = 5;
                else if (s[i] == 'X')
                    valueR = 10;
                else if (s[i] == 'L')
                    valueR = 50;
                else if (s[i] == 'C')
                    valueR = 100;
                else if (s[i] == 'D')
                    valueR = 500;
                else if (s[i] == 'M')
                    valueR = 1000;
                #endregion
                if (valueR < temp)
                {
                    output -= (valueR);
                    temp = valueR;
                }
                else
                {
                    output += valueR;
                    temp = valueR;
                }
            }
            #endregion
            return output;
            /*Runtime: 96 ms, faster than 37.86% of C# online submissions for Roman to Integer.
            Memory Usage: 25.6 MB, less than 8.70% of C# online submissions for Roman to Integer.*/

            //https://leetcode.com/problems/roman-to-integer/submissions/
        }
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
        //Very unclear instructions to solve needs work.
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

        //Reverse integers.
        public static int Reverseint(int x)
        {
            int y = 0;
            int temp;
            if (x < 0)
            {
                x = x *(-1);
                while (x != 0)
                {
                    temp = x % 10;
                    y = (y * 10) + temp;
                    x = x / 10;
                }
                y = y * (-1);
            }
            else if (x > 0)
            {
                while (x != 0)
                {
                    temp = x % 10;
                    y = (y * 10) + temp;
                    x = x / 10;
                }
            }

            return y;
        }

        //Identifies the number that doesn't repeat in a array.
        public static void Repeating(int[] arR)
        {

            int res = 0;
            foreach (int n in arR)
            {
                res ^= n;
            }
            Console.WriteLine("The number that does not repeat in the array is {0}", res);
        }

        //Identifies a integer if it is a Palindrome with a boolean value.
        public static bool IsPalindrome(int x)
        {
            int[] arr = new int[x.ToString().Length];
            int temp = 0;
            if (x < 0)
            {
                return false;
            }
            else if (x.ToString().Length == 1)
            {
                return true;
            }
            else
            {
                while (x > 0)
                {
                    arr[temp] = (x % 10);
                    x = x / 10;
                    temp++;
                }
            }
            for (int i = 0, j = arr.Length -1; i < (arr.Length/2); i++, j--)
            {
                    if (arr[i] == arr[j])
                    {
                        continue;
                    }
                    else 
                    return false;
            }
            return true;
            /* Runtime: 68 ms, faster than 54.01% of C# online submissions for Palindrome Number.
            Memory Usage: 17.8 MB, less than 5.00% of C# online submissions for Palindrome Number.*/
            //Reference: https://leetcode.com/problems/palindrome-number/ 
        }

        //This method returns a desired array when you enter an array of integer values, 
        //and another array of indexes you want the first array values to be in. 
        public static int[] CreateTargetArray(int[] nums, int[] index)
        {
            //New array to put values in the correct index
            int[] targetArr = new int[nums.Length];
            //iterrate through the array parameters
            for (int i = 0; i < nums.Length; i++)
            {
                //Move the index to the right
                    for (int j = targetArr.Length; j - 1 > index[i]; j--)
                    {
                        targetArr[j - 1] = targetArr[j - 2];
                    }
                //Set the desired index to the nums value.
                targetArr[index[i]] = nums[i];
            }
            //0,4,1,3,2
            //
            //0,1,2,3,4
            //
            //1,3,3
            return targetArr;
        }
    }
}
