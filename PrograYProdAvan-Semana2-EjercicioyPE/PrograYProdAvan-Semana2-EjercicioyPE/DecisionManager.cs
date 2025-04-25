using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrograYProdAvan_Semana2_EjercicioyPE
{
    public class DecisionManager
    {
        private Dictionary<string, Action<Player>> decisions;

        public DecisionManager()
        {
            decisions = new Dictionary<string, Action<Player>>();

            decisions.Add("1", (player) => {
                Console.WriteLine("Decisión 1: Tomaste un atajo peligroso. Pierdes 10 de vida.");
                player.TakeDamage(10);
            });

            decisions.Add("2", (player) => {
                Console.WriteLine("Decisión 2: Descansas bajo un árbol. Recuperas 20 de vida.");
                player.Heal(20);
            });

            decisions.Add("3", (player) => {
                Console.WriteLine("Decisión 3: Encuentras una poción. Recuperas 15 de vida.");
                player.Heal(15);
            });

            decisions.Add("4", (player) => {
                Console.WriteLine("Decisión 4: Te golpeas con una rama. Pierdes 5 de vida.");
                player.TakeDamage(5);
            });

            decisions.Add("5", (player) => {
                Console.WriteLine("Decisión 5: Tomas un desvío largo. Nada ocurre.");
            });

            decisions.Add("6", (player) => {
                Console.WriteLine("Decisión 6: Tropiezas y pierdes 8 de vida.");
                player.TakeDamage(8);
            });

            decisions.Add("7", (player) => {
                Console.WriteLine("Decisión 7: Comes una baya mágica. Recuperas 10 de vida.");
                player.Heal(10);
            });

            decisions.Add("8", (player) => {
                Console.WriteLine("Decisión 8: Te enfrentas a un recuerdo doloroso. Pierdes 7 de vida.");
                player.TakeDamage(7);
            });

            decisions.Add("9", (player) => {
                Console.WriteLine("Decisión 9: Tomas agua del río. Recuperas 5 de vida.");
                player.Heal(5);
            });

            decisions.Add("10", (player) => {
                Console.WriteLine("Decisión 10: Meditas. Recuperas 12 de vida.");
                player.Heal(12);
            });
        }

        public void ApplyDecision(string key, Player player)
        {
            if (decisions.ContainsKey(key))
                decisions[key](player);
            else
                Console.WriteLine("Decisión no válida. No ocurre nada.");
        }
    }
}
