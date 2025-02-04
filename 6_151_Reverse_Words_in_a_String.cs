using System;

namespace leetcode
{
    public class program
    {
        public static void Main()
        {
            string s = "a good   example";

		string res = string.Empty;
		var splitStr = s.Trim().Split(' ');

		for(int i = splitStr.Length - 1; i >= 0; i--)
		{
			if(!String.IsNullOrEmpty(splitStr[i]) && !String.IsNullOrWhiteSpace(splitStr[i])) res += splitStr[i] + " ";
		}

		Console.WriteLine(res.Trim());
        }
    }
}