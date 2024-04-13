using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_23
{
    public class StringTransformer
    {
        Dictionary<char, int> lastOccurrences = new Dictionary<char, int>();

        public string TransformWords(string input)
        {
            string[] words = input.Split(new char[] { ' ', ',', '.', ':', ';', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            List<string> transformedWords = new List<string>();
            foreach (string word in words)
            {
                transformedWords.Add(TransformWord(word));
            }

            string result = string.Join(" ", transformedWords);

            return result;
        }

        private string TransformWord(string word)
        {
            lastOccurrences.Clear();

            for (int i = word.Length - 1; i >= 0; i--)
            {
                char currentChar = word[i];
                if (!lastOccurrences.ContainsKey(currentChar))
                {
                    lastOccurrences[currentChar] = i;
                }
            }

            IEnumerable<char> transformedWord = lastOccurrences.OrderBy(kv => kv.Value).Select(kv => kv.Key);
            return new string(transformedWord.ToArray());
        }
    }
}
