using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractGame
{
    internal class Hero : GamePerson, IDamageble, IRespawner
    {
        private int Damage { get; set; }
        private int counterHealth = 3;
        public Hero(int health, int speed, int damage)
            : base(health, speed)
        {
            Damage = damage;
        }

        public int InflictDamage()
        {
            return Damage;
        }

        //якщо у Hero кількість життів більше нуля - відроджує, інакше зануляє 
        public IRespawner Respawn()
        {
            if (Health <= 0 && counterHealth > 0)
            {
                IsDead = false;
                counterHealth--;
                return this;
            }
            Console.WriteLine("Game over");
            return null;
        }
    }
}
