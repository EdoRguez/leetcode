using System;
using System.Text;

namespace leetcode
{
    public class program
    {
        public static void Main()
        {
            List<bool> res = new List<bool>();

            int maxNumber = candies.Max();

            foreach(var item in candies)
            {
                bool val = item + extraCandies >= maxNumber;
                res.Add(val);
            }

            return res.ToArray();
        }
    }
}