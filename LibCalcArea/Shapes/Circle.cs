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
            this.Radius = rad;
        }

        public override string ToString()
        {
            return "О круге: \r\n" + "\r\n Радиус круга " + Radius + "\r\n Площадь круга = " + Area + "\r\n";
        }

        public void ShowAreaShape()
        {
            Console.WriteLine(ToString());
        }

        
    }
}
