using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Point
    {
        private int x;
        private int y;

        public int X
        {
            get 
            {
                return x; 
            }
            set 
            {
                if (value <= 0)
                {
                    Console.WriteLine("Error! Input positive value");
                }

                x = value; 
            }
        }

        public int Y
        {
            get 
            {
                return y; 
            }
            set 
            {
                if (value <= 0)
                {
                    Console.WriteLine("Error! Input positive value");
                }

                y = value; 
            }
        }
    }
}
