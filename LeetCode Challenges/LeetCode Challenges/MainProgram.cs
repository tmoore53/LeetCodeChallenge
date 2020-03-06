using System;
using System.Collections;

namespace LeetCode_Challenges
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] test1 = { 3,2,4 };//Test array
            foreach(int i in TS.TwoSum(test1,6))//This is to display each index in the array that had values that added up to the target value.
            {
                Console.WriteLine(i);//
            }
            Console.WriteLine(TS.TwoSum(test1,6));//To show the value/datatype returned.

           
        }

 
    }
}
