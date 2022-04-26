using System;

namespace Codecool.Geometry.Shapes
{
    /// <summary>
    ///     Triangle implementation class
    /// </summary>
    public class Triangle : Shape
    {

        private double _a;
        private double _b;
        private double _c;
        private double _height;
        private static string _areaFormula = "0.5 * b * height";
        private static string _perimeterFormula = "a + b + c";
        public double _area;
        public double _perimeter;

        public Triangle(double a, double b, double c)
        {
            _a = a;
            _b = b;
            _c = c;
            _height = Math.Sqrt((a + b + c) * (-a + b + c) * (a - b + c) * (a + b - c)) / (2 * c);
            _area = 0.5 * b * _height;
            _perimeter = a + b + c;
        }

        /// <summary>
        ///     Gets formula for the area of the triangle as a string.
        /// </summary>
        public new static string AreaFormula => _areaFormula;

        /// <summary>
        ///     Gets formula for the perimeter of the triangle as a string.
        /// </summary>
        public new static string PerimeterFormula => _perimeterFormula;

        /// <inheritdoc/>
        public override double Perimeter => _area;

        /// <inheritdoc />
        public override double Area => _perimeter;

        public override string ToString()
        {
            return $"Triangle: The 'a' side is {_a} cm, the 'b' side is {_b} cm, the 'c' side is {_c} cm, the area is {_area} cm2, the perimeter is {_perimeter} cm";
        }
    }
}
