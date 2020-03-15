﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode_Challenges
{
    /*This methods compares the index of two arrays and counts the number 
         * of times each array has a larger number than the other array.*/
    class HackerRnkClass
    {
        public static List<int> CompareThrees(List<int> a, List<int> b)
        {
            List<int> count = new List<int>() { 0, 0};
            for(int i = 0; i< a.Count; i++)
            {
                
                if (a[i] == b[i])
                {
                    continue;
                }
                else if (a[i] > b[i])
                {
                    count[0] = count[0] + 1;
                }
                else if (a[i] < b[i])
                {
                    count[1] = count[1] + 1;
                }
            }
            return count;
        }

        //Reverse array

        public static int[] ReverseArr(int[] a)
        {
            List<int> output = new List<int> { };
            for (int i = 0, j = a.Length -1 ; i < a.Length ; i++, j--)
            {
                output.Add(a[j]);
            }
            //Day6 Array Challange.
            int n = a.Length;
            while (n >= 1)
            {
                Console.Write(a[--n] + "");
            }
            return output.ToArray();

        }



        //This method requests an integer input and iterates it through a for loop.
        public static void Day5forloop()
        {
            Console.WriteLine("Please enter a number to iterate by:");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", n, i, n * i);
            }


        }

        //Sum of all integers in a array.
        public static int simpleArraySum(int[] ar)
        {

            int x = 0;
            foreach (int item in ar)
            {
                x = x + item;
            }
            return x;
            /*
             * Write your code here.
             */

        }

        public static void Day6(string str)
        {
            string odd = "";
            string even = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (i%2 == 0)
                {
                    even = even + str[i];
                }
                else if(i%2 != 0 )
                {
                    odd = odd + str[i];
                }
                
            }
            Console.WriteLine(even + " " + odd);

            //The results are the same but do not match the request.
            //Reference: https://www.hackerrank.com/challenges/30-review-loop/problem
        }

    }

    //This person class is for the Day 3 Challenge of 30 Days of code.
    class Day4Personclass
    {
        public int age;
        //Constructor to set the age of a person.
        public Day4Personclass(int initialAge)
        {
            if (initialAge < 0)
            {
                age = 0;
                Console.WriteLine("Age is not valid, setting age to {0}", age);
            }
            else
            {
                age = initialAge;
            }
        }
        //This method informs the user the characteristics of the person by age.
        public void amIOld()
        {
            if (age < 13)
            {
                Console.WriteLine("You are young.");
            }
            else if (age >= 13 && age < 18)
            {
                Console.WriteLine("You are a teenager.");
            }
            else
                Console.WriteLine("You are old.");
            // Do some computations in here and print out the correct statement to the console. 
        }
        //This method increments the age of a person by one year.
        public void yearPasses()
        {
            // Increment the age of the person in here.
            age += 1;
        }
    }

}
