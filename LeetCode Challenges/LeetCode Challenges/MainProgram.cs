﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace LeetCode_Challenges
{
    class Program
    {
        static void Main(string[] args)
        {


            //int[] test = { 2, 2, 4 };//Test array
            //int[] test1 = { 3,2,4 };//Test array

            //List<int> test2 = new List<int> () { 1, 2, 4, 4 };
            //List<int> test3 = new List<int>() { 2, 3, 3, 4 };

            //int test4 = 121;

            //Console.WriteLine(   TS.IsPalindrome(test4));

            //Day4Personclass tyler = new Day4Personclass(-1);
            //tyler.yearPasses();
            //tyler.yearPasses();
            //tyler.yearPasses();
            //Console.WriteLine(tyler.age);
            //tyler.amIOld();

            ////HackerRnkClass.Day4forloop();

            //string strtest = "Hacker";
            //string strtest1 = "Rank";


            //HackerRnkClass.Day6SepStrIndex(strtest);
            //HackerRnkClass.Day6SepStrIndex(strtest1);

            //HackerRnkClass.ReverseArr(test);

            //HackerRnkClass.Day8Dictionary();

            int[] testing = new int[] { 0, 1, 2, 3, 4 };
            int[] index = new int[] { 0, 1, 2, 2, 1 };
            

            int[] test2 = new int[] { 1, 2, 3, 4, 0 };
            int[] index2 = new int[] { 0, 1, 2, 3, 0 };

            int[] test3 = new int[] { 3, 3, 1 };
            int[] index3 = new int[] { 0, 0, 0 };

            int[] tester = TS.CreateTargetArray(testing, index);
            int[] tester2 = TS.CreateTargetArray(test2, index2);
            int[] tester3 = TS.CreateTargetArray(test3, index3);

            foreach (int testout in tester)
            {
                Console.Write(testout);
            }
            Console.WriteLine();
            foreach (int testout in tester2)
            {
                Console.Write(testout);
            }
            Console.WriteLine();
            foreach (int testout in tester3)
            {
                Console.Write(testout);
            }

            //Console.WriteLine(TS.Reverseint(test4));

            //Console.WriteLine(   TS.GenerateTheString(4));

            //foreach (int i in MTSN.ReverseArr(test1))//This is to display each index in the array that had values that added up to the target value.
            //{
            //    Console.WriteLine(i);//
            //}

            //foreach (int i in MTSN.CompareThrees(test2, test3))//This is to display each index in the array that had values that added up to the target value.
            //{
            //    Console.WriteLine(i);//
            //}

            //Console.WriteLine(MTSN.CompareThrees(test2, test3));

        }

 
    }
}
