using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrograYProdAvan_Semana2_EjercicioyPE
{
    public class DecisionManager
    {
        private Dictionary<string, Action<Player>> decisions = new Dictionary<string, Action<Player>>();

        public DecisionManager() 
        {
            decisions["1"] = (player) =>
            {
                Console.WriteLine("Decidiste tomar el atajo peligroso. Pierdes 10 de vida");
                player.TakeDamage(10);
            };

            decisions["2"] = (player) =>
            {
                Console.WriteLine("");
                player.Heal(20);
            };
        }

        public void ApplyDecision(string key, Player player)
        {
            if (decisions.ContainsKey(key))
            {
                decisions[key](player);
            }
            else
            {
                Console.WriteLine("Decisión no válida. No ocurre nada.");
            }
        }
    }
}
