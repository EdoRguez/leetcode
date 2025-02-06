using System;

namespace leetcode
{
    public class program
    {
        public static void Main()
        {
            int[] answer = new int[nums.Length];

            int leftProduct = 1;
            for (int i = 0; i < nums.Length; i++) {
                answer[i] = leftProduct;
                leftProduct *= nums[i];
            }

            // Compute right products and multiply with left products
            int rightProduct = 1;
            for (int i = nums.Length - 1; i >= 0; i--) {
                answer[i] *= rightProduct;
                rightProduct *= nums[i];
            }

            return answer;
        }
    }
}