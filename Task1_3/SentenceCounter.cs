using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task1_3
{
    public class SentenceCounter
    {
        public int CountSentences(string input)
        {
            string pattern = @"[.!?]+";

            string[] sentences = Regex.Split(input, pattern);

            return sentences.Length - 1; // -1 для исключения последнего элемента, который будет пустой строкой
        }
    }
}
