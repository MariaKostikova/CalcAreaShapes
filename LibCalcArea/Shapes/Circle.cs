using System;
using System.Collections.Generic;
using System.Text;

namespace LibCalcArea.Shapes
{
    public class Circle : IShape
    {
        public double Radius { get; set; }

        public double Area => Math.PI * Math.Pow(Radius, 2);

        public Circle(double rad)
        {
            Radius = rad;
        }

        public override string ToString()
        {
            return "Радиус круга " + Radius + "\r\nПлощадь круга = " + Area;
        }

        public void ShowShape()
        {
            Console.WriteLine(ToString());
        }

        
    }
}
