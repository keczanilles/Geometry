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
            _area = Math.Pow(side, 2) * Math.Sqrt(0.75);
            _perimeter = 3 * side;
        }

        /// <summary>
        ///     Gets formula for the area of the triangle as a string.
        /// </summary>
        public new static string AreaFormula => _areaFormula;

        /// <summary>
        ///     Gets formula for the perimeter of the triangle as a string.
        /// </summary>
        public new static string PerimeterFormula => _perimeterFormula;
    }
}
