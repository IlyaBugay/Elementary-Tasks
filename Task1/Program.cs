using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Task 1";
            Board point = new Board();
            UserInterface.SetChessBoardParameters(point);
            UserInterface.DisplayChessBoard(point);
            Console.ReadKey();
        }
    }
}
