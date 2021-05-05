using LibCalcArea;
using System;
using System.Collections.Generic;
using LibCalcArea.Shapes;

namespace CalcAreaShapes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IShape> shapes = new List<IShape>();
            IShape shape1 = new Triangle(4, 3, 5);
            shapes.Add(shape1);
            shapes.Add(new Circle(5));
            shapes.Add(new ShapeRandom(15,34));

           foreach (IShape shape in shapes)
           {
               shape.ShowAreaShape();
           }

           Console.Read();
        }
    }
}
