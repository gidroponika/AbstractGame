using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractGame
{

    //абстракний клас усіх ігрових персонажів
    internal abstract class GamePerson
    {
        public bool IsDead { get; protected set; } = false;
        public int Health { get; protected set; }
        public int Speed { get; protected set; }
        public GamePerson(int health, int speed)
        {
            Health = health;
            Speed = speed;
        }
        public void Move(int speed)
        {
            Speed = speed;
            Console.WriteLine($"Я рухаюсь зі швидкістю {speed}");
        }
        public virtual void TakeDamage(int damage)
        {
            Health -= damage;
            if (Health <= 0)
            {
                Dead();
            }
            else
            {
                Console.WriteLine("Спрацьовуе анімація отримання пошкодження");
            }
        }
        protected void Dead()
        {
            IsDead = true;
            Console.WriteLine("Спрацьовує анімація смерті");
        }
    }
}
