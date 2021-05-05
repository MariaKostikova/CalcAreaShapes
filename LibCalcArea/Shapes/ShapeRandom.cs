using System;
using System.Collections.Generic;
using System.Text;

namespace LibCalcArea.Shapes
{
    public class ShapeRandom : IShape
    {
        /// <summary>
        /// количество пересечений на границе фигуры (для формулы Пика)
        /// </summary>
        private int M { get; set; }
        /// <summary>
        /// количество пересечений внутри фигуры ( для формулы Пика)
        /// </summary>
        private int N { get; set; }

        public ShapeRandom()
        {
            this.M = this.N = default(int);
        }

        public ShapeRandom(int m, int n)
        {
            if (M >= 0 && N >= 0)
            {
                this.M = m;
                this.N = n;
            }
            else
            {
                throw new Exception("Value cannot be negative");
            }
        }

        public double Area =>(M / 2) + N - 1;

        public override string ToString()
        {
            return
                "О фигуре произвольной формы: \r\n" +
                "\r\n Количество пересечений на границе фигуры (для формулы Пика) = " + M +
                "\r\n Количество пересечений внутри фигуры (для формулы Пика) = " + N +
                "\r\n Площадь фигуры = " + Area + "\r\n";
        }

        public void ShowAreaShape()
        {
            Console.WriteLine(ToString());
        }



    }
}
