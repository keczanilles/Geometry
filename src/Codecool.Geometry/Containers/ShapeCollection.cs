using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Codecool.Geometry.Shapes;

namespace Codecool.Geometry.Containers
{
    /// <summary>
    ///     Shape Collection class
    /// </summary>
    public class ShapeCollection
    {
        public List<Shape> shapes { get; set; }

        public ShapeCollection()
        {
            shapes = new List<Shape>();
        }

        public void AddShape()
        {
            Console.WriteLine("Please choose your shape:");
            Console.WriteLine("1. Circle");
            Console.WriteLine("2. Equilateral Triangle");
            Console.WriteLine("3. Rectangle");
            Console.WriteLine("4. Regular Pentagon");
            Console.WriteLine("5. Square");
            Console.WriteLine("6. Triangle");

            int input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case 1:
                    Console.WriteLine("Please give a radius number:");
                    string radius = Console.ReadLine();
                    var circle = new Circle(double.Parse(radius));
                    shapes.Add(circle);
                    break;
                case 2:
                    Console.WriteLine("Please give a side length:");
                    string eqSideLength = Console.ReadLine();
                    var equilateralTriangle = new EquilateralTriangle(double.Parse(eqSideLength));
                    shapes.Add(equilateralTriangle);
                    break;
                case 3:
                    Console.WriteLine("Please give the length of side 'a': ");
                    string aSide = Console.ReadLine();
                    Console.WriteLine("Please give the length of side 'b': ");
                    string bSide = Console.ReadLine();
                    var rectangle = new Rectangle(double.Parse(aSide), double.Parse(bSide));
                    shapes.Add(rectangle);
                    break;
                case 4:
                    Console.WriteLine("Please give a side length:");
                    string rpSideLength = Console.ReadLine();
                    var regularPentagon = new RegularPentagon(double.Parse(rpSideLength));
                    shapes.Add(regularPentagon);
                    break;
                case 5:
                    Console.WriteLine("Please give a side length:");
                    string squSideLength = Console.ReadLine();
                    var square = new Square(double.Parse(squSideLength));
                    shapes.Add(square);
                    break;
                case 6:
                    Console.WriteLine("Please give the length of side 'a': ");
                    string triangleA = Console.ReadLine();
                    Console.WriteLine("Please give the length of side 'b': ");
                    string triangleB = Console.ReadLine();
                    Console.WriteLine("Please give the length of side 'c': ");
                    string triangleC = Console.ReadLine();
                    var triangle = new Triangle(double.Parse(triangleA), double.Parse(triangleB), double.Parse(triangleC));
                    shapes.Add(triangle);
                    break;
            }
        }

        public void GetShapesTable()
        {
            for (int i = 0; i < shapes.Count; i++)
            {
                Console.WriteLine($"{i}, {shapes[i].GetType().Name}, {shapes[i]}, {Math.Round(shapes[i].Perimeter, 2)}, {shapes[i].PerimeterFormula}, {Math.Round(shapes[i].Area, 2)}, {shapes[i].AreaFormula}");
            }
        }

        public void GetLargestShapeByPerimeter()
        {
            double max = shapes.Max(item => item.Perimeter);

            foreach (var shape in shapes)
            {
                if (shape.Perimeter == max)
                {
                    Console.WriteLine($"{shape.GetType().Name}, {shape}, {Math.Round(shape.Perimeter, 2)}, {shape.PerimeterFormula}, {Math.Round(shape.Area, 2)}, {shape.AreaFormula}");
                }
            }
        }

        public void GetLargestShapeByArea()
        {
            double max = shapes.Max(item => item.Area);

            foreach (var shape in shapes)
            {
                if (shape.Area == max)
                {
                    Console.WriteLine($"{shape.GetType().Name}, {shape}, {Math.Round(shape.Perimeter, 2)}, {shape.PerimeterFormula}, {Math.Round(shape.Area, 2)}, {shape.AreaFormula}");
                }
            }
        }

        public void GetFormulas()
        {
            Console.WriteLine("Please choose your shape:");
            Console.WriteLine("1. Circle");
            Console.WriteLine("2. Equilateral Triangle");
            Console.WriteLine("3. Rectangle");
            Console.WriteLine("4. Regular Pentagon");
            Console.WriteLine("5. Square");
            Console.WriteLine("6. Triangle");

            int input = int.Parse(Console.ReadLine());

            var circle = new Circle(1);
            var equilateralTriangle = new EquilateralTriangle(1);
            var rectangle = new Rectangle(1, 1);
            var regularPentagon = new RegularPentagon(1);
            var square = new Square(1);
            var triangle = new Triangle(1, 1, 1);

            switch (input)
            {
                case 1:
                    Console.WriteLine($"Circle area formula: {circle.AreaFormula}, Circle perimeter formula: {circle.PerimeterFormula}");
                    break;
                case 2:
                    Console.WriteLine($"Equilateral Triangle area formula: {equilateralTriangle.AreaFormula}, Equilateral Triangle perimeter formula: {equilateralTriangle.PerimeterFormula}");
                    break;
                case 3:
                    Console.WriteLine($"Rectangle area formula: {rectangle.AreaFormula}, Rectangle perimeter formula: {rectangle.PerimeterFormula}");
                    break;
                case 4:
                    Console.WriteLine($"Regular pentagon area formula: {regularPentagon.AreaFormula}, Regular pentagon perimeter formula: {regularPentagon.PerimeterFormula}");
                    break;
                case 5:
                    Console.WriteLine($"Square area formula: {square.AreaFormula}, Square perimeter formula: {square.PerimeterFormula}");
                    break;
                case 6:
                    Console.WriteLine($"Triangle area formula: {triangle.AreaFormula}, Triangle perimeter formula: {triangle.PerimeterFormula}");
                    break;
            }
        }
    }
}