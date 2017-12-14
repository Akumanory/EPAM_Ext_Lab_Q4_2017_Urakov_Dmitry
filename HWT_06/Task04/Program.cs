using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04
{
    /*
     Создайте иерархию классов и пропишите ключевые методы для компьютерной игры (без реализации функционала).
     */
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            Map mapStatus = new Map();

            if (player.HealthPoints == 0 | mapStatus.BonusQuantity == 0 )
            {
                mapStatus.GameOver();
            }
        }
    }
}
