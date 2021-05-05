using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace LibCalcArea
{
    public interface IShape
    {
        double Area { get; }

        void ShowAreaShape();
    }
}
