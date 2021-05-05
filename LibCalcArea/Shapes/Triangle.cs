using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace LibCalcArea.Shapes
{
    public class Triangle : IShape
    {
        private int A { get; set; }

        private int B { get; set; }

        private int C { get; set; }

        public Triangle()
        {
            this.A = this.B = this.C = default(int);
            
        }

        public Triangle(int a, int b, int c)
        {
            if (A >= 0 && B >= 0 && C >= 0)
            {
                this.A = a;
                this.B = b;
                this.C = c;
            }
            else
            {
                throw new Exception("Value cannot be negative");
            }
            
        }

        public double Area
        {
            get
            {
                int Perimeter = (A + B + C) / 2;
                return Math.Sqrt(Perimeter * (Perimeter - A) * (Perimeter - B) * (Perimeter - C));
            }
        }

        public bool IsRightTriangle()
        {
            return (A == Math.Sqrt(Math.Pow(B, 2) + Math.Pow(C, 2)) 
                    || B == Math.Sqrt(Math.Pow(A, 2) + Math.Pow(C, 2)) 
                    || C == Math.Sqrt(Math.Pow(A, 2) + Math.Pow(B,2)));
        }


        public override string ToString()
        {
            return "О треугольнике: \r\n" +
                   "\r\n Сторона А = " + A + 
                   "\r\n Сторона В = " + B +
                   "\r\n Сторона С = " + C +
                   "\r\n Площадь треугольника = " + Area +
                   "\r\n Треугольник прямоугольный? - " + IsRightTriangle() + "\r\n";
        }

        public void ShowAreaShape()
        {
            Console.WriteLine(ToString());
        }
    }

        
    
}
