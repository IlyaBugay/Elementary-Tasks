using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public abstract class FigureParser
    {
        protected string[] Arguments { get; set; }

        public FigureParser(string args)
        {
            Arguments = args.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        }

        protected bool IsCorrectArgs()
        {
            return Arguments.Length == Message.SIDES_NUMBER + 1;
        }

        public virtual string GetName()
        {
            if (Arguments.Length > 0)
            {
                return Arguments[0];
            }
            throw new ArgumentException(Message.WRONG_NUMBER_OF_ARGS);
        }

        public virtual double[] GetSides()
        {
            double[] sides = new double[Arguments.Length - 1];
            for (int i = 0; i < sides.Length; i++)
            {
                Arguments[i + 1] = Arguments[i + 1].Replace(".", ",");
                if (!double.TryParse(Arguments[i + 1], out sides[i]))
                {
                    throw new FormatException(Message.INCORRECT_INPUT);
                }
                if (sides[i] <= 0)
                {
                    throw new ArgumentOutOfRangeException(sides[i].ToString(), Message.NEGATIVE_NUMBER_ERROR);
                }
            }

            return sides;
        }

        public abstract IFigureCreator TryParse();
    }
}
