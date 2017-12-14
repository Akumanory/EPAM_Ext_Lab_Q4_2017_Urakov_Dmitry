using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04
{
    public class Fire : Obstacle, IHealthTakeable
    {
        public bool TakeHealth()
        {
            throw new NotImplementedException();
        }
    }
}
