using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrograYProdAvan_Semana2_EjercicioyPE
{
    public class Player : Character
    {
        public Player(string name, int health, int damage) : base(name, health, damage) { }

        public override void TakeDamage(int amount)
        {
            Health -= amount;
            Console.WriteLine($"{Name} recibe {amount} de daño. Vida actual: {Health}");
        }

        public override void Attack(Character target)
        {
            Console.WriteLine($"{Name} ataca a {target.Name} causando {Damage} de daño.");
            target.TakeDamage(Damage);
        }

        public void Heal(int amount)
        {
            Health += amount;
            Console.WriteLine($"{Name} recupera {amount} de vida. Vida actual: {Health}");
        }

    }
}
