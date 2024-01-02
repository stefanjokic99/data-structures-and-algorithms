using System.Text;
using System.Text.RegularExpressions;

namespace data_structures_and_algorithms.DS_Array
{
    public static class StringHelper
    {
        public static string ReverseString(string input)
        {
            var reverseString = new StringBuilder("");

            for (int i = 0; i < input.Length; i++) 
            {
                reverseString.Append(input[input.Length - i - 1]);
            }

            return reverseString.ToString();
        }

        public static string LongestWord(string statement) 
        {
            string[] words = Regex.Replace(statement, @"[^\w\s]", "").Split(" ");

            var longestWord = words[0];
            for (int i = 1; i < words.Length; i++) 
            {
                if (words[i].Length > longestWord.Length)
                { 
                    longestWord = words[i]; 
                }
                
            }

            return longestWord;

        }
    }
}
