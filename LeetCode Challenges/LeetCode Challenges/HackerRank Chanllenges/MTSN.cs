using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode_Challenges
{
    class MTSN
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

    }

}
