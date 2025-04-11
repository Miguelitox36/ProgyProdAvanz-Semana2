using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrograYProdAvan_Semana2_EjercicioyPE
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var game = new Game();
                game.Start();
            }
            catch (Exception ex) 
            {
                Console.WriteLine($"¡Ocurrio un error {ex.Message}!");
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
