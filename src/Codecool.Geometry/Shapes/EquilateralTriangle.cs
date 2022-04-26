using System;

namespace Codecool.Geometry.Shapes
{
    /// <summary>
    ///     Equilateral Triangle implementation class
    /// </summary>
    public class EquilateralTriangle : Triangle
    {

        private double _side;
        private static string _areaFormula = "Math.Pow(a, 2) * Math.Sqrt(0.75)";
        private static string _perimeterFormula = "3 * a";
        
        public EquilateralTriangle(double side) : base(side, side, side)
        {
            _side = side;
            _area = Math.Pow(_side, 2) * Math.Sqrt(0.75);
            _perimeter = 3 * _side;
        }

        /// <summary>
        ///     Gets formula for the area of the triangle as a string.
        /// </summary>
        public new static string AreaFormula => _areaFormula;

        /// <summary>
        ///     Gets formula for the perimeter of the triangle as a string.
        /// </summary>
        public new static string PerimeterFormula => _perimeterFormula;

        public override string ToString()
        {
            return $"Equilateral Triangle: The sides are {_side} cm, the area is {_area} cm2, the perimeter is {_perimeter} cm";
        }
    }
}
