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
            Console.WriteLine("Please choose your shape.");
            int input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case 1:
                    Console.WriteLine("Please give a radius number:");
                    string radius = Console.ReadLine();
                    var circle = new Circle(int.Parse(radius));
                    shapes.Add(circle);
                    break;
            }
        }

    }
}
