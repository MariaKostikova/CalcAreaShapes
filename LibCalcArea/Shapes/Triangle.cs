using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace LibCalcArea.Shapes
{
    class Triangle : IShape
    {
        public int A { get; set; }

        public int B { get; set; }

        public int C { get; set; }

        public Triangle()
        {
            A = B = C = default(int);
            
        }

        public Triangle(int a, int b, int c)
        {
            A = a;
            B = b;
            C = c;
        }

        public double Area
        {
            get
            {
                var Perimeter = (A + B + C) / 2;
                return Math.Sqrt(Perimeter * (Perimeter - A) * (Perimeter - B) * (Perimeter - C));
            }
        }


        public override string ToString()
        {
            return "Сторона А = " + A + 
                   "\r\n Сторона В = " + B +
                   "\r\n Сторона С = " + C +
                   "\r\nПлощадь треугольника = " + Area;
        }

        public void ShowShape()
        {
            Console.WriteLine(ToString());
        }
    }

        
    
}
