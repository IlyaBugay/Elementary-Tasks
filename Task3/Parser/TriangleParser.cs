using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class TriangleParser : FigureParser
    {
        public TriangleParser(string args) : base(args)
        {

        }

        public override IFigureCreator TryParse()
        {
            if (!IsCorrectArgs())
            {
                throw new ArgumentException(Message.WRONG_NUMBER_OF_ARGS);
            }

            double[] sides = GetSides();
            string name = GetName();

            if (!Triangle.IsTriangleExist(sides[0], sides[1], sides[2]))
            {
                throw new ArgumentException(Message.NOT_EXIST);
            }

            return new TriangleCreator(name, sides[0], sides[1], sides[2]);
        }
    }
}
