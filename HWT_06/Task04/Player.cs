using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04
{
    public class Player : Object, IWalkable, IBonusObtaineable
    {

        private int healthPoints;

        public int HealthPoints
        {
            get { return healthPoints;}
            set { healthPoints = value; }
        }

        public bool WalkAbility()
        {
            throw new NotImplementedException();
        }

        public double WalkSpeed()
        {
            throw new NotImplementedException();
        }

        public bool CanUseBonus()
        {
            throw new NotImplementedException();
        }
    }
}
