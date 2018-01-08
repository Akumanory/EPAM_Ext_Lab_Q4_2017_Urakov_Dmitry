using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    class Round : Figure
    {
        FiguresShapes type = FiguresShapes.Round;

        public Round()
        {
            FigureType = type.ToString();
        }
    }
}
