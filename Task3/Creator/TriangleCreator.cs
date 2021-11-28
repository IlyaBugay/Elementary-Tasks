using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class TriangleCreator : IFigureCreator
    {
        #region Properties

        public string Name { get; set; }

        private double[] _sides = new double[3];

        #endregion

        #region Ctor

        public TriangleCreator(string name, double firstSide, double secondSide, double thirdSide)
        {
            Name = name;
            _sides[0] = firstSide;
            _sides[1] = secondSide;
            _sides[2] = thirdSide;
        }

        #endregion

        public IFigure Create()
        {
            return new Triangle(Name, _sides[0], _sides[1], _sides[2]);
        }
    }
}
