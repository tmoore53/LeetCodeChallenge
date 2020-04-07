using System;
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
                Console.WriteLine(a[--n] + "");
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

        //Seperates the even indexes and odds in a string.
        public static void Day6SepStrIndex(string str)
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

        //Creates a phonebook with user input.
        public static void Day8Dictionary()
        {
            Console.WriteLine("How many names do you want to add?");
            //Input the amount of names to put into a dictionary.
            int n = Convert.ToInt32(Console.ReadLine());
            //Create a dictionary name phoneBook.
            Dictionary<string, int> phoneBook = new Dictionary<string, int>(n);
            Console.WriteLine($"Enter Name and phone number {n} times.");
            //For each desired entry input a name and valid number seperated by a space " ".
            for (int i = 0; i < n; i++)
            {
                //Initialize a array of strings and split the name and phone number entry.
                string[] temp = Console.ReadLine().Split(' ');
                if (temp[1].Length == 7)
                {
                    //Add the two strings in the array into the dictionary. 
                    phoneBook.Add(temp[0], Convert.ToInt32(temp[1]));
                }
            }
            //Initialize a string variable.
            string nameToSearch = "";
            Console.WriteLine("Search for a name in the phone book.");
            //
            while ((nameToSearch = Console.ReadLine()) != null)
            {
                int flagFound = 0;
                if (nameToSearch != "")
                {
                    if (phoneBook.ContainsKey(nameToSearch))
                    {
                        flagFound = 1;
                    }
                }
                if (flagFound == 1)
                {
                    // Output the key and the value of phone book if the name exists.  
                    Console.WriteLine(nameToSearch + "=" + phoneBook[nameToSearch]);
                }
                // If the user doesn't input anything then and hits enter exit the program. 
                else if (nameToSearch == "")
                {
                    break;
                }
                //If the user doesn't input the correct name then it displays a message.
                else
                {
                    Console.WriteLine("Not found");
                }
            }
        }

        public static int Day9MYRecursion(int n)
        {
            if (n <= 1)
                return 1;
            else
                return n * Day9MYRecursion(n - 1);
        }

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


