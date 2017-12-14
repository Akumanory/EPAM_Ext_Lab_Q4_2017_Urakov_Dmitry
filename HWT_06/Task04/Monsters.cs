using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04
{
    public class Monster : Object, IWalkable, IHealthTakeable
    {
        public bool WalkAbility()
        {
            throw new NotImplementedException();
        }

        public double WalkSpeed()
        {
            throw new NotImplementedException();
        }

        public bool TakeHealth()
        {
            throw new NotImplementedException();
        }
    }
}
