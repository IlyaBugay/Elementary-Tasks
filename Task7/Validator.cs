using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class Validator
    {
        public static int ValidateInputValue(string message)
        {
            #region TryParse
            //bool isvalidInput;
            //int outputNumber;
            //do
            //{
            //    Console.Write($"{enterMessage} {message}");
            //    isvalidInput = int.TryParse(Console.ReadLine(), out outputNumber);

            //    if (!isvalidInput)
            //    {
            //        Console.WriteLine($"{errorFormatMess}");
            //    }
            //} while (!isvalidInput);
            //return outputNumber;
            #endregion

            #region try/catch
            bool isvalidInput = false;
            int numericValue = 0;
            while (!isvalidInput)
            {
                try
                {
                    Console.Write($"{message}");
                    numericValue = int.Parse(Console.ReadLine());
                    isvalidInput = true;
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(Messages.NUMERIC_VALUE_ERROR);
                    Console.ResetColor();
                }

                if (numericValue < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(Messages.POSITIVE_VALUE_ERROR);
                    Console.ResetColor();
                    isvalidInput = false;
                }
            }
            return numericValue;
            #endregion
        }
    }
}
