using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode_Challenges
{
    class MTSN
    {
        /*This methods compares the index of two arrays and counts the number 
         * of times each array has a larger number than the other array.*/
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
            return output.ToArray();
        }

    }

    class Person
    {
        public int age;
        public Person(int initialAge)
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

            // Add some more code to run some checks on initialAge
        }
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
            // Do some computations in here and print out the correct statement to the console 
        }

        public void yearPasses()
        {
            // Increment the age of the person in here
            age += 1;
        }
    }

}
