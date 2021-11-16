using System;

namespace Task1
{
    class Controller
    {
        public static int ValidateInputIntegervalue(string message)
        {
            #region Tryparse
            //bool isValidInput;
            //int outputNumber;
            //do
            //{
            //    Console.WriteLine($"Enter {message}");
            //    isValidInput = int.TryParse(Console.ReadLine(), out outputNumber);//TODO: think about exeption..

            //    if (!isValidInput)
            //    {
            //        Console.WriteLine("Error format!");
            //    }
            //} while (!isValidInput);

            //return outputNumber;
            #endregion

            #region Try/Catch
            bool isValidInput = false;
            int outputNumber = 0;
            while (!isValidInput)
            {
                try
                {
                    Console.Write($"{Messages.enterMessage} {message}");
                    outputNumber = int.Parse(Console.ReadLine());
                    isValidInput = true;
                }
                catch
                {
                    Console.WriteLine($"{Messages.errorFormatMessage}");
                }
            }
            
            return outputNumber;
            #endregion
        }
    }
}
