using System;

namespace leetcode
{
    public class program
    {
        public static void Main()
        {
            if(nums.Length < 3) return false;

        int smallest = int.MaxValue;
        int secondSmallest = int.MaxValue;

        for(int idx = 0; idx < nums.Length; idx++)
        {
            if(nums[idx] <= smallest)
                smallest = nums[idx];
            else if(nums[idx] <= secondSmallest)
                secondSmallest = nums[idx];
            else
                return true;
        }

        return false;
        }
    }
}