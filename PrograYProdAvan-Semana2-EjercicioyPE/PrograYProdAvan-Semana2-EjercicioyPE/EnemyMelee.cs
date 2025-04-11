using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrograYProdAvan_Semana2_EjercicioyPE
{
    public class EnemyMelee : Character, IEnemy
    {
        public EnemyMelee(string name) : base (name, 40, 10) 
        {

        }

        public override void TakeDamage(int amount)
        {
            Health -= amount;
            Console.WriteLine($"{Name} grita al recibir {amount} de daño.");
        }

        public override void Attack(Character target)
        {
            Console.WriteLine($"{Name} ataca a {target.Name}");
            target.TakeDamage(Damage);
        }

        public void Taunt()
        {
            Console.WriteLine($"{Name} dice: ¡Te voy a destrozar!");
        }
    }
}
