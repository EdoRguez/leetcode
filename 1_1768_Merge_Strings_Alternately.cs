using System;
using System.Text;

namespace leetcode
{
    public class program
    {
        public static void Main()
        {
            string word1 = "ab";
            string word2 = "pqrs";

            StringBuilder res = new StringBuilder();

            int idx = 0;
            while(res.Length != word1.Length + word2.Length)
            {
                if(idx < word1.Length)
                    res.Append(word1[idx]);

                if(idx < word2.Length)
                    res.Append(word2[idx]);

                idx++;
            }

            Console.WriteLine(res.ToString());
        }
    }
}