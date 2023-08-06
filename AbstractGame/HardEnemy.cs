using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractGame
{

    //Хард-ворог, який після смерті має шанс на відродження

    internal class HardEnemy : Enemy, IDamageble, IRespawner
    {
        private int Damage { get; set; }
        private int SpeedDamage { get; set; }

        Random random = new Random();

        public const int ChanceRespawn = 20;
        public HardEnemy(int health, int speed, int damage, int speedDamage = 10)
            : base(health, speed)
        {
            Damage = damage;
            SpeedDamage = speedDamage;
        }
        public int InflictDamage()
        {
            Console.WriteLine($"Спрацьовує анімація нанесення урону із швидкістю {SpeedDamage}");
            return Damage;
        }

        public override void TakeDamage(int damage)
        {
            Health -= damage;
            if (Health <= 0)
            {
                IsDead = true;
                Dead();
            }
            else
            {
                Console.WriteLine("Спрацьовуе анімація отримання пошкодження");
            }
        }

        //якщо рандомне число між 1 і 20, то повертає єкземпляр ворога
        //та перероджує його, інакше зануляє
        public IRespawner Respawn()
        {
            Console.WriteLine("Спрацьовує анімація відродження");
            if (random.Next(1, 101) <= ChanceRespawn)
            {
                IsDead = false;
                return this;
            }
            return null;
        }
    }
}
