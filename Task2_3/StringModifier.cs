using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_3
{
    public class StringModifier
    {
        public string RemoveFirstAndLastOccurrence(string input, char character)
        {
            int firstIndex = input.IndexOf(character);
            int lastIndex = input.LastIndexOf(character);

            if (firstIndex == -1 || lastIndex == -1)
            {
                return input;
            }

            string result = "";

            if (firstIndex != lastIndex)
            {
                // Удаление первого и последнего вхождения символа
                result = input.Remove(lastIndex, 1).Remove(firstIndex, 1);
            }
            else
            {
                // Удаление единственного вхождения символа
                result = input.Remove(firstIndex, 1);
            }

            return result;
        }
    }
}
