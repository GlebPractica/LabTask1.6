using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_23
{
    public class SequenceBuilder
    {
        public string BuildSequence()
        {
            StringBuilder sequence = new StringBuilder();

            for (int i = 9; i >= 1; i--)
            {
                sequence.Append(i);
                sequence.Append("87" + " ");
            }

            for (int i = 1; i < 210; i += 11)
            {
                sequence.Append(i + " ");
                if (i + 11 > 209)
                    sequence.Append(211);
            }

            return sequence.ToString();
        }
    }
}
