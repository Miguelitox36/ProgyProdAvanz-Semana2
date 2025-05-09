﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrograYProdAvan_Semana2_EjercicioyPE
{
    public class Game
    {
        private Player player;
        private List<Map> map;
        private DecisionManager decisionManager;

        public void Start()
        {
            Console.WriteLine("Bienvenido al RPG de texto. Crea tu personaje");

            Console.Write("Nombre: ");
            string name = Console.ReadLine();

            int health = GetStat("vida", 100);
            int daño = 100 - health;

            player = new Player(name, health, daño);
            decisionManager = new DecisionManager();
            map = GenerateMap();

            for (int i = 0; i < map.Count && player.IsAlive; i++)
            {
                Console.WriteLine($"\nMinimapa: {BuildMapString(i)}");

                var node = map[i];
                switch (node.type)
                {
                    case Type.Camino:
                        Console.WriteLine("Avanzas por el camino...");
                        break;
                    case Type.Combate:
                        Combat(node.Enemy);
                        break;
                    case Type.Decision:
                        Console.WriteLine("¡Toma una decisión! (1 al 10)");
                        string decision = Console.ReadLine();
                        decisionManager.ApplyDecision(decision, player);
                        break;
                }
            }

            Console.WriteLine(player.IsAlive ? "¡Ganaste el juego!" : "Has muerto. Fin del juego.");
        }

        private void Combat(IEnemy enemy)
        {
            Character foe = enemy as Character;
            enemy.Taunt();

            while (player.IsAlive && foe.IsAlive)
            {
                player.Attack(foe);
                if (foe.IsAlive)
                    foe.Attack(player);
            }
        }

        private List<Map> GenerateMap()
        {
            return new List<Map>
            {
                new Map { type = Type.Camino },
                new Map { type = Type.Combate, Enemy = new EnemyMelee("Goblin") },
                new Map { type = Type.Decision, DecisionKey = "1" },
                new Map { type = Type.Camino },
                new Map { type = Type.Combate, Enemy = new EnemyRange("Elfo Oscuro") },
                new Map { type = Type.Decision, DecisionKey = "2" },
                new Map { type = Type.Camino },
                new Map { type = Type.Combate, Enemy = new EnemyMelee("Orco") },
                new Map { type = Type.Decision, DecisionKey = "3" },
                new Map { type = Type.Camino },
                new Map { type = Type.Combate, Enemy = new EnemyRange("Bruja") },
                new Map { type = Type.Decision, DecisionKey = "4" },
                new Map { type = Type.Camino },
                new Map { type = Type.Combate, Enemy = new EnemyMelee("Esqueleto") },
                new Map { type = Type.Decision, DecisionKey = "5" },
                new Map { type = Type.Camino },
                new Map { type = Type.Combate, Enemy = new EnemyRange("Arquero") },
                new Map { type = Type.Decision, DecisionKey = "6" },
                new Map { type = Type.Camino },
                new Map { type = Type.Combate, Enemy = new EnemyRange("Centauro") },
                new Map { type = Type.Decision, DecisionKey = "7" },
                new Map { type = Type.Camino },
                new Map { type = Type.Combate, Enemy = new EnemyRange("Mago") },
                new Map { type = Type.Decision, DecisionKey = "8" },
                new Map { type = Type.Camino },
                new Map { type = Type.Combate, Enemy = new EnemyRange("Enano") },
                new Map { type = Type.Decision, DecisionKey = "9" },
                new Map { type = Type.Camino },
                new Map { type = Type.Combate, Enemy = new EnemyRange("Bandido") },
                new Map { type = Type.Decision, DecisionKey = "10" },
                new Map { type = Type.Camino },
            };
        }

        private string BuildMapString(int position)
        {
            var builder = new StringBuilder();
            for (int i = 0; i < map.Count; i++)
            {
                if (i == position)
                    builder.Append("[P]");
                else
                    switch (map[i].type)
                    {
                        case Type.Camino:
                            builder.Append("[O]");
                            break;
                        case Type.Combate:
                            builder.Append("[X]");
                            break;
                        case Type.Decision:
                            builder.Append("[D]");
                            break;
                        default:
                            builder.Append("[ ]");
                            break;
                    }
            }
            return builder.ToString();
        }

        private int GetStat(string statName, int max)
        {
            while (true)
            {
                Console.WriteLine($"Distribuye puntos a {statName} (máx {max}): ");
                string input = Console.ReadLine();
                int value;
                if (int.TryParse(input, out value) && value >= 0 && value <= max)
                    return value;
                Console.WriteLine("Valor inválido.");
            }
        }
    }
}
