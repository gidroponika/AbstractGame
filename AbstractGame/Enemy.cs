using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractGame
{
    //за допомогою класу Enemy відтіняємо ворогів від інших GamePerson
    internal abstract class Enemy : GamePerson
    {
        public Enemy(int health, int speed)
            : base(health, speed)
        {
        }
    }
}
