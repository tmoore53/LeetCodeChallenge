using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode_Challenges.CodeWars
{
    public static class CodeWar
    {
        public static int IQTest(string numbers)
        {
            numbers.Split();
            foreach (var item in numbers)
            {
                Console.Write(item);
            }
            return 0;

            //Reference: https://www.codewars.com/kata/552c028c030765286c00007d/train/csharp
        }
    }
}
