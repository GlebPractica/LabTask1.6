using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task3_3
{
    public class WordCounter
    {
        public int CountWords(string input)
        {
            string pattern = @"\b([а-яА-Я])\w*\1\b";

            MatchCollection matches = Regex.Matches(input, pattern);

            return matches.Count;
        }
    }
}
