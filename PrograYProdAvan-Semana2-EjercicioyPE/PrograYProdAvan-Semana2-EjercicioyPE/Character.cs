using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrograYProdAvan_Semana2_EjercicioyPE
{
    public abstract class Character
    {

        public string Name;
        public int Health;
        public int Damage;

        public Character(string name, int health, int damage)
        {
            this.Name = name;
            this.Health = health;
            this.Damage = damage;
        }

        public abstract void TakeDamage(int amount);
        public abstract void Attack(Character target);
        public bool IsAlive { get { return Health > 0; } }
    }
}
