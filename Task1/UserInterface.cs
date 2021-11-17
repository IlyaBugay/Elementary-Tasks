using System;

namespace Task1
{
    class UserInterface
    {
        public static void SetChessBoardParameters(Board point)
        {
            point.Row = Controller.ValidateInputIntegerValue($"{Messages.INPUT_WIDTH_MESSAGE}");
            point.Column = Controller.ValidateInputIntegerValue($"{Messages.INPUT_HEIGHT_MESSAGE}");
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
