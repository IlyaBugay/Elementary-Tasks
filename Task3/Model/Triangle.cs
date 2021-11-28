using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Triangle : IFigure
    {
        #region ========== Properties ==========
        public string Name { get; set; }
        private double[] _sides = new double[3];

        public double Square
        {
            get
            {
                double halfPerimeter = _sides.Sum() / 2.0;

                double productOfHalfPerimeterSidesDiff = 1;
                foreach (var side in _sides)
                {
                    productOfHalfPerimeterSidesDiff *= halfPerimeter - side;
                }

                double squareRes = Math.Sqrt(halfPerimeter * productOfHalfPerimeterSidesDiff);

                return squareRes;
            }
        }
        #endregion

        #region Constructor
        public Triangle(string name, double firstSide, double secondSide, double thirdSide)
        {
            Name = name;
            _sides[0] = firstSide;
            _sides[1] = secondSide;
            _sides[2] = thirdSide;
        }
        #endregion

        public static bool IsTriangleExist(double firstSide, double secondSide, double thirdSide)
        {
            bool isExist = (firstSide + secondSide > thirdSide &&
                firstSide + thirdSide > secondSide && secondSide + thirdSide > firstSide);
            return isExist;
        }

        public override string ToString()
        {
            return string.Format($"[{Name}]: {Square} cm");
        }
    }
}
