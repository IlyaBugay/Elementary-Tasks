using System;

namespace Task1
{
    class UserInterface
    {
        const string widthMessage = "width: ";
        const string heightMessage = "height: ";

        public static void SetChessBoardParameters(Board point)
        {
            point.Row = Controller.ValidateInputIntegervalue($"{widthMessage}");
            point.Column = Controller.ValidateInputIntegervalue($"{heightMessage}");
        }

        public static void DisplayChessBoard(Board point)
        {
            for (int i = 0; i < point.Row; i++)
            {
                for (int j = 0; j < point.Column; j++)
                {
                    if ((i + j) % 2 != 0)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
