using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCsharp
{
    class Linea
    {
        //Propiedades de navegación
        public Coordenada p1 { get; set; }
        public Coordenada p2 { get; set; }

       public double CalcularDistancia()
        {
            double distancia = Math.Sqrt(Math.Pow(p1.x - p2.x, 2) + Math.Pow(p1.y - p2.y,2));
            return distancia;
        }


    }
}
