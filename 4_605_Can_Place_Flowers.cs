using System;

namespace leetcode
{
    public class program
    {
        public static void Main()
        {
            int[] flowerbed = {0,0,0,0,0,1,0,0};
            int n = 1;

            int counter = 0;

            for(int i = 0; i < flowerbed.Length; i++)
            {
                int left = i - 1;
                int right = i + 1;

                if(counter == n)
                {
                    break;
                }

                if(left == -1 && right == flowerbed.Length)
                {
                    if(flowerbed[i] == 0)
                    {
                        counter++;
                        flowerbed[i] = 1;
                    }
                }
                else if(left == -1)
                {
                    if(flowerbed[right] != 1 && flowerbed[i] == 0)
                    {
                        counter++;
                        flowerbed[i] = 1;
                    }
                }
                else if(right == flowerbed.Length)
                {
                    if(flowerbed[left] != 1 && flowerbed[i] == 0)
                    {
                        counter++;
                        flowerbed[i] = 1;
                    }
                }
                else
                {
                    if(flowerbed[left] != 1 && flowerbed[right] != 1 && flowerbed[i] == 0)
                    {
                        counter++;
                        flowerbed[i] = 1;
                    }
                }
            }

            Console.WriteLine(counter == n);
        }
    }
}