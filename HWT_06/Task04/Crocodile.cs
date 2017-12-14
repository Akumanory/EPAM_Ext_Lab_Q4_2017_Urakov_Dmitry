using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04
{
    public class Crocodile : Monster
    {
        public bool WalkNearTheRiver()
        {
            return true;
        }

        public bool IgnoreRiver()
        {
            return true;
        }
    }
}
