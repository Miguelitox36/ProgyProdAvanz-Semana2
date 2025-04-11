using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrograYProdAvan_Semana2_EjercicioyPE
{
    public enum Type
    {
        Camino,
        Combate,
        Decision
    }

    public class Map
    {
        public Type type;
        public IEnemy Enemy;
        public string DecisionKey;
    }
}
