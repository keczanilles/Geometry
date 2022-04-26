using System;
using System.Collections.Generic;
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
                    var circle = new Circle(int.Parse(radius));
                    shapes.Add(circle);
                    break;
                case 2:
                    Console.WriteLine("Please give a side length:");
                    string eqSideLength = Console.ReadLine();
                    var equilateralTriangle = new EquilateralTriangle(int.Parse(eqSideLength));
                    shapes.Add(equilateralTriangle);
                    break;
                case 3:
                    Console.WriteLine("Please give the length of side 'a': ");
                    string aSide = Console.ReadLine();
                    Console.WriteLine("Please give the length of side 'b': ");
                    string bSide = Console.ReadLine();
                    var rectangle = new Rectangle(int.Parse(aSide), int.Parse(bSide));
                    shapes.Add(rectangle);
                    break;
                case 4:
                    Console.WriteLine("Please give a side length:");
                    string rpSideLength = Console.ReadLine();
                    var regularPentagon = new RegularPentagon(int.Parse(rpSideLength));
                    shapes.Add(regularPentagon);
                    break;
                case 5:
                    Console.WriteLine("Please give a side length:");
                    string squSideLength = Console.ReadLine();
                    var square = new Square(int.Parse(squSideLength));
                    shapes.Add(square);
                    break;
                case 6:
                    Console.WriteLine("Please give the length of side 'a': ");
                    string triangleA = Console.ReadLine();
                    Console.WriteLine("Please give the length of side 'b': ");
                    string triangleB = Console.ReadLine();
                    Console.WriteLine("Please give the length of side 'c': ");
                    string triangleC = Console.ReadLine();
                    var triangle = new Triangle(int.Parse(triangleA), int.Parse(triangleB), int.Parse(triangleC));
                    shapes.Add(triangle);
                    break;
            }
        }

    }
}
