using System;

namespace Codecool.Geometry.Shapes
{
    /// <summary>
    ///     Regular Pentagon implementation class
    /// </summary>
    public class RegularPentagon : Shape
    {

        private double _side;
        private static string _areaFormula = "(Math.Sqrt(25 + 10 * Math.Sqrt(5))) / 4 * Math.Pow(a, 2)";
        private static string _perimeterFormula = "5 * a";
        private double _area;
        private double _perimeter;


        public RegularPentagon(double side)
        {
            _side = side;
            _area = (Math.Sqrt(25 + 10 * Math.Sqrt(5))) / 4 * Math.Pow(_side, 2);
            _perimeter = 5 * _side;
        }

        /// <summary>
        ///     Gets formula for the area of the pentagon as a string.
        /// </summary>
        public new static string AreaFormula => _areaFormula;

        /// <summary>
        ///     Gets formula for the perimeter of the pentagon as a string.
        /// </summary>
        public new static string PerimeterFormula => _perimeterFormula;

        /// <inheritdoc/>
        public override double Area => _area;

        /// <inheritdoc/>
        public override double Perimeter => _perimeter;

        public override string ToString()
        {
            return $"Regular Pentagon: The sides are {_side} cm, the area is {_area} cm2, the perimeter is {_perimeter} cm";
        }
    }
}
