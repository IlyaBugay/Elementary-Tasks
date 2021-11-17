using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class Validator
    {
        public static bool IsValid(string strValue)
        {
            int numericValue;

            try
            {
                numericValue = int.Parse(strValue);
            }
            catch
            {
                Console.WriteLine(Messages.NUMERIC_VALUE_ERROR);
                return false;
            }

            if (numericValue < 0)
            {
                Console.WriteLine(Messages.POSITIVE_VALUE_ERROR);
            }

            return numericValue >= 0;
        }
    }
}
