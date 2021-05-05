using System;
using System.Collections.Generic;
using System.Text;

namespace LibCalcArea.Shapes
{
    class ShapeRandom : IShape
    {
        private IShape shape;

        public double Area => shape.Area;
        
        public ShapeRandom(IShape _shape)
        {
            shape = _shape;
        }

        public override string ToString()
        {
            return "Площадь фигуры = " + Area;
        }

        public void ShowShape()
        {
            Console.WriteLine(ToString());
        }



    }
}
