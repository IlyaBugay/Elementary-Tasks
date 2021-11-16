using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class SequenceGenerator
    {
        public static string GetSequence(int length, int minSquare)
        {
            StringBuilder result = new StringBuilder();
            int firstNum = (int)Math.Ceiling(Math.Sqrt(minSquare));

            if (length > 0)
            {
                for (int i = 0; i < length; i++, firstNum++)
                {
                    if (i == length - 1)
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
