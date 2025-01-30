using System;

namespace leetcode
{
    public class program
    {
        public static void Main()
        {
            string s = "leetcode";

            string vowels = "aeiouAEIOU";

            Stack sVowels = new Stack();

            foreach(var item in s)
            {
                if(vowels.Contains(item)) sVowels.Push(item);
            }

            StringBuilder sb = new StringBuilder(s);

            for(int i = 0; i < s.Length; i++)
            {
                if(vowels.Contains(sb[i]))
                {
                    sb[i] = (char)sVowels.Pop();
                }
            }

            Console.WriteLine(sb.ToString());
        }
    }
}