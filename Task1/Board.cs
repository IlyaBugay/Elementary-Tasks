using System;

namespace Task1
{
    class Board
    {
        private int row;
        private int column;

        public int Row
        {
            get 
            {
                return row; 
            }
            set 
            {
                if (value <= 0)
                {
                    Console.WriteLine("Error! Input positive value");
                }

                row = value; 
            }
        }
        
        public int Column
        {
            get 
            {
                return column; 
            }
            set 
            {
                if (value <= 0)
                {
                    Console.WriteLine("Error! Input positive value");
                }

                column = value; 
            }
        }
    }
}
