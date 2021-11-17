using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class SequenceGenerator
    {
        public static string GetSequence(Sequence sequence)
        {
            StringBuilder result = new StringBuilder();
            int firstNum = (int)Math.Ceiling(Math.Sqrt(sequence.MinimalSquare));
            if (sequence.SequenceLength > 0)
            {
                for (int i = 0; i < sequence.SequenceLength; i++, firstNum++)
                {
                    if (i == sequence.SequenceLength - 1)
                    {
                        result.Append(firstNum);
                    }
                    else
                    {
                        result.Append(firstNum).Append(", ");
                    }
                }
            }
            return result.ToString().Trim();
        }
    }
}
