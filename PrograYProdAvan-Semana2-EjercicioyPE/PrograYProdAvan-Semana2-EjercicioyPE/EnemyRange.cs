using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrograYProdAvan_Semana2_EjercicioyPE
{
    public class EnemyRange : Character, IEnemy
    {
        public EnemyRange(string name) : base(name, 30, 25) { }

        public override void TakeDamage(int amount)
        {
            Health -= amount;
            Console.WriteLine($"{Name} sufre {amount} de daño, pero promete venganza...");
        }

        public override void Attack(Character target)
        {
            Console.WriteLine($"{Name} dispara su arco a {target.Name}");
            target.TakeDamage(Damage);
        }

        public void Taunt()
        {
            Console.WriteLine($"{Name} susurra: ¡No escaparás de la muerte...!");
        }
    }
}
