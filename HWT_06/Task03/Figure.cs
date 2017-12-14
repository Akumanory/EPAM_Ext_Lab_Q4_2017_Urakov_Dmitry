using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    class Figure
    {
        private int x;
        private int y;
        private string figureType;

        public int X
        {
            get { return x; }

            set { x = value; }
        }

        public int Y
        {
            get { return y; }

            set { y = value; }
        }

        public string FigureType
        {
            get { return figureType; }

            set { figureType = value; }
        } 
       
    }
}
