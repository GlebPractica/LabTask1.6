using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_3
{
    public class StringGenerator
    {
        public string GenerateAlternatingString(int N, char C1, char C2)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < N; i++)
            {
                result.Append(i % 2 == 0 ? C1 : C2);
            }

            return result.ToString();
        }
    }
}
