using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class ExecuteProgram
    {
        public static void ExecuteApp()
        {
            Board point = new Board();
            UserInterface.SetChessBoardParameters(point);
            UserInterface.DisplayChessBoard(point);
        }
    }
}
