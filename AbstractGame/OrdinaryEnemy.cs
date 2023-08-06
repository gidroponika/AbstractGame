using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractGame
{
    //звичайний лайтовий ворог, що здатен наносити урон
    internal class OrdinaryEnemy : Enemy, IDamageble
    {
        public OrdinaryEnemy(int health, int speed, int damage, int speedDamage = 3)
            : base(health, speed)
        {
            Damage = damage;
            SpeedDamage = speedDamage;
        }

        private int Damage { get; set; }
        private int SpeedDamage { get; set; }

        public int InflictDamage()
        {
            Console.WriteLine($"Спрацьовує анімація нанесення урону із швидкістю {SpeedDamage}");
            return Damage;
        }
    }
}
