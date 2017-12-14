using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04
{
    public class Map 
    {
        private double width;
        private double hight;
        private int monsterQuantity;
        private int bonusQuantity;
        private int obstacleQuantity;

        public double Width
        {
            get {return width; }
            set { width = value; }
        }

        public double Higth
        {
            get { return hight; }
            set { hight = value; }
        }

        public int MonsterQuantity
        {
            get { return monsterQuantity; }
            set { }
        }

        public int ObstacleQuantity
        {
            get { return obstacleQuantity; }
            set { }
        }

        public int BonusQuantity
        {
            get { return bonusQuantity; }
            set { }
        }

        public bool GameOver()
        {
            return true;
        }

    }
}
