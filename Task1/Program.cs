using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void DisplayChessBoard(Point point)
        {
            for (int i = 0; i < point.X; i++)
            {
                for (int j = 0; j < point.Y; j++)
                {
                    if ((i + j) % 2 != 0)
                    {
                        Console.WriteLine(" ");
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }
                Console.WriteLine();
            }
        }

        static int InputIntegervalue(string message)
        {
            bool isvalidInput;
            int result;
            do
            {
                Console.WriteLine("Enter {0}", message);
                isvalidInput = int.TryParse(Console.ReadLine(), out result);

                if (!isvalidInput)
                {
                    Console.WriteLine("Error format!");
                }
            } while (!isvalidInput);

            return result;
        }

        static void SetChessBoardParameters(Point point)
        {
            point.X = InputIntegervalue("width: ");
            point.Y = InputIntegervalue("height: ");
        }

        static void Main(string[] args)
        {

        }
    }
}
