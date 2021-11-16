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
                Console.WriteLine("Error! Please, input a numeric value");
                return false;
            }

            if (numericValue < 0)
            {
                Console.WriteLine("Error! Please, input a positive value");
            }

            return numericValue >= 0;
        }
    }
}
