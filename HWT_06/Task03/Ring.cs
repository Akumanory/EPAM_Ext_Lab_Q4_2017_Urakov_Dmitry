﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    class Ring : Figure
    {
        FiguresShapes type = FiguresShapes.Ring;

        public Ring()
        {
            FigureType = type.ToString();
        }
    }
}
