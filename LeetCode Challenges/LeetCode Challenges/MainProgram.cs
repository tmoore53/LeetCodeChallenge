﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace LeetCode_Challenges
{
    class Program
    {
        static void Main(string[] args)
        {


            int[] test = { 2, 2, 4 };//Test array
            int[] test1 = { 3,2,4 };//Test array

            List<int> test2 = new List<int> () { 1, 2, 4, 4 };
            List<int> test3 = new List<int>() { 2, 3, 3, 4 };
            //foreach(int i in TS.TwoSum(test1,6))//This is to display each index in the array that had values that added up to the target value.
            //{
            //    Console.WriteLine(i);//
            //}
            //Console.WriteLine(TS.TwoSum(test1,6));//To show the value/datatype returned.

            foreach (int i in MTSN.CompareThrees(test2, test3))//This is to display each index in the array that had values that added up to the target value.
            {
                Console.WriteLine(i);//
            }

            Console.WriteLine(MTSN.CompareThrees(test2, test3));

        }

 
    }
}
