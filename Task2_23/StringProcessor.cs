using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task2_23
{
    public class StringProcessor
    {
        private bool IsPalindrome(string word)
        {
            int length = word.Length;
            for (int i = 0; i < length / 2; i++)
            {
                if (word[i] != word[length - i - 1])
                {
                    return false;
                }
            }
            return true;
        }

        public string RemovePalindromes(string input)
        {
            string[] words = input.Split(',');

            Regex pattern = new Regex("[^a-zA-Z]+");

            string result = string.Join(",", words.Where(word => !IsPalindrome(pattern.Replace(word.Trim(), ""))));

            return result + ".";
        }
    }
}
