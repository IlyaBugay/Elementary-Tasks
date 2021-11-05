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

        static void Main(string[] args)
        {

        }
    }
}
