using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04
{
    class Snake : Monster
    {
        public bool IgnoreRock()
        {
            return true;
        }

        public bool WalkNearTheRock()
        {
            return true;
        }
    }
}
