using System;
using Codecool.Geometry.Containers;

namespace Codecool.Geometry
{
    /// <summary>
    ///     This is the main class of your program which contains Main method
    /// </summary>
    public static class Program
    {
        /// <summary>
        ///     This is the entry point of your program.
        /// </summary>
        /// <param name="args">Command line arguments.</param>
        public static void Main(string[] args)
        {
            bool isRunning = true;
            var shapeCollection = new ShapeCollection();

            while (isRunning)
            {
                Console.WriteLine("Please choose your option:");
                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        shapeCollection.AddShape();
                        break;
                    case 2:
                        foreach (var item in shapeCollection.shapes)
                        {
                            Console.WriteLine(item);
                        }
                        break;
                    case 3:
                        // TODO Show shape with the largest perimeter
                        break;
                    case 4:
                        // TODO Show shape with the largest area
                        break;
                    case 5:
                        // TODO Show formulas
                        break;
                    case 0:
                        isRunning = false;
                        break;
                }
                
            }
        }
    }
}
